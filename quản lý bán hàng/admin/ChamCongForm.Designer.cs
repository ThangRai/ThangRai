
namespace quản_lý_bán_hàng
{
    partial class ChamCongForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTimKiem = new quản_lý_bán_hàng.textBoxCustom();
            this.buttonTimKiem = new quản_lý_bán_hàng.customButton();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.radioButtonMaNV = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonKhong = new System.Windows.Forms.RadioButton();
            this.radioButtonCo = new System.Windows.Forms.RadioButton();
            this.dataGridViewChamCong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFile = new quản_lý_bán_hàng.customButton();
            this.customButton1 = new quản_lý_bán_hàng.customButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 136);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.textBoxTimKiem);
            this.panel3.Controls.Add(this.buttonTimKiem);
            this.panel3.Controls.Add(this.radioButtonTen);
            this.panel3.Controls.Add(this.radioButtonMaNV);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(158, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 108);
            this.panel3.TabIndex = 2;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTimKiem.BorderSize = 1;
            this.textBoxTimKiem.Br = System.Drawing.Color.White;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimKiem.Location = new System.Drawing.Point(55, 61);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.PasswordChar = '\0';
            this.textBoxTimKiem.Size = new System.Drawing.Size(242, 30);
            this.textBoxTimKiem.TabIndex = 3;
            this.textBoxTimKiem.textboxRadius = 15;
            this.textBoxTimKiem.UseSystemPasswordChar = false;
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
            this.buttonTimKiem.Location = new System.Drawing.Point(516, 52);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(150, 40);
            this.buttonTimKiem.TabIndex = 1;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextColor = System.Drawing.Color.White;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Location = new System.Drawing.Point(178, 17);
            this.radioButtonTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(119, 20);
            this.radioButtonTen.TabIndex = 2;
            this.radioButtonTen.TabStop = true;
            this.radioButtonTen.Text = "Tên nhân viên";
            this.radioButtonTen.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaNV
            // 
            this.radioButtonMaNV.AutoSize = true;
            this.radioButtonMaNV.Location = new System.Drawing.Point(46, 17);
            this.radioButtonMaNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonMaNV.Name = "radioButtonMaNV";
            this.radioButtonMaNV.Size = new System.Drawing.Size(114, 20);
            this.radioButtonMaNV.TabIndex = 2;
            this.radioButtonMaNV.TabStop = true;
            this.radioButtonMaNV.Text = "Mã nhân viên";
            this.radioButtonMaNV.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.radioButtonKhong);
            this.panel4.Controls.Add(this.radioButtonCo);
            this.panel4.Location = new System.Drawing.Point(321, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 105);
            this.panel4.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // radioButtonKhong
            // 
            this.radioButtonKhong.AutoSize = true;
            this.radioButtonKhong.Location = new System.Drawing.Point(102, 15);
            this.radioButtonKhong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonKhong.Name = "radioButtonKhong";
            this.radioButtonKhong.Size = new System.Drawing.Size(70, 20);
            this.radioButtonKhong.TabIndex = 2;
            this.radioButtonKhong.TabStop = true;
            this.radioButtonKhong.Text = "Không";
            this.radioButtonKhong.UseVisualStyleBackColor = true;
            // 
            // radioButtonCo
            // 
            this.radioButtonCo.AutoSize = true;
            this.radioButtonCo.Location = new System.Drawing.Point(27, 15);
            this.radioButtonCo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonCo.Name = "radioButtonCo";
            this.radioButtonCo.Size = new System.Drawing.Size(47, 20);
            this.radioButtonCo.TabIndex = 2;
            this.radioButtonCo.TabStop = true;
            this.radioButtonCo.Text = "Có";
            this.radioButtonCo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChamCong
            // 
            this.dataGridViewChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChamCong.Location = new System.Drawing.Point(2, 140);
            this.dataGridViewChamCong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewChamCong.Name = "dataGridViewChamCong";
            this.dataGridViewChamCong.RowHeadersWidth = 51;
            this.dataGridViewChamCong.RowTemplate.Height = 24;
            this.dataGridViewChamCong.Size = new System.Drawing.Size(1090, 376);
            this.dataGridViewChamCong.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonFile);
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 72);
            this.panel2.TabIndex = 2;
            // 
            // buttonFile
            // 
            this.buttonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonFile.BoderRadius = 40;
            this.buttonFile.BoderSize = 0;
            this.buttonFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonFile.FlatAppearance.BorderSize = 0;
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.ForeColor = System.Drawing.Color.White;
            this.buttonFile.Location = new System.Drawing.Point(22, 20);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(150, 40);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "File";
            this.buttonFile.TextColor = System.Drawing.Color.White;
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
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
            this.customButton1.Location = new System.Drawing.Point(202, 20);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Print";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewChamCong);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ChamCongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewChamCong;
        private System.Windows.Forms.Panel panel2;
        public customButton buttonFile;
        public customButton customButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        public textBoxCustom textBoxTimKiem;
        public System.Windows.Forms.RadioButton radioButtonTen;
        public System.Windows.Forms.RadioButton radioButtonMaNV;
        public customButton buttonTimKiem;
        public System.Windows.Forms.RadioButton radioButtonKhong;
        public System.Windows.Forms.RadioButton radioButtonCo;
    }
}