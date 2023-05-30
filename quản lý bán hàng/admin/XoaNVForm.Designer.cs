
namespace quản_lý_bán_hàng
{
    partial class XoaNVForm
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
            this.buttonXoaNV = new quản_lý_bán_hàng.customButton();
            this.textBoxXoaNV = new quản_lý_bán_hàng.textBoxCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonXoaNV.Location = new System.Drawing.Point(302, 32);
            this.buttonXoaNV.Name = "buttonXoaNV";
            this.buttonXoaNV.Size = new System.Drawing.Size(187, 45);
            this.buttonXoaNV.TabIndex = 0;
            this.buttonXoaNV.Text = "Xóa nhân viên";
            this.buttonXoaNV.TextColor = System.Drawing.Color.White;
            this.buttonXoaNV.UseVisualStyleBackColor = false;
            this.buttonXoaNV.Click += new System.EventHandler(this.buttonXoaNV_Click);
            // 
            // textBoxXoaNV
            // 
            this.textBoxXoaNV.BackColor = System.Drawing.Color.Transparent;
            this.textBoxXoaNV.BorderColor = System.Drawing.Color.Gray;
            this.textBoxXoaNV.BorderSize = 1;
            this.textBoxXoaNV.Br = System.Drawing.Color.White;
            this.textBoxXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxXoaNV.ForeColor = System.Drawing.Color.Black;
            this.textBoxXoaNV.Location = new System.Drawing.Point(50, 41);
            this.textBoxXoaNV.Name = "textBoxXoaNV";
            this.textBoxXoaNV.PasswordChar = '\0';
            this.textBoxXoaNV.Size = new System.Drawing.Size(235, 30);
            this.textBoxXoaNV.TabIndex = 1;
            this.textBoxXoaNV.textboxRadius = 15;
            this.textBoxXoaNV.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // XoaNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(506, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxXoaNV);
            this.Controls.Add(this.buttonXoaNV);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "XoaNVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xóa nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public customButton buttonXoaNV;
        public textBoxCustom textBoxXoaNV;
        private System.Windows.Forms.Label label1;
    }
}