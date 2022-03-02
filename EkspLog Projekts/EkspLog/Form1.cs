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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 inst = new Form2();
            inst.Show();
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 log = new Form3();
            log.Show();
        }

        private void butExp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 exp = new Form4();
            exp.Show();
        }
    }
}
