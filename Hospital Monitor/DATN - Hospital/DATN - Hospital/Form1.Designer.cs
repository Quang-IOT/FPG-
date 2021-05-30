
namespace DATN___Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_co = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txt_mabn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sdtnn = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_nnv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_benhan = new System.Windows.Forms.TextBox();
            this.txtbs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_call = new System.Windows.Forms.Label();
            this.lb_tt = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_nt = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ngắt kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_co
            // 
            this.btn_co.Location = new System.Drawing.Point(351, 82);
            this.btn_co.Name = "btn_co";
            this.btn_co.Size = new System.Drawing.Size(76, 24);
            this.btn_co.TabIndex = 16;
            this.btn_co.Text = "Kết nối";
            this.btn_co.UseVisualStyleBackColor = true;
            this.btn_co.Click += new System.EventHandler(this.btn_co_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chưa kết nối";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Trạng thái :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Baud Rate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "COM :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(211, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhận dữ liệu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(90, 85);
            this.textBox1.TabIndex = 8;
            // 
            // txt_mabn
            // 
            this.txt_mabn.Location = new System.Drawing.Point(211, 59);
            this.txt_mabn.Name = "txt_mabn";
            this.txt_mabn.Size = new System.Drawing.Size(121, 20);
            this.txt_mabn.TabIndex = 18;
            this.txt_mabn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã Bệnh Nhân :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sdtnn);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txt_nnv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_benhan);
            this.groupBox1.Controls.Add(this.txtbs);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_ns);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(117, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 165);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ Sơ Bệnh Nhân";
            // 
            // txt_sdtnn
            // 
            this.txt_sdtnn.Location = new System.Drawing.Point(104, 128);
            this.txt_sdtnn.Name = "txt_sdtnn";
            this.txt_sdtnn.Size = new System.Drawing.Size(121, 20);
            this.txt_sdtnn.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "SĐT người nhà :";
            // 
            // txt_nnv
            // 
            this.txt_nnv.Location = new System.Drawing.Point(104, 102);
            this.txt_nnv.Name = "txt_nnv";
            this.txt_nnv.Size = new System.Drawing.Size(121, 20);
            this.txt_nnv.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ngày nhập viện :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bệnh án:";
            // 
            // txt_benhan
            // 
            this.txt_benhan.Location = new System.Drawing.Point(297, 32);
            this.txt_benhan.Multiline = true;
            this.txt_benhan.Name = "txt_benhan";
            this.txt_benhan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_benhan.Size = new System.Drawing.Size(223, 116);
            this.txt_benhan.TabIndex = 26;
            // 
            // txtbs
            // 
            this.txtbs.Location = new System.Drawing.Point(104, 76);
            this.txtbs.Name = "txtbs";
            this.txtbs.Size = new System.Drawing.Size(121, 20);
            this.txtbs.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bác sỹ phụ trách :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(104, 50);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(121, 20);
            this.txt_ns.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày tháng sinh:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(104, 24);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(121, 20);
            this.txt_ten.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên Bệnh Nhân :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 24);
            this.button3.TabIndex = 21;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(443, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(91, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "70";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "70";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Call Y tá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Tình Trạng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "70";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nhịp Tim";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_call);
            this.groupBox3.Controls.Add(this.lb_tt);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lb_nt);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(437, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // lb_call
            // 
            this.lb_call.AutoSize = true;
            this.lb_call.Location = new System.Drawing.Point(91, 75);
            this.lb_call.Name = "lb_call";
            this.lb_call.Size = new System.Drawing.Size(33, 13);
            this.lb_call.TabIndex = 15;
            this.lb_call.Text = "None";
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Location = new System.Drawing.Point(91, 53);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(33, 13);
            this.lb_tt.TabIndex = 14;
            this.lb_tt.Text = "None";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Call Y tá";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Tình Trạng";
            // 
            // lb_nt
            // 
            this.lb_nt.AutoSize = true;
            this.lb_nt.Location = new System.Drawing.Point(92, 26);
            this.lb_nt.Name = "lb_nt";
            this.lb_nt.Size = new System.Drawing.Size(33, 13);
            this.lb_nt.TabIndex = 11;
            this.lb_nt.Text = "None";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Nhịp Tim";
            // 
            // btnSThem
            // 
            this.btnSThem.Location = new System.Drawing.Point(15, 233);
            this.btnSThem.Name = "btnSThem";
            this.btnSThem.Size = new System.Drawing.Size(75, 23);
            this.btnSThem.TabIndex = 23;
            this.btnSThem.Text = "Thêm";
            this.btnSThem.UseVisualStyleBackColor = true;
            this.btnSThem.Click += new System.EventHandler(this.btnSThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 332);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mabn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_co);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_co;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txt_mabn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_benhan;
        private System.Windows.Forms.TextBox txt_nnv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_call;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_nt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_sdtnn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnSThem;
        private System.Windows.Forms.Button btnExit;
    }
}

