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
    public partial class FormLog1 : Form
    {
        public FormLog1()
        {
            InitializeComponent();
        }

        private void FormLog1_Load(object sender, EventArgs e)
        {
            labLog1answer.Visible = false;
            labLog1yn.Visible = false;
        }

        private void butLog1Check_Click(object sender, EventArgs e)
        {
            int x;
            bool isA = false;
            isA = int.TryParse(textLog1.Text, out x);
            if(isA==false)
            {
                labLog1yn.Visible = true;
                labLog1yn.Text = "Ievadiet skaitli!";
            }
            else
            {
                if(x == 3)
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

        private void butLog1Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 log = new Form3();
            log.Show();
        }

        private void butLog1Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }
    }
}
