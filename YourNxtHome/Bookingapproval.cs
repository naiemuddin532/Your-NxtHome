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
    public partial class BookingApproval : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string ownerUserId = "";

        // Stores selected booking id and renter id for approve/reject
        int selectedBookingId = -1;
        string selectedRenterId = "";

        public BookingApproval(string ownerId)
        {
            InitializeComponent();
            ownerUserId = ownerId;
            LoadPendingRequests();
        }

        // Load all pending bookings for posts owned by this user
        private void LoadPendingRequests()
        {
            listViewRequests.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT b.BookingId, b.UserId AS RenterId, u.Name AS RenterName,
                           p.PostTitle, p.Location, b.BookingDate
                    FROM Bookings b
                    JOIN Posts     p ON b.PostId  = p.PostId
                    JOIN User_info u ON b.UserId  = u.UserId
                    WHERE p.OwnerId = @oid AND b.Status = 'Pending'
                    ORDER BY b.BookingDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@oid", ownerUserId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["BookingId"].ToString());
                    item.SubItems.Add(dr["RenterName"].ToString());
                    item.SubItems.Add(dr["PostTitle"].ToString());
                    item.SubItems.Add(dr["Location"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(dr["BookingDate"]).ToString("dd MMM yyyy  hh:mm tt"));
                    item.Tag = dr["BookingId"].ToString() + "|" + dr["RenterId"].ToString();
                    listViewRequests.Items.Add(item);
                }
                con.Close();

                if (listViewRequests.Items.Count == 0)
                    labelNoRequest.Visible = true;
                else
                    labelNoRequest.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void listViewRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRequests.SelectedItems.Count == 0) return;

            string tag = listViewRequests.SelectedItems[0].Tag.ToString();
            string[] parts = tag.Split('|');
            selectedBookingId = Convert.ToInt32(parts[0]);
            selectedRenterId = parts[1];

            btnAccept.Enabled = true;
            btnReject.Enabled = true;
        }

        // =====================
        // ACCEPT BOOKING
        // =====================
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (selectedBookingId == -1) return;

            DialogResult confirm = MessageBox.Show(
                "Accept this booking request?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                // 1. Update booking status to Confirmed
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmdUpd = new SqlCommand(
                    "UPDATE Bookings SET Status='Confirmed' WHERE BookingId=@bid", con);
                cmdUpd.Parameters.AddWithValue("@bid", selectedBookingId);
                con.Open(); cmdUpd.ExecuteNonQuery(); con.Close();

                // 2. Send confirmation message to renter
                string confirmMsg = "✅ Great news! Your booking request has been ACCEPTED by the owner. " +
                                    "Please contact the owner to confirm further details.";
                SendMessage(ownerUserId, selectedRenterId, confirmMsg);

                MessageBox.Show("Booking ACCEPTED! ✅ A confirmation message has been sent to the renter.");
                selectedBookingId = -1;
                selectedRenterId = "";
                btnAccept.Enabled = false;
                btnReject.Enabled = false;
                LoadPendingRequests();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // =====================
        // REJECT BOOKING
        // =====================
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (selectedBookingId == -1) return;

            DialogResult confirm = MessageBox.Show(
                "Reject this booking request?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                // 1. Delete the booking (or set status to Rejected)
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmdDel = new SqlCommand(
                    "UPDATE Bookings SET Status='Rejected' WHERE BookingId=@bid", con);
                cmdDel.Parameters.AddWithValue("@bid", selectedBookingId);
                con.Open(); cmdDel.ExecuteNonQuery(); con.Close();

                // 2. Send rejection message to renter
                string rejectMsg = "❌ Sorry! Your booking request has been declined by the owner. " +
                                   "You may try other available posts.";
                SendMessage(ownerUserId, selectedRenterId, rejectMsg);

                MessageBox.Show("Booking REJECTED. A notification has been sent to the renter.");
                selectedBookingId = -1;
                selectedRenterId = "";
                btnAccept.Enabled = false;
                btnReject.Enabled = false;
                LoadPendingRequests();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // =====================
        // SEND MESSAGE HELPER
        // =====================
        private void SendMessage(string senderId, string receiverId, string text)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Messages (SenderId,ReceiverId,MessageText,SentTime) VALUES(@s,@r,@msg,@t)", con);
            cmd.Parameters.AddWithValue("@s", senderId);
            cmd.Parameters.AddWithValue("@r", receiverId);
            cmd.Parameters.AddWithValue("@msg", text);
            cmd.Parameters.AddWithValue("@t", DateTime.Now);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadPendingRequests();

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
