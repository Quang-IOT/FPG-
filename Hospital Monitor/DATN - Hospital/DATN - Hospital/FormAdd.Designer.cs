
namespace DATN___Hospital
{
    partial class FormAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMabn = new System.Windows.Forms.TextBox();
            this.txtMabn_ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMabn);
            this.groupBox1.Controls.Add(this.txtMabn_);
            this.groupBox1.Location = new System.Drawing.Point(106, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_sdtnn
            // 
            this.txt_sdtnn.Location = new System.Drawing.Point(206, 189);
            this.txt_sdtnn.Name = "txt_sdtnn";
            this.txt_sdtnn.Size = new System.Drawing.Size(121, 20);
            this.txt_sdtnn.TabIndex = 43;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(111, 196);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "SĐT người nhà :";
            // 
            // txt_nnv
            // 
            this.txt_nnv.Location = new System.Drawing.Point(206, 163);
            this.txt_nnv.Name = "txt_nnv";
            this.txt_nnv.Size = new System.Drawing.Size(121, 20);
            this.txt_nnv.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Ngày nhập viện :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Bệnh án:";
            // 
            // txt_benhan
            // 
            this.txt_benhan.Location = new System.Drawing.Point(399, 93);
            this.txt_benhan.Multiline = true;
            this.txt_benhan.Name = "txt_benhan";
            this.txt_benhan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_benhan.Size = new System.Drawing.Size(223, 116);
            this.txt_benhan.TabIndex = 38;
            // 
            // txtbs
            // 
            this.txtbs.Location = new System.Drawing.Point(206, 137);
            this.txtbs.Name = "txtbs";
            this.txtbs.Size = new System.Drawing.Size(121, 20);
            this.txtbs.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Bác sỹ phụ trách :";
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(206, 111);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(121, 20);
            this.txt_ns.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ngày tháng sinh:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(206, 85);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(121, 20);
            this.txt_ten.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tên Bệnh Nhân :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(176, 28);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(297, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Location = new System.Drawing.Point(257, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 63);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // txtMabn
            // 
            this.txtMabn.Location = new System.Drawing.Point(100, 18);
            this.txtMabn.Name = "txtMabn";
            this.txtMabn.Size = new System.Drawing.Size(121, 20);
            this.txtMabn.TabIndex = 49;
            // 
            // txtMabn_
            // 
            this.txtMabn_.AutoSize = true;
            this.txtMabn_.Location = new System.Drawing.Point(1, 25);
            this.txtMabn_.Name = "txtMabn_";
            this.txtMabn_.Size = new System.Drawing.Size(85, 13);
            this.txtMabn_.TabIndex = 48;
            this.txtMabn_.Text = "Mã Bệnh Nhân :";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_sdtnn);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txt_nnv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_benhan);
            this.Controls.Add(this.txtbs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ns);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_sdtnn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_nnv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_benhan;
        private System.Windows.Forms.TextBox txtbs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMabn;
        private System.Windows.Forms.Label txtMabn_;
    }
}