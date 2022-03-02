using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspLog
{
    public partial class Form4 : Form
    {
        double a;
        public Form4()
        {
            InitializeComponent();
        }

        private void butExpBack_Click(object sender, EventArgs e)
        {
            butExp1.Visible = true;
            butExp1.Enabled = true;
            butExp2.Visible = true;
            butExp2.Enabled = true;
            butExp3.Visible = true;
            butExp3.Enabled = true;
            butExp4.Visible = true;
            butExp4.Enabled = true;
            butExp5.Visible = true;
            butExp5.Enabled = true;
            label2.Visible = false;
            labExp1.Visible = false;
            textExp.Visible = false;
            labExpanswer.Visible = false;
            labExpyn.Visible = false;
            labExp.Visible = true;
            butExpCheck.Visible = false;
            butExpCheck.Enabled = false;
            butExpBack.Visible = false;
            butExpBack.Enabled = false;
            textExp.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            labExp1.Visible = false;
            textExp.Visible = false;
            labExpanswer.Visible = false;
            labExpyn.Visible = false;
            butExpCheck.Visible = false;
            butExpCheck.Enabled = false;
            butExpBack.Visible = false;
            butExpBack.Enabled = false;
        }

        private void butExpMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }

        private void butExp1_Click(object sender, EventArgs e)
        {
            butExp1.Visible = false;
            butExp1.Enabled = false;
            butExp2.Visible = false;
            butExp2.Enabled = false;
            butExp3.Visible = false;
            butExp3.Enabled = false;
            butExp4.Visible = false;
            butExp4.Enabled = false;
            butExp5.Visible = false;
            butExp5.Enabled = false;
            label2.Visible = true;
            labExp1.Visible = true;
            textExp.Visible = true;
            labExpanswer.Visible = false;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "1. Uzdevums";
            labExp1.Text = "3^x = 9";
            labExpanswer.Text = "3^x = 3^2,   x = 2";
            a = 2;
        }

        private void butExp2_Click(object sender, EventArgs e)
        {
            butExp1.Visible = false;
            butExp1.Enabled = false;
            butExp2.Visible = false;
            butExp2.Enabled = false;
            butExp3.Visible = false;
            butExp3.Enabled = false;
            butExp4.Visible = false;
            butExp4.Enabled = false;
            butExp5.Visible = false;
            butExp5.Enabled = false;
            label2.Visible = true;
            labExp1.Visible = true;
            textExp.Visible = true;
            labExpanswer.Visible = false;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "2. Uzdevums";
            labExp1.Text = "3^-2x-9 = 81";
            labExpanswer.Text = "3^-2x-9 = 3^4,   -2x - 9 = 4,   -2x = 13,   x = -6.5";
            a = -6.5;
        }

        private void butExp3_Click(object sender, EventArgs e)
        {
            butExp1.Visible = false;
            butExp1.Enabled = false;
            butExp2.Visible = false;
            butExp2.Enabled = false;
            butExp3.Visible = false;
            butExp3.Enabled = false;
            butExp4.Visible = false;
            butExp4.Enabled = false;
            butExp5.Visible = false;
            butExp5.Enabled = false;
            label2.Visible = true;
            labExp1.Visible = true;
            textExp.Visible = true;
            labExpanswer.Visible = false;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "3. Uzdevums";
            labExp1.Text = "5^x + 5^x+1 = 750";
            labExpanswer.Text = "5^x + 5^x * 5^1 = 750,   5^x + 25^x = 750,   5^x(1 + 5) = 750,   5^x * 6 = 750,   5^x = 125, 5^x = 5^3,   x=3";
            a = 3;
        }

        private void butExp4_Click(object sender, EventArgs e)
        {
            butExp1.Visible = false;
            butExp1.Enabled = false;
            butExp2.Visible = false;
            butExp2.Enabled = false;
            butExp3.Visible = false;
            butExp3.Enabled = false;
            butExp4.Visible = false;
            butExp4.Enabled = false;
            butExp5.Visible = false;
            butExp5.Enabled = false;
            label2.Visible = true;
            labExp1.Visible = true;
            textExp.Visible = true;
            labExpanswer.Visible = false;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "4. Uzdevums";
            labExp1.Text = "3^2x - 2 * 3^2x-1 - 2 * 3^2x-2 = 1";
            labExpanswer.Text = "3^2x-2(3^2x-2x+2 - 2 * 3^2x-1-2x+2 - 2 * 1) = 1,   3^2x-2(3^2 - 2 * 3^1 - 2 * 1) = 1,   3^2x-2 * 1 = 1,   3^2x-2 = 1,   3^2x-2 = 3^0,   2x-2 = 0,   2x = 2,   x = 1";
            a = 1;
        }

        private void butExp5_Click(object sender, EventArgs e)
        {
            butExp1.Visible = false;
            butExp1.Enabled = false;
            butExp2.Visible = false;
            butExp2.Enabled = false;
            butExp3.Visible = false;
            butExp3.Enabled = false;
            butExp4.Visible = false;
            butExp4.Enabled = false;
            butExp5.Visible = false;
            butExp5.Enabled = false;
            label2.Visible = true;
            labExp1.Visible = true;
            textExp.Visible = true;
            labExpanswer.Visible = false;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "5. Uzdevums";
            labExp1.Text = "2^2x + 3 * 2^x - 28 = 0";
            labExpanswer.Text = "2^x = y,   y^2 + 3y - 28 = 0,   D = 3^2 - 4 * 1 * (-28) = 121,   y1 = (-3 + 11) / 2 = 4,   y2 = (-3 - 11) / 2 = -7,   2^x = -7,   x = {},   2^x = 4,   x = 2";
            a = 2;
        }

        private void butExpCheck_Click(object sender, EventArgs e)
        {
            double x;
            bool isA = false;
            isA = double.TryParse(textExp.Text, out x);
            if (isA == false)
            {
                labExpyn.Visible = true;
                labExpyn.Text = "Ievadiet skaitli!";
            }
            else
            {
                if (x == a)
                {
                    labExpyn.Visible = true;
                    labExpyn.Text = "Pareizi!";
                }
                else
                {
                    labExpyn.Visible = true;
                    labExpyn.Text = "Nepareizi!";
                    labExpanswer.Visible = true;
                }
            }
        }
    }
}
