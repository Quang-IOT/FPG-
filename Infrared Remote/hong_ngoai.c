#include <ESP8266WiFi.h>
#include <Firebase_ESP_Client.h>
#include <SD.h>
#include <SPI.h>
#include <IRremoteESP8266.h>
#include <IRrecv.h>
#include <IRutils.h>
#include <IRsend.h>

#define RECV_PIN D2
#define IR_LED D1
#define BAUD_RATE 115200
#define CAPTURE_BUFFER_SIZE 1024

#if DECODE_AC
#define TIMEOUT 50U
#else // DECODE_AC
#define TIMEOUT 15U
#endif // DECODE_AC
#define MIN_UNKNOWN_SIZE 12

/* 1. Define the WiFi credentials */
#define WIFI_SSID "OpenSpace_6.3"
#define WIFI_PASSWORD "1041050127"

/* 2. Define the Firebase project host name (required) */
#define FIREBASE_HOST "remotedatabase-d1c46-default-rtdb.asia-southeast1.firebasedatabase.app"
/** 3. Define the API key
 * 
 * The API key can be obtained since you created the project and set up 
 * the Authentication in Firebase console.
 * 
 * You may need to enable the Identity provider at https://console.cloud.google.com/customer-identity/providers 
 * Select your project, click at ENABLE IDENTITY PLATFORM button.
 * The API key also available by click at the link APPLICATION SETUP DETAILS.
 * 
*/
#define API_KEY "AIzaSyBUKSO3Hmy6SmQuRw7PB4y1CtlCOuQbID0"

/* 4. Define the user Email and password that already registerd or added in your project */
#define USER_EMAIL "thanhtien0123456789@gmail.com"
#define USER_PASSWORD "Thanhtien009"

/* 5. Define the Firebase Data object */
FirebaseData fbdo;

/* 6. Define the FirebaseAuth data for authentication data */
FirebaseAuth auth;

/* 7. Define the FirebaseConfig data for config data */
FirebaseConfig config;

/* The function to print the operating results */
void printResult(FirebaseData &data);

/* The helper function to get the token status string */
String getTokenStatus(struct token_info_t info);

/* The helper function to get the token type string */
String getTokenType(struct token_info_t info);

/* The helper function to get the token error string */
String getTokenError(struct token_info_t info);
//testing
int count = 0;

File myFile;

int pinCS = 15;
uint16_t array_[1000];
int i = 0;
int a = 0;
int tggio = 0, tgphut = 0;

String mode_run = "";
String nut0 = "", nut1 = "", nut2 = "", nut3 = "", nut4 = "", nut5 = "", nut6 = "", nut7 = "",
       nut8 = "", nut9 = "", nut10 = "";   
String on1 = "",on2 = "",on3 = "",on4 = "",up = "",dw = "",next = "",back = "",bsao = "",bthang = "",mode = "",menu = "",exit = "",mute = "";
String Status_IR= "";
String base_path = "DATA/";

byte s;


IRrecv irrecv(RECV_PIN, CAPTURE_BUFFER_SIZE, TIMEOUT, true);
IRsend irsend(IR_LED);
decode_results results;

void getBTNvalue()
{

  Firebase.RTDB.getString(&fbdo, "TT_NUT_ON_1");
  on1 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_NUT_ON_2");
  on2 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_NUT_ON_3");
  on3 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_NUT_ON_4");
  on4 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_UP");
  up = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_DW");
  dw = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_NEXT");
  next = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_BACK");
  back = fbdo.stringData();

  Firebase.RTDB.getString(&fbdo, "SETUP/MODE");
  mode_run = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_00");
  nut0 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_01");
  nut1 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_02");
  nut2 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_03");
  nut3 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_04");
  nut4 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_05");
  nut5 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_06");
  nut6 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_07");
  nut7 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_08");
  nut8 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_09");
  nut9 = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "DATA/NUT_10");
  nut10 = fbdo.stringData();

  Firebase.RTDB.getString(&fbdo, "TT_SAO");
  bsao = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_THANG");
  bthang = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_MODE");
  mode = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_MENU");
  menu = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_EXIT");
  exit = fbdo.stringData();
  Firebase.RTDB.getString(&fbdo, "TT_MUTE");
  mute = fbdo.stringData();
}

