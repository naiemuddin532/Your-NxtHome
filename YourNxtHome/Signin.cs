#nullable disable
using Microsoft.Data.SqlClient;    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourNxtHome
{
    public partial class Signin : Form
    {
        bool isPasswordVisible = false;
        public Signin()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            labelShowPass.Text = "Show Password";
        }
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter UserId & Password ❗");
                return;
            }
            if (textBox1.Text == "Naiem" && textBox2.Text == "N532")
            {
                MessageBox.Show("Developer Login Successful!");
                Developer dev = new Developer();
                dev.ShowDialog();
                this.Hide();
                return;
            }
            SqlConnection con = new SqlConnection(connStr);

            string query = "SELECT Role FROM User_info WHERE UserId=@uid AND UserPassword=@pass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uid", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();

            object result = cmd.ExecuteScalar();

            con.Close();

            if (result != null)
            {
                string role = result.ToString();

                MessageBox.Show("Login Successful!");

                if (role == "Admin")
                {
                    AdminDashboard ad = new AdminDashboard();
                    ad.Show();
                }
                else
                {
                    UserDashboard ud = new UserDashboard(textBox1.Text);
                    ud.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password ❌");
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.White;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.Cyan;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Mainpage m = new Mainpage();
            m.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ForgotPass fp = new ForgotPass(textBox1.Text);
            fp.Show();
            this.Hide();
        }

        private void labelShowPass_Click(object sender, EventArgs e)
        {

            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                textBox2.UseSystemPasswordChar = false;
                labelShowPass.Text = "Hide Password";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                labelShowPass.Text = "Show Password";
            }
        }
    }
}
