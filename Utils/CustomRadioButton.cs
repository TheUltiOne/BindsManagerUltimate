using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BindsManagerUltimate.Utils
{
    public class CustomRadioButton : CheckBox
    {
        protected override void OnPaint(PaintEventArgs ev)
        {
            ev.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectBorder = new RectangleF()
            {
                X = 0.3f,
                Y = (Height-12)/2,
                Height = 12,
                Width = 12
            };

            RectangleF rectFill = new RectangleF()
            {
                X = rectBorder.X + (rectBorder.Width - 6)/2,
                Y = (Height - 6)/2,
                Width = 6,
                Height = 6,
            };

            using (Pen pen = new Pen(Color.Gray, 1.6f))
            using (SolidBrush brush = new SolidBrush(Color.Gray))
            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                ev.Graphics.Clear(BackColor);
                ev.Graphics.DrawRectangles(pen, new RectangleF[] {rectBorder});

                if (Checked) {
                    ev.Graphics.DrawRectangles(pen, new RectangleF[] {rectFill});
                    ev.Graphics.FillRectangle(brush, rectFill);
                }
                
                ev.Graphics.DrawString(Text, Font, textBrush, 15,
                    (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
            }
        }
    }
}