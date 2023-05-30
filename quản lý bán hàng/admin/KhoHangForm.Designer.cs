
namespace quản_lý_bán_hàng
{
    partial class KhoHangForm
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
            this.buttonTimKiem = new quản_lý_bán_hàng.customButton();
            this.textBoxTimKiem = new quản_lý_bán_hàng.textBoxCustom();
            this.radioButtonTenMH = new System.Windows.Forms.RadioButton();
            this.radioButtonMaMH = new System.Windows.Forms.RadioButton();
            this.dataGridViewKhoHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonXuatDS = new quản_lý_bán_hàng.customButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonTimKiem);
            this.panel1.Controls.Add(this.textBoxTimKiem);
            this.panel1.Controls.Add(this.radioButtonTenMH);
            this.panel1.Controls.Add(this.radioButtonMaMH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonTimKiem.BoderRadius = 40;
            this.buttonTimKiem.BoderSize = 0;
            this.buttonTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonTimKiem.FlatAppearance.BorderSize = 0;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Location = new System.Drawing.Point(636, 30);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.ReadOnly = false;
            this.buttonTimKiem.Size = new System.Drawing.Size(150, 40);
            this.buttonTimKiem.TabIndex = 4;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextColor = System.Drawing.Color.White;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTimKiem.BorderSize = 1;
            this.textBoxTimKiem.Br = System.Drawing.Color.White;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimKiem.Location = new System.Drawing.Point(377, 40);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.PasswordChar = '\0';
            this.textBoxTimKiem.ReadOnly = false;
            this.textBoxTimKiem.Size = new System.Drawing.Size(241, 30);
            this.textBoxTimKiem.TabIndex = 3;
            this.textBoxTimKiem.textboxRadius = 15;
            this.textBoxTimKiem.UseSystemPasswordChar = false;
            this.textBoxTimKiem.Click += new System.EventHandler(this.textBoxTimKiem_Click);
            // 
            // radioButtonTenMH
            // 
            this.radioButtonTenMH.AutoSize = true;
            this.radioButtonTenMH.Location = new System.Drawing.Point(501, 12);
            this.radioButtonTenMH.Name = "radioButtonTenMH";
            this.radioButtonTenMH.Size = new System.Drawing.Size(133, 23);
            this.radioButtonTenMH.TabIndex = 2;
            this.radioButtonTenMH.TabStop = true;
            this.radioButtonTenMH.Text = "Tên mặt hàng";
            this.radioButtonTenMH.UseVisualStyleBackColor = true;
            this.radioButtonTenMH.CheckedChanged += new System.EventHandler(this.radioButtonTenMH_CheckedChanged);
            // 
            // radioButtonMaMH
            // 
            this.radioButtonMaMH.AutoSize = true;
            this.radioButtonMaMH.Location = new System.Drawing.Point(377, 12);
            this.radioButtonMaMH.Name = "radioButtonMaMH";
            this.radioButtonMaMH.Size = new System.Drawing.Size(128, 23);
            this.radioButtonMaMH.TabIndex = 1;
            this.radioButtonMaMH.TabStop = true;
            this.radioButtonMaMH.Text = "Mã mặt hàng";
            this.radioButtonMaMH.UseVisualStyleBackColor = true;
            this.radioButtonMaMH.CheckedChanged += new System.EventHandler(this.radioButtonMaMH_CheckedChanged);
            // 
            // dataGridViewKhoHang
            // 
            this.dataGridViewKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoHang.Location = new System.Drawing.Point(1, 100);
            this.dataGridViewKhoHang.Name = "dataGridViewKhoHang";
            this.dataGridViewKhoHang.RowHeadersWidth = 51;
            this.dataGridViewKhoHang.RowTemplate.Height = 50;
            this.dataGridViewKhoHang.Size = new System.Drawing.Size(1052, 444);
            this.dataGridViewKhoHang.TabIndex = 2;
            this.dataGridViewKhoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhoHang_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buttonXuatDS);
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 60);
            this.panel2.TabIndex = 3;
            // 
            // buttonXuatDS
            // 
            this.buttonXuatDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXuatDS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXuatDS.BoderRadius = 40;
            this.buttonXuatDS.BoderSize = 0;
            this.buttonXuatDS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXuatDS.FlatAppearance.BorderSize = 0;
            this.buttonXuatDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatDS.ForeColor = System.Drawing.Color.White;
            this.buttonXuatDS.Location = new System.Drawing.Point(12, 10);
            this.buttonXuatDS.Name = "buttonXuatDS";
            this.buttonXuatDS.ReadOnly = false;
            this.buttonXuatDS.Size = new System.Drawing.Size(150, 40);
            this.buttonXuatDS.TabIndex = 5;
            this.buttonXuatDS.Text = "Xuất danh sách";
            this.buttonXuatDS.TextColor = System.Drawing.Color.White;
            this.buttonXuatDS.UseVisualStyleBackColor = false;
            this.buttonXuatDS.Click += new System.EventHandler(this.buttonXuatDS_Click);
            // 
            // KhoHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewKhoHang);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "KhoHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.KhoHangForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewKhoHang;
        public customButton buttonTimKiem;
        public textBoxCustom textBoxTimKiem;
        public System.Windows.Forms.RadioButton radioButtonTenMH;
        public System.Windows.Forms.RadioButton radioButtonMaMH;
        private System.Windows.Forms.Panel panel2;
        private customButton buttonXuatDS;
    }
}