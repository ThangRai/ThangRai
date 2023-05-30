
namespace quản_lý_bán_hàng
{
    partial class QuanLyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonQuanLyNV = new quản_lý_bán_hàng.customButton();
            this.buttonXoaNV = new quản_lý_bán_hàng.customButton();
            this.ButtonThemNV = new quản_lý_bán_hàng.customButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChamCong = new quản_lý_bán_hàng.customButton();
            this.customButton4 = new quản_lý_bán_hàng.customButton();
            this.customButton3 = new quản_lý_bán_hàng.customButton();
            this.customButton2 = new quản_lý_bán_hàng.customButton();
            this.customButton1 = new quản_lý_bán_hàng.customButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 77);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bạn đang đăng nhập dưới quyền admin";
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(352, 77);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.RowHeadersWidth = 51;
            this.dataGridViewDoanhThu.RowTemplate.Height = 24;
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(587, 389);
            this.dataGridViewDoanhThu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doanh thu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buttonQuanLyNV);
            this.panel2.Controls.Add(this.buttonXoaNV);
            this.panel2.Controls.Add(this.ButtonThemNV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 114);
            this.panel2.TabIndex = 4;
            // 
            // buttonQuanLyNV
            // 
            this.buttonQuanLyNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonQuanLyNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonQuanLyNV.BoderRadius = 40;
            this.buttonQuanLyNV.BoderSize = 0;
            this.buttonQuanLyNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonQuanLyNV.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyNV.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyNV.Location = new System.Drawing.Point(529, 61);
            this.buttonQuanLyNV.Name = "buttonQuanLyNV";
            this.buttonQuanLyNV.Size = new System.Drawing.Size(352, 40);
            this.buttonQuanLyNV.TabIndex = 11;
            this.buttonQuanLyNV.Text = "Quản lý nhân viên";
            this.buttonQuanLyNV.TextColor = System.Drawing.Color.White;
            this.buttonQuanLyNV.UseVisualStyleBackColor = false;
            this.buttonQuanLyNV.Click += new System.EventHandler(this.buttonQuanLyNV_Click);
            // 
            // buttonXoaNV
            // 
            this.buttonXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoaNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoaNV.BoderRadius = 40;
            this.buttonXoaNV.BoderSize = 0;
            this.buttonXoaNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXoaNV.FlatAppearance.BorderSize = 0;
            this.buttonXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaNV.ForeColor = System.Drawing.Color.White;
            this.buttonXoaNV.Location = new System.Drawing.Point(265, 61);
            this.buttonXoaNV.Name = "buttonXoaNV";
            this.buttonXoaNV.Size = new System.Drawing.Size(212, 40);
            this.buttonXoaNV.TabIndex = 11;
            this.buttonXoaNV.Text = "Xóa nhân viên";
            this.buttonXoaNV.TextColor = System.Drawing.Color.White;
            this.buttonXoaNV.UseVisualStyleBackColor = false;
            this.buttonXoaNV.Click += new System.EventHandler(this.buttonXoaNV_Click);
            // 
            // ButtonThemNV
            // 
            this.ButtonThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ButtonThemNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ButtonThemNV.BoderRadius = 40;
            this.ButtonThemNV.BoderSize = 0;
            this.ButtonThemNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonThemNV.FlatAppearance.BorderSize = 0;
            this.ButtonThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThemNV.ForeColor = System.Drawing.Color.White;
            this.ButtonThemNV.Location = new System.Drawing.Point(16, 61);
            this.ButtonThemNV.Name = "ButtonThemNV";
            this.ButtonThemNV.Size = new System.Drawing.Size(212, 40);
            this.ButtonThemNV.TabIndex = 11;
            this.ButtonThemNV.Text = "Thêm nhân viên";
            this.ButtonThemNV.TextColor = System.Drawing.Color.White;
            this.ButtonThemNV.UseVisualStyleBackColor = false;
            this.ButtonThemNV.Click += new System.EventHandler(this.ButtonThemNV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý cửa hàng";
            // 
            // buttonChamCong
            // 
            this.buttonChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonChamCong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonChamCong.BoderRadius = 40;
            this.buttonChamCong.BoderSize = 0;
            this.buttonChamCong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonChamCong.FlatAppearance.BorderSize = 0;
            this.buttonChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChamCong.ForeColor = System.Drawing.Color.White;
            this.buttonChamCong.Location = new System.Drawing.Point(12, 360);
            this.buttonChamCong.Name = "buttonChamCong";
            this.buttonChamCong.Size = new System.Drawing.Size(324, 40);
            this.buttonChamCong.TabIndex = 10;
            this.buttonChamCong.Text = "Chấm công";
            this.buttonChamCong.TextColor = System.Drawing.Color.White;
            this.buttonChamCong.UseVisualStyleBackColor = false;
            this.buttonChamCong.Click += new System.EventHandler(this.buttonChamCong_Click);
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton4.BoderRadius = 40;
            this.customButton4.BoderSize = 0;
            this.customButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(12, 304);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(324, 40);
            this.customButton4.TabIndex = 9;
            this.customButton4.Text = "Thống kê doanh thu";
            this.customButton4.TextColor = System.Drawing.Color.White;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton3.BoderRadius = 40;
            this.customButton3.BoderSize = 0;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(12, 244);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(324, 40);
            this.customButton3.TabIndex = 8;
            this.customButton3.Text = "Thống kê mua sắm";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton2.BoderRadius = 40;
            this.customButton2.BoderSize = 0;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(12, 189);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(324, 40);
            this.customButton2.TabIndex = 7;
            this.customButton2.Text = "Mã giảm giá";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.customButton1.BoderRadius = 40;
            this.customButton1.BoderSize = 0;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(12, 132);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(324, 40);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Kho hàng";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(940, 581);
            this.Controls.Add(this.buttonChamCong);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "QuanLyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.QuanLyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private customButton customButton1;
        private customButton customButton2;
        private customButton customButton3;
        private customButton customButton4;
        private System.Windows.Forms.Label label4;
        public customButton buttonChamCong;
        public customButton buttonXoaNV;
        public customButton ButtonThemNV;
        public customButton buttonQuanLyNV;
    }
}