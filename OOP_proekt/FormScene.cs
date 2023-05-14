using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace OOP_proekt
{
    public partial class FormScene : Form
    {
        public List<Shape> _shapes = new List<Shape>();
        public static FormScene formSceneInstance;
        public Rectangle _frameRectangle; // Квадратът, който селектира фигурите
        public Point _mouseDownLocation;
        private bool shapeMove = false;
        
        // Нови функционалности и промени, които не са описани в заданието:
        // 04.04.2022:
        // Вместо с бутона на скрола, Canvas Settings се отваря чрез бутона в левия ъгъл на програмата
        // Преместването на фигурите става чрез натискане върху геом. фиг. с бутона за скрола (Middle button), при което тя се селектира
        // и може да буде преместена като се натисне със същия бутон на друга, избрана от потребителя, точка
        // При селектиране на множество фигури, чрез десния бутон на мишката и след това натискане на бутона за скрола, селектираните фигури 
        // се събират в една точка.
        // Ако множество от фигури се маркират и след това се натисне подходящ клавиш от клавиатурата (R, O, Y, G, B, P) всички избрани фигури
        // ще се оцветят в избрния цвят.

        public FormScene()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);

            formSceneInstance = this;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shapes in _shapes)
            {
                shapes.Paint(e.Graphics);
            }
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            shapeMove = false;
        } //Функция при вдигане на бутон от мишката 

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) //Движене на фигурите със средния бутон
            {
                for (int s = _shapes.Count() - 1; s >= 0; s--)
                {
                    if (_shapes[s].Selected)
                    {
                        _shapes[s].Location = e.Location;
                        shapeMove = true;
                    }
                    else { _shapes[s].Selected = false; }
                }
            }
            _mouseDownLocation = e.Location;
            if (!shapeMove)
            {
                _frameRectangle = new Rectangle
                {
                   Color = Color.Gray
                };

                var unselectedShapes = _shapes.
                    Take(_shapes
                    .Count())
                    .ToList();

                unselectedShapes.ForEach(i => i.Selected = false);


                for (int s = _shapes.Count() - 1; s >= 0; s--)
                {
                    if (_shapes[s].SelectedShape(e.Location))
                    {
                        _shapes[s].Selected = true;
                        break;
                    }
                }
                Shape shape = null;
                if (e.Button == MouseButtons.Left) //Рисуване на фигури с левия бутон
                {
                    for (int s = _shapes.Count() - 1; s >= 0; s--)
                    {
                        _shapes[s].Selected = false;
                    }

                        if (radioButtonRectangle.Checked)
                        shape = new Rectangle()
                        {
                            Location = e.Location,
                            Width = 150,
                            Height = 70,
                        };
                    else if (radioButtonSquare.Checked)
                        shape = new Square()
                        {
                            Location = e.Location,
                            Width = 90,
                            Height = 90
                            
                        };
                    else if (radioButtonTriangle.Checked)
                        shape = new Triangle()
                        {
                            Location = e.Location,
                            Width = 80,
                            Height = 80
                        };
                    else if (radioButtonCircle.Checked)
                        shape = new Circle()
                        {
                            Location = e.Location,
                            Radius = 50
                        };
                } 
                if (shape != null) //Рандъм цвят на фигуритв
                {
                    var r = new Random();

                    shape.Location = e.Location;
                    shape.Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

                    _shapes.Add(shape);
                    shape.Selected = true;

                }
                for (int s = _shapes.Count() - 1; s >= 0; s--)
                {
                   if (_shapes[s].Selected)
                   {
                     toolStripStatusLabel1.Text = _shapes[s].Surface.ToString();
                   }
                }
            }

            Invalidate();
        }  // Функции при натискане на бутоните на мишката 
        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_frameRectangle != null)
                {
                    _frameRectangle.Location = new Point
                    {
                        X = Math.Min(_mouseDownLocation.X, e.Location.X),
                        Y = Math.Min(_mouseDownLocation.Y, e.Location.Y),
                    };
                     
                    _frameRectangle.Width = Math.Abs(_mouseDownLocation.X - e.Location.X);
                    _frameRectangle.Height = Math.Abs(_mouseDownLocation.Y - e.Location.Y);

                    for (int s = 0; s < _shapes.Count(); s++)
                    {
                        _shapes[s].Selected = _shapes[s].Intersect(_frameRectangle);
                    }
                }
            }
            Invalidate();
        }  // Функции при движение на мишката (селектиране на множество фигури с двесния бутон на мишката)
        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (
                e.KeyCode != Keys.Delete && 
                e.KeyCode != Keys.R && 
                e.KeyCode != Keys.B &&
                e.KeyCode != Keys.G &&
                e.KeyCode != Keys.P && 
                e.KeyCode != Keys.O &&
                e.KeyCode != Keys.W &&
                e.KeyCode != Keys.Y &&
                e.KeyCode != Keys.D)
                return;

            for (int shape = _shapes.Count() - 1; shape >= 0; --shape)
                if (_shapes[shape].Selected)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        _shapes.RemoveAt(shape);
                    }
                    if (e.KeyCode == Keys.R)
                    {
                        _shapes[shape].Color = Color.Red;
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        _shapes[shape].Color = Color.Gray;
                    }
                    if (e.KeyCode == Keys.B)
                    {
                        _shapes[shape].Color = Color.Blue;
                    }
                    if (e.KeyCode == Keys.G)
                    {
                        _shapes[shape].Color = Color.Green;
                    }
                    if (e.KeyCode == Keys.P)
                    {
                        _shapes[shape].Color = Color.DeepPink;
                    }
                    if (e.KeyCode == Keys.O)
                    {
                        _shapes[shape].Color = Color.Orange;
                    }
                    if (e.KeyCode == Keys.Y)
                    {
                        _shapes[shape].Color = Color.Yellow;
                    }
                    if (e.KeyCode == Keys.D)
                    {
                        _shapes[shape].Color = Color.Black;
                    }
                }


            Invalidate();
        } // Функции за натискане на бутон от клавиатуарата (Delete и промяна на цвят на геом. фиг.)

        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
                foreach (var shape in _shapes)
                {
                    if (shape.Selected)
                    {
                    if (shape is Rectangle)
                    {
                        var fr = new FormRectangle();
                        fr.Rectangle = (Rectangle)shape;
                        fr.ShowDialog();

                        break;
                    }

                    else if (shape is Circle)
                    {
                        var fr = new FormCircle();
                        fr.Circle = (Circle)shape;
                        fr.ShowDialog();

                        break;
                    }
                    else if (shape is Square)
                    {
                        var fr = new FormSquare();
                        fr.Square = (Square)shape;
                        fr.ShowDialog();

                        break;
                    }
                    else if (shape is Triangle)
                    {
                        var fr = new FormTriangle();
                        fr.Triangle = (Triangle)shape;
                        fr.ShowDialog();

                        break;
                    }
                }
            }
            Invalidate();
        } //Функции при двойно натискане на мишкта (да се отварят отделните форми за настройките на всеки елемент)

        private void canvasSettings_Click(object sender, EventArgs e)
        {
            CanvasSettings canvasSettings = new CanvasSettings();
            canvasSettings.FormScene = (FormScene)formSceneInstance;
            canvasSettings._shapes = _shapes;

            if (canvasSettings != null)
            {
                panel1.ForeColor = FormScene.DefaultForeColor;
                panel2 .ForeColor = FormScene.DefaultForeColor;
            }

            canvasSettings.Show();

            Invalidate();
        } // За отваряне на Canvas Setting 

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();

                try
                {
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open))
                        _shapes = (List<Shape>)formatter.Deserialize(fs);

                }
                catch
                {
                    MessageBox.Show("The file is not suitable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        } //За отваряне на вечв запазен проект

        private void FormScene_SizeChanged(object sender, EventArgs e)
        {
            buttonOpen.Location = new Point(formSceneInstance.Width - 145, 5);
            panel1.Width = formSceneInstance.Width;
            panel2.Location = new Point(0, formSceneInstance.Height);


        } // Функции при промяна на размерите на главната сцена

    }
}