using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Thêm 3 em này vào là OK, để sài SerialPort
using System.IO;
using System.IO.Ports;
using System.Xml;
// Bắt đầu code

namespace DATN___Hospital
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        public Form1()
        {
            InitializeComponent();
            // Khai báo hàm delegate bằng phương thức DataReceived của Object SerialPort;
            // Cái này khi có sự kiện nhận dữ liệu sẽ nhảy đến phương thức DataReceive
            // Nếu ko hiểu đoạn này bạn có thể tìm hiểu về Delegate, còn ko cứ COPY . Ko cần quan tâm
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox2.Items.AddRange(BaudRate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();

            //comboBox2.SelectedIndex = 3;
            //readFileDataSave();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                // txtIn.Text = InputData; // Ko dùng đc như thế này vì khác threads .
                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.
                
            }

        }
        // Hàm của em nó là ở đây. Đừng hỏi vì sao lại thế.
        private void SetText(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else this.textBox1.Text += text;
            InputData = "A69B0C0";// can sua cho nay
            lb_nt.Text = InputData.Substring(1, 2).ToString();
            if (InputData.Substring(4, 1).ToString() == "0")
            {
                lb_tt.Text = "OFF";
            }
            if (InputData.Substring(4, 1).ToString() == "1")
            {
                lb_tt.Text = "ON";
            }
            if (InputData.Substring(6, 1).ToString() == "0")
            {
                lb_call.Text = "OFF";
            }
            if (InputData.Substring(6, 1).ToString() == "1")
            {
                lb_call.Text = "ON";
            }
            label5.Text = "Đã kết nối";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("2");//Nếu button2 được nhấn,gửi byte “1” đến cổng serialPort1
            readFileDataSave();
        }
        private void readFileDataSave()
        {
            string name = txt_mabn.Text;
            try
            {
                DirectoryInfo directory = Directory.CreateDirectory("C:/data_DATN");
                using (StreamReader sr = new StreamReader("C:/data_DATN/"+ name+ ".txt"))
                {

                    txt_ten.Text = sr.ReadLine().ToString();
                    txt_ns.Text = sr.ReadLine().ToString();
                    txtbs.Text = sr.ReadLine().ToString();
                    txt_nnv.Text = sr.ReadLine().ToString();
                    txt_sdtnn.Text = sr.ReadLine().ToString();
                    txt_benhan.Text = sr.ReadLine().ToString();

                }
            }
            catch (Exception e)
            {
                txt_ten.Text = "err";
            }
        }

        private void btn_co_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) // Nếu đối tượng serialPort1 chưa được mở , sau khi nhấn button 1 thỳ…
            {

                serialPort1.PortName = comboBox1.Text;//cổng serialPort1 = ComboBox mà bạn đang chọn
                serialPort1.Open();// Mở cổng serialPort1


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label5.Text = "Đã ngắt kết nối";
        }


    }


    }

