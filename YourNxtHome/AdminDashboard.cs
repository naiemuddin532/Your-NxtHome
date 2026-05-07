#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YourNxtHome;
namespace YourNxtHome
{
    public partial class AdminDashboard : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string currentRole = "Admin";

        public AdminDashboard()
        {
            InitializeComponent();
            currentRole = "Admin";
            ShowPanel(panelOverview);
            LoadOverview();
        }

        public AdminDashboard(string role)
        {
            InitializeComponent();
            currentRole = role;
            ShowPanel(panelOverview);
            LoadOverview();

            // Developer cannot delete users or messages
            if (role == "Developer")
            {
                btnDeleteUser.Enabled = false;
                btnDeleteMessage.Enabled = false;
                btnDeleteUser.Text = "🔒 Delete User";
                btnDeleteMessage.Text = "🔒 Delete Message";
            }
        }

        // =============================================
        // PANEL SWITCH
        // =============================================
        private void ShowPanel(Panel panel)
        {
            panelOverview.Visible = false;
            panelAllPosts.Visible = false;
            panelBookings.Visible = false;
            panelMessages.Visible = false;
            panel.Visible = true;
        }

        private void btnOverview_Click(object sender, EventArgs e) { ShowPanel(panelOverview); LoadOverview(); }
        private void btnAllPosts_Click(object sender, EventArgs e) { ShowPanel(panelAllPosts); LoadAllPosts(""); }
        //private void btnAllUsers_Click(object sender, EventArgs e) { ShowPanel(panelAllUsers); LoadAllUsers(); }
        private void btnBookings_Click(object sender, EventArgs e) { ShowPanel(panelBookings); LoadAllBookings(); }
        private void btnMessages_Click(object sender, EventArgs e) { ShowPanel(panelMessages); LoadAllMessages(); }

