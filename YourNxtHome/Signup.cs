using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YourNxtHome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourNxtHome
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please fill required fields ❗");
                return;
            }
            if (!long.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("❗ Contact must be numeric only");
                return;
            }
            if (!long.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("❗ NID must be numeric only");
                return;
            }
            if (!textBox5.Text.Contains("@"))
            {
                MessageBox.Show("❗ Email must contain @");
                return;
            }


            SqlConnection con = new SqlConnection(connStr);

            string query = "INSERT INTO User_info (Name,Phone,Email,NID,Address,Occupation,UserId,UserPassword,ImagePath) " +
                           "VALUES (@n,@p,@e,@nid,@ad,@oc,@uid,@pass,@img)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@n", textBox1.Text);
            cmd.Parameters.AddWithValue("@p", textBox2.Text);
            cmd.Parameters.AddWithValue("@e", textBox5.Text);
            cmd.Parameters.AddWithValue("@nid", textBox4.Text);
            cmd.Parameters.AddWithValue("@ad", textBox3.Text);
            cmd.Parameters.AddWithValue("@oc", textBox6.Text);
            cmd.Parameters.AddWithValue("@uid", textBox7.Text);
            cmd.Parameters.AddWithValue("@pass", textBox8.Text);
            cmd.Parameters.AddWithValue("@img", imgPath);
            cmd.Parameters.AddWithValue("@role", "User");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🎉 Congratulations! Account Created Successfully ✅");
                UserDashboard usd = new UserDashboard(textBox7.Text);
                usd.Show();
                this.Hide();


                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        string imgPath = "";

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string folder = Application.StartupPath + "\\Images\\";
                System.IO.Directory.CreateDirectory(folder);

                string dest = folder + System.IO.Path.GetFileName(ofd.FileName);
                System.IO.File.Copy(ofd.FileName, dest, true);

                imgPath = dest;
                pictureBox1.Image = Image.FromFile(imgPath);
            }
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            pictureBox1.Image = null;
            imgPath = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
           Mainpage m = new Mainpage();
            m.Show();
            this.Hide();
        }
    }
}
