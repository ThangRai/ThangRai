using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public class textBoxCustom : Control
    {
        private int radius = 12;
        public TextBox textbox = new TextBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color br;
        private Color _borderColor = Color.Gray;
        private bool _Readonly = false;
        private int _borderSize = 1;
        private bool check = false;
        //private char pwdchar;

        public textBoxCustom()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.textbox.Parent = this;
            base.Controls.Add(this.textbox);
            this.textbox.BorderStyle = BorderStyle.None;
            textbox.Font = this.Font;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.br = Color.White;
            textbox.BackColor = this.br;
            textbox.ReadOnly = this.check;
            this.Text = null;
            this.Font = new Font("Century Gothic", 12f);
            base.Size = new Size(135, 33);
            this.DoubleBuffered = true;
            textbox.KeyDown += new KeyEventHandler(textbox_KeyDown);
            textbox.TextChanged += new EventHandler(textbox_TextChanged);
            textbox.MouseDoubleClick += new MouseEventHandler(textbox_MouseDoubleClick);
            textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textbox_KeyPress);
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        private void textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textbox.SelectAll();
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            this.Text = textbox.Text;
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                textbox.SelectionStart = 0;
                textbox.SelectionLength = this.Text.Length;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            textbox.Font = this.Font;
            base.Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textbox.ForeColor = this.ForeColor;
            base.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new CustomTextbox((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new CustomTextbox(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            if (textbox.Height >= (base.Height - 4))
            {
                base.Height = textbox.Height + 4;
            }
            textbox.Location = new Point(this.radius - 5, (base.Height / 2) - (textbox.Font.Height / 2));
            textbox.Width = base.Width - ((int)(this.radius * 1.5));
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            Pen pp = new Pen(_borderColor, _borderSize);
            e.Graphics.DrawPath(pp, this.shape);

            using (SolidBrush brush = new SolidBrush(this.br))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            Trans.MakeTransparent(this, e.Graphics);
            base.OnPaint(e);
        }


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            textbox.Text = this.Text;
        }
        public void SelectAll()
        {
            textbox.SelectAll();
        }
        public char PasswordChar
        {
            get =>
                textbox.PasswordChar;
            set
            {
                textbox.PasswordChar = value;
                base.Invalidate();
            }

        }
        public bool UseSystemPasswordChar
        {
            get =>
                textbox.UseSystemPasswordChar;
            set
            {
                textbox.UseSystemPasswordChar = value;
                base.Invalidate();
            }

        }
        public Color Br
        {
            get =>
                this.br;
            set
            {
                this.br = value;
                if (this.br != Color.Transparent)
                {
                    textbox.BackColor = this.br;
                }
                base.Invalidate();
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
        public Color BorderColor
        {
            get =>
                this._borderColor;
            set { this._borderColor = value; Invalidate(); }
        }
        public int textboxRadius
        {
            get =>
                this.radius;
            set { this.radius = value; Invalidate(); }
        }
        public int BorderSize
        {
            get =>
                this._borderSize;
            set { this._borderSize = value; Invalidate(); }
        }
        public bool ReadOnly
        {
            get => this._Readonly;
            set { this._Readonly = value; Invalidate(); }
        }
    }
}
