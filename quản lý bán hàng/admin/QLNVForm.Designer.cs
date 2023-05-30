
namespace quản_lý_bán_hàng
{
    partial class QLNVForm
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
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerNamSinh = new System.Windows.Forms.DateTimePicker();
            this.buttonUpload = new quản_lý_bán_hàng.customButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.textBoxDiaChi = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxPass = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxUser = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxHoTen = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxMaNV = new quản_lý_bán_hàng.textBoxCustom();
            this.buttonSua = new quản_lý_bán_hàng.customButton();
            this.buttonThoat = new quản_lý_bán_hàng.customButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 50;
            this.dataGridViewNV.Size = new System.Drawing.Size(740, 633);
            this.dataGridViewNV.TabIndex = 0;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(740, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 635);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dateTimePickerNamSinh);
            this.panel1.Controls.Add(this.buttonUpload);
            this.panel1.Controls.Add(this.radioButtonNu);
            this.panel1.Controls.Add(this.radioButtonNam);
            this.panel1.Controls.Add(this.pictureBoxHinh);
            this.panel1.Controls.Add(this.textBoxDiaChi);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.textBoxHoTen);
            this.panel1.Controls.Add(this.textBoxMaNV);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 611);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerNamSinh
            // 
            this.dateTimePickerNamSinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNamSinh.Location = new System.Drawing.Point(137, 192);
            this.dateTimePickerNamSinh.Name = "dateTimePickerNamSinh";
            this.dateTimePickerNamSinh.Size = new System.Drawing.Size(157, 25);
            this.dateTimePickerNamSinh.TabIndex = 13;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonUpload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonUpload.BoderRadius = 26;
            this.buttonUpload.BoderSize = 0;
            this.buttonUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpload.FlatAppearance.BorderSize = 0;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpload.ForeColor = System.Drawing.Color.White;
            this.buttonUpload.Location = new System.Drawing.Point(138, 419);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.ReadOnly = false;
            this.buttonUpload.Size = new System.Drawing.Size(150, 26);
            this.buttonUpload.TabIndex = 12;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.TextColor = System.Drawing.Color.White;
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(201, 155);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(56, 23);
            this.radioButtonNu.TabIndex = 11;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            this.radioButtonNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(137, 155);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(69, 23);
            this.radioButtonNam.TabIndex = 11;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.BackColor = System.Drawing.Color.White;
            this.pictureBoxHinh.Location = new System.Drawing.Point(137, 316);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(153, 99);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinh.TabIndex = 10;
            this.pictureBoxHinh.TabStop = false;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.textBoxDiaChi.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDiaChi.BorderSize = 1;
            this.textBoxDiaChi.Br = System.Drawing.Color.White;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxDiaChi.ForeColor = System.Drawing.Color.Black;
            this.textBoxDiaChi.Location = new System.Drawing.Point(137, 237);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.PasswordChar = '\0';
            this.textBoxDiaChi.ReadOnly = false;
            this.textBoxDiaChi.Size = new System.Drawing.Size(157, 60);
            this.textBoxDiaChi.TabIndex = 9;
            this.textBoxDiaChi.textboxRadius = 12;
            this.textBoxDiaChi.UseSystemPasswordChar = false;
            this.textBoxDiaChi.Click += new System.EventHandler(this.textBoxCustom4_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPass.BorderColor = System.Drawing.Color.Gray;
            this.textBoxPass.BorderSize = 1;
            this.textBoxPass.Br = System.Drawing.Color.White;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(141, 501);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '\0';
            this.textBoxPass.ReadOnly = false;
            this.textBoxPass.Size = new System.Drawing.Size(153, 30);
            this.textBoxPass.TabIndex = 8;
            this.textBoxPass.textboxRadius = 15;
            this.textBoxPass.UseSystemPasswordChar = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUser.BorderColor = System.Drawing.Color.Gray;
            this.textBoxUser.BorderSize = 1;
            this.textBoxUser.Br = System.Drawing.Color.White;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(141, 453);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.ReadOnly = false;
            this.textBoxUser.Size = new System.Drawing.Size(153, 30);
            this.textBoxUser.TabIndex = 7;
            this.textBoxUser.textboxRadius = 15;
            this.textBoxUser.UseSystemPasswordChar = false;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.BackColor = System.Drawing.Color.Transparent;
            this.textBoxHoTen.BorderColor = System.Drawing.Color.Gray;
            this.textBoxHoTen.BorderSize = 1;
            this.textBoxHoTen.Br = System.Drawing.Color.White;
            this.textBoxHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxHoTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxHoTen.Location = new System.Drawing.Point(137, 106);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.PasswordChar = '\0';
            this.textBoxHoTen.ReadOnly = false;
            this.textBoxHoTen.Size = new System.Drawing.Size(157, 30);
            this.textBoxHoTen.TabIndex = 4;
            this.textBoxHoTen.textboxRadius = 15;
            this.textBoxHoTen.UseSystemPasswordChar = false;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaNV.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaNV.BorderSize = 1;
            this.textBoxMaNV.Br = System.Drawing.Color.White;
            this.textBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaNV.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaNV.Location = new System.Drawing.Point(137, 54);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.PasswordChar = '\0';
            this.textBoxMaNV.ReadOnly = false;
            this.textBoxMaNV.Size = new System.Drawing.Size(157, 30);
            this.textBoxMaNV.TabIndex = 3;
            this.textBoxMaNV.textboxRadius = 15;
            this.textBoxMaNV.UseSystemPasswordChar = false;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonSua.BoderRadius = 40;
            this.buttonSua.BoderSize = 0;
            this.buttonSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(180, 556);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.ReadOnly = false;
            this.buttonSua.Size = new System.Drawing.Size(114, 40);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextColor = System.Drawing.Color.White;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonThoat.BoderRadius = 40;
            this.buttonThoat.BoderSize = 0;
            this.buttonThoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonThoat.FlatAppearance.BorderSize = 0;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.ForeColor = System.Drawing.Color.White;
            this.buttonThoat.Location = new System.Drawing.Point(32, 556);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.ReadOnly = false;
            this.buttonThoat.Size = new System.Drawing.Size(114, 40);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextColor = System.Drawing.Color.White;
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ảnh đại diện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số nhân viên";
            // 
            // QLNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewNV);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "QLNVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QLNVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton radioButtonNu;
        public System.Windows.Forms.RadioButton radioButtonNam;
        public System.Windows.Forms.PictureBox pictureBoxHinh;
        public textBoxCustom textBoxDiaChi;
        public textBoxCustom textBoxPass;
        public textBoxCustom textBoxUser;
        public textBoxCustom textBoxHoTen;
        public textBoxCustom textBoxMaNV;
        public customButton buttonSua;
        public customButton buttonThoat;
        public System.Windows.Forms.Label label1;
        public customButton buttonUpload;
        public System.Windows.Forms.DateTimePicker dateTimePickerNamSinh;
    }
}