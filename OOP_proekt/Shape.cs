using System;
using System.Drawing;
using System.Linq;


namespace OOP_proekt
{
    [Serializable]
    public abstract class Shape
    {
        public int _height;
        public int Height
        {
            get => _height;
            set
            {
                if (value < 0)
                {
                    throw new InvalidValueException("Negative value not allowed!");
                }

                _height = value;
            }
        }

        public int _width;
        public int Width 
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new InvalidValueException("Negative value not allowed!");
                }

                _width = value;
            }
        }
        public Point Location { get; set; }
        public Color Color { get; set; }

        [NonSerialized]
        public bool _selected;
        public bool Selected
        {
            get => _selected;
            set => _selected = value;
        }
        public virtual int Surface { get; } // за лицето

        protected internal abstract void Paint(Graphics graphics);
        protected internal abstract bool SelectedShape(Point point);
        public abstract bool Intersect(Rectangle rectangle); 

    }
}
