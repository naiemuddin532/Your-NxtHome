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
    public partial class ChatWindow : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string senderId = "";
        string receiverId = "";
        System.Windows.Forms.Timer? refreshTimer;

        public ChatWindow(string sender, string receiver)
        {
            InitializeComponent();
            senderId = sender;
            receiverId = receiver;
            LoadReceiverName();
            LoadMessages();

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 4000;
            refreshTimer.Tick += (s, e) => LoadMessages();
            refreshTimer.Start();
        }

        private void LoadReceiverName()
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("SELECT Name FROM User_info WHERE UserId=@uid", con);
                cmd.Parameters.AddWithValue("@uid", receiverId);
                con.Open();
                object? result = cmd.ExecuteScalar();
                con.Close();
                labelChatWith.Text = "💬 Chat with: " + (result?.ToString() ?? "");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LoadMessages()
        {
            listBoxMessages.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT m.SenderId, u.Name, m.MessageText, m.SentTime
                    FROM Messages m
                    JOIN User_info u ON m.SenderId = u.UserId
                    WHERE (m.SenderId=@s AND m.ReceiverId=@r)
                       OR (m.SenderId=@r AND m.ReceiverId=@s)
                    ORDER BY m.SentTime ASC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@s", senderId);
                cmd.Parameters.AddWithValue("@r", receiverId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string who = (dr["SenderId"].ToString() ?? "") == senderId
                                  ? "You"
                                  : (dr["Name"].ToString() ?? "");
                    string time = Convert.ToDateTime(dr["SentTime"]).ToString("hh:mm tt");
                    string msg = dr["MessageText"].ToString() ?? "";
                    listBoxMessages.Items.Add($"[{time}]  {who} :  {msg}");
                }
                con.Close();

                if (listBoxMessages.Items.Count > 0)
                    listBoxMessages.TopIndex = listBoxMessages.Items.Count - 1;
            }
            catch (Exception ex) { MessageBox.Show("Error loading messages: " + ex.Message); }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textMessage.Text.Trim() == "") return;
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Messages (SenderId,ReceiverId,MessageText,SentTime) VALUES(@s,@r,@msg,@t)", con);
                cmd.Parameters.AddWithValue("@s", senderId);
                cmd.Parameters.AddWithValue("@r", receiverId);
                cmd.Parameters.AddWithValue("@msg", textMessage.Text.Trim());
                cmd.Parameters.AddWithValue("@t", DateTime.Now);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                textMessage.Clear();
                LoadMessages();
            }
            catch (Exception ex) { MessageBox.Show("Send error: " + ex.Message); }
        }

        private void textMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend_Click(sender, e);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            refreshTimer?.Stop();
            refreshTimer?.Dispose();
            base.OnFormClosed(e);
        }
    }
}