using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace YourNxtHome
{
    public partial class ForgotPass : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";

        string? userId;
        bool isVerified = false;

        public ForgotPass()
        {
            InitializeComponent();
        }

        public ForgotPass(string uid)
        {
            InitializeComponent();
            userId = uid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);

            string query = "SELECT COUNT(*) FROM User_info WHERE UserId=@uid AND Phone=@ph AND NID=@nid";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@uid", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@nid", txtNID.Text.Trim());

            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                isVerified = true;

                panelReset.Visible = true;
                txtNewPass.Enabled = true;
                button2.Enabled = true;

                MessageBox.Show("✅ Verification Successful. You can reset password.");
            }
            else
            {
                isVerified = false;
                MessageBox.Show("❌ Verification Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isVerified)
            {
                MessageBox.Show("⚠ Please verify first!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show("⚠ Password cannot be empty!");
                return;
            }

            SqlConnection con = new SqlConnection(connStr);

            string query = "UPDATE User_info SET UserPassword=@pass WHERE UserId=@uid";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@pass", txtNewPass.Text.Trim());
            cmd.Parameters.AddWithValue("@uid", textBox1.Text.Trim());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("✅ Password Updated Successfully");
            this.Hide();
            Signin sn = new Signin();
            sn.Show();

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Signin sn = new Signin();
            sn.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Mainpage mp = new Mainpage();
            mp.Show();
            this.Hide();
        }
    }
}