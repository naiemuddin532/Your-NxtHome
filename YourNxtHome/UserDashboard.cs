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
    public partial class UserDashboard : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        public string CurrentUserId = "";

        public UserDashboard(string userId)
        {
            InitializeComponent();
            CurrentUserId = userId;
            LoadUserInfo();
            ShowPanel(panelProfile);
        }

        private void LoadUserInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = "SELECT UserId, Name, Email, Phone, Occupation, Address, NID, ImagePath FROM User_info WHERE UserId=@uid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    labelUserId.Text = "ID : " + (dr["UserId"].ToString() ?? "");
                    labelUserName.Text = dr["Name"].ToString() ?? "";
                    labelEmail.Text = dr["Email"].ToString() ?? "";
                    labelPhone.Text = dr["Phone"].ToString() ?? "";
                    labelOccupation.Text = dr["Occupation"].ToString() ?? "";
                    labelAddress.Text = dr["Address"].ToString() ?? "";
                    labelNID.Text = dr["NID"].ToString() ?? "";

                    string imgPath = dr["ImagePath"].ToString() ?? "";
                    if (imgPath != "" && System.IO.File.Exists(imgPath))
                        pictureBoxUser.Image = Image.FromFile(imgPath);
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ShowPanel(Panel panel)
        {
            panelProfile.Visible = false;
            panelPending.Visible = false;
            panelConfirmed.Visible = false;
            panelRating.Visible = false;
            panelMessages.Visible = false;
            panelViewPost.Visible = false;
            panelWishlist.Visible = false;
            panel.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e) { ShowPanel(panelProfile); LoadUserInfo(); }
        private void btnPending_Click(object sender, EventArgs e) { ShowPanel(panelPending); LoadPendingBookings(); }
        private void btnConfirmed_Click(object sender, EventArgs e) { ShowPanel(panelConfirmed); LoadConfirmedBookings(); }
        private void btnRating_Click(object sender, EventArgs e) { ShowPanel(panelRating); LoadMyRatings(); }
        private void btnMessages_Click(object sender, EventArgs e) { ShowPanel(panelMessages); LoadInbox(); }

        private void btnBookingApproval_Click(object sender, EventArgs e)
        {
            BookingApproval ba = new BookingApproval(CurrentUserId);
            ba.ShowDialog();
        }

        private void btnViewPost_Click(object sender, EventArgs e)
        {
            ViewPost vp = new ViewPost(CurrentUserId);
            vp.Show();
            this.Hide();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            Wishlist wl = new Wishlist(CurrentUserId);
            wl.Show();
            this.Hide();
        }

        // =====================
        // EDIT PROFILE
        // =====================
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            labelUserName.Visible = false;
            labelEmail.Visible = false;
            labelPhone.Visible = false;
            labelOccupation.Visible = false;
            labelAddress.Visible = false;
            labelNID.Visible = false;

            textEditName.Text = labelUserName.Text;
            textEditEmail.Text = labelEmail.Text;
            textEditPhone.Text = labelPhone.Text;
            textEditOccupation.Text = labelOccupation.Text;
            textEditAddress.Text = labelAddress.Text;
            textEditNID.Text = labelNID.Text;
            textEditUserId.Text = CurrentUserId;
            textEditPassword.Text = "";

            textEditName.Visible = true;
            textEditEmail.Visible = true;
            textEditPhone.Visible = true;
            textEditOccupation.Visible = true;
            textEditAddress.Visible = true;
            textEditNID.Visible = true;
            textEditUserId.Visible = true;
            textEditPassword.Visible = true;
            labelNewPass.Visible = true;
            labelNewUserId.Visible = true;

            btnSaveProfile.Visible = true;
            btnEditProfile.Visible = false;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE User_info SET Name=@name, Email=@email, Phone=@phone, Occupation=@occ, Address=@addr, NID=@nid";
                bool newPass = textEditPassword.Text.Trim() != "";
                bool newUserId = textEditUserId.Text.Trim() != CurrentUserId;

                if (newPass) query += ", UserPassword=@pass";
                if (newUserId) query += ", UserId=@newuid";
                query += " WHERE UserId=@uid";

                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", textEditName.Text.Trim());
                cmd.Parameters.AddWithValue("@email", textEditEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", textEditPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@occ", textEditOccupation.Text.Trim());
                cmd.Parameters.AddWithValue("@addr", textEditAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@nid", textEditNID.Text.Trim());
                cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                if (newPass) cmd.Parameters.AddWithValue("@pass", textEditPassword.Text.Trim());
                if (newUserId)
                {
                    cmd.Parameters.AddWithValue("@newuid", textEditUserId.Text.Trim());
                    CurrentUserId = textEditUserId.Text.Trim();
                }
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show("Profile updated! ✅");

                // hide edit controls
                textEditName.Visible = textEditEmail.Visible = textEditPhone.Visible = false;
                textEditOccupation.Visible = textEditAddress.Visible = textEditNID.Visible = false;
                textEditUserId.Visible = textEditPassword.Visible = false;
                labelNewPass.Visible = labelNewUserId.Visible = false;
                btnSaveProfile.Visible = false;
                btnEditProfile.Visible = true;
                labelUserName.Visible = labelEmail.Visible = labelPhone.Visible = true;
                labelOccupation.Visible = labelAddress.Visible = labelNID.Visible = true;
                LoadUserInfo();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connStr);
                    SqlCommand cmd = new SqlCommand("UPDATE User_info SET ImagePath=@path WHERE UserId=@uid", con);
                    cmd.Parameters.AddWithValue("@path", ofd.FileName);
                    cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                    con.Open(); cmd.ExecuteNonQuery(); con.Close();
                    pictureBoxUser.Image = Image.FromFile(ofd.FileName);
                    MessageBox.Show("Photo updated! ✅");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        // =====================
        // PENDING
        // =====================
        private void LoadPendingBookings()
        {
            listBoxPending.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(@"
                    SELECT p.PostTitle, p.Location, b.BookingDate
                    FROM Bookings b JOIN Posts p ON b.PostId=p.PostId
                    WHERE b.UserId=@uid AND b.Status='Pending'", con);
                cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBoxPending.Items.Add(
                        $"📋 {dr["PostTitle"]}  |  {dr["Location"]}  |  " +
                        $"{Convert.ToDateTime(dr["BookingDate"]).ToShortDateString()}");
                con.Close();
                if (listBoxPending.Items.Count == 0)
                    listBoxPending.Items.Add("No pending bookings.");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // =====================
        // CONFIRMED
        // =====================
        private void LoadConfirmedBookings()
        {
            listBoxConfirmed.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(@"
                    SELECT p.PostTitle, p.Location, b.BookingDate
                    FROM Bookings b JOIN Posts p ON b.PostId=p.PostId
                    WHERE b.UserId=@uid AND b.Status='Confirmed'", con);
                cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBoxConfirmed.Items.Add(
                        $"✅ {dr["PostTitle"]}  |  {dr["Location"]}  |  " +
                        $"{Convert.ToDateTime(dr["BookingDate"]).ToShortDateString()}");
                con.Close();
                if (listBoxConfirmed.Items.Count == 0)
                    listBoxConfirmed.Items.Add("No confirmed bookings.");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRateOwner_Click(object sender, EventArgs e)
        {
            if (listBoxConfirmed.SelectedItem == null)
            { MessageBox.Show("Select a confirmed booking first."); return; }
            RateOwner ro = new RateOwner(CurrentUserId);
            ro.Show();
        }

        // =====================
        // RATINGS
        // =====================
        private void LoadMyRatings()
        {
            listBoxRating.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(@"
                    SELECT r.Rating, r.Comment, u.Name
                    FROM Ratings r JOIN User_info u ON r.OwnerId=u.UserId
                    WHERE r.UserId=@uid", con);
                cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string stars = new string('★', Convert.ToInt32(dr["Rating"]));
                    string name = dr["Name"].ToString() ?? "";
                    string comment = dr["Comment"].ToString() ?? "";
                    listBoxRating.Items.Add($"{stars}  |  Owner: {name}  |  {comment}");
                }
                con.Close();
                if (listBoxRating.Items.Count == 0)
                    listBoxRating.Items.Add("No ratings given yet.");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // =====================
        // INBOX
        // =====================
        private void LoadInbox()
        {
            listViewInbox.Items.Clear();
            listBoxInbox.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT DISTINCT
                        CASE WHEN m.SenderId=@uid THEN m.ReceiverId ELSE m.SenderId END AS OtherUserId,
                        u.Name AS OtherName,
                        (SELECT TOP 1 MessageText FROM Messages
                         WHERE (SenderId=@uid AND ReceiverId=u.UserId)
                            OR (SenderId=u.UserId AND ReceiverId=@uid)
                         ORDER BY SentTime DESC) AS LastMsg,
                        (SELECT TOP 1 SentTime FROM Messages
                         WHERE (SenderId=@uid AND ReceiverId=u.UserId)
                            OR (SenderId=u.UserId AND ReceiverId=@uid)
                         ORDER BY SentTime DESC) AS LastTime
                    FROM Messages m
                    JOIN User_info u
                         ON u.UserId = CASE WHEN m.SenderId=@uid THEN m.ReceiverId ELSE m.SenderId END
                    WHERE m.SenderId=@uid OR m.ReceiverId=@uid
                    ORDER BY LastTime DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", CurrentUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string otherId = dr["OtherUserId"].ToString() ?? "";
                    string otherName = dr["OtherName"].ToString() ?? "";
                    string lastMsg = dr["LastMsg"].ToString() ?? "";
                    string time = Convert.ToDateTime(dr["LastTime"]).ToString("dd MMM  hh:mm tt");

                    if (lastMsg.Length > 50) lastMsg = lastMsg[..50] + "...";

                    ListViewItem item = new ListViewItem(otherName);
                    item.SubItems.Add(lastMsg);
                    item.SubItems.Add(time);
                    item.Tag = otherId;
                    listViewInbox.Items.Add(item);
                }
                con.Close();

                if (listViewInbox.Items.Count == 0)
                {
                    listBoxInbox.Visible = true;
                    listBoxInbox.Items.Add("No messages yet.");
                }
                else
                    listBoxInbox.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error loading inbox: " + ex.Message); }
        }

        private void listViewInbox_DoubleClick(object sender, EventArgs e)
        {
            if (listViewInbox.SelectedItems.Count == 0) return;
            string otherId = listViewInbox.SelectedItems[0].Tag?.ToString() ?? "";
            if (otherId == "") return;
            ChatWindow cw = new ChatWindow(CurrentUserId, otherId);
            cw.Show();
        }

        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            if (listViewInbox.SelectedItems.Count == 0)
            { MessageBox.Show("Select a conversation first."); return; }
            string otherId = listViewInbox.SelectedItems[0].Tag?.ToString() ?? "";
            if (otherId == "") return;
            ChatWindow cw = new ChatWindow(CurrentUserId, otherId);
            cw.Show();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(80, 0, 180); }
        private void btn_MouseLeave(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(40, 0, 120); }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainpage m = new Mainpage();
            m.Show();
            this.Close();
        }
    }
}
