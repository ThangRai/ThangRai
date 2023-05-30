
namespace quản_lý_bán_hàng
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerXemGio = new System.Windows.Forms.DateTimePicker();
            this.buttonThoat = new quản_lý_bán_hàng.customButton();
            this.buttonDangXuat = new quản_lý_bán_hàng.customButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mặtHàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mặtHàngToolStripMenuItem
            // 
            this.mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
            this.mặtHàngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.mặtHàngToolStripMenuItem.Text = "Mặt hàng";
            this.mặtHàngToolStripMenuItem.Click += new System.EventHandler(this.mặtHàngToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dateTimePickerXemGio);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonDangXuat);
            this.panel1.Location = new System.Drawing.Point(2, 783);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 71);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerXemGio
            // 
            this.dateTimePickerXemGio.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerXemGio.Enabled = false;
            this.dateTimePickerXemGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerXemGio.Location = new System.Drawing.Point(28, 36);
            this.dateTimePickerXemGio.Name = "dateTimePickerXemGio";
            this.dateTimePickerXemGio.Size = new System.Drawing.Size(184, 22);
            this.dateTimePickerXemGio.TabIndex = 4;
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
            this.buttonThoat.Location = new System.Drawing.Point(1318, 18);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(150, 40);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextColor = System.Drawing.Color.White;
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click_1);
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
            this.buttonDangXuat.Location = new System.Drawing.Point(1142, 18);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(150, 40);
            this.buttonDangXuat.TabIndex = 2;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.TextColor = System.Drawing.Color.White;
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Location = new System.Drawing.Point(2, 31);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1475, 750);
            this.panelMenu.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        public customButton buttonThoat;
        public customButton buttonDangXuat;
        public System.Windows.Forms.DateTimePicker dateTimePickerXemGio;
    }
}