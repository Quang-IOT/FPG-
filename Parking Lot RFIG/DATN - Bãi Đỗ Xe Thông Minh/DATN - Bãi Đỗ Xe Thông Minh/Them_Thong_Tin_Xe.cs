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

namespace DATN___Bãi_Đỗ_Xe_Thông_Minh
{
    public partial class Them_Thong_Tin_Xe : Form
    {
        public Them_Thong_Tin_Xe()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "am0jkrGRyzrmBY02wKYWHkxNL6vqUJhkue0IY71q",
            BasePath = "https://fir-esp8266-e5534-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Them_Thong_Tin_Xe_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem", "Warning!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_BienSoXe.Text) &&
               string.IsNullOrWhiteSpace(tbx_LoaiXe.Text) &&
               string.IsNullOrWhiteSpace(tbx_MauXe.Text) &&
               string.IsNullOrWhiteSpace(tbx_LoaiVe.Text) &&
               string.IsNullOrWhiteSpace(tbx_Sophone.Text) &&
               string.IsNullOrWhiteSpace(tbx_maRFID.Text))
            {
                MessageBox.Show("Please Fill All The Fields", "Warning!");
                return;
            }


            DataCar dataCar = new DataCar()
            {
                str_BienSoXe = tbx_BienSoXe.Text,
                str_LoaiXe = tbx_LoaiXe.Text,
                str_MauXe = tbx_MauXe.Text,
                str_LoaiVe = tbx_LoaiVe.Text,
                dt_GioVao = DateTime.Now,
                int_TienThu = 0,
                int_trangThai = "-4",
                str_maRFID = tbx_maRFID.Text

            };
            SetResponse response = client.Set(@"DataCar/" + tbx_maRFID.Text, dataCar);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Successfully Add {tbx_BienSoXe.Text}!", "Information!");
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_BienSoXe.Text) &&
               string.IsNullOrWhiteSpace(tbx_LoaiXe.Text) &&
               string.IsNullOrWhiteSpace(tbx_MauXe.Text) &&
               string.IsNullOrWhiteSpace(tbx_LoaiVe.Text) &&
               string.IsNullOrWhiteSpace(tbx_Sophone.Text) &&
               string.IsNullOrWhiteSpace(tbx_maRFID.Text))
            {
                MessageBox.Show("Please Fill All The Fields", "Warning!");
                return;
            }


            DataCar dataCar = new DataCar()
            {
                str_BienSoXe = tbx_BienSoXe.Text,
                str_LoaiXe = tbx_LoaiXe.Text,
                str_MauXe = tbx_MauXe.Text,
                str_LoaiVe = tbx_LoaiVe.Text,
                dt_GioVao = DateTime.Now,
                int_TienThu = 0,
                int_trangThai = "-4",
                str_maRFID = tbx_maRFID.Text

            };
            SetResponse response = client.Set(@"DataCar/" + tbx_maRFID.Text, dataCar);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Successfully Update {tbx_BienSoXe.Text}!", "Information!");
            }
        }
    }
}
