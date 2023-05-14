using System;
using System.Linq;
using System.Windows.Forms;

namespace OOP_proekt
{
    public partial class FormCircle : Form
    {
        private Circle _circle;
        public Circle Circle
            {
                get
                {
                    return _circle;
                }
                set
                {
                    _circle = value;

                textBoxWidth.Text = Circle.Radius.ToString();

                buttonColor.BackColor = _circle.Color;
                }
            }
        public FormCircle()
            {
                InitializeComponent();
            }

        private void buttonOk_Click(object sender, EventArgs e)
            {
            try
            {
                Circle.Radius = int.Parse(textBoxWidth.Text);
                Circle.Color = buttonColor.BackColor;
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

        private void FormCircle_Load(object sender, EventArgs e)
            {
            }

        private void buttonDelete_Click(object sender, EventArgs e)
            {
            Circle.Radius = 0;
            Close();
            }
    }
}
