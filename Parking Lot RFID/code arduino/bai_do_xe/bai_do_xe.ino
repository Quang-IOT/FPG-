#include <SPI.h>
#include <MFRC522.h>
#include <ESP8266WiFi.h>
#include <Firebase_ESP_Client.h>
#include <Servo.h>
#include <Ticker.h>

#define ENTRY 1
#define EXIT  0

#define RST_PIN 5 //D1 //reset two module rfid reader

#define SS0_PIN 15  //D8
#define SS1_PIN 4  //D2

#define Servo_Entry_PIN D3
#define Servo_Exit_PIN  D4

MFRC522 Reader_Entry(SS0_PIN, RST_PIN);   // Create MFRC522 instance.

MFRC522 Reader_Exit(SS1_PIN, RST_PIN);   // Create MFRC522 instance.

Servo servo0, servo1;  // create servo object to control a servo
// twelve servo objects can be created on most boards

#define WIFI_SSID "OpenSpace_6.3"
#define WIFI_PASSWORD "1041050127"

#define FIREBASE_HOST "fir-esp8266-e5534-default-rtdb.firebaseio.com"

#define API_KEY "AIzaSyBaJY3wXmNjzFqZsKp8-STIdWdNs4pBDic"

#define USER_EMAIL "collectionparodymusic@gmail.com"
#define USER_PASSWORD "quang1997"


FirebaseData fbdo;
FirebaseAuth auth;
FirebaseConfig config;

Ticker timer0;
Ticker timer1;

int statuss = 0;
int out = 0;

void setup()
{
	Serial.begin(9600);   // Initiate a serial communication
	SPI.begin();      // Initiate  SPI bus
	Reader_Entry.PCD_Init();   // Initiate MFRC522
	Reader_Exit.PCD_Init();   // Initiate MFRC522

	WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
	Serial.print("Connecting to Wi-Fi");
	while (WiFi.status() != WL_CONNECTED)
	{
		Serial.print(".");
		delay(300);
	}
	Serial.println();
	Serial.print("Connected with IP: ");
	Serial.println(WiFi.localIP());
	Serial.println();

	config.host = FIREBASE_HOST;
	config.api_key = API_KEY;

	Firebase.reconnectWiFi(true);

	auth.user.email = USER_EMAIL;
	auth.user.password = USER_PASSWORD;

	Firebase.reconnectWiFi(true);

	Firebase.begin(&config, &auth);

	servo0.attach(Servo_Entry_PIN);
	servo1.attach(Servo_Exit_PIN);
  	servo0.write(175); // init angel servo
	servo1.write(175);

	Serial.println(" Bai Do Xe Thong Minh ");
}

void loop()
{
	// Look for new cards
	if (Reader_Entry.PICC_IsNewCardPresent())
	{
		Serial.print("CAR IN\n");
		// Select one of the cards
		Reader_Entry.PICC_ReadCardSerial();
		Send_UID_to_firebase(Reader_Entry, ENTRY);
		delay(3000);
		//Serial.print("CAR IN accepted\n");
	}
	else if (Reader_Exit.PICC_IsNewCardPresent())
	{
		Serial.print("CAR OUT\n");
		// Select one of the cards
		Reader_Exit.PICC_ReadCardSerial();
		Send_UID_to_firebase(Reader_Exit, EXIT);
		delay(3000);
		//Serial.print("CAR OUT accepted\n");
	}

	Get_data_from_firebase();


}

void Send_UID_to_firebase(MFRC522 object, bool in_out_check)
{
	Serial.println();
	Serial.print(" UID tag :");
	String content = "";
	byte letter;
	for (byte i = 0; i < object.uid.size; i++)
	{
		Serial.print(object.uid.uidByte[i] < 0x10 ? " 0" : " ");
		Serial.print(object.uid.uidByte[i], HEX);
		content.concat(String(object.uid.uidByte[i] < 0x10 ? " 0" : " "));
		content.concat(String(object.uid.uidByte[i], HEX));
	}
	content.toUpperCase();
	Serial.println();
	// check reader
	if(in_out_check == ENTRY)
		Firebase.RTDB.setString(&fbdo, "In4_car_input/My_RFID", content);
	else
		Firebase.RTDB.setString(&fbdo, "In4_car_output/My_RFID", content);
}

void Get_data_from_firebase(void)
{
	Firebase.RTDB.getString(&fbdo, "In4_car_input/status");
	String entry_control_value = fbdo.stringData();
	Firebase.RTDB.getString(&fbdo, "In4_car_output/status");
	String exit_control_value = fbdo.stringData();
	Firebase.RTDB.getString(&fbdo, "Speaker Warning");
	String speaker_out = fbdo.stringData();

	if (entry_control_value.toInt() == 1) //convert value
	{
		//speaker out
		open_entry_door();
		//turn on timer then 5s close the door
		timer0.attach(3.5, close_entry_door);
	}
	if (exit_control_value.toInt() == 1) 
	{
		//speaker out
		open_exit_door();
		//turn on timer then 5s close the door
		timer1.attach(3.5, close_exit_door);
	}
	if (speaker_out.toInt() == 1)
	{
		//speaker_out_ting();
	}

}
void open_entry_door(void)
{
	for (int pos = 175; pos >= 80; pos -= 1) { // goes from 180 degrees to 0 degrees
		servo0.write(pos);              // tell servo to go to position in variable 'pos'
		delay(15);                       // waits 15ms for the servo to reach the position
	}
	delay(2000);
}
void close_entry_door(void)
{
	for (int pos = 80; pos <= 175; pos += 1) { // goes from 0 degrees to 180 degrees
		// in steps of 1 degree
		servo0.write(pos);              // tell servo to go to position in variable 'pos'
		delay(15);                       // waits 15ms for the servo to reach the position
	}
	delay(2000);
	timer0.detach();
}
void open_exit_door(void) // edit angel
{
	for (int pos = 175; pos >= 80; pos -= 1) { // goes from 180 degrees to 0 degrees
		// in steps of 1 degree
		servo1.write(pos);              // tell servo to go to position in variable 'pos'
		delay(15);                       // waits 15ms for the servo to reach the position
	}
	delay(2000);
}
void close_exit_door(void)
{
	for (int pos = 80; pos <= 175; pos += 1) { // goes from 0 degrees to 180 degrees
		// in steps of 1 degree
		servo1.write(pos);              // tell servo to go to position in variable 'pos'
		delay(15);                       // waits 15ms for the servo to reach the position
	}
	delay(2000);
	timer1.detach();
}
