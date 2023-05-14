using System;
using System.Linq;
using System.Windows.Forms;

namespace OOP_proekt
{
    public partial class FormTriangle : Form
    {
        public FormTriangle()
        {
            InitializeComponent();
        }
        private Triangle _triangle;
        public Triangle Triangle
        {
            get
            {
                return _triangle;
            }
            set
            {
                _triangle = value;

                textBoxWidth.Text = Triangle.Width.ToString();
                textBoxHeight.Text = Triangle.Height.ToString();
                buttonColor.BackColor = _triangle.Color;
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle.Width = int.Parse(textBoxWidth.Text);
                Triangle.Height = int.Parse(textBoxHeight.Text);
                Triangle.Color = buttonColor.BackColor;
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
            Triangle.Height = 0;
            Close();
        }
    }
}
