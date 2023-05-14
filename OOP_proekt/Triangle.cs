using System;
using System.Drawing;
using System.Linq;


namespace OOP_proekt
{
    [Serializable]
    public class Triangle : Shape
    {
         public override int Surface
         { 
             get
             {
                 return (Width * Height) /2;
             }
         }

         protected internal override void Paint(Graphics graphics)
         {
            Point point1 = new Point(Location.X, Location.Y);
            Point point2 = new Point(Location.X + Width, Location.Y);
            Point point3 = new Point(Location.X + Width / 2, (Location.Y + Height));
            Point[] curvePoints = { point1, point2, point3,};
            var colorBorder = Selected
                ? Color.Red
                : Color;

            var ColorFill = Color.FromArgb(100, colorBorder);
            using (var brush = new SolidBrush(ColorFill))
            {
                graphics.FillPolygon(brush, curvePoints);
            }
            using (var pen = new Pen(colorBorder))
            {
                graphics.DrawLine(pen, Location.X, Location.Y, Location.X, Location.Y);
            }
         }

        protected internal override bool SelectedShape(Point point)
         {
            Point point1 = new Point(Location.X, Location.Y);
            Point point2 = new Point(Location.X + Width, Location.Y);
            Point point3 = new Point(Location.X + Width/2, (Location.Y + Height));
            Point[] curvePoints = { point1, point2, point3, };

            return
                  point.X >= Location.X && Location.X + Width >= point.X &&
                  point.Y >= Location.Y && Location.Y + Height >= point.Y;
        }
        public override bool Intersect(Rectangle rectangle)
        {
            return
               Location.X < rectangle.Location.X + rectangle.Width && rectangle.Location.X < Location.X + Width &&
               Location.Y < rectangle.Location.Y + rectangle.Width && rectangle.Location.Y < Location.Y + Width;
        }
    }
}
