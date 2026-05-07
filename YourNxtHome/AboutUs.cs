using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YourNxtHome
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Mainpage m = new Mainpage();
            m.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Signin sn = new Signin();
            sn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Guest g = new Guest();
            g.Show();
            this.Hide();
        }
        private void label_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.BlueViolet;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.FromArgb(240, 248, 255);
            }
        }
    }
}
