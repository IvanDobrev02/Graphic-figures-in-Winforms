using System;
using System.Linq;
using System.Windows.Forms;

namespace OOP_proekt
{
    public partial class FormRectangle : Form
    {
        private Rectangle _rectangle;
        public Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }
            set
            {
                _rectangle = value;
                
                textBoxHeigh.Text = Rectangle.Height.ToString();
                textBoxWidth.Text = Rectangle.Width.ToString();

                buttonColor.BackColor = _rectangle.Color;
            }
        }
        public FormRectangle()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle.Height = int.Parse(textBoxHeigh.Text);
                Rectangle.Width = int.Parse(textBoxWidth.Text);
                Rectangle.Color = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Rectangle.Width = 0;
            Rectangle.Height = 0;
            Close();
        }
    }
}
