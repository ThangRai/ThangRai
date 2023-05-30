
namespace quản_lý_bán_hàng
{
    partial class GioHangForm
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
            this.dataGridViewGH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxMSKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.buttonThanhToan = new quản_lý_bán_hàng.customButton();
            this.buttonXoaHang = new quản_lý_bán_hàng.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGH
            // 
            this.dataGridViewGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGH.Location = new System.Drawing.Point(-534, 101);
            this.dataGridViewGH.Name = "dataGridViewGH";
            this.dataGridViewGH.RowHeadersWidth = 51;
            this.dataGridViewGH.RowTemplate.Height = 24;
            this.dataGridViewGH.Size = new System.Drawing.Size(1095, 259);
            this.dataGridViewGH.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textBoxTenKH);
            this.panel1.Controls.Add(this.textBoxMSKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 100);
            this.panel1.TabIndex = 1;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(297, 58);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.ReadOnly = true;
            this.textBoxTenKH.Size = new System.Drawing.Size(207, 22);
            this.textBoxTenKH.TabIndex = 1;
            // 
            // textBoxMSKH
            // 
            this.textBoxMSKH.Location = new System.Drawing.Point(297, 18);
            this.textBoxMSKH.Name = "textBoxMSKH";
            this.textBoxMSKH.ReadOnly = true;
            this.textBoxMSKH.Size = new System.Drawing.Size(60, 22);
            this.textBoxMSKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số khách hàng:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelTongTien);
            this.panel2.Controls.Add(this.buttonThanhToan);
            this.panel2.Controls.Add(this.buttonXoaHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 117);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(154, 18);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(101, 26);
            this.labelTongTien.TabIndex = 1;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonThanhToan.BoderRadius = 20;
            this.buttonThanhToan.BoderSize = 0;
            this.buttonThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonThanhToan.FlatAppearance.BorderSize = 0;
            this.buttonThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThanhToan.ForeColor = System.Drawing.Color.White;
            this.buttonThanhToan.Location = new System.Drawing.Point(302, 64);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.ReadOnly = false;
            this.buttonThanhToan.Size = new System.Drawing.Size(202, 32);
            this.buttonThanhToan.TabIndex = 0;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.TextColor = System.Drawing.Color.White;
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // buttonXoaHang
            // 
            this.buttonXoaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoaHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoaHang.BoderRadius = 20;
            this.buttonXoaHang.BoderSize = 0;
            this.buttonXoaHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXoaHang.FlatAppearance.BorderSize = 0;
            this.buttonXoaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaHang.ForeColor = System.Drawing.Color.White;
            this.buttonXoaHang.Location = new System.Drawing.Point(27, 64);
            this.buttonXoaHang.Name = "buttonXoaHang";
            this.buttonXoaHang.ReadOnly = false;
            this.buttonXoaHang.Size = new System.Drawing.Size(202, 32);
            this.buttonXoaHang.TabIndex = 0;
            this.buttonXoaHang.Text = "Xóa hàng";
            this.buttonXoaHang.TextColor = System.Drawing.Color.White;
            this.buttonXoaHang.UseVisualStyleBackColor = false;
            this.buttonXoaHang.Click += new System.EventHandler(this.buttonXoaHang_Click);
            // 
            // GioHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewGH);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "GioHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.GioHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public customButton buttonXoaHang;
        public customButton buttonThanhToan;
        public System.Windows.Forms.Label labelTongTien;
        public System.Windows.Forms.TextBox textBoxTenKH;
        public System.Windows.Forms.TextBox textBoxMSKH;
    }
}