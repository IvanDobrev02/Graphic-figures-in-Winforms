using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_proekt
{
    public class Ellipse : Shape
    {
        public override int Surface
        { 
            get
            {
                return (int)(Math.PI*(3*(Width + Height) - Math.Sqrt((3*Width + Height)*(Width + 3*Height))));
            }
        }
        public override int Area
        { 
            get
            {
                return (int)(Math.PI * Width * Height);
            }
        }
       
        public override void Paint(Graphics graphics)
        {
            var colorBorder = Selected
               ? Color.Red
               : ColorBorder;

            using (var brush = new SolidBrush(ColorFill))
            {
                graphics.FillEllipse(brush, Location.X, Location.Y, Width, Height);
            }
            using (var pen = new Pen(colorBorder))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y, Width, Height);
            }
        }

        public override bool SelectedShape(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Width &&
                Location.Y <= point.Y && point.Y <= Location.Y + Height;
        }
    }
}
