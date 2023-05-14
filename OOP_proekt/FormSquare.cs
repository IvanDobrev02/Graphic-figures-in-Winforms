using System;
using System.Linq;
using System.Windows.Forms;

namespace OOP_proekt
{
        public partial class FormSquare : Form
        {
            private Square _square;
            public Square Square
            {
                get
                {
                    return _square;
                }
                set
                {
                _square = value;
                textBoxWidth.Text = Square.Width.ToString();
                buttonColor.BackColor = _square.Color;
                }
            }
            public FormSquare()
            {
                InitializeComponent();
            }

            private void buttonOk_Click(object sender, EventArgs e) // за бутона ОК
            {
            try
            {
                Square.Width = int.Parse(textBoxWidth.Text);
                Square.Height = int.Parse(textBoxWidth.Text);
                Square.Color = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
                DialogResult = DialogResult.OK;
            }

            private void buttonCancel_Click(object sender, EventArgs e) // За бутана кенсъл
            {
                DialogResult = DialogResult.Cancel;
            }

            private void buttonColor_Click(object sender, EventArgs e) //За оцветяване на фигурата
            {
                var cd = new ColorDialog();

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    buttonColor.BackColor = cd.Color;
                }
            }

            private void FormSquare_Load(object sender, EventArgs e)
            {

            }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                Square.Width = 0;
                Square.Height = 0;
                Close();
            }
        }
}
