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
    public partial class Wishlist : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string currentUserId = "";

        public Wishlist(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadWishlist();
        }

        private void LoadWishlist()
        {
            listViewWishlist.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT p.PostId, p.PostTitle, p.Location, p.Rent, u.Name, w.AddedDate
                    FROM Wishlist w
                    JOIN Posts p     ON w.PostId  = p.PostId
                    JOIN User_info u ON p.OwnerId = u.UserId
                    WHERE w.UserId=@uid
                    ORDER BY w.AddedDate DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["PostId"].ToString() ?? "");
                    item.SubItems.Add(dr["PostTitle"].ToString() ?? "");
                    item.SubItems.Add(dr["Location"].ToString() ?? "");
                    item.SubItems.Add("৳ " + dr["Rent"].ToString());
                    item.SubItems.Add(dr["Name"].ToString() ?? "");
                    item.SubItems.Add(Convert.ToDateTime(dr["AddedDate"]).ToShortDateString());
                    item.Tag = dr["PostId"].ToString() ?? "";
                    listViewWishlist.Items.Add(item);
                }
                con.Close();
                labelEmpty.Visible = listViewWishlist.Items.Count == 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listViewWishlist.SelectedItems.Count == 0)
            { MessageBox.Show("Select a post to remove."); return; }

            string tag = listViewWishlist.SelectedItems[0].Tag?.ToString() ?? "";
            if (tag == "") return;
            int postId = Convert.ToInt32(tag);

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Wishlist WHERE UserId=@uid AND PostId=@pid", con);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.Parameters.AddWithValue("@pid", postId);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show("Removed from Wishlist.");
                LoadWishlist();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ViewPost vp = new ViewPost(currentUserId);
            vp.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard(currentUserId);
            ud.Show();
            this.Close();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(80, 0, 180); }
        private void btn_MouseLeave(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.DarkSlateBlue; }
    }
}
