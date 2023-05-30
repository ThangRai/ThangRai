using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public class customButton : Button
    {
        private int boderSize = 0;
        private int boderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;
        private bool readOnly=false;


        //properties
        [Category("Custom Button NT")]
        public int BoderSize
        { 
            get
            {
                return boderSize;
            }
            set
            {
                boderSize = value;
                this.Invalidate();
                //invalidate dùng để yêu cầu control vẽ lại (redraw)
                //invalidate(Rectangle) cũng yêu cầu control vẽ lại nhưng chỉ một vùng nào đó chỉ định
            }
        }
        [Category("Custom Button NT")]
        public int BoderRadius
        {
            get
            {
                return boderRadius;
            }

            set
            {
                if (value <= this.Height)
                    boderRadius = value;
                else boderRadius = this.Height;
                this.Invalidate();
            }
        }
        [Category("Custom Button NT")]
        public Color BorderColor { 
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Button NT")]
        public bool ReadOnly
        {
            get
            {
                return readOnly;
            }
            set
            {
                readOnly = value;
                this.Invalidate();
            }
        }
        [Category("Custom Button NT")]
        public Color BackgroundColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
              
            }
        }
        [Category("Custom Button NT")]
        public Color TextColor
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;

            }
        }

        //Constructor
        public customButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; 
            this.Size = new Size(150, 40);
            //màu backgroud
            this.BackColor = Color.FromArgb(255, 26, 26);
            //màu chữ
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        

        //method
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBoder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (boderRadius > 2) //làm tròn button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, boderRadius))
                using (GraphicsPath pathBoder = GetFigurePath(rectBoder, boderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBoder = new Pen(borderColor, boderSize))
                {
                    penBoder.Alignment = PenAlignment.Inset;
                    //button surface
                    this.Region = new Region(pathSurface);
                    //vẽ đường viền ở bề mặt HD
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //button boder
                    //draw control boder 
                    if (boderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBoder, pathBoder);
                    }
                }

            }
            else
            {
                //button surface
                this.Region = new Region(rectSurface);
                if (boderSize >= 1)
                {
                    using (Pen penBoder = new Pen(borderColor, boderSize))
                    {
                        penBoder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBoder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (boderRadius > this.Height)
                boderRadius = this.Height;
        }
    }
}