        // ← UserInfo button opens UserInfo form
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo(currentRole);
            ui.Show();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainpage m = new Mainpage();
            m.Show();
            this.Close();
        }

        // =============================================
        // OVERVIEW
        // =============================================
        private void LoadOverview()
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                labelStatUsers.Text = "👤 Total Users     : " + Count(con, "SELECT COUNT(*) FROM User_info");
                labelStatPosts.Text = "🏠 Total Posts     : " + Count(con, "SELECT COUNT(*) FROM Posts");
                labelStatBookings.Text = "📋 Total Bookings  : " + Count(con, "SELECT COUNT(*) FROM Bookings");
                labelStatPending.Text = "⏳ Pending         : " + Count(con, "SELECT COUNT(*) FROM Bookings WHERE Status='Pending'");
                labelStatConfirmed.Text = "✅ Confirmed       : " + Count(con, "SELECT COUNT(*) FROM Bookings WHERE Status='Confirmed'");
                labelStatRejected.Text = "❌ Rejected        : " + Count(con, "SELECT COUNT(*) FROM Bookings WHERE Status='Rejected'");
                labelStatMessages.Text = "💬 Total Messages  : " + Count(con, "SELECT COUNT(*) FROM Messages");
                labelStatRatings.Text = "⭐ Total Ratings   : " + Count(con, "SELECT COUNT(*) FROM Ratings");
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private string Count(SqlConnection con, string query)
        {
            return new SqlCommand(query, con).ExecuteScalar().ToString();
        }

        // =============================================
        // ALL POSTS
        // =============================================
        private void LoadAllPosts(string search)
        {
            listViewPosts.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT p.PostId, p.PostTitle, p.Location, p.Rent,
                           p.TenantType, p.RestrictionType, p.PostDate,
                           u.Name AS OwnerName
                    FROM Posts p
                    JOIN User_info u ON p.OwnerId = u.UserId
                    WHERE p.PostTitle LIKE @s OR p.Location LIKE @s OR u.Name LIKE @s
                    ORDER BY p.PostDate DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@s", "%" + search + "%");
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["PostId"].ToString());
                    item.SubItems.Add(dr["PostTitle"].ToString());
                    item.SubItems.Add(dr["OwnerName"].ToString());
                    item.SubItems.Add(dr["Location"].ToString());
                    item.SubItems.Add("৳ " + dr["Rent"].ToString());
                    item.SubItems.Add(dr["TenantType"].ToString());
                    item.SubItems.Add(dr["RestrictionType"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(dr["PostDate"]).ToShortDateString());
                    item.Tag = dr["PostId"].ToString();
                    listViewPosts.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnPostSearch_Click(object sender, EventArgs e) => LoadAllPosts(textPostSearch.Text.Trim());
        private void textPostSearch_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) LoadAllPosts(textPostSearch.Text.Trim()); }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            if (listViewPosts.SelectedItems.Count == 0) { MessageBox.Show("Select a post first."); return; }
            string postId = listViewPosts.SelectedItems[0].Tag.ToString();
            string title = listViewPosts.SelectedItems[0].SubItems[1].Text;

            if (MessageBox.Show($"Delete post:\n\"{title}\" ?\n\nThis will also delete all bookings & wishlists for this post.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                new SqlCommand($"DELETE FROM Wishlist WHERE PostId={postId}", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Bookings WHERE PostId={postId}", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Posts    WHERE PostId={postId}", con).ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Post deleted! 🗑️");
                LoadAllPosts(textPostSearch.Text.Trim());
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            if (listViewPosts.SelectedItems.Count == 0) { MessageBox.Show("Select a post first."); return; }
            int postId = Convert.ToInt32(listViewPosts.SelectedItems[0].Tag.ToString());
            AdminEditPost ep = new AdminEditPost(postId);
            ep.ShowDialog();
            LoadAllPosts(textPostSearch.Text.Trim());
        }

        // =============================================
        // ALL USERS
        // =============================================
        /*private void LoadAllUsers()
        {
            listViewUsers.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "SELECT UserId, Name, Email, Phone, Occupation, Role FROM User_info ORDER BY Name", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["UserId"].ToString());
                    item.SubItems.Add(dr["Name"].ToString());
                    item.SubItems.Add(dr["Email"].ToString());
                    item.SubItems.Add(dr["Phone"].ToString());
                    item.SubItems.Add(dr["Occupation"].ToString());
                    item.SubItems.Add(dr["Role"].ToString());
                    item.Tag = dr["UserId"].ToString();

                    // Color: Admin = gold, Developer = cyan, User = white
                    string role = dr["Role"].ToString();
                    item.ForeColor = role == "Admin" ? Color.Gold
                                   : role == "Developer" ? Color.Cyan
                                   : Color.FloralWhite;
                    listViewUsers.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (currentRole != "Admin") { MessageBox.Show("Only Admin can delete users! 🔒"); return; }
            if (listViewUsers.SelectedItems.Count == 0) { MessageBox.Show("Select a user first."); return; }

            string uid = listViewUsers.SelectedItems[0].Tag.ToString();
            string name = listViewUsers.SelectedItems[0].SubItems[1].Text;

            if (MessageBox.Show($"Delete user \"{name}\"?\nAll their data will also be deleted.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                new SqlCommand($"DELETE FROM Messages WHERE SenderId='{uid}' OR ReceiverId='{uid}'", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Ratings  WHERE UserId='{uid}' OR OwnerId='{uid}'", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Wishlist WHERE UserId='{uid}'", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Bookings WHERE UserId='{uid}'", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Wishlist WHERE PostId IN (SELECT PostId FROM Posts WHERE OwnerId='{uid}')", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Bookings WHERE PostId IN (SELECT PostId FROM Posts WHERE OwnerId='{uid}')", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Posts    WHERE OwnerId='{uid}'", con).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM User_info WHERE UserId='{uid}'", con).ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User deleted! 🗑️");
                LoadAllUsers();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        */
        // =============================================
        // ALL BOOKINGS
        // =============================================
        private void LoadAllBookings()
        {
            listViewBookings.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT b.BookingId, u.Name AS RenterName, ow.Name AS OwnerName,
                           p.PostTitle, p.Location, b.Status, b.BookingDate
                    FROM Bookings b
                    JOIN Posts     p  ON b.PostId  = p.PostId
                    JOIN User_info u  ON b.UserId  = u.UserId
                    JOIN User_info ow ON p.OwnerId = ow.UserId
                    ORDER BY b.BookingDate DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["BookingId"].ToString());
                    item.SubItems.Add(dr["RenterName"].ToString());
                    item.SubItems.Add(dr["OwnerName"].ToString());
                    item.SubItems.Add(dr["PostTitle"].ToString());
                    item.SubItems.Add(dr["Location"].ToString());
                    item.SubItems.Add(dr["Status"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(dr["BookingDate"]).ToShortDateString());
                    item.Tag = dr["BookingId"].ToString();

                    string status = dr["Status"].ToString();
                    item.ForeColor = status == "Confirmed" ? Color.LightGreen
                                   : status == "Rejected" ? Color.Tomato
                                   : Color.Gold;
                    listViewBookings.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnApproveBooking_Click(object sender, EventArgs e)
        {
            if (listViewBookings.SelectedItems.Count == 0) { MessageBox.Show("Select a booking first."); return; }
            UpdateBookingStatus(listViewBookings.SelectedItems[0].Tag.ToString(), "Confirmed");
        }

        private void btnRejectBooking_Click(object sender, EventArgs e)
        {
            if (listViewBookings.SelectedItems.Count == 0) { MessageBox.Show("Select a booking first."); return; }
            UpdateBookingStatus(listViewBookings.SelectedItems[0].Tag.ToString(), "Rejected");
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (listViewBookings.SelectedItems.Count == 0) { MessageBox.Show("Select a booking first."); return; }
            if (MessageBox.Show("Delete this booking?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                new SqlCommand($"DELETE FROM Bookings WHERE BookingId={listViewBookings.SelectedItems[0].Tag}", con).ExecuteNonQuery();
                // open connection first
                con.Open();
                new SqlCommand($"DELETE FROM Bookings WHERE BookingId={listViewBookings.SelectedItems[0].Tag}", con).ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Booking deleted.");
                LoadAllBookings();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void UpdateBookingStatus(string bookingId, string status)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE Bookings SET Status=@s WHERE BookingId=@id", con);
                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@id", bookingId);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show($"Booking marked as {status}! ✅");
                LoadAllBookings();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // =============================================
        // ALL MESSAGES
        // =============================================
        private void LoadAllMessages()
        {
            listViewMessages.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT m.MessageId, s.Name AS SenderName, r.Name AS ReceiverName,
                           m.MessageText, m.SentTime
                    FROM Messages m
                    JOIN User_info s ON m.SenderId   = s.UserId
                    JOIN User_info r ON m.ReceiverId = r.UserId
                    ORDER BY m.SentTime DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MessageId"].ToString());
                    item.SubItems.Add(dr["SenderName"].ToString());
                    item.SubItems.Add(dr["ReceiverName"].ToString());
                    string msg = dr["MessageText"].ToString();
                    item.SubItems.Add(msg.Length > 60 ? msg[..60] + "..." : msg);
                    item.SubItems.Add(Convert.ToDateTime(dr["SentTime"]).ToString("dd MMM  hh:mm tt"));
                    item.Tag = dr["MessageId"].ToString();
                    if (msg.StartsWith("[OFFER]")) item.ForeColor = Color.Gold;
                    listViewMessages.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            if (currentRole != "Admin") { MessageBox.Show("Only Admin can delete messages! 🔒"); return; }
            if (listViewMessages.SelectedItems.Count == 0) { MessageBox.Show("Select a message first."); return; }
            if (MessageBox.Show("Delete this message?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand($"DELETE FROM Messages WHERE MessageId={listViewMessages.SelectedItems[0].Tag}", con);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show("Message deleted.");
                LoadAllMessages();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // hover
        private void btn_MouseEnter(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(80, 0, 180); }
        private void btn_MouseLeave(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(40, 0, 80); }
    }
}