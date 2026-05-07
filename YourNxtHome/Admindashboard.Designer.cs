#nullable disable

namespace YourNxtHome
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Sidebar controls
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelAdminTitle = new System.Windows.Forms.Label();
            this.labelAdminSub = new System.Windows.Forms.Label();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnAllPosts = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            // Overview panel
            this.panelOverview = new System.Windows.Forms.Panel();
            this.labelOvTitle = new System.Windows.Forms.Label();
            this.labelStatUsers = new System.Windows.Forms.Label();
            this.labelStatPosts = new System.Windows.Forms.Label();
            this.labelStatBookings = new System.Windows.Forms.Label();
            this.labelStatPending = new System.Windows.Forms.Label();
            this.labelStatConfirmed = new System.Windows.Forms.Label();
            this.labelStatRejected = new System.Windows.Forms.Label();
            this.labelStatMessages = new System.Windows.Forms.Label();
            this.labelStatRatings = new System.Windows.Forms.Label();

            // All Posts panel
            this.panelAllPosts = new System.Windows.Forms.Panel();
            this.labelPostsTitle = new System.Windows.Forms.Label();
            this.textPostSearch = new System.Windows.Forms.TextBox();
            this.btnPostSearch = new System.Windows.Forms.Button();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.colPId = new System.Windows.Forms.ColumnHeader();
            this.colPTitle = new System.Windows.Forms.ColumnHeader();
            this.colPOwner = new System.Windows.Forms.ColumnHeader();
            this.colPLoc = new System.Windows.Forms.ColumnHeader();
            this.colPRent = new System.Windows.Forms.ColumnHeader();
            this.colPTenant = new System.Windows.Forms.ColumnHeader();
            this.colPRestrict = new System.Windows.Forms.ColumnHeader();
            this.colPDate = new System.Windows.Forms.ColumnHeader();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.btnEditPost = new System.Windows.Forms.Button();

            // All Users panel
           /* this.panelAllUsers = new System.Windows.Forms.Panel();
            this.labelUsersTitle = new System.Windows.Forms.Label();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.colUId = new System.Windows.Forms.ColumnHeader();
            this.colUName = new System.Windows.Forms.ColumnHeader();
            this.colUEmail = new System.Windows.Forms.ColumnHeader();
            this.colUPhone = new System.Windows.Forms.ColumnHeader();
            this.colUOcc = new System.Windows.Forms.ColumnHeader();
            this.colURole = new System.Windows.Forms.ColumnHeader();
            this.btnDeleteUser = new System.Windows.Forms.Button();*/
            // Bookings panel
            this.panelBookings = new System.Windows.Forms.Panel();
            this.labelBookingsTitle = new System.Windows.Forms.Label();
            this.listViewBookings = new System.Windows.Forms.ListView();
            this.colBId = new System.Windows.Forms.ColumnHeader();
            this.colBRenter = new System.Windows.Forms.ColumnHeader();
            this.colBOwner = new System.Windows.Forms.ColumnHeader();
            this.colBPost = new System.Windows.Forms.ColumnHeader();
            this.colBLoc = new System.Windows.Forms.ColumnHeader();
            this.colBStatus = new System.Windows.Forms.ColumnHeader();
            this.colBDate = new System.Windows.Forms.ColumnHeader();
            this.btnApproveBooking = new System.Windows.Forms.Button();
            this.btnRejectBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();

            // Messages panel
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMsgTitle = new System.Windows.Forms.Label();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.colMId = new System.Windows.Forms.ColumnHeader();
            this.colMSender = new System.Windows.Forms.ColumnHeader();
            this.colMReceiver = new System.Windows.Forms.ColumnHeader();
            this.colMText = new System.Windows.Forms.ColumnHeader();
            this.colMTime = new System.Windows.Forms.ColumnHeader();
            this.btnDeleteMessage = new System.Windows.Forms.Button();

            this.panelSidebar.SuspendLayout();
            this.panelOverview.SuspendLayout();
            this.panelAllPosts.SuspendLayout();
            this.panelBookings.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.SuspendLayout();

            // ===========================
            // FORM
            // ===========================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Name = "AdminDashboard";
            this.Text = "Your NxtHome - Admin Panel";

            // ===========================
            // SIDEBAR
            // ===========================
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(200, 10, 0, 30);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(235, 700);

            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminTitle.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic);
            this.labelAdminTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelAdminTitle.Location = new System.Drawing.Point(18, 15);
            this.labelAdminTitle.Text = "Admin Panel";

            this.labelAdminSub.AutoSize = true;
            this.labelAdminSub.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.labelAdminSub.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            this.labelAdminSub.Location = new System.Drawing.Point(22, 45);
            this.labelAdminSub.Text = "Your NxtHome";

            // Sidebar buttons  y=75, step=48
            SB(this.btnOverview, "📊  Overview", 75);
            SB(this.btnAllPosts, "🏠  All Posts", 123);
            SB(this.btnUserInfo, "🗂️  User Info", 171);
            SB(this.btnBookings, "📋  All Bookings", 219);
            SB(this.btnMessages, "💬  All Messages", 267);
            SB(this.btnBack, "← Sign Out", 630);
            this.btnBack.ForeColor = System.Drawing.Color.Tomato;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;

            // Wire events
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            this.btnAllPosts.Click += new System.EventHandler(this.btnAllPosts_Click);
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.panelSidebar.Controls.Add(this.labelAdminTitle);
            this.panelSidebar.Controls.Add(this.labelAdminSub);
            this.panelSidebar.Controls.Add(this.btnOverview);
            this.panelSidebar.Controls.Add(this.btnAllPosts);
            this.panelSidebar.Controls.Add(this.btnUserInfo);
            this.panelSidebar.Controls.Add(this.btnBookings);
            this.panelSidebar.Controls.Add(this.btnMessages);
            this.panelSidebar.Controls.Add(this.btnBack);

            // ===========================
            // OVERVIEW PANEL
            // ===========================
            MakePanel(this.panelOverview, true);

            this.labelOvTitle.AutoSize = true;
            this.labelOvTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelOvTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelOvTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelOvTitle.Location = new System.Drawing.Point(245, 20);
            this.labelOvTitle.Text = "📊 Platform Overview";

            // Two columns of stat cards
            int sx1 = 50, sx2 = 510, sy = 90, sg = 70;
            StatCard(this.labelStatUsers, sx1, sy);
            StatCard(this.labelStatPosts, sx1, sy + sg);
            StatCard(this.labelStatBookings, sx1, sy + sg * 2);
            StatCard(this.labelStatMessages, sx1, sy + sg * 3);
            StatCard(this.labelStatPending, sx2, sy);
            StatCard(this.labelStatConfirmed, sx2, sy + sg);
            StatCard(this.labelStatRejected, sx2, sy + sg * 2);
            StatCard(this.labelStatRatings, sx2, sy + sg * 3);

            this.panelOverview.Controls.Add(this.labelOvTitle);
            this.panelOverview.Controls.Add(this.labelStatUsers);
            this.panelOverview.Controls.Add(this.labelStatPosts);
            this.panelOverview.Controls.Add(this.labelStatBookings);
            this.panelOverview.Controls.Add(this.labelStatMessages);
            this.panelOverview.Controls.Add(this.labelStatPending);
            this.panelOverview.Controls.Add(this.labelStatConfirmed);
            this.panelOverview.Controls.Add(this.labelStatRejected);
            this.panelOverview.Controls.Add(this.labelStatRatings);

            // ===========================
            // ALL POSTS PANEL
            // ===========================
            MakePanel(this.panelAllPosts, false);

            this.labelPostsTitle.AutoSize = true;
            this.labelPostsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPostsTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelPostsTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelPostsTitle.Location = new System.Drawing.Point(280, 16);
            this.labelPostsTitle.Text = "🏠 All Posts";

            this.textPostSearch.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            this.textPostSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textPostSearch.Location = new System.Drawing.Point(28, 60);
            this.textPostSearch.PlaceholderText = "Search title / location / owner...";
            this.textPostSearch.Size = new System.Drawing.Size(340, 32);
            this.textPostSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPostSearch_KeyDown);

            this.btnPostSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPostSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostSearch.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPostSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPostSearch.ForeColor = System.Drawing.Color.Cyan;
            this.btnPostSearch.Location = new System.Drawing.Point(380, 60);
            this.btnPostSearch.Size = new System.Drawing.Size(110, 32);
            this.btnPostSearch.Text = "🔍 Search";
            this.btnPostSearch.Click += new System.EventHandler(this.btnPostSearch_Click);

            MakeLV(this.listViewPosts, 28, 103, 900, 490);
            this.listViewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colPId, this.colPTitle, this.colPOwner, this.colPLoc,
                this.colPRent, this.colPTenant, this.colPRestrict, this.colPDate });
            this.colPId.Text = "ID"; this.colPId.Width = 40;
            this.colPTitle.Text = "Title"; this.colPTitle.Width = 175;
            this.colPOwner.Text = "Owner"; this.colPOwner.Width = 130;
            this.colPLoc.Text = "Location"; this.colPLoc.Width = 130;
            this.colPRent.Text = "Rent"; this.colPRent.Width = 80;
            this.colPTenant.Text = "Tenant"; this.colPTenant.Width = 80;
            this.colPRestrict.Text = "Type"; this.colPRestrict.Width = 110;
            this.colPDate.Text = "Date"; this.colPDate.Width = 90;

            MakeBtn(this.btnDeletePost, "🗑️ Delete Post", 28, 610, System.Drawing.Color.FromArgb(80, 15, 0), System.Drawing.Color.Tomato);
            MakeBtn(this.btnEditPost, "✏️ Edit Post", 222, 610, System.Drawing.Color.DarkSlateBlue, System.Drawing.Color.Cyan);
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            this.btnEditPost.Click += new System.EventHandler(this.btnEditPost_Click);

            this.panelAllPosts.Controls.Add(this.labelPostsTitle);
            this.panelAllPosts.Controls.Add(this.textPostSearch);
            this.panelAllPosts.Controls.Add(this.btnPostSearch);
            this.panelAllPosts.Controls.Add(this.listViewPosts);
            this.panelAllPosts.Controls.Add(this.btnDeletePost);
            this.panelAllPosts.Controls.Add(this.btnEditPost);

            // ===========================
            // BOOKINGS PANEL
            // ===========================
            MakePanel(this.panelBookings, false);

            this.labelBookingsTitle.AutoSize = true;
            this.labelBookingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelBookingsTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelBookingsTitle.Location = new System.Drawing.Point(275, 16);
            this.labelBookingsTitle.Text = "📋 All Bookings";

            MakeLV(this.listViewBookings, 28, 60, 900, 536);
            this.listViewBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colBId, this.colBRenter, this.colBOwner, this.colBPost,
                this.colBLoc, this.colBStatus, this.colBDate });
            this.colBId.Text = "ID"; this.colBId.Width = 40;
            this.colBRenter.Text = "Renter"; this.colBRenter.Width = 140;
            this.colBOwner.Text = "Owner"; this.colBOwner.Width = 140;
            this.colBPost.Text = "Post"; this.colBPost.Width = 185;
            this.colBLoc.Text = "Location"; this.colBLoc.Width = 118;
            this.colBStatus.Text = "Status"; this.colBStatus.Width = 88;
            this.colBDate.Text = "Date"; this.colBDate.Width = 90;

            MakeBtn(this.btnApproveBooking, "✅ Approve", 28, 608, System.Drawing.Color.FromArgb(0, 70, 20), System.Drawing.Color.LightGreen);
            MakeBtn(this.btnRejectBooking, "❌ Reject", 218, 608, System.Drawing.Color.FromArgb(80, 15, 0), System.Drawing.Color.Tomato);
            MakeBtn(this.btnDeleteBooking, "🗑️ Delete", 408, 608, System.Drawing.Color.FromArgb(40, 0, 80), System.Drawing.Color.FromArgb(180, 130, 255));
            this.btnApproveBooking.Click += new System.EventHandler(this.btnApproveBooking_Click);
            this.btnRejectBooking.Click += new System.EventHandler(this.btnRejectBooking_Click);
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);

            this.panelBookings.Controls.Add(this.labelBookingsTitle);
            this.panelBookings.Controls.Add(this.listViewBookings);
            this.panelBookings.Controls.Add(this.btnApproveBooking);
            this.panelBookings.Controls.Add(this.btnRejectBooking);
            this.panelBookings.Controls.Add(this.btnDeleteBooking);

            // ===========================
            // MESSAGES PANEL
            // ===========================
            MakePanel(this.panelMessages, false);

            this.labelMsgTitle.AutoSize = true;
            this.labelMsgTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelMsgTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelMsgTitle.Location = new System.Drawing.Point(270, 16);
            this.labelMsgTitle.Text = "💬 All Messages";

            MakeLV(this.listViewMessages, 28, 60, 900, 536);
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMId, this.colMSender, this.colMReceiver, this.colMText, this.colMTime });
            this.colMId.Text = "ID"; this.colMId.Width = 40;
            this.colMSender.Text = "From"; this.colMSender.Width = 140;
            this.colMReceiver.Text = "To"; this.colMReceiver.Width = 140;
            this.colMText.Text = "Message"; this.colMText.Width = 390;
            this.colMTime.Text = "Time"; this.colMTime.Width = 165;

            MakeBtn(this.btnDeleteMessage, "🗑️ Delete Message", 28, 608, System.Drawing.Color.FromArgb(80, 15, 0), System.Drawing.Color.Tomato);
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);

            this.panelMessages.Controls.Add(this.labelMsgTitle);
            this.panelMessages.Controls.Add(this.listViewMessages);
            this.panelMessages.Controls.Add(this.btnDeleteMessage);

            // ===========================
            // ADD ALL TO FORM
            // ===========================
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelOverview);
            this.Controls.Add(this.panelAllPosts);
            this.Controls.Add(this.panelBookings);
            this.Controls.Add(this.panelMessages);

            this.panelSidebar.ResumeLayout(false); this.panelSidebar.PerformLayout();
            this.panelOverview.ResumeLayout(false); this.panelOverview.PerformLayout();
            this.panelAllPosts.ResumeLayout(false); this.panelAllPosts.PerformLayout();
            this.panelBookings.ResumeLayout(false); this.panelBookings.PerformLayout();
            this.panelMessages.ResumeLayout(false); this.panelMessages.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── helpers ──────────────────────────────────────────────
        private void SB(System.Windows.Forms.Button b, string text, int y)
        {
            b.BackColor = System.Drawing.Color.FromArgb(40, 0, 80);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            b.ForeColor = System.Drawing.Color.Gold;
            b.Location = new System.Drawing.Point(5, y);
            b.Size = new System.Drawing.Size(223, 42);
            b.Text = text;
            b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            b.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            b.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
        }

        private void MakePanel(System.Windows.Forms.Panel p, bool visible)
        {
            p.BackColor = System.Drawing.Color.Transparent;
            p.Location = new System.Drawing.Point(235, 0);
            p.Size = new System.Drawing.Size(965, 700);
            p.Visible = visible;
        }

        private void StatCard(System.Windows.Forms.Label l, int x, int y)
        {
            l.AutoSize = false;
            l.BackColor = System.Drawing.Color.FromArgb(60, 255, 255, 255);
            l.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            l.ForeColor = System.Drawing.Color.FloralWhite;
            l.Location = new System.Drawing.Point(x, y);
            l.Size = new System.Drawing.Size(400, 55);
            l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            l.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            l.Text = "Loading...";
        }

        private void MakeLV(System.Windows.Forms.ListView lv, int x, int y, int w, int h)
        {
            lv.BackColor = System.Drawing.Color.FromArgb(18, 0, 48);
            lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lv.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            lv.ForeColor = System.Drawing.Color.FloralWhite;
            lv.FullRowSelect = true;
            lv.GridLines = false;
            lv.Location = new System.Drawing.Point(x, y);
            lv.Size = new System.Drawing.Size(w, h);
            lv.View = System.Windows.Forms.View.Details;
        }

        private void MakeBtn(System.Windows.Forms.Button b, string text, int x, int y,
            System.Drawing.Color back, System.Drawing.Color fore)
        {
            b.BackColor = back;
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = fore;
            b.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            b.ForeColor = fore;
            b.Location = new System.Drawing.Point(x, y);
            b.Size = new System.Drawing.Size(180, 44);
            b.Text = text;
        }

        #endregion

        // ── field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelAdminTitle, labelAdminSub;
        private System.Windows.Forms.Button btnOverview, btnAllPosts, btnAllUsers;
        private System.Windows.Forms.Button btnBookings, btnMessages, btnUserInfo, btnBack;

        private System.Windows.Forms.Panel panelOverview;
        private System.Windows.Forms.Label labelOvTitle;
        private System.Windows.Forms.Label labelStatUsers, labelStatPosts, labelStatBookings, labelStatMessages;
        private System.Windows.Forms.Label labelStatPending, labelStatConfirmed, labelStatRejected, labelStatRatings;

        private System.Windows.Forms.Panel panelAllPosts;
        private System.Windows.Forms.Label labelPostsTitle;
        private System.Windows.Forms.TextBox textPostSearch;
        private System.Windows.Forms.Button btnPostSearch, btnDeletePost, btnEditPost;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.ColumnHeader colPId, colPTitle, colPOwner, colPLoc;
        private System.Windows.Forms.ColumnHeader colPRent, colPTenant, colPRestrict, colPDate;

        private System.Windows.Forms.Panel panelAllUsers;
        private System.Windows.Forms.Label labelUsersTitle;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader colUId, colUName, colUEmail, colUPhone, colUOcc, colURole;

        private System.Windows.Forms.Panel panelBookings;
        private System.Windows.Forms.Label labelBookingsTitle;
        private System.Windows.Forms.ListView listViewBookings;
        private System.Windows.Forms.ColumnHeader colBId, colBRenter, colBOwner, colBPost, colBLoc, colBStatus, colBDate;
        private System.Windows.Forms.Button btnApproveBooking, btnRejectBooking, btnDeleteBooking;

        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelMsgTitle;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader colMId, colMSender, colMReceiver, colMText, colMTime;
        private System.Windows.Forms.Button btnDeleteMessage;
    }
}