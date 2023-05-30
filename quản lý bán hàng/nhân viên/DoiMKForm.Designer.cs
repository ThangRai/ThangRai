
namespace quản_lý_bán_hàng
{
    partial class DoiMKForm
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
            this.labelTenKh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRePass = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxUser = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxPass = new quản_lý_bán_hàng.textBoxCustom();
            this.buttonXacNhan = new quản_lý_bán_hàng.customButton();
            this.SuspendLayout();
            // 
            // labelTenKh
            // 
            this.labelTenKh.AutoSize = true;
            this.labelTenKh.Location = new System.Drawing.Point(100, 21);
            this.labelTenKh.Name = "labelTenKh";
            this.labelTenKh.Size = new System.Drawing.Size(140, 16);
            this.labelTenKh.TabIndex = 3;
            this.labelTenKh.Text = "Thông tin đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "New password";
            // 
            // textBoxRePass
            // 
            this.textBoxRePass.BackColor = System.Drawing.Color.Transparent;
            this.textBoxRePass.BorderColor = System.Drawing.Color.Gray;
            this.textBoxRePass.BorderSize = 1;
            this.textBoxRePass.Br = System.Drawing.Color.White;
            this.textBoxRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxRePass.ForeColor = System.Drawing.Color.Black;
            this.textBoxRePass.Location = new System.Drawing.Point(139, 186);
            this.textBoxRePass.Name = "textBoxRePass";
            this.textBoxRePass.PasswordChar = '\0';
            this.textBoxRePass.Size = new System.Drawing.Size(194, 30);
            this.textBoxRePass.TabIndex = 2;
            this.textBoxRePass.textboxRadius = 12;
            this.textBoxRePass.UseSystemPasswordChar = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUser.BorderColor = System.Drawing.Color.Gray;
            this.textBoxUser.BorderSize = 1;
            this.textBoxUser.Br = System.Drawing.Color.White;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(139, 57);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.Size = new System.Drawing.Size(194, 30);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.textboxRadius = 12;
            this.textBoxUser.UseSystemPasswordChar = false;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPass.BorderColor = System.Drawing.Color.Gray;
            this.textBoxPass.BorderSize = 1;
            this.textBoxPass.Br = System.Drawing.Color.White;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(139, 119);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '\0';
            this.textBoxPass.Size = new System.Drawing.Size(194, 30);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.textboxRadius = 12;
            this.textBoxPass.UseSystemPasswordChar = false;
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
            this.buttonXacNhan.Location = new System.Drawing.Point(28, 248);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(305, 40);
            this.buttonXacNhan.TabIndex = 0;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.TextColor = System.Drawing.Color.White;
            this.buttonXacNhan.UseVisualStyleBackColor = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // DoiMKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(345, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTenKh);
            this.Controls.Add(this.textBoxRePass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.buttonXacNhan);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "DoiMKForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.DoiMKForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public customButton buttonXacNhan;
        public textBoxCustom textBoxPass;
        public textBoxCustom textBoxUser;
        public textBoxCustom textBoxRePass;
        public System.Windows.Forms.Label labelTenKh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}