void setup() {
  pinMode(RECV_PIN, INPUT);
  pinMode(IR_LED, OUTPUT);
  Serial.begin(BAUD_RATE, SERIAL_8N1, SERIAL_TX_ONLY);
  while (!Serial) // Wait for the serial connection to be establised.
    delay(50);
  Serial.println();
  Serial.print("IRrecvDumpV2 is now running and waiting for IR input on Pin ");
  Serial.println(RECV_PIN);
  irsend.begin();
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
  
  /* Assign the project host and API key (required) */
   config.host = FIREBASE_HOST;
   config.api_key = API_KEY;

   Firebase.reconnectWiFi(true);

   /* Assign the user sign in credentials */
   auth.user.email = USER_EMAIL;
   auth.user.password = USER_PASSWORD;

   Firebase.reconnectWiFi(true);

   //String base_path = "/UsersData2/";

   /* Initialize the library with the Firebase authen and config */
   Firebase.begin(&config, &auth);

#if DECODE_HASH
// Ignore messages with less than minimum on or off pulses.
  irrecv.setUnknownThreshold(MIN_UNKNOWN_SIZE);
#endif // DECODE_HASH
  irrecv.enableIRIn(); // Start the receiver

  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(pinCS, OUTPUT);
  SD.begin(pinCS);
  Serial.println("SD card setup done");
  digitalWrite(0, HIGH);
}

