using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_1204017
{
    public partial class VerticalLabel : Control
    {
        public VerticalLabel()
        {
            InitializeComponent();
        }

        private string labelText;
        [Category("VerticalLabel"), Description("Text is displayed in container")]

        public override string Text
        {
            get { return labelText; }
            set
            {
                labelText = value;
                Invalidate();
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float sngControlWidth, sngControlHeight, sngTransformX, sngTransformY;

            Color labelColor = new Color();
            Pen labelBorderPen = new Pen(labelColor, 0);
            SolidBrush labelBackColorBrush = new SolidBrush(labelColor);
            SolidBrush labelForeColorBrush = new SolidBrush(base.ForeColor);

            if (this.DesignMode)
            {
                base.ResizeRedraw = true;
            }

            base.OnPaint(e);

            sngControlWidth = this.Size.Width;
            sngControlHeight = this.Size.Height;

            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, sngControlWidth, sngControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, sngControlWidth, sngControlHeight);

            sngTransformX = 0;
            sngTransformY = sngControlHeight;

            e.Graphics.TranslateTransform(sngTransformX, sngTransformY);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(labelText, Font, labelForeColorBrush, 0, 0);
        }
    }
}