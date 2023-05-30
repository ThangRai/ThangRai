
namespace quản_lý_bán_hàng
{
    partial class DKiKHForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDki = new quản_lý_bán_hàng.customButton();
            this.buttonDong = new quản_lý_bán_hàng.customButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxMaKH = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxHoTen = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxDiaChi = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxSDT = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxUser = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxPass = new quản_lý_bán_hàng.textBoxCustom();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số điện thoại";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // buttonDki
            // 
            this.buttonDki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonDki.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonDki.BoderRadius = 40;
            this.buttonDki.BoderSize = 0;
            this.buttonDki.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDki.FlatAppearance.BorderSize = 0;
            this.buttonDki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDki.ForeColor = System.Drawing.Color.White;
            this.buttonDki.Location = new System.Drawing.Point(214, 465);
            this.buttonDki.Name = "buttonDki";
            this.buttonDki.ReadOnly = false;
            this.buttonDki.Size = new System.Drawing.Size(150, 40);
            this.buttonDki.TabIndex = 3;
            this.buttonDki.Text = "Đăng kí";
            this.buttonDki.TextColor = System.Drawing.Color.White;
            this.buttonDki.UseVisualStyleBackColor = false;
            this.buttonDki.Click += new System.EventHandler(this.buttonDki_Click);
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonDong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonDong.BoderRadius = 40;
            this.buttonDong.BoderSize = 0;
            this.buttonDong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDong.FlatAppearance.BorderSize = 0;
            this.buttonDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDong.ForeColor = System.Drawing.Color.White;
            this.buttonDong.Location = new System.Drawing.Point(31, 465);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.ReadOnly = false;
            this.buttonDong.Size = new System.Drawing.Size(150, 40);
            this.buttonDong.TabIndex = 4;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.TextColor = System.Drawing.Color.White;
            this.buttonDong.UseVisualStyleBackColor = false;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.Lime;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(79, 519);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(253, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đã có tài khoản ??,Đăng nhập ngay !!!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaKH.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaKH.BorderSize = 1;
            this.textBoxMaKH.Br = System.Drawing.Color.White;
            this.textBoxMaKH.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxMaKH.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaKH.Location = new System.Drawing.Point(170, 52);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.PasswordChar = '\0';
            this.textBoxMaKH.ReadOnly = false;
            this.textBoxMaKH.Size = new System.Drawing.Size(181, 30);
            this.textBoxMaKH.TabIndex = 6;
            this.textBoxMaKH.textboxRadius = 12;
            this.textBoxMaKH.UseSystemPasswordChar = false;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.BackColor = System.Drawing.Color.Transparent;
            this.textBoxHoTen.BorderColor = System.Drawing.Color.Gray;
            this.textBoxHoTen.BorderSize = 1;
            this.textBoxHoTen.Br = System.Drawing.Color.White;
            this.textBoxHoTen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxHoTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxHoTen.Location = new System.Drawing.Point(170, 100);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.PasswordChar = '\0';
            this.textBoxHoTen.ReadOnly = false;
            this.textBoxHoTen.Size = new System.Drawing.Size(181, 30);
            this.textBoxHoTen.TabIndex = 6;
            this.textBoxHoTen.textboxRadius = 12;
            this.textBoxHoTen.UseSystemPasswordChar = false;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.textBoxDiaChi.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDiaChi.BorderSize = 1;
            this.textBoxDiaChi.Br = System.Drawing.Color.White;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxDiaChi.ForeColor = System.Drawing.Color.Black;
            this.textBoxDiaChi.Location = new System.Drawing.Point(170, 241);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.PasswordChar = '\0';
            this.textBoxDiaChi.ReadOnly = false;
            this.textBoxDiaChi.Size = new System.Drawing.Size(181, 30);
            this.textBoxDiaChi.TabIndex = 6;
            this.textBoxDiaChi.textboxRadius = 12;
            this.textBoxDiaChi.UseSystemPasswordChar = false;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSDT.BorderColor = System.Drawing.Color.Gray;
            this.textBoxSDT.BorderSize = 1;
            this.textBoxSDT.Br = System.Drawing.Color.White;
            this.textBoxSDT.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxSDT.ForeColor = System.Drawing.Color.Black;
            this.textBoxSDT.Location = new System.Drawing.Point(170, 291);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.PasswordChar = '\0';
            this.textBoxSDT.ReadOnly = false;
            this.textBoxSDT.Size = new System.Drawing.Size(181, 30);
            this.textBoxSDT.TabIndex = 6;
            this.textBoxSDT.textboxRadius = 12;
            this.textBoxSDT.UseSystemPasswordChar = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUser.BorderColor = System.Drawing.Color.Gray;
            this.textBoxUser.BorderSize = 1;
            this.textBoxUser.Br = System.Drawing.Color.White;
            this.textBoxUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(170, 347);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.ReadOnly = false;
            this.textBoxUser.Size = new System.Drawing.Size(181, 30);
            this.textBoxUser.TabIndex = 6;
            this.textBoxUser.textboxRadius = 12;
            this.textBoxUser.UseSystemPasswordChar = false;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPass.BorderColor = System.Drawing.Color.Gray;
            this.textBoxPass.BorderSize = 1;
            this.textBoxPass.Br = System.Drawing.Color.White;
            this.textBoxPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(170, 406);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '\0';
            this.textBoxPass.ReadOnly = false;
            this.textBoxPass.Size = new System.Drawing.Size(181, 30);
            this.textBoxPass.TabIndex = 6;
            this.textBoxPass.textboxRadius = 12;
            this.textBoxPass.UseSystemPasswordChar = false;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(170, 156);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(58, 20);
            this.radioButtonNam.TabIndex = 7;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(241, 154);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(48, 20);
            this.radioButtonNu.TabIndex = 7;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // DKiKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(389, 544);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.buttonDki);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.Name = "DKiKHForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private customButton buttonDki;
        public customButton buttonDong;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public textBoxCustom textBoxMaKH;
        public textBoxCustom textBoxHoTen;
        public textBoxCustom textBoxDiaChi;
        public textBoxCustom textBoxSDT;
        public textBoxCustom textBoxUser;
        public textBoxCustom textBoxPass;
        public System.Windows.Forms.RadioButton radioButtonNam;
        public System.Windows.Forms.RadioButton radioButtonNu;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}