void loop()
{
  getBTNvalue();
  if (mode_run == "1")
  { 
    Serial.println("wait"); 
    Firebase.RTDB.setString(&fbdo, "CHECK/Status_IR", "wait");
    if (irrecv.decode(&results))
    {
      if (results.overflow)
        Serial.printf("WARNING: IR code is too big for buffer (>= %d). "
              "This result shouldn't be trusted until this is resolved. "
              "Edit & increase CAPTURE_BUFFER_SIZE.\n",
              CAPTURE_BUFFER_SIZE);
      Serial.print(resultToHumanReadableBasic(&results));
      yield(); // Feed the WDT as the text output can take a while to print.
      Serial.println(resultToSourceCode(&results));
      yield();             // Feed the WDT (again)
      a = getCorrectedRawLength(&results);
      Serial.print("value a"); Serial.println(a);
      Firebase.RTDB.setString(&fbdo, "CHECK/Status_IR", "ir received");
      delay(100);
      choosefileSD(); //step 2: check choose nut7 succces
      writetoSD();  //step 1: comment this line
      Firebase.RTDB.setString(&fbdo, "CHECK/Status_IR", "save");
      delay(100);

      //step 3: remove all feelback to firebase - just test receive IR not store
      //step 0: remove usb cable to esp board
      //step 4: transfer bin file
    }
  }
  else 
  {
    Firebase.RTDB.setString(&fbdo, "CHECK/Status_IR", "sending");
      choosefileSD();
      ReadFromSD();
    Firebase.RTDB.setString(&fbdo, "CHECK/Status_IR", "sent");
  }
  digitalWrite(LED_BUILTIN, !digitalRead(LED_BUILTIN));
}
void choosefileSD()
{
  s = 0;
  if (mode_run == "1")
  {
	 if (nut0 == "1") {
      SD.remove(base_path + "nut0.txt"); myFile = SD.open(base_path + "nut0.txt", FILE_WRITE); s++;
     }
     if (nut1 == "1") {
      SD.remove(base_path + "nut1.txt"); myFile = SD.open(base_path + "nut1.txt", FILE_WRITE); s++;
     }
     if (nut2 == "1") {
      SD.remove(base_path + "nut2.txt"); myFile = SD.open(base_path + "nut2.txt", FILE_WRITE); s++;
     }
     if (nut3 == "1") {
      SD.remove(base_path + "nut3.txt"); myFile = SD.open(base_path + "nut3.txt", FILE_WRITE); s++;
     }
     if (nut4 == "1") {
      SD.remove(base_path + "nut4.txt"); myFile = SD.open(base_path + "nut4.txt", FILE_WRITE); s++;
     }
     if (nut5 == "1") {
      SD.remove(base_path + "nut5.txt"); myFile = SD.open(base_path + "nut5.txt", FILE_WRITE); s++;
     }
     if (nut6 == "1") {
      SD.remove(base_path + "nut6.txt"); myFile = SD.open(base_path + "nut6.txt", FILE_WRITE); s++;
     }
     if (nut7 == "1") {
      SD.remove(base_path + "nut7.txt"); myFile = SD.open(base_path + "nut7.txt", FILE_WRITE); s++;
     }
     if (nut8 == "1") {
      SD.remove(base_path + "nut8.txt"); myFile = SD.open(base_path + "nut8.txt", FILE_WRITE); s++;
     }
     if (nut9 == "1") {
      SD.remove(base_path + "nut9.txt"); myFile = SD.open(base_path + "nut9.txt", FILE_WRITE); s++;
     }
     if (nut10 == "1") {
      SD.remove(base_path + "nut10.txt"); myFile = SD.open(base_path + "nut10.txt", FILE_WRITE); s++;
     }
     if (on1 == "1") {
      SD.remove(base_path + "on1.txt"); myFile = SD.open(base_path + "on1.txt", FILE_WRITE); s++;
     }
     if (on2 == "1") {
      SD.remove(base_path + "on2.txt"); myFile = SD.open(base_path + "on2.txt", FILE_WRITE); s++;
     }
     if (on3 == "1") {
      SD.remove(base_path + "on3.txt"); myFile = SD.open(base_path + "on3.txt", FILE_WRITE); s++;
     }
     if (on4 == "1") {
      SD.remove(base_path + "on4.txt"); myFile = SD.open(base_path + "on4.txt", FILE_WRITE); s++;
     }
     if (up == "1") {
      SD.remove(base_path + "up.txt"); myFile = SD.open(base_path + "up.txt", FILE_WRITE); s++;
     }
     if (dw == "1") {
      SD.remove(base_path + "dw.txt"); myFile = SD.open(base_path + "dw.txt", FILE_WRITE); s++;
     }
     if (next == "1") {
      SD.remove(base_path + "next.txt"); myFile = SD.open(base_path + "next.txt", FILE_WRITE); s++;
     }
     if (back == "1") {
      SD.remove(base_path + "back.txt"); myFile = SD.open(base_path + "back.txt", FILE_WRITE); s++;
     }
     if (bsao == "1") {
      SD.remove(base_path + "bsao.txt"); myFile = SD.open(base_path + "bsao.txt", FILE_WRITE); s++;
     }
     if (bthang == "1") {
      SD.remove(base_path + "bthang.txt"); myFile = SD.open(base_path + "bthang.txt", FILE_WRITE); s++;
     }
     if (mode == "1") {
      SD.remove(base_path + "mode.txt"); myFile = SD.open(base_path + "mode.txt", FILE_WRITE); s++;
     }
     if (menu == "1") {
      SD.remove(base_path + "menu.txt"); myFile = SD.open(base_path + "menu.txt", FILE_WRITE); s++;
     }
     if (exit == "1") {
      SD.remove(base_path + "exit.txt"); myFile = SD.open(base_path + "exit.txt", FILE_WRITE); s++;
     }
     if (mute == "1") {
      SD.remove(base_path + "mute.txt"); myFile = SD.open(base_path + "mute.txt", FILE_WRITE); s++;
     }
    else
    {
      Serial.println("not found tenfile.txt");
    }
  }
  else if (mode_run == "0")
  {
	if (nut1 == "0") {myFile = SD.open(base_path + "nut0.txt"); s++;}
    if (nut1 == "1") {myFile = SD.open(base_path + "nut1.txt"); s++;}
    if (nut2 == "1") {myFile = SD.open(base_path + "nut2.txt"); s++;}
    if (nut3 == "1") {myFile = SD.open(base_path + "nut3.txt"); s++;}
    if (nut4 == "1") {myFile = SD.open(base_path + "nut4.txt"); s++;}
    if (nut5 == "1") {myFile = SD.open(base_path + "nut5.txt"); s++;}
    if (nut6 == "1") {myFile = SD.open(base_path + "nut6.txt"); s++;}
    if (nut7 == "1") {myFile = SD.open(base_path + "nut7.txt"); s++;}
    if (nut8 == "1") {myFile = SD.open(base_path + "nut8.txt"); s++;}
    if (nut9 == "1") {myFile = SD.open(base_path + "nut9.txt"); s++;}
    if (nut10 == "1") {myFile = SD.open(base_path + "nut10.txt"); s++;}
	if (on1 == "0") {myFile = SD.open(base_path + "on1.txt"); s++;}
	if (on2 == "0") {myFile = SD.open(base_path + "on2.txt"); s++;}
	if (on3 == "0") {myFile = SD.open(base_path + "on3.txt"); s++;}
	if (on4 == "0") {myFile = SD.open(base_path + "on4.txt"); s++;}
	if (up == "0") {myFile = SD.open(base_path + "up.txt"); s++;}
	if (dw == "0") {myFile = SD.open(base_path + "dw.txt"); s++;}
	if (next == "0") {myFile = SD.open(base_path + "next.txt"); s++;}
	if (back == "0") {myFile = SD.open(base_path + "back.txt"); s++;}
	if (bsao == "0") {myFile = SD.open(base_path + "bsao.txt"); s++;}
	if (bthang == "0") {myFile = SD.open(base_path + "bthang.txt"); s++;}
	if (mode == "0") {myFile = SD.open(base_path + "mode.txt"); s++;}
	if (menu == "0") {myFile = SD.open(base_path + "menu.txt"); s++;}
	if (exit == "0") {myFile = SD.open(base_path + "exit.txt"); s++;}
	if (mute == "0") {myFile = SD.open(base_path + "mute.txt"); s++;}
  }
}
void writetoSD()
{
  //*sizeof(uint16_t)
  uint16_t *temp = new uint16_t[1000];
  temp = resultToRawArray(&results);
  memcpy(array_, temp, a*sizeof(uint16_t)); 
  if (s > 0)
  {
    if (myFile)
    {
      for (i = 0; i < a; i++)
      {
        myFile.print(String(array_[i]));
        myFile.print(",");
      }
      myFile.close(); // close the file
    }
  }
  delete[] temp;
}
void ReadFromSD()
{
  if (s > 0)
  {
    uint16_t mang[1000];
    uint16_t k = 0, moc;
    String myString;
    if (myFile)
    {
      while (myFile.available())
      {
        char c = myFile.read();
        myString = myString + String(c);
      }
      myFile.close();
      Serial.println(" " + myString);
      Serial.print("Dodaichuoi: "); Serial.print(myString.length());
      Serial.println();
      for (uint16_t n = 0; n < myString.length(); n++)
      {
        if (myString.charAt(n) == ',')
        {
          moc = n;
          mang[k] = myString.toInt();
          myString.remove(0, moc + 1);
          k++;
          n = 0;
        }
      }
      Serial.print("Dodaimang: "); Serial.print(k);
      Serial.println();
 for(uint16_t m=0;m<k;m++)
 {
 Serial.print(mang[m]); Serial.print(" ");
 }
 Serial.println();
      irsend.sendRaw(mang, k, 38);
      Serial.println("da gui ma IR");
    }
    else Serial.println("error opening tenfile.txt");
  }
}