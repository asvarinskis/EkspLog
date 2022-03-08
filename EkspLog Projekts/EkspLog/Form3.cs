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
    public partial class Form3 : Form
    {
        double a;
        int b;
        public Form3()
        {
            InitializeComponent();
        }

        private void butLogBack_Click(object sender, EventArgs e)
        {
            butLog1.Visible = true;
            butLog1.Enabled = true;
            butLog2.Visible = true;
            butLog2.Enabled = true;
            butLog3.Visible = true;
            butLog3.Enabled = true;
            butLog4.Visible = true;
            butLog4.Enabled = true;
            butLog5.Visible = true;
            butLog5.Enabled = true;
            label1.Visible = false;
            textLog1.Visible = false;
            labLog1yn.Visible = false;
            butLog1Check.Visible = false;
            butLog1Check.Enabled = false;
            butLogBack.Visible = false;
            butLogBack.Enabled = false;
            textLog1.Text = "";
            picLog1.Visible = false;
            picLog1a.Visible = false;
            picLog2.Visible = false;
            picLog2a.Visible = false;
            picLog3.Visible = false;
            picLog3a.Visible = false;
            picLog4.Visible = false;
            picLog4a.Visible = false;
            picLog5.Visible = false;
            picLog5a.Visible = false;
            textLog1.Enabled = true;
        }

        private void butLog1_Click(object sender, EventArgs e)
        {
            butLog1.Visible = false;
            butLog1.Enabled = false;
            butLog2.Visible = false;
            butLog2.Enabled = false;
            butLog3.Visible = false;
            butLog3.Enabled = false;
            butLog4.Visible = false;
            butLog4.Enabled = false;
            butLog5.Visible = false;
            butLog5.Enabled = false;
            label1.Visible = true;
            picLog1.Visible = true;
            textLog1.Visible = true;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "1. Uzdevums";
            a = 3;
            b = 1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            picLog1.Visible = false;
            picLog1a.Visible = false;
            picLog2.Visible = false;
            picLog2a.Visible = false;
            picLog3.Visible = false;
            picLog3a.Visible = false;
            picLog4.Visible = false;
            picLog4a.Visible = false;
            picLog5.Visible = false;
            picLog5a.Visible = false;
            textLog1.Visible = false;
            labLog1yn.Visible = false;
            butLog1Check.Visible = false;
            butLog1Check.Enabled = false;
            butLogBack.Visible = false;
            butLogBack.Enabled = false;
        }

        private void butLogMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }

        private void butLog1Check_Click(object sender, EventArgs e)
        {
            double x;
            bool isA = false;
            isA = double.TryParse(textLog1.Text, out x);
            if (isA == false)
            {
                labLog1yn.Visible = true;
                labLog1yn.Text = "Ievadiet skaitli!";
            }
            else
            {
                if(x == a)
                {
                    labLog1yn.Visible = true;
                    labLog1yn.Text = "Pareizi!";
                }
                else
                {
                    labLog1yn.Visible = true;
                    labLog1yn.Text = "Nepareizi!";
                    textLog1.Enabled = false;
                    butLog1Check.Enabled = false;
                    if (b == 1)
                    {
                        picLog1a.Visible = true;
                    }
                    else if (b == 2)
                    {
                        picLog2a.Visible = true;
                    }
                    else if (b == 3)
                    {
                        picLog3a.Visible = true;
                    }
                    else if (b == 4)
                    {
                        picLog4a.Visible = true;
                    }
                    else if (b == 5)
                    {
                        picLog5a.Visible = true;
                    }
                }
            }
        }

        private void butLog2_Click(object sender, EventArgs e)
        {
            butLog1.Visible = false;
            butLog1.Enabled = false;
            butLog2.Visible = false;
            butLog2.Enabled = false;
            butLog3.Visible = false;
            butLog3.Enabled = false;
            butLog4.Visible = false;
            butLog4.Enabled = false;
            butLog5.Visible = false;
            butLog5.Enabled = false;
            label1.Visible = true;
            textLog1.Visible = true;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "2. Uzdevums";
            a = 2;
            picLog2.Visible = true;
            b = 2;
        }

        private void butLog3_Click(object sender, EventArgs e)
        {
            butLog1.Visible = false;
            butLog1.Enabled = false;
            butLog2.Visible = false;
            butLog2.Enabled = false;
            butLog3.Visible = false;
            butLog3.Enabled = false;
            butLog4.Visible = false;
            butLog4.Enabled = false;
            butLog5.Visible = false;
            butLog5.Enabled = false;
            label1.Visible = true;
            textLog1.Visible = true;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "3. Uzdevums";
            a = 10;
            picLog3.Visible = true;
            b = 3;
        }

        private void butLog4_Click(object sender, EventArgs e)
        {
            butLog1.Visible = false;
            butLog1.Enabled = false;
            butLog2.Visible = false;
            butLog2.Enabled = false;
            butLog3.Visible = false;
            butLog3.Enabled = false;
            butLog4.Visible = false;
            butLog4.Enabled = false;
            butLog5.Visible = false;
            butLog5.Enabled = false;
            label1.Visible = true;
            textLog1.Visible = true;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "4. Uzdevums";
            a = 36;
            picLog4.Visible = true;
            b = 4;
        }

        private void butLog5_Click(object sender, EventArgs e)
        {
            butLog1.Visible = false;
            butLog1.Enabled = false;
            butLog2.Visible = false;
            butLog2.Enabled = false;
            butLog3.Visible = false;
            butLog3.Enabled = false;
            butLog4.Visible = false;
            butLog4.Enabled = false;
            butLog5.Visible = false;
            butLog5.Enabled = false;
            label1.Visible = true;
            textLog1.Visible = true;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "5. Uzdevums";
            a = 100;
            picLog5.Visible = true;
            b = 5;
        }
    }
}
