
namespace quản_lý_bán_hàng
{
    partial class KiGuiForm
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
            this.dataGridViewKiGui = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMoKiGui = new quản_lý_bán_hàng.customButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiGui)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKiGui
            // 
            this.dataGridViewKiGui.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKiGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiGui.Location = new System.Drawing.Point(0, 59);
            this.dataGridViewKiGui.Name = "dataGridViewKiGui";
            this.dataGridViewKiGui.RowHeadersWidth = 51;
            this.dataGridViewKiGui.RowTemplate.Height = 24;
            this.dataGridViewKiGui.Size = new System.Drawing.Size(799, 306);
            this.dataGridViewKiGui.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonMoKiGui);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 84);
            this.panel1.TabIndex = 1;
            // 
            // buttonMoKiGui
            // 
            this.buttonMoKiGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMoKiGui.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMoKiGui.BoderRadius = 40;
            this.buttonMoKiGui.BoderSize = 0;
            this.buttonMoKiGui.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonMoKiGui.FlatAppearance.BorderSize = 0;
            this.buttonMoKiGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoKiGui.ForeColor = System.Drawing.Color.White;
            this.buttonMoKiGui.Location = new System.Drawing.Point(324, 21);
            this.buttonMoKiGui.Name = "buttonMoKiGui";
            this.buttonMoKiGui.Size = new System.Drawing.Size(150, 40);
            this.buttonMoKiGui.TabIndex = 0;
            this.buttonMoKiGui.Text = "Mở kí gửi";
            this.buttonMoKiGui.TextColor = System.Drawing.Color.White;
            this.buttonMoKiGui.UseVisualStyleBackColor = false;
            this.buttonMoKiGui.Click += new System.EventHandler(this.buttonMoKiGui_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn kí gửi";
            // 
            // KiGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewKiGui);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.MaximizeBox = false;
            this.Name = "KiGuiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kí gửi";
            this.Load += new System.EventHandler(this.KiGuiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiGui)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKiGui;
        private System.Windows.Forms.Panel panel1;
        public customButton buttonMoKiGui;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}