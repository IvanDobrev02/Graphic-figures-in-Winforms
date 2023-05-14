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
    public partial class FormSaveImage : Form
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
            }
        }

        public FormSaveImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {

            if (radioButtonImage.Checked)
            {
                using (Bitmap bmp = new Bitmap(FormScene.Width, FormScene.Height))
                {
                    FormScene.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(@"" + textBoxSaveImage.Text + ".jpg");
                    Close();
                }
            }
            else if (radioButtonWorkFile.Checked)
            {
                IFormatter formatter = new BinaryFormatter();

                using (var fs = new FileStream(textBoxSaveImage.Text, FileMode.Create))
                    formatter.Serialize(fs, _shapes);
                Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
