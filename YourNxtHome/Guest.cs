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
    public partial class Guest : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";

        public Guest()
        {
            InitializeComponent();
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
                    string title = dr["PostTitle"].ToString();
                    string location = dr["Location"].ToString();
                    int rent = Convert.ToInt32(dr["Rent"]);
                    string owner = dr["OwnerName"].ToString();
                    double avg = Convert.ToDouble(dr["AvgRating"]);
                    string tenant = dr["TenantType"].ToString();
                    string restrict = dr["RestrictionType"].ToString();

                    Image postImg = null;
                    if (dr["PostPhoto"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])dr["PostPhoto"];
                        postImg = Image.FromStream(new System.IO.MemoryStream(imgBytes));
                    }

                    Panel card = CreateCard(postId, title, location, rent, owner, avg, tenant, restrict, postImg);
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
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private Panel CreateCard(int postId, string title, string location, int rent,
            string ownerName, double rating, string tenant, string restrict, Image postImg)
        {
            Panel card = new Panel
            {
                Size = new Size(272, 300),
                BackColor = Color.FromArgb(55, 90, 55, 190),
                Margin = new Padding(10)
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(272, 130),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(25, 0, 55)
            };
            if (postImg != null) pb.Image = postImg;
            card.Controls.Add(pb);

            AddLbl(card, title, new Font("Segoe UI", 11F, FontStyle.Bold), Color.FloralWhite, new Point(8, 136), new Size(256, 24), true);
            AddLbl(card, "৳ " + rent.ToString("N0") + " / month",
                         new Font("Segoe UI", 10F, FontStyle.Bold), Color.LightGreen, new Point(8, 161), new Size(256, 22), false);
            AddLbl(card, "📍 " + location,
                         new Font("Segoe UI", 9F, FontStyle.Italic), Color.Cyan, new Point(8, 183), new Size(256, 20), true);

            string tenantTxt = tenant == "Bachelor" ? "🧑 Bachelor" : "👨‍👩‍👧 Family";
            string restrictTxt = restrict == "Restricted" ? " | 🚫 Restricted" : " | ✅ Free";
            AddLbl(card, tenantTxt + restrictTxt,
                         new Font("Segoe UI", 8.5F, FontStyle.Italic), Color.FromArgb(200, 200, 255), new Point(8, 203), new Size(256, 20), false);
            AddLbl(card, "⭐ " + rating.ToString("0.0") + "   👤 " + ownerName,
                         new Font("Segoe UI", 9F), Color.Gold, new Point(8, 222), new Size(256, 20), true);

            // Details button only — no book/chat/offer for guest
            Button btnDet = new Button
            {
                Text = "🔍 Details",
                Location = new Point(8, 253),
                Size = new Size(256, 34),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.DarkSlateBlue,
                ForeColor = Color.Cyan,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Tag = postId
            };
            btnDet.FlatAppearance.BorderColor = Color.Cyan;
            btnDet.Click += (s, e) => ShowDetails(Convert.ToInt32(((Button)s).Tag));
            card.Controls.Add(btnDet);

            return card;
        }

        private void ShowDetails(int postId)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = @"
                    SELECT p.PostTitle, p.Location, p.Rent, p.Description,
                           p.TenantType, p.RestrictionType, p.PostPhoto,
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
                    labelDetailTitle.Text = dr["PostTitle"].ToString();
                    labelDetailLocation.Text = "📍 " + dr["Location"].ToString();
                    labelDetailRent.Text = "💰 ৳ " + Convert.ToInt32(dr["Rent"]).ToString("N0") + " / month";
                    labelDetailOwner.Text = "👤 Owner: " + dr["OwnerName"].ToString();
                    double avg = Convert.ToDouble(dr["AvgRating"]);
                    labelDetailRating.Text = "⭐ " + avg.ToString("0.0") + " / 5";
                    string tenant = dr["TenantType"].ToString();
                    string restrict = dr["RestrictionType"].ToString();
                    labelDetailTags.Text = (tenant == "Bachelor" ? "🧑 Bachelor" : "👨‍👩‍👧 Family")
                                        + (restrict == "Restricted" ? "   🚫 Restricted" : "   ✅ No Restriction");
                    labelDetailDesc.Text = dr["Description"].ToString();

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

        private void AddLbl(Panel p, string text, Font font, Color fore, Point loc, Size size, bool ellipsis)
        {
            p.Controls.Add(new Label
            {
                Text = text,
                Font = font,
                ForeColor = fore,
                BackColor = Color.Transparent,
                Location = loc,
                Size = size,
                AutoEllipsis = ellipsis
            });
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadPosts();
        private void textSearch_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) LoadPosts(); }
        private void chkFilter_CheckedChanged(object sender, EventArgs e) => LoadPosts();
        private void btnDetailClose_Click(object sender, EventArgs e) => panelDetail.Visible = false;

        private void btnLoginToBook_Click(object sender, EventArgs e)
        {
            // Prompt guest to sign in
            MessageBox.Show("Please Sign In or Sign Up to book, chat, or make offers! 🔐",
                            "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Signin si = new Signin();
            si.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainpage m = new Mainpage();
            m.Show();
            this.Close();
        }

    }
}