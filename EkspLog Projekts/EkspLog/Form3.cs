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
            labLog1.Visible = false;
            textLog1.Visible = false;
            labLog1answer.Visible = false;
            labLog1yn.Visible = false;
            butLog1Check.Visible = false;
            butLog1Check.Enabled = false;
            butLogBack.Visible = false;
            butLogBack.Enabled = false;
            textLog1.Text = "";
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
            labLog1.Visible = true;
            textLog1.Visible = true;
            labLog1answer.Visible = false;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "1. Uzdevums";
            labLog1.Text = "log 2 (8)";
            labLog1answer.Text = "log 2 (8) = x,   2^x = 8,   2^x =2^3,    x = 3";
            a = 3;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            labLog1.Visible = false;
            textLog1.Visible = false;
            labLog1answer.Visible = false;
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
                    labLog1answer.Visible = true;
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
            labLog1.Visible = true;
            textLog1.Visible = true;
            labLog1answer.Visible = false;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "2. Uzdevums";
            labLog1.Text = "lg 100";
            labLog1answer.Text = "lg 100 = log 10 (100),   log 10 (100) = x,   10^x = 100,   10^x = 10^2,   x = 2";
            a = 2;
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
            labLog1.Visible = true;
            textLog1.Visible = true;
            labLog1answer.Visible = false;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "3. Uzdevums";
            labLog1.Text = "6^log 6 (10)";
            labLog1answer.Text = "a^log a (b) = b,   6^log 6 (10) = 10";
            a = 10;
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
            labLog1.Visible = true;
            textLog1.Visible = true;
            labLog1answer.Visible = false;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "4. Uzdevums";
            labLog1.Text = "3^log 3 (4)+2";
            labLog1answer.Text = "a^n+k = a^n  *  a^k,   3^log 3 (4)  *  3^2   =   4  *  9 = 36";
            a = 36;
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
            labLog1.Visible = true;
            textLog1.Visible = true;
            labLog1answer.Visible = false;
            labLog1yn.Visible = true;
            butLog1Check.Visible = true;
            butLog1Check.Enabled = true;
            butLogBack.Visible = true;
            butLogBack.Enabled = true;
            labLog1yn.Text = "";
            label1.Text = "5. Uzdevums";
            labLog1.Text = "81^log 9 (10)";
            labLog1answer.Text = "81^log 9 (10)   =   (3^4)^log 9 (10)   =   3^4log 9 (10)   =   3^4log 3^2 (10)   =   3^4x0.5log 3 (10)   =   3^2log 3 (10)   =   (3^log 3 (10))^2   =   10^2   =   100";
            a = 100;
        }
    }
}
