
namespace quản_lý_bán_hàng
{
    partial class QuanLyMaGiamGiaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoa = new quản_lý_bán_hàng.customButton();
            this.buttonThem = new quản_lý_bán_hàng.customButton();
            this.textBoxMaGG = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxTenMH = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxMaMH = new quản_lý_bán_hàng.textBoxCustom();
            this.dataGridViewMaGG = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaGG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.textBoxMaGG);
            this.groupBox1.Controls.Add(this.textBoxTenMH);
            this.groupBox1.Controls.Add(this.textBoxMaMH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(497, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý mã giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã mặt hàng";
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonXoa.BoderRadius = 40;
            this.buttonXoa.BoderSize = 0;
            this.buttonXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(24, 292);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.ReadOnly = false;
            this.buttonXoa.Size = new System.Drawing.Size(278, 40);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa mã giảm giá";
            this.buttonXoa.TextColor = System.Drawing.Color.White;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
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
            this.buttonThem.Location = new System.Drawing.Point(25, 231);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.ReadOnly = false;
            this.buttonThem.Size = new System.Drawing.Size(278, 40);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm mã giảm giá";
            this.buttonThem.TextColor = System.Drawing.Color.White;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // textBoxMaGG
            // 
            this.textBoxMaGG.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaGG.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaGG.BorderSize = 1;
            this.textBoxMaGG.Br = System.Drawing.Color.White;
            this.textBoxMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaGG.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaGG.Location = new System.Drawing.Point(124, 163);
            this.textBoxMaGG.Name = "textBoxMaGG";
            this.textBoxMaGG.PasswordChar = '\0';
            this.textBoxMaGG.ReadOnly = false;
            this.textBoxMaGG.Size = new System.Drawing.Size(169, 30);
            this.textBoxMaGG.TabIndex = 2;
            this.textBoxMaGG.textboxRadius = 15;
            this.textBoxMaGG.UseSystemPasswordChar = false;
            // 
            // textBoxTenMH
            // 
            this.textBoxTenMH.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTenMH.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTenMH.BorderSize = 1;
            this.textBoxTenMH.Br = System.Drawing.Color.White;
            this.textBoxTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTenMH.ForeColor = System.Drawing.Color.Black;
            this.textBoxTenMH.Location = new System.Drawing.Point(123, 101);
            this.textBoxTenMH.Name = "textBoxTenMH";
            this.textBoxTenMH.PasswordChar = '\0';
            this.textBoxTenMH.ReadOnly = false;
            this.textBoxTenMH.Size = new System.Drawing.Size(168, 30);
            this.textBoxTenMH.TabIndex = 1;
            this.textBoxTenMH.textboxRadius = 15;
            this.textBoxTenMH.UseSystemPasswordChar = false;
            // 
            // textBoxMaMH
            // 
            this.textBoxMaMH.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaMH.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaMH.BorderSize = 1;
            this.textBoxMaMH.Br = System.Drawing.Color.White;
            this.textBoxMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaMH.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaMH.Location = new System.Drawing.Point(124, 39);
            this.textBoxMaMH.Name = "textBoxMaMH";
            this.textBoxMaMH.PasswordChar = '\0';
            this.textBoxMaMH.ReadOnly = false;
            this.textBoxMaMH.Size = new System.Drawing.Size(167, 30);
            this.textBoxMaMH.TabIndex = 0;
            this.textBoxMaMH.textboxRadius = 15;
            this.textBoxMaMH.UseSystemPasswordChar = false;
            // 
            // dataGridViewMaGG
            // 
            this.dataGridViewMaGG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaGG.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaGG.Name = "dataGridViewMaGG";
            this.dataGridViewMaGG.RowHeadersWidth = 51;
            this.dataGridViewMaGG.RowTemplate.Height = 24;
            this.dataGridViewMaGG.Size = new System.Drawing.Size(498, 342);
            this.dataGridViewMaGG.TabIndex = 1;
            this.dataGridViewMaGG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaGG_CellClick);
            // 
            // QuanLyMaGiamGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 343);
            this.Controls.Add(this.dataGridViewMaGG);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "QuanLyMaGiamGiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mã giảm giá";
            this.Load += new System.EventHandler(this.QuanLyMaGiamGiaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaGG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMaGG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public customButton buttonXoa;
        public customButton buttonThem;
        public textBoxCustom textBoxMaGG;
        public textBoxCustom textBoxTenMH;
        public textBoxCustom textBoxMaMH;
    }
}