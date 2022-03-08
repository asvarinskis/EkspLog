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
        int b;
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
            textExp.Visible = false;
            labExpyn.Visible = false;
            labExp.Visible = true;
            butExpCheck.Visible = false;
            butExpCheck.Enabled = false;
            butExpBack.Visible = false;
            butExpBack.Enabled = false;
            textExp.Text = "";
            picExp1.Visible = false;
            picExp1a.Visible = false;
            picExp2.Visible = false;
            picExp2a.Visible = false;
            picExp3.Visible = false;
            picExp3a.Visible = false;
            picExp4.Visible = false;
            picExp4a.Visible = false;
            picExp5.Visible = false;
            picExp5a.Visible = false;
            textExp.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textExp.Visible = false;
            labExpyn.Visible = false;
            butExpCheck.Visible = false;
            butExpCheck.Enabled = false;
            butExpBack.Visible = false;
            butExpBack.Enabled = false;
            picExp1.Visible = false;
            picExp1a.Visible = false;
            picExp2.Visible = false;
            picExp2a.Visible = false;
            picExp3.Visible = false;
            picExp3a.Visible = false;
            picExp4.Visible = false;
            picExp4a.Visible = false;
            picExp5.Visible = false;
            picExp5a.Visible = false;
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
            textExp.Visible = true;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "1. Uzdevums";
            a = 2;
            picExp1.Visible = true;
            b = 1;
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
            textExp.Visible = true;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "2. Uzdevums";
            a = -6.5;
            picExp2.Visible = true;
            b = 2;
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
            textExp.Visible = true;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "3. Uzdevums";
            a = 3;
            picExp3.Visible = true;
            b = 3;
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
            textExp.Visible = true;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "4. Uzdevums";
            a = 1;
            picExp4.Visible = true;
            b = 4;
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
            textExp.Visible = true;
            labExpyn.Visible = true;
            labExp.Visible = false;
            butExpCheck.Visible = true;
            butExpCheck.Enabled = true;
            butExpBack.Visible = true;
            butExpBack.Enabled = true;
            labExpyn.Text = "";
            label2.Text = "5. Uzdevums";
            a = 2;
            picExp5.Visible = true;
            b = 5;
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
                    textExp.Enabled = false;
                    butExpCheck.Enabled = false;
                    if (b == 1)
                    {
                        picExp1a.Visible = true;
                    }
                    else if (b == 2)
                    {
                        picExp2a.Visible = true;
                    }
                    else if (b == 3)
                    {
                        picExp3a.Visible = true;
                    }
                    else if (b == 4)
                    {
                        picExp4a.Visible = true;
                    }
                    else if (b == 5)
                    {
                        picExp5a.Visible = true;
                    }
                }
            }
        }
    }
}
