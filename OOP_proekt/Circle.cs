using System;
using System.Drawing;
using System.Linq;

namespace OOP_proekt
{
    [Serializable]
    public class Circle : Shape
    {
        public int _radius;
        public int Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    throw new InvalidValueException("Negative value not allowed!");
                }

                _radius = value;
            }
        }
        public override int Surface
        {
            get
            {
                return (int)(Math.PI * Radius * Radius);
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
                graphics.FillEllipse(brush, Location.X, Location.Y, 2*Radius, 2*Radius);
            }

            using (var pen = new Pen(colorBorder))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y, 2*Radius, 2*Radius);
            }
        
        }

        protected internal override bool SelectedShape(Point point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + 2 * Radius &&
                Location.Y <= point.Y && point.Y <= Location.Y + 2 * Radius;
        } 

        public override bool Intersect(Rectangle rectangle)
        {
            return
               Location.X < rectangle.Location.X + rectangle.Width && rectangle.Location.X < Location.X + Width &&
               Location.Y < rectangle.Location.Y + rectangle.Height && rectangle.Location.Y < Location.Y + Height;
        }
    }
}
