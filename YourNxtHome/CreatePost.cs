using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace YourNxtHome
{
    public partial class CreatePost : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string currentUserId = "";
        byte[] postPhotoBytes = null;

        public CreatePost(string userId)
        {
            InitializeComponent();
            currentUserId = userId;

            // Fix: AutoCheck false করে manually handle করব
            radioBachelorType.AutoCheck = false;
            radioFamilyType.AutoCheck = false;
            radioRestricted.AutoCheck = false;
            radioRestrictionLess.AutoCheck = false;

            radioBachelorType.Click += (s, e) =>
            {
                radioBachelorType.Checked = true;
                radioFamilyType.Checked = false;
            };

            radioFamilyType.Click += (s, e) =>
            {
                radioFamilyType.Checked = true;
                radioBachelorType.Checked = false;
            };

            radioRestrictionLess.Click += (s, e) =>
            {
                radioRestrictionLess.Checked = true;
                radioRestricted.Checked = false;
            };

            radioRestricted.Click += (s, e) =>
            {
                radioRestricted.Checked = true;
                radioRestrictionLess.Checked = false;
            };

            // Default checked state
            radioBachelorType.Checked = true;
            radioRestrictionLess.Checked = true;
        }

        private void btnPickPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                postPhotoBytes = System.IO.File.ReadAllBytes(ofd.FileName);
                pictureBoxPreview.Image = Image.FromFile(ofd.FileName);
                labelPhotoStatus.Text = "✅ Photo selected";
                labelPhotoStatus.ForeColor = Color.LightGreen;
            }
        }

        private void btnSubmitPost_Click(object sender, EventArgs e)
        {
            if (textTitle.Text.Trim() == "" || textLocation.Text.Trim() == "" || textRent.Text.Trim() == "")
            {
                MessageBox.Show("Please fill Title, Location, and Rent ❗");
                return;
            }

            if (!int.TryParse(textRent.Text.Trim(), out int rent))
            {
                MessageBox.Show("Rent must be a number ❗");
                return;
            }

            if (!radioFamilyType.Checked && !radioBachelorType.Checked)
            {
                MessageBox.Show("Please select Tenant Type (Bachelor or Family) ❗");
                return;
            }

            string tenantType = radioBachelorType.Checked ? "Bachelor" : "Family";
            string restrictType = radioRestricted.Checked ? "Restricted" : "RestrictionLess";

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"INSERT INTO Posts 
                                 (OwnerId, PostTitle, Location, Rent, Description, PostPhoto, TenantType, RestrictionType, PostDate)
                                 VALUES (@owner, @title, @loc, @rent, @desc, @photo, @tenant, @restrict, @date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@owner", currentUserId);
                cmd.Parameters.AddWithValue("@title", textTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@loc", textLocation.Text.Trim());
                cmd.Parameters.AddWithValue("@rent", rent);
                cmd.Parameters.AddWithValue("@desc", textDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@photo", postPhotoBytes != null ? (object)postPhotoBytes : DBNull.Value);
                cmd.Parameters.AddWithValue("@tenant", tenantType);
                cmd.Parameters.AddWithValue("@restrict", restrictType);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Post created successfully! 🏠✅");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelPost_Click(object sender, EventArgs e) => this.Close();
    }
}