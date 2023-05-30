
namespace quản_lý_bán_hàng
{
    partial class KHForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHForm));
            this.labelKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKhuyenMai = new System.Windows.Forms.Label();
            this.pictureBoxGioHang = new System.Windows.Forms.PictureBox();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelGioHang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMuaHang = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new quản_lý_bán_hàng.customButton();
            this.buttonDangXuat = new quản_lý_bán_hàng.customButton();
            this.buttonChonGH = new quản_lý_bán_hàng.customButton();
            this.buttonXacNhan = new quản_lý_bán_hàng.customButton();
            this.textBoxMaGG = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxGia = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxTenHang = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxMaHang = new quản_lý_bán_hàng.textBoxCustom();
            this.buttonThem = new quản_lý_bán_hàng.customButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.groupBoxMuaHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKH
            // 
            this.labelKH.AutoSize = true;
            this.labelKH.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKH.ForeColor = System.Drawing.Color.Red;
            this.labelKH.Location = new System.Drawing.Point(158, 14);
            this.labelKH.Name = "labelKH";
            this.labelKH.Size = new System.Drawing.Size(406, 28);
            this.labelKH.TabIndex = 15;
            this.labelKH.Text = "Khách hàng ... hiện đang mua sắm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelKhuyenMai);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonDangXuat);
            this.panel1.Controls.Add(this.labelKH);
            this.panel1.Controls.Add(this.pictureBoxGioHang);
            this.panel1.Location = new System.Drawing.Point(2, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 106);
            this.panel1.TabIndex = 6;
            // 
            // labelKhuyenMai
            // 
            this.labelKhuyenMai.AutoSize = true;
            this.labelKhuyenMai.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhuyenMai.ForeColor = System.Drawing.Color.Cyan;
            this.labelKhuyenMai.Location = new System.Drawing.Point(158, 69);
            this.labelKhuyenMai.Name = "labelKhuyenMai";
            this.labelKhuyenMai.Size = new System.Drawing.Size(582, 24);
            this.labelKhuyenMai.TabIndex = 18;
            this.labelKhuyenMai.Text = "Áp dụng mã giảm giá được giảm 10% trên tổng hóa đơn";
            // 
            // pictureBoxGioHang
            // 
            this.pictureBoxGioHang.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGioHang.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGioHang.Image")));
            this.pictureBoxGioHang.Location = new System.Drawing.Point(11, 3);
            this.pictureBoxGioHang.Name = "pictureBoxGioHang";
            this.pictureBoxGioHang.Size = new System.Drawing.Size(132, 99);
            this.pictureBoxGioHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGioHang.TabIndex = 4;
            this.pictureBoxGioHang.TabStop = false;
            this.pictureBoxGioHang.Click += new System.EventHandler(this.pictureBoxGioHang_Click);
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 80;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(848, 529);
            this.dataGridViewMatHang.TabIndex = 8;
            this.dataGridViewMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellClick);
            this.dataGridViewMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonChonGH);
            this.panel2.Controls.Add(this.buttonXacNhan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxMaGG);
            this.panel2.Controls.Add(this.textBoxGia);
            this.panel2.Controls.Add(this.textBoxTenHang);
            this.panel2.Controls.Add(this.textBoxMaHang);
            this.panel2.Controls.Add(this.buttonThem);
            this.panel2.Controls.Add(this.pictureBoxHinh);
            this.panel2.Controls.Add(this.numericSoLuong);
            this.panel2.Controls.Add(this.labelGioHang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 617);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã giảm giá";
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.BackColor = System.Drawing.Color.White;
            this.pictureBoxHinh.Location = new System.Drawing.Point(141, 301);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(163, 140);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinh.TabIndex = 3;
            this.pictureBoxHinh.TabStop = false;
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(141, 190);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(65, 25);
            this.numericSoLuong.TabIndex = 2;
            // 
            // labelGioHang
            // 
            this.labelGioHang.AutoSize = true;
            this.labelGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioHang.Location = new System.Drawing.Point(179, 12);
            this.labelGioHang.Name = "labelGioHang";
            this.labelGioHang.Size = new System.Drawing.Size(125, 29);
            this.labelGioHang.TabIndex = 0;
            this.labelGioHang.Text = "Giỏ hàng:";
            this.labelGioHang.Click += new System.EventHandler(this.labelGioHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá(số lượng 1):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // groupBoxMuaHang
            // 
            this.groupBoxMuaHang.Controls.Add(this.panel2);
            this.groupBoxMuaHang.Location = new System.Drawing.Point(850, 3);
            this.groupBoxMuaHang.Name = "groupBoxMuaHang";
            this.groupBoxMuaHang.Size = new System.Drawing.Size(458, 641);
            this.groupBoxMuaHang.TabIndex = 7;
            this.groupBoxMuaHang.TabStop = false;
            this.groupBoxMuaHang.Text = "Mua hàng";
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
            this.buttonThoat.Location = new System.Drawing.Point(1006, 59);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.ReadOnly = false;
            this.buttonThoat.Size = new System.Drawing.Size(106, 40);
            this.buttonThoat.TabIndex = 17;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextColor = System.Drawing.Color.White;
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonDangXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonDangXuat.BoderRadius = 40;
            this.buttonDangXuat.BoderSize = 0;
            this.buttonDangXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDangXuat.FlatAppearance.BorderSize = 0;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangXuat.ForeColor = System.Drawing.Color.White;
            this.buttonDangXuat.Location = new System.Drawing.Point(731, 39);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.ReadOnly = false;
            this.buttonDangXuat.Size = new System.Drawing.Size(111, 40);
            this.buttonDangXuat.TabIndex = 16;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.TextColor = System.Drawing.Color.White;
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonChonGH
            // 
            this.buttonChonGH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChonGH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonChonGH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonChonGH.BoderRadius = 0;
            this.buttonChonGH.BoderSize = 0;
            this.buttonChonGH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonChonGH.FlatAppearance.BorderSize = 0;
            this.buttonChonGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChonGH.ForeColor = System.Drawing.Color.White;
            this.buttonChonGH.Location = new System.Drawing.Point(13, 13);
            this.buttonChonGH.Name = "buttonChonGH";
            this.buttonChonGH.ReadOnly = false;
            this.buttonChonGH.Size = new System.Drawing.Size(104, 30);
            this.buttonChonGH.TabIndex = 12;
            this.buttonChonGH.Text = "Chọn giỏ hàng";
            this.buttonChonGH.TextColor = System.Drawing.Color.White;
            this.buttonChonGH.UseVisualStyleBackColor = false;
            this.buttonChonGH.Click += new System.EventHandler(this.buttonChonGH_Click);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXacNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXacNhan.BoderRadius = 40;
            this.buttonXacNhan.BoderSize = 0;
            this.buttonXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXacNhan.FlatAppearance.BorderSize = 0;
            this.buttonXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXacNhan.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhan.Location = new System.Drawing.Point(144, 558);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.ReadOnly = false;
            this.buttonXacNhan.Size = new System.Drawing.Size(150, 40);
            this.buttonXacNhan.TabIndex = 11;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.TextColor = System.Drawing.Color.White;
            this.buttonXacNhan.UseVisualStyleBackColor = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // textBoxMaGG
            // 
            this.textBoxMaGG.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaGG.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaGG.BorderSize = 1;
            this.textBoxMaGG.Br = System.Drawing.Color.White;
            this.textBoxMaGG.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxMaGG.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaGG.Location = new System.Drawing.Point(85, 518);
            this.textBoxMaGG.Name = "textBoxMaGG";
            this.textBoxMaGG.PasswordChar = '\0';
            this.textBoxMaGG.ReadOnly = false;
            this.textBoxMaGG.Size = new System.Drawing.Size(273, 34);
            this.textBoxMaGG.TabIndex = 9;
            this.textBoxMaGG.textboxRadius = 12;
            this.textBoxMaGG.UseSystemPasswordChar = false;
            // 
            // textBoxGia
            // 
            this.textBoxGia.BackColor = System.Drawing.Color.Transparent;
            this.textBoxGia.BorderColor = System.Drawing.Color.Gray;
            this.textBoxGia.BorderSize = 1;
            this.textBoxGia.Br = System.Drawing.Color.White;
            this.textBoxGia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxGia.ForeColor = System.Drawing.Color.Black;
            this.textBoxGia.Location = new System.Drawing.Point(144, 238);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.PasswordChar = '\0';
            this.textBoxGia.ReadOnly = true;
            this.textBoxGia.Size = new System.Drawing.Size(163, 34);
            this.textBoxGia.TabIndex = 8;
            this.textBoxGia.textboxRadius = 12;
            this.textBoxGia.UseSystemPasswordChar = false;
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTenHang.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTenHang.BorderSize = 1;
            this.textBoxTenHang.Br = System.Drawing.Color.White;
            this.textBoxTenHang.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxTenHang.ForeColor = System.Drawing.Color.Black;
            this.textBoxTenHang.Location = new System.Drawing.Point(141, 139);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.PasswordChar = '\0';
            this.textBoxTenHang.ReadOnly = false;
            this.textBoxTenHang.Size = new System.Drawing.Size(163, 34);
            this.textBoxTenHang.TabIndex = 7;
            this.textBoxTenHang.textboxRadius = 12;
            this.textBoxTenHang.UseSystemPasswordChar = false;
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaHang.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaHang.BorderSize = 1;
            this.textBoxMaHang.Br = System.Drawing.Color.White;
            this.textBoxMaHang.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxMaHang.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaHang.Location = new System.Drawing.Point(141, 79);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.PasswordChar = '\0';
            this.textBoxMaHang.ReadOnly = false;
            this.textBoxMaHang.Size = new System.Drawing.Size(163, 34);
            this.textBoxMaHang.TabIndex = 6;
            this.textBoxMaHang.textboxRadius = 12;
            this.textBoxMaHang.UseSystemPasswordChar = false;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonThem.BoderRadius = 40;
            this.buttonThem.BoderSize = 0;
            this.buttonThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(85, 447);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.ReadOnly = false;
            this.buttonThem.Size = new System.Drawing.Size(264, 40);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm vào giỏ";
            this.buttonThem.TextColor = System.Drawing.Color.White;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // KHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 647);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxMuaHang);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "KHForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.KHForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.groupBoxMuaHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBoxGioHang;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelKH;
        public customButton buttonThoat;
        public customButton buttonDangXuat;
        private System.Windows.Forms.DataGridView dataGridViewMatHang;
        public System.Windows.Forms.Label labelKhuyenMai;
        private System.Windows.Forms.Panel panel2;
        public customButton buttonChonGH;
        public customButton buttonXacNhan;
        private System.Windows.Forms.Label label8;
        private textBoxCustom textBoxMaGG;
        public textBoxCustom textBoxGia;
        public textBoxCustom textBoxTenHang;
        public textBoxCustom textBoxMaHang;
        public customButton buttonThem;
        public System.Windows.Forms.PictureBox pictureBoxHinh;
        public System.Windows.Forms.NumericUpDown numericSoLuong;
        public System.Windows.Forms.Label labelGioHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBoxMuaHang;
    }
}