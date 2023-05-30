
namespace quản_lý_bán_hàng
{
    partial class ThanhToanForm
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
            this.dataGridViewTT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.buttonThanhToan = new quản_lý_bán_hàng.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTT
            // 
            this.dataGridViewTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTT.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTT.Location = new System.Drawing.Point(3, 109);
            this.dataGridViewTT.Name = "dataGridViewTT";
            this.dataGridViewTT.RowHeadersWidth = 51;
            this.dataGridViewTT.RowTemplate.Height = 24;
            this.dataGridViewTT.Size = new System.Drawing.Size(496, 400);
            this.dataGridViewTT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelTenKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelMaKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 103);
            this.panel1.TabIndex = 2;
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKH.Location = new System.Drawing.Point(122, 70);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(165, 24);
            this.labelTenKH.TabIndex = 0;
            this.labelTenKH.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn ";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKH.Location = new System.Drawing.Point(122, 41);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(157, 24);
            this.labelMaKH.TabIndex = 0;
            this.labelMaKH.Text = "Mã khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelTongTien);
            this.panel2.Controls.Add(this.buttonThanhToan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 104);
            this.panel2.TabIndex = 3;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(97, 12);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(140, 31);
            this.labelTongTien.TabIndex = 2;
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
            this.buttonThanhToan.Location = new System.Drawing.Point(64, 52);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.ReadOnly = false;
            this.buttonThanhToan.Size = new System.Drawing.Size(379, 36);
            this.buttonThanhToan.TabIndex = 0;
            this.buttonThanhToan.Text = "Xác nhận hóa đơn";
            this.buttonThanhToan.TextColor = System.Drawing.Color.White;
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTT);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "ThanhToanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.ThanhToanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTT;
        public System.Windows.Forms.Label labelTenKH;
        public System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Panel panel2;
        public customButton buttonThanhToan;
        public System.Windows.Forms.Label labelTongTien;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
    }
}