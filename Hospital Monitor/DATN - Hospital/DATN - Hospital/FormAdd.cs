using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN___Hospital
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1_ = new Form1();
            Form1_.ShowDialog();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_ten.Text = "";
            txt_ns.Text = "";
            txtbs.Text = "";
            txt_nnv.Text = "";
            txt_sdtnn.Text = "";
            txt_benhan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMabn_.Text !="")
            {
                using (StreamWriter sw = new StreamWriter(@"..\Database\" + txtMabn.Text + ".txt"))
                {

                        sw.WriteLine(txt_ten.Text);
                        sw.WriteLine(txt_ns.Text);
                        sw.WriteLine(txtbs.Text);
                        sw.WriteLine(txt_nnv.Text);
                        sw.WriteLine(txt_sdtnn.Text);
                }
                using (StreamWriter swbn = new StreamWriter(@"..\Database\" + txtMabn.Text + "_b_a.txt"))
                {
                        swbn.WriteLine(txt_benhan.Text);
                }

                MessageBox.Show("Đã thêm data bệnh nhân"+ txt_ten.Text + " có mã " + txtMabn.Text + " vào CSDL");
                txt_ten.Text = "";
                txt_ns.Text = "";
                txtbs.Text = "";
                txt_nnv.Text = "";
                txt_sdtnn.Text = "";
                txt_benhan.Text = "";
            }    
            else
            {

            }

        }
    }
}
