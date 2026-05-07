using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YourNxtHome
{
    public partial class RateOwner : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string currentUserId = "";
        int selectedRating = 0;

        public RateOwner(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadConfirmedOwners();
        }

        private void LoadConfirmedOwners()
        {
            comboOwner.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT DISTINCT u.UserId, u.Name
                    FROM Bookings b
                    JOIN Posts p      ON b.PostId   = p.PostId
                    JOIN User_info u  ON p.OwnerId  = u.UserId
                    WHERE b.UserId=@uid AND b.Status='Confirmed'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    comboOwner.Items.Add((dr["Name"].ToString() ?? "") + "|" + (dr["UserId"].ToString() ?? ""));
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void star_Click(object sender, EventArgs e)
        {
            if (sender is Label lbl && lbl.Tag != null)
            {
                selectedRating = Convert.ToInt32(lbl.Tag);
                UpdateStars();
            }
        }

        private void UpdateStars()
        {
            Label[] stars = { star1, star2, star3, star4, star5 };
            for (int i = 0; i < stars.Length; i++)
                stars[i].ForeColor = i < selectedRating ? Color.Gold : Color.FromArgb(80, 80, 80);
            labelRatingValue.Text = selectedRating + " / 5";
        }

        private void btnSubmitRating_Click(object sender, EventArgs e)
        {
            if (comboOwner.SelectedIndex < 0)
            { MessageBox.Show("Please select an owner."); return; }
            if (selectedRating == 0)
            { MessageBox.Show("Please select a star rating."); return; }

            string selected = comboOwner.SelectedItem?.ToString() ?? "";
            string ownerId = selected.Contains('|') ? selected.Split('|')[1] : "";
            if (ownerId == "") return;

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand chk = new SqlCommand(
                    "SELECT COUNT(*) FROM Ratings WHERE UserId=@uid AND OwnerId=@oid", con);
                chk.Parameters.AddWithValue("@uid", currentUserId);
                chk.Parameters.AddWithValue("@oid", ownerId);
                con.Open();
                int existing = Convert.ToInt32(chk.ExecuteScalar());
                con.Close();

                if (existing > 0) { MessageBox.Show("Already rated this owner! ⚠️"); return; }

                SqlConnection con2 = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Ratings (UserId,OwnerId,Rating,Comment,RatedDate)
                    VALUES (@uid,@oid,@rating,@comment,@date)", con2);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.Parameters.AddWithValue("@oid", ownerId);
                cmd.Parameters.AddWithValue("@rating", selectedRating);
                cmd.Parameters.AddWithValue("@comment", textComment.Text.Trim());
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                con2.Open(); cmd.ExecuteNonQuery(); con2.Close();

                MessageBox.Show("Rating submitted! ⭐ Thank you.");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
