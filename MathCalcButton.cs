using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalc
{
    class MathCalcButton : Button
    {
        #region variables

        private Color CurrentBackColor;

        private Color onHoverBackColor = Color.FromArgb(30,84,161);


        #endregion


   
        public Color OnHoverBackColor
        {
            get { return onHoverBackColor; }
            set { onHoverBackColor = value; Invalidate(); }
        }


        public MathCalcButton()
        {
            
            ForeColor = Color.White;
            CurrentBackColor = Color.FromArgb(30, 50, 94);      
        }

        #region

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            CurrentBackColor = onHoverBackColor;
            Cursor = Cursors.Hand;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CurrentBackColor = Color.FromArgb(30,50,94);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            CurrentBackColor = Color.FromArgb(30, 99, 183);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            CurrentBackColor = Color.FromArgb(30, 84, 161);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }

        #endregion
    }
}
