using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace OOP_proekt
{
    public partial class CanvasSettings : Form
    {

        public List<Shape> _shapes = new List<Shape>();
        private FormScene _formScene;
        public FormScene FormScene
        {
            get 
            {
                return _formScene;
            }
            set 
            {
                _formScene = value;

                textBoxHeigh.Text = FormScene.Height.ToString();
                textBoxWidth.Text = FormScene.Width.ToString();

                buttonColor.BackColor = _formScene.BackColor;
            }
        }
        public CanvasSettings()
        {
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxHeigh.Text) == 0)
                {
                    MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                {
                    FormScene.Height = Math.Abs(int.Parse(textBoxHeigh.Text)); 
                }

                if (int.Parse(textBoxWidth.Text) == 0)
                {
                    MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    FormScene.Width = Math.Abs(int.Parse(textBoxWidth.Text));
                }

                FormScene.BackColor = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            for (int s = _shapes.Count() - 1; s >= 0; s--)
            {
                _shapes.RemoveAt(s);
            }
            FormScene.BackColor = Color.White;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FormSaveImage formSaveImage = new FormSaveImage();
            formSaveImage.FormScene = FormScene;
            formSaveImage._shapes = _shapes;
            formSaveImage.Show();
            Close();
        }
    }
}
