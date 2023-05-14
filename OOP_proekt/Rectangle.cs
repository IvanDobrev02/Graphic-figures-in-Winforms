using System;
using System.Drawing;
using System.Linq;

namespace OOP_proekt
{
    [Serializable]
    public class Rectangle : Shape
    {
        public override int Surface
        {
            get
            {
                return Height * Width;
            }
        }
        protected internal override void Paint(Graphics graphics)
        {
            var colorBorder = Selected
                ? Color.Red
                : Color;

            var ColorFill = Color.FromArgb(100, colorBorder);
            using (var brush = new SolidBrush(ColorFill))
            { 
                graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            }

            using (var pen = new Pen(colorBorder))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
            }
        }

        protected internal override bool SelectedShape(Point point)
        {
            if (point.X >= Location.X && Location.X + Width >= point.X && point.Y >= Location.Y && Location.Y + Height >= point.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        public override bool Intersect(Rectangle rectangle)
        {
            return
               Location.X < rectangle.Location.X + rectangle.Width && rectangle.Location.X < Location.X + Width &&
               Location.Y < rectangle.Location.Y + rectangle.Height && rectangle.Location.Y < Location.Y + Height;
        }
    }
}
