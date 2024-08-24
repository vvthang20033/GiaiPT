using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GiaiPhuongTrinh
{
    public partial class GiaiPT : Form
    {
        public GiaiPT()
        {
            InitializeComponent();
        }

        private void GiaiPT_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input and parse coefficients
            if (!double.TryParse(textBox1.Text, out double a))
            {
                label6.Text = "Hệ số bậc 2 không hợp lệ!";
                return;
            }

            if (!double.TryParse(textBox2.Text, out double b))
            {
                label6.Text = "Hệ số bậc 1 không hợp lệ!";
                return;
            }

            if (!double.TryParse(textBox3.Text, out double c))
            {
                label6.Text = "Hệ số tự do không hợp lệ!";
                return;
            }

            // Reset the result label
            label6.Text = "";

            // Solve the quadratic equation
            if (a == 0)
            {
                // Special cases when a = 0 (Linear equation or no solution)
                if (b == 0)
                {
                    if (c == 0)
                    {
                        label6.Text = "Phương trình có vô số nghiệm";
                    }
                    else
                    {
                        label6.Text = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    // Linear equation bx + c = 0
                    if (c == 0)
                    {
                        label6.Text = "Phương trình có nghiệm x = 0";
                    }
                    else
                    {
                        label6.Text = "Phương trình có nghiệm x = " + (-c / b);
                    }
                }
            }
            else
            {
                // Quadratic equation: ax^2 + bx + c = 0
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    label6.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2.0 * a);
                    label6.Text = "Phương trình có nghiệm kép x1 = x2 = " + x;
                }
                else
                {
                    double sqrtDelta = Math.Sqrt(delta);
                    double x1 = (-b + sqrtDelta) / (2.0 * a);
                    double x2 = (-b - sqrtDelta) / (2.0 * a);
                    label6.Text = "Phương trình có hai nghiệm phân biệt x1 = " + x1 + " và x2 = " + x2;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGiai_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a1) || !double.TryParse(textBoxB.Text, out double b1)
                || !double.TryParse(textBoxC.Text, out double c1) || !double.TryParse(textBoxA2.Text, out double a2)
                    || !double.TryParse(textBoxB2.Text, out double b2) || !double.TryParse(textBoxC2.Text, out double c2))
            {
                labelDapAn.Text = "Hệ số không hợp lệ ";
            }
            else
            {
                double det = a1 * b2 - a2 * b1 ;
                if(det != 0)
                {
                    double y = (c2 * a1 - c1 * a2) / det;


                    double x = (c1 - b1 * y) / a1;

                    labelDapAn.Text = $" Nghiệm của hệ phương trình là x = {x} và y = {y}";
                }
                else if (det == 0 && (c1/a1 == c2 / a2))
                {
                    labelDapAn.Text = "Hệ phương trình có vô số nghiệm";
                }
                else
                {
                    labelDapAn.Text = "Hệ phương trình vô nghiệm";
                }

            }
        }
    }

}