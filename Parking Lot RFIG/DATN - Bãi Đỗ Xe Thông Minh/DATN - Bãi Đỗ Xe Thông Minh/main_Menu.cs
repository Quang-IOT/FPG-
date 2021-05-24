using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN___Bãi_Đỗ_Xe_Thông_Minh
{
    public partial class main_Menu : Form
    {
        public main_Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Them_Thong_Tin_Xe Them_Thong_Tin_Xe_ = new Them_Thong_Tin_Xe();
            Them_Thong_Tin_Xe_.ShowDialog();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
