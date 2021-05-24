using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Threading;

namespace DATN___Bãi_Đỗ_Xe_Thông_Minh
{
    public partial class Giao_Dien_Gui_Xe : Form
    {
        public Giao_Dien_Gui_Xe()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "am0jkrGRyzrmBY02wKYWHkxNL6vqUJhkue0IY71q",
            BasePath = "https://fir-esp8266-e5534-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        class in4_input
        {
            public string My_RFID { get; set; }
            public string status { get; set; }
        };
        private void Giao_Dien_Gui_Xe_Load(object sender, EventArgs e)
        {
            string number_card = null;
            string[] arr_data_;
            // read data the gủi xe ở đây
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                FirebaseResponse data__ = client.Get(@"In4_car_input/" + "My_RFID");
                number_card = data__.Body.ToString().Replace("\"", "");
            }
            catch
            {

            }
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                FirebaseResponse data_ = client.Get(@"DataCar/" + number_card);
                string str_data_ = data_.Body.ToString().Replace("\"", "").Replace("{", "").Replace("}", "");
                arr_data_ = str_data_.Split(new char[] { ',' });

                foreach (string count in arr_data_)
                {
                    if (count.Contains("dt_GioVao"))
                    {
                        string[] data_show_ = count.Split(new char[] { ':' });
                        tbx_GioVao.Text = data_show_[1].ToString();
                    }
                    if (count.Contains("int_trangThai"))
                    {
                        string[] data_show_ = count.Split(new char[] { ':' });
                    }
                    if (count.Contains("str_BienSoXe"))
                    {
                        string[] data_show_ = count.Split(new char[] { ':' });
                        tbx_BienSoXe.Text = data_show_[1].ToString();
                    }
                    if (count.Contains("str_LoaiVe"))
                    {
                        string[] data_show_ = count.Split(new char[] { ':' });
                        tbx_LoaiVe.Text = data_show_[1].ToString();
                    }
                    if (count.Contains("str_LoaiXe"))
                    {
                        string[] data_show_ = count.Split(new char[] { ':' });
                        tbx_LoaiXe.Text = data_show_[1].ToString();
                    }
                    if (count.Contains("str_MauXe"))
                    {
                        string[] data_show_ = count.Split(new char[] { ':' });
                        tbx_MauXe.Text = data_show_[1].ToString();
                    }
                }

            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem", "Warning!");
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(ifc);
            FirebaseResponse data_ = client.Get(@"In4_car_input/" + "My_RFID");
            string number_card = data_.Body.ToString().Replace("\"", "");

            in4_input in4_input_ = new in4_input()
            {
                My_RFID = "Waiting",
                status = "1"
            };

            in4_input in4_done_ = new in4_input()
            {
                My_RFID = "Done",
                status = "0"
            };

            DataCar dataCar = new DataCar()
            {
                str_BienSoXe = tbx_BienSoXe.Text,
                str_LoaiXe = tbx_LoaiXe.Text,
                str_MauXe = tbx_MauXe.Text,
                str_LoaiVe = tbx_LoaiVe.Text,
                dt_GioVao = DateTime.Now,
                int_TienThu = 0,
                int_trangThai = "-1",
                str_maRFID = number_card
            };

            client = new FireSharp.FirebaseClient(ifc);
            FirebaseResponse data_status = client.Get(@"DataCar/" + number_card);
            string str_data_status = data_status.Body.ToString().Replace("\"", "").Replace("{", "").Replace("}", "");
            string[] arr_data_status = str_data_status.Split(new char[] { ',' });
            string ststus_ht = "emp";
            foreach (string count in arr_data_status)
            {
                if (count.Contains("int_trangThai"))
                {
                    string[] data_show_ = count.Split(new char[] { ':' });
                    ststus_ht = data_show_[1].ToString();
                }
            }
            if (ststus_ht == "-4")
            {
                var update = client.Update(@"DataCar/" + number_card, dataCar);
                Thread.Sleep(1000);
                var sent = client.Update(@"In4_car_input/", in4_input_);
                Thread.Sleep(1000);
                var done_ = client.Update(@"In4_car_input/", in4_done_);
                Thread.Sleep(1000);
            }
            else
            {
                MessageBox.Show("Not Data Car output");
            }
        }
        private void btn_selec_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            Them_Thong_Tin_Xe Them_Thong_Tin_Xe_ = new Them_Thong_Tin_Xe();
            Them_Thong_Tin_Xe_.ShowDialog();
            this.Close();
        }

        private void btn_selec_Gui_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giao_Dien_Gui_Xe Giao_Dien_Gui_Xe_ = new Giao_Dien_Gui_Xe();
            Giao_Dien_Gui_Xe_.ShowDialog();
            this.Close();
        }

        private void btn_selec_Lay_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Giao_Dien_Lay_Xe Giao_Dien_Lay_Xe_ = new Giao_Dien_Lay_Xe();
            Giao_Dien_Lay_Xe_.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
