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
    public partial class ViewPost : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        string currentUserId = "";
        int selectedPostId = -1;
        string selectedOwnerId = "";

        public ViewPost(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadPosts();
        }

        private void LoadPosts()
        {
            flowPanelPosts.Controls.Clear();

            string search = textSearch.Text.Trim();
            string tenantFilter = "";
            string restrictFilter = "";

            if (chkBachelor.Checked && !chkFamily.Checked) tenantFilter = "Bachelor";
            else if (!chkBachelor.Checked && chkFamily.Checked) tenantFilter = "Family";
            if (chkRestricted.Checked && !chkFree.Checked) restrictFilter = "Restricted";
            else if (!chkRestricted.Checked && chkFree.Checked) restrictFilter = "RestrictionLess";

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT p.PostId, p.PostTitle, p.Location, p.Rent,
                           p.TenantType, p.RestrictionType, p.PostPhoto, p.PostDate,
                           u.Name AS OwnerName,
                           ISNULL((SELECT AVG(CAST(r.Rating AS FLOAT))
                                   FROM Ratings r WHERE r.OwnerId = p.OwnerId), 0) AS AvgRating
                    FROM Posts p
                    JOIN User_info u ON p.OwnerId = u.UserId
                    WHERE 1=1";

                if (search != "") query += " AND (p.PostTitle LIKE @search OR p.Location LIKE @search)";
                if (tenantFilter != "") query += " AND p.TenantType = @tenant";
                if (restrictFilter != "") query += " AND p.RestrictionType = @restrict";
                query += " ORDER BY p.PostDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                if (search != "") cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                if (tenantFilter != "") cmd.Parameters.AddWithValue("@tenant", tenantFilter);
                if (restrictFilter != "") cmd.Parameters.AddWithValue("@restrict", restrictFilter);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int postId = Convert.ToInt32(dr["PostId"]);
                    string title = dr["PostTitle"].ToString() ?? "";
                    string location = dr["Location"].ToString() ?? "";
                    int rent = Convert.ToInt32(dr["Rent"]);
                    string owner = dr["OwnerName"].ToString() ?? "";
                    double avg = Convert.ToDouble(dr["AvgRating"]);
                    string tenant = dr["TenantType"].ToString() ?? "";
                    string restrict = dr["RestrictionType"].ToString() ?? "";

                    Image? postImg = null;
                    if (dr["PostPhoto"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])dr["PostPhoto"];
                        postImg = Image.FromStream(new System.IO.MemoryStream(imgBytes));
                    }

                    Panel card = CreatePostCard(postId, title, location, rent, owner, avg, tenant, restrict, postImg);
                    flowPanelPosts.Controls.Add(card);
                }
                con.Close();

                if (flowPanelPosts.Controls.Count == 0)
                {
                    Label noPost = new Label
                    {
                        Text = "No posts found 🏠",
                        Font = new Font("Segoe UI", 14F, FontStyle.Italic),
                        ForeColor = Color.Cyan,
                        BackColor = Color.Transparent,
                        AutoSize = true,
                        Margin = new Padding(300, 120, 0, 0)
                    };
                    flowPanelPosts.Controls.Add(noPost);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading posts: " + ex.Message); }
        }

        private Panel CreatePostCard(int postId, string title, string location, int rent,
            string ownerName, double rating, string tenant, string restrict, Image? img)
        {
            Panel card = new Panel
            {
                Size = new Size(272, 318),
                BackColor = Color.FromArgb(55, 90, 55, 190),
                Margin = new Padding(10),
                Cursor = Cursors.Default
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(272, 135),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(25, 0, 55)
            };
            if (img != null) pb.Image = img;
            card.Controls.Add(pb);

            AddLabel(card, title, new Font("Segoe UI", 11F, FontStyle.Bold), Color.FloralWhite, new Point(8, 140), new Size(256, 24), true);
            AddLabel(card, "৳ " + rent.ToString("N0") + " / month",
                                     new Font("Segoe UI", 10F, FontStyle.Bold), Color.LightGreen, new Point(8, 165), new Size(256, 22), false);
            AddLabel(card, "📍 " + location,
                                     new Font("Segoe UI", 9F, FontStyle.Italic), Color.Cyan, new Point(8, 188), new Size(256, 20), true);

            string tenantTxt = tenant == "Bachelor" ? "🧑 Bachelor" : "👨‍👩‍👧 Family";
            string restrictTxt = restrict == "Restricted" ? " | 🚫 Restricted" : " | ✅ Free";
            AddLabel(card, tenantTxt + restrictTxt,
                                     new Font("Segoe UI", 8.5F, FontStyle.Italic), Color.FromArgb(200, 200, 255), new Point(8, 208), new Size(256, 20), false);
            AddLabel(card, "⭐ " + rating.ToString("0.0") + "   👤 " + ownerName,
                                     new Font("Segoe UI", 9F), Color.Gold, new Point(8, 228), new Size(256, 20), true);

            Button btnDet = MakeBtn("Details", new Point(8, 258), new Size(82, 34),
                Color.DarkSlateBlue, Color.Cyan);
            btnDet.Tag = postId;
            btnDet.Click += (s, e) => ShowDetails(Convert.ToInt32(((Button)s).Tag));
            card.Controls.Add(btnDet);

            Button btnWish = MakeBtn("🤍", new Point(100, 258), new Size(44, 34),
                Color.FromArgb(80, 20, 0), Color.Tomato);
            btnWish.Tag = postId;
            btnWish.Click += (s, e) => ToggleWishlist(Convert.ToInt32(((Button)s).Tag), (Button)s);
            card.Controls.Add(btnWish);

            Button btnBk = MakeBtn("🔖 Book", new Point(154, 258), new Size(110, 34),
                Color.FromArgb(0, 60, 20), Color.LightGreen);
            btnBk.Tag = postId;
            btnBk.Click += (s, e) => BookPost(Convert.ToInt32(((Button)s).Tag));
            card.Controls.Add(btnBk);

            return card;
        }

        private void AddLabel(Panel card, string text, Font font, Color fore,
            Point loc, Size size, bool ellipsis)
        {
            Label l = new Label
            {
                Text = text,
                Font = font,
                ForeColor = fore,
                BackColor = Color.Transparent,
                Location = loc,
                Size = size,
                AutoEllipsis = ellipsis
            };
            card.Controls.Add(l);
        }

        private Button MakeBtn(string text, Point loc, Size size, Color back, Color fore)
        {
            Button b = new Button
            {
                Text = text,
                Location = loc,
                Size = size,
                FlatStyle = FlatStyle.Flat,
                BackColor = back,
                ForeColor = fore,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderColor = fore;
            return b;
        }


        private void ShowDetails(int postId)
        {
            selectedPostId = postId;
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT p.PostTitle, p.Location, p.Rent, p.Description,
                           p.TenantType, p.RestrictionType, p.PostPhoto, p.OwnerId,
                           u.Name AS OwnerName,
                           ISNULL((SELECT AVG(CAST(r.Rating AS FLOAT))
                                   FROM Ratings r WHERE r.OwnerId = p.OwnerId), 0) AS AvgRating
                    FROM Posts p
                    JOIN User_info u ON p.OwnerId = u.UserId
                    WHERE p.PostId = @pid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pid", postId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    selectedOwnerId = dr["OwnerId"].ToString() ?? "";

                    labelDetailTitle.Text = dr["PostTitle"].ToString() ?? "";
                    labelDetailLocation.Text = "📍 " + (dr["Location"].ToString() ?? "");
                    labelDetailRent.Text = "💰 ৳ " + Convert.ToInt32(dr["Rent"]).ToString("N0") + " / month";
                    labelDetailOwner.Text = "👤 Owner: " + (dr["OwnerName"].ToString() ?? "");
                    double avg = Convert.ToDouble(dr["AvgRating"]);
                    labelDetailRating.Text = "⭐ Rating: " + avg.ToString("0.0") + " / 5";

                    string tenant = dr["TenantType"].ToString() ?? "";
                    string restrict = dr["RestrictionType"].ToString() ?? "";
                    labelDetailTags.Text = (tenant == "Bachelor" ? "🧑 Bachelor" : "👨‍👩‍👧 Family")
                                        + (restrict == "Restricted" ? "   🚫 Restricted" : "   ✅ No Restriction");

                    labelDetailDesc.Text = dr["Description"].ToString() ?? "";

                    if (dr["PostPhoto"] != DBNull.Value)
                        pictureBoxDetail.Image = Image.FromStream(
                            new System.IO.MemoryStream((byte[])dr["PostPhoto"]));
                    else
                        pictureBoxDetail.Image = null;
                }
                con.Close();
                panelDetail.Visible = true;
                panelDetail.BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ToggleWishlist(int postId, Button btn)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand chk = new SqlCommand(
                    "SELECT COUNT(*) FROM Wishlist WHERE UserId=@uid AND PostId=@pid", con);
                chk.Parameters.AddWithValue("@uid", currentUserId);
                chk.Parameters.AddWithValue("@pid", postId);
                con.Open();
                int count = Convert.ToInt32(chk.ExecuteScalar());
                con.Close();

                SqlConnection con2 = new SqlConnection(connStr);
                if (count > 0)
                {
                    SqlCommand del = new SqlCommand(
                        "DELETE FROM Wishlist WHERE UserId=@uid AND PostId=@pid", con2);
                    del.Parameters.AddWithValue("@uid", currentUserId);
                    del.Parameters.AddWithValue("@pid", postId);
                    con2.Open(); del.ExecuteNonQuery(); con2.Close();
                    btn.Text = "🤍";
                    MessageBox.Show("Removed from Wishlist.");
                }
                else
                {
                    SqlCommand ins = new SqlCommand(
                        "INSERT INTO Wishlist (UserId,PostId,AddedDate) VALUES(@uid,@pid,@d)", con2);
                    ins.Parameters.AddWithValue("@uid", currentUserId);
                    ins.Parameters.AddWithValue("@pid", postId);
                    ins.Parameters.AddWithValue("@d", DateTime.Now);
                    con2.Open(); ins.ExecuteNonQuery(); con2.Close();
                    btn.Text = "❤️";
                    MessageBox.Show("Added to Wishlist! ❤️");
                }
            }
            catch (Exception ex) { MessageBox.Show("Wishlist error: " + ex.Message); }
        }
        private void BookPost(int postId)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand chk = new SqlCommand(
                    "SELECT COUNT(*) FROM Bookings WHERE UserId=@uid AND PostId=@pid", con);
                chk.Parameters.AddWithValue("@uid", currentUserId);
                chk.Parameters.AddWithValue("@pid", postId);
                con.Open();
                int existing = Convert.ToInt32(chk.ExecuteScalar());
                con.Close();

                if (existing > 0) { MessageBox.Show("Already booked! ⚠️"); return; }

                SqlConnection con2 = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Bookings (UserId,PostId,BookingDate,Status) VALUES(@uid,@pid,@d,'Pending')", con2);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.Parameters.AddWithValue("@pid", postId);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);
                con2.Open(); cmd.ExecuteNonQuery(); con2.Close();

                BookingPopup bp = new BookingPopup();
                bp.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Booking error: " + ex.Message); }
        }
        private void btnSearch_Click(object sender, EventArgs e) => LoadPosts();
        private void textSearch_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) LoadPosts(); }
        private void chkFilter_CheckedChanged(object sender, EventArgs e) => LoadPosts();
        private void btnDetailClose_Click(object sender, EventArgs e) => panelDetail.Visible = false;
        private void btnDetailBook_Click(object sender, EventArgs e) => BookPost(selectedPostId);
        private void btnDetailWishlist_Click(object sender, EventArgs e) => ToggleWishlist(selectedPostId, btnDetailWishlist);

        private void btnDetailChat_Click(object sender, EventArgs e)
        {
            if (selectedOwnerId == "") return;
            ChatWindow cw = new ChatWindow(currentUserId, selectedOwnerId);
            cw.Show();
        }

        private void btnDetailOffer_Click(object sender, EventArgs e)
        {
            if (selectedPostId == -1) return;
            string offer = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your offer amount (৳):", "Make an Offer", "");
            if (offer.Trim() == "") return;
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Messages (SenderId,ReceiverId,MessageText,SentTime) VALUES(@s,@r,@msg,@t)", con);
                cmd.Parameters.AddWithValue("@s", currentUserId);
                cmd.Parameters.AddWithValue("@r", selectedOwnerId);
                cmd.Parameters.AddWithValue("@msg", $"[OFFER] ৳{offer} for Post #{selectedPostId}");
                cmd.Parameters.AddWithValue("@t", DateTime.Now);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show("Offer sent! 💬");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            CreatePost cp = new CreatePost(currentUserId);
            cp.ShowDialog();
            LoadPosts();
        }

        private void btnBackDash_Click(object sender, EventArgs e)
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
