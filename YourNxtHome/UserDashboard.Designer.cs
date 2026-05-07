
namespace YourNxtHome
{
    partial class UserDashboard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnViewPost = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnConfirmed = new System.Windows.Forms.Button();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnBookingApproval = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelProfileTitle = new System.Windows.Forms.Label();
            this.labelNameHead = new System.Windows.Forms.Label();
            this.labelEmailHead = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneHead = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelOccHead = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelAddrHead = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNIDHead = new System.Windows.Forms.Label();
            this.labelNID = new System.Windows.Forms.Label();
            this.labelNewUserId = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textEditName = new System.Windows.Forms.TextBox();
            this.textEditEmail = new System.Windows.Forms.TextBox();
            this.textEditPhone = new System.Windows.Forms.TextBox();
            this.textEditOccupation = new System.Windows.Forms.TextBox();
            this.textEditAddress = new System.Windows.Forms.TextBox();
            this.textEditNID = new System.Windows.Forms.TextBox();
            this.textEditUserId = new System.Windows.Forms.TextBox();
            this.textEditPassword = new System.Windows.Forms.TextBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnChangePhoto = new System.Windows.Forms.Button();

            this.panelPending = new System.Windows.Forms.Panel();
            this.labelPendingTitle = new System.Windows.Forms.Label();
            this.listBoxPending = new System.Windows.Forms.ListBox();

            this.panelConfirmed = new System.Windows.Forms.Panel();
            this.labelConfirmedTitle = new System.Windows.Forms.Label();
            this.listBoxConfirmed = new System.Windows.Forms.ListBox();
            this.btnRateOwner = new System.Windows.Forms.Button();

            this.panelRating = new System.Windows.Forms.Panel();
            this.labelRatingTitle = new System.Windows.Forms.Label();
            this.listBoxRating = new System.Windows.Forms.ListBox();

            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMessagesTitle = new System.Windows.Forms.Label();
            this.listViewInbox = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colLastMsg = new System.Windows.Forms.ColumnHeader();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.listBoxInbox = new System.Windows.Forms.ListBox();
            this.btnOpenChat = new System.Windows.Forms.Button();

            this.panelViewPost = new System.Windows.Forms.Panel();
            this.labelViewPostInfo = new System.Windows.Forms.Label();
            this.panelWishlist = new System.Windows.Forms.Panel();
            this.labelWishlistInfo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelPending.SuspendLayout();
            this.panelConfirmed.SuspendLayout();
            this.panelRating.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.SuspendLayout();

            // ===========================
            // FORM
            // ===========================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Name = "UserDashboard";
            this.Text = "Your NxtHome - Dashboard";

            // ===========================
            // SIDEBAR PANEL
            // ===========================
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(80, 20, 0, 80);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(230, 700);

            this.labelAppName.AutoSize = true;
            this.labelAppName.BackColor = System.Drawing.Color.Transparent;
            this.labelAppName.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Italic);
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            this.labelAppName.Location = new System.Drawing.Point(22, 12);
            this.labelAppName.Text = "Your NxtHome";

            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(60, 255, 255, 255);
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(65, 46);
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;

            this.labelUserName.AutoSize = false;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelUserName.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelUserName.Location = new System.Drawing.Point(5, 152);
            this.labelUserName.Size = new System.Drawing.Size(220, 26);
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserName.Text = "Username";

            this.labelUserId.AutoSize = false;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.labelUserId.ForeColor = System.Drawing.Color.Cyan;
            this.labelUserId.Location = new System.Drawing.Point(5, 178);
            this.labelUserId.Size = new System.Drawing.Size(220, 20);
            this.labelUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserId.Text = "ID: ---";

            // Sidebar buttons — y=206, step=44
            SB(this.btnProfile, "👤  My Profile", 206);
            SB(this.btnViewPost, "🏠  View Posts", 250);
            SB(this.btnWishlist, "❤️  Wishlist", 294);
            SB(this.btnPending, "⏳  Pending Booking", 338);
            SB(this.btnConfirmed, "✅  Confirmed Booking", 382);
            SB(this.btnRating, "⭐  My Ratings", 426);
            SB(this.btnMessages, "💬  Messages", 470);
            SB(this.btnBookingApproval, "📋  Booking Requests", 514);
            SB(this.btnBack, "← Sign Out", 648);
            this.btnBack.ForeColor = System.Drawing.Color.Tomato;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;

            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnViewPost.Click += new System.EventHandler(this.btnViewPost_Click);
            this.btnWishlist.Click += new System.EventHandler(this.btnWishlist_Click);
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            this.btnConfirmed.Click += new System.EventHandler(this.btnConfirmed_Click);
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            this.btnBookingApproval.Click += new System.EventHandler(this.btnBookingApproval_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.panelSidebar.Controls.Add(this.labelAppName);
            this.panelSidebar.Controls.Add(this.pictureBoxUser);
            this.panelSidebar.Controls.Add(this.labelUserName);
            this.panelSidebar.Controls.Add(this.labelUserId);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnViewPost);
            this.panelSidebar.Controls.Add(this.btnWishlist);
            this.panelSidebar.Controls.Add(this.btnPending);
            this.panelSidebar.Controls.Add(this.btnConfirmed);
            this.panelSidebar.Controls.Add(this.btnRating);
            this.panelSidebar.Controls.Add(this.btnMessages);
            this.panelSidebar.Controls.Add(this.btnBookingApproval);
            this.panelSidebar.Controls.Add(this.btnBack);

            // ===========================
            // PROFILE PANEL
            // ===========================
            this.panelProfile.BackColor = System.Drawing.Color.Transparent;
            this.panelProfile.Location = new System.Drawing.Point(230, 0);
            this.panelProfile.Size = new System.Drawing.Size(870, 700);
            this.panelProfile.Visible = true;

            this.labelProfileTitle.AutoSize = true;
            this.labelProfileTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelProfileTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelProfileTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelProfileTitle.Location = new System.Drawing.Point(255, 18);
            this.labelProfileTitle.Text = "👤 My Profile";

            int lx = 40, vx = 210, ew = 340;
            int y1 = 65, y2 = 112, y3 = 159, y4 = 206, y5 = 253, y6 = 300, y7 = 350, y8 = 397;

            HL(this.labelNameHead, "Name :", lx, y1);
            VL(this.labelUserName, "---", vx, y1);
            TB(this.textEditName, vx, y1 - 2, ew);

            HL(this.labelEmailHead, "Email :", lx, y2);
            VL(this.labelEmail, "---", vx, y2);
            TB(this.textEditEmail, vx, y2 - 2, ew);

            HL(this.labelPhoneHead, "Phone :", lx, y3);
            VL(this.labelPhone, "---", vx, y3);
            TB(this.textEditPhone, vx, y3 - 2, ew);

            HL(this.labelOccHead, "Occupation :", lx, y4);
            VL(this.labelOccupation, "---", vx, y4);
            TB(this.textEditOccupation, vx, y4 - 2, ew);

            HL(this.labelAddrHead, "Address :", lx, y5);
            VL(this.labelAddress, "---", vx, y5);
            TB(this.textEditAddress, vx, y5 - 2, ew);

            HL(this.labelNIDHead, "NID :", lx, y6);
            VL(this.labelNID, "---", vx, y6);
            TB(this.textEditNID, vx, y6 - 2, ew);

            this.labelNewUserId.AutoSize = true;
            this.labelNewUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelNewUserId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelNewUserId.ForeColor = System.Drawing.Color.Cyan;
            this.labelNewUserId.Location = new System.Drawing.Point(lx, y7);
            this.labelNewUserId.Text = "New User ID :";
            this.labelNewUserId.Visible = false;
            TB(this.textEditUserId, vx, y7 - 2, ew);

            this.labelNewPass.AutoSize = true;
            this.labelNewPass.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelNewPass.ForeColor = System.Drawing.Color.Cyan;
            this.labelNewPass.Location = new System.Drawing.Point(lx, y8);
            this.labelNewPass.Text = "New Password :";
            this.labelNewPass.Visible = false;
            TB(this.textEditPassword, vx, y8 - 2, ew);
            this.textEditPassword.UseSystemPasswordChar = true;

            this.btnEditProfile.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnEditProfile.ForeColor = System.Drawing.Color.Cyan;
            this.btnEditProfile.Location = new System.Drawing.Point(lx, 452);
            this.btnEditProfile.Size = new System.Drawing.Size(175, 42);
            this.btnEditProfile.Text = "✏️ Edit Profile";
            this.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);

            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(0, 80, 20);
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.LightGreen;
            this.btnSaveProfile.Location = new System.Drawing.Point(lx, 452);
            this.btnSaveProfile.Size = new System.Drawing.Size(175, 42);
            this.btnSaveProfile.Text = "💾 Save Changes";
            this.btnSaveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProfile.Visible = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);

            this.btnChangePhoto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhoto.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnChangePhoto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnChangePhoto.ForeColor = System.Drawing.Color.Cyan;
            this.btnChangePhoto.Location = new System.Drawing.Point(lx + 195, 452);
            this.btnChangePhoto.Size = new System.Drawing.Size(175, 42);
            this.btnChangePhoto.Text = "📷 Change Photo";
            this.btnChangePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);

            this.panelProfile.Controls.Add(this.labelProfileTitle);
            this.panelProfile.Controls.Add(this.labelNameHead); this.panelProfile.Controls.Add(this.labelUserName);
            this.panelProfile.Controls.Add(this.labelEmailHead); this.panelProfile.Controls.Add(this.labelEmail);
            this.panelProfile.Controls.Add(this.labelPhoneHead); this.panelProfile.Controls.Add(this.labelPhone);
            this.panelProfile.Controls.Add(this.labelOccHead); this.panelProfile.Controls.Add(this.labelOccupation);
            this.panelProfile.Controls.Add(this.labelAddrHead); this.panelProfile.Controls.Add(this.labelAddress);
            this.panelProfile.Controls.Add(this.labelNIDHead); this.panelProfile.Controls.Add(this.labelNID);
            this.panelProfile.Controls.Add(this.labelNewUserId); this.panelProfile.Controls.Add(this.textEditUserId);
            this.panelProfile.Controls.Add(this.textEditName); this.panelProfile.Controls.Add(this.textEditEmail);
            this.panelProfile.Controls.Add(this.textEditPhone); this.panelProfile.Controls.Add(this.textEditOccupation);
            this.panelProfile.Controls.Add(this.textEditAddress); this.panelProfile.Controls.Add(this.textEditNID);
            this.panelProfile.Controls.Add(this.labelNewPass); this.panelProfile.Controls.Add(this.textEditPassword);
            this.panelProfile.Controls.Add(this.btnEditProfile); this.panelProfile.Controls.Add(this.btnSaveProfile);
            this.panelProfile.Controls.Add(this.btnChangePhoto);

            // ===========================
            // PENDING PANEL
            // ===========================
            this.panelPending.BackColor = System.Drawing.Color.Transparent;
            this.panelPending.Location = new System.Drawing.Point(230, 0);
            this.panelPending.Size = new System.Drawing.Size(870, 700);
            this.panelPending.Visible = false;

            this.labelPendingTitle.AutoSize = true;
            this.labelPendingTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPendingTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelPendingTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelPendingTitle.Location = new System.Drawing.Point(235, 24);
            this.labelPendingTitle.Text = "⏳ Pending Bookings";

            this.listBoxPending.BackColor = System.Drawing.Color.FromArgb(20, 0, 50);
            this.listBoxPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPending.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listBoxPending.ForeColor = System.Drawing.Color.FloralWhite;
            this.listBoxPending.Location = new System.Drawing.Point(35, 75);
            this.listBoxPending.Size = new System.Drawing.Size(800, 520);

            this.panelPending.Controls.Add(this.labelPendingTitle);
            this.panelPending.Controls.Add(this.listBoxPending);

            // ===========================
            // CONFIRMED PANEL
            // ===========================
            this.panelConfirmed.BackColor = System.Drawing.Color.Transparent;
            this.panelConfirmed.Location = new System.Drawing.Point(230, 0);
            this.panelConfirmed.Size = new System.Drawing.Size(870, 700);
            this.panelConfirmed.Visible = false;

            this.labelConfirmedTitle.AutoSize = true;
            this.labelConfirmedTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmedTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelConfirmedTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelConfirmedTitle.Location = new System.Drawing.Point(210, 24);
            this.labelConfirmedTitle.Text = "✅ Confirmed Bookings";

            this.listBoxConfirmed.BackColor = System.Drawing.Color.FromArgb(20, 0, 50);
            this.listBoxConfirmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxConfirmed.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listBoxConfirmed.ForeColor = System.Drawing.Color.FloralWhite;
            this.listBoxConfirmed.Location = new System.Drawing.Point(35, 75);
            this.listBoxConfirmed.Size = new System.Drawing.Size(800, 450);

            this.btnRateOwner.BackColor = System.Drawing.Color.FromArgb(60, 50, 0);
            this.btnRateOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRateOwner.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnRateOwner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnRateOwner.ForeColor = System.Drawing.Color.Gold;
            this.btnRateOwner.Location = new System.Drawing.Point(35, 540);
            this.btnRateOwner.Size = new System.Drawing.Size(175, 42);
            this.btnRateOwner.Text = "⭐ Rate Owner";
            this.btnRateOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRateOwner.Click += new System.EventHandler(this.btnRateOwner_Click);

            this.panelConfirmed.Controls.Add(this.labelConfirmedTitle);
            this.panelConfirmed.Controls.Add(this.listBoxConfirmed);
            this.panelConfirmed.Controls.Add(this.btnRateOwner);

            // ===========================
            // RATING PANEL
            // ===========================
            this.panelRating.BackColor = System.Drawing.Color.Transparent;
            this.panelRating.Location = new System.Drawing.Point(230, 0);
            this.panelRating.Size = new System.Drawing.Size(870, 700);
            this.panelRating.Visible = false;

            this.labelRatingTitle.AutoSize = true;
            this.labelRatingTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelRatingTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelRatingTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelRatingTitle.Location = new System.Drawing.Point(240, 24);
            this.labelRatingTitle.Text = "⭐ My Ratings Given";

            this.listBoxRating.BackColor = System.Drawing.Color.FromArgb(20, 0, 50);
            this.listBoxRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listBoxRating.ForeColor = System.Drawing.Color.Gold;
            this.listBoxRating.Location = new System.Drawing.Point(35, 75);
            this.listBoxRating.Size = new System.Drawing.Size(800, 520);

            this.panelRating.Controls.Add(this.labelRatingTitle);
            this.panelRating.Controls.Add(this.listBoxRating);

            // ===========================
            // MESSAGES PANEL
            // ===========================
            this.panelMessages.BackColor = System.Drawing.Color.Transparent;
            this.panelMessages.Location = new System.Drawing.Point(230, 0);
            this.panelMessages.Size = new System.Drawing.Size(870, 700);
            this.panelMessages.Visible = false;

            this.labelMessagesTitle.AutoSize = true;
            this.labelMessagesTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMessagesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelMessagesTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelMessagesTitle.Location = new System.Drawing.Point(265, 24);
            this.labelMessagesTitle.Text = "💬 My Messages";

            this.listViewInbox.BackColor = System.Drawing.Color.FromArgb(20, 0, 50);
            this.listViewInbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewInbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listViewInbox.ForeColor = System.Drawing.Color.FloralWhite;
            this.listViewInbox.FullRowSelect = true;
            this.listViewInbox.GridLines = false;
            this.listViewInbox.Location = new System.Drawing.Point(35, 75);
            this.listViewInbox.Size = new System.Drawing.Size(800, 490);
            this.listViewInbox.View = System.Windows.Forms.View.Details;
            this.listViewInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colName, this.colLastMsg, this.colTime
            });
            this.listViewInbox.DoubleClick += new System.EventHandler(this.listViewInbox_DoubleClick);

            this.colName.Text = "From / To";
            this.colName.Width = 155;
            this.colLastMsg.Text = "Last Message";
            this.colLastMsg.Width = 435;
            this.colTime.Text = "Time";
            this.colTime.Width = 185;

            this.listBoxInbox.BackColor = System.Drawing.Color.FromArgb(20, 0, 50);
            this.listBoxInbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxInbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.listBoxInbox.ForeColor = System.Drawing.Color.Cyan;
            this.listBoxInbox.Location = new System.Drawing.Point(35, 580);
            this.listBoxInbox.Size = new System.Drawing.Size(500, 26);
            this.listBoxInbox.Visible = false;

            this.btnOpenChat.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOpenChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenChat.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOpenChat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnOpenChat.ForeColor = System.Drawing.Color.Cyan;
            this.btnOpenChat.Location = new System.Drawing.Point(35, 584);
            this.btnOpenChat.Size = new System.Drawing.Size(200, 42);
            this.btnOpenChat.Text = "💬 Open Chat";
            this.btnOpenChat.Click += new System.EventHandler(this.btnOpenChat_Click);

            this.panelMessages.Controls.Add(this.labelMessagesTitle);
            this.panelMessages.Controls.Add(this.listViewInbox);
            this.panelMessages.Controls.Add(this.listBoxInbox);
            this.panelMessages.Controls.Add(this.btnOpenChat);

            // ===========================
            // PLACEHOLDER PANELS
            // ===========================
            this.panelViewPost.BackColor = System.Drawing.Color.Transparent;
            this.panelViewPost.Location = new System.Drawing.Point(230, 0);
            this.panelViewPost.Size = new System.Drawing.Size(870, 700);
            this.panelViewPost.Visible = false;
            this.labelViewPostInfo.AutoSize = true;
            this.labelViewPostInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelViewPostInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.labelViewPostInfo.ForeColor = System.Drawing.Color.Cyan;
            this.labelViewPostInfo.Location = new System.Drawing.Point(200, 300);
            this.labelViewPostInfo.Text = "Opening View Posts...";
            this.panelViewPost.Controls.Add(this.labelViewPostInfo);

            this.panelWishlist.BackColor = System.Drawing.Color.Transparent;
            this.panelWishlist.Location = new System.Drawing.Point(230, 0);
            this.panelWishlist.Size = new System.Drawing.Size(870, 700);
            this.panelWishlist.Visible = false;
            this.labelWishlistInfo.AutoSize = true;
            this.labelWishlistInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelWishlistInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.labelWishlistInfo.ForeColor = System.Drawing.Color.Cyan;
            this.labelWishlistInfo.Location = new System.Drawing.Point(200, 300);
            this.labelWishlistInfo.Text = "Opening Wishlist...";
            this.panelWishlist.Controls.Add(this.labelWishlistInfo);

            // ===========================
            // ADD ALL TO FORM
            // ===========================
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelPending);
            this.Controls.Add(this.panelConfirmed);
            this.Controls.Add(this.panelRating);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelViewPost);
            this.Controls.Add(this.panelWishlist);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelSidebar.ResumeLayout(false); this.panelSidebar.PerformLayout();
            this.panelProfile.ResumeLayout(false); this.panelProfile.PerformLayout();
            this.panelPending.ResumeLayout(false); this.panelPending.PerformLayout();
            this.panelConfirmed.ResumeLayout(false); this.panelConfirmed.PerformLayout();
            this.panelRating.ResumeLayout(false); this.panelRating.PerformLayout();
            this.panelMessages.ResumeLayout(false); this.panelMessages.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── helpers ──────────────────────────────────────
        private void SB(System.Windows.Forms.Button b, string text, int y)
        {
            b.BackColor = System.Drawing.Color.FromArgb(40, 0, 120);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 0, 200, 255);
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            b.ForeColor = System.Drawing.Color.Cyan;
            b.Location = new System.Drawing.Point(5, y);
            b.Size = new System.Drawing.Size(218, 40);
            b.Text = text;
            b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            b.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            b.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
        }
        private void HL(System.Windows.Forms.Label l, string t, int x, int y)
        {
            l.AutoSize = true; l.BackColor = System.Drawing.Color.Transparent;
            l.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            l.ForeColor = System.Drawing.Color.Cyan; l.Location = new System.Drawing.Point(x, y); l.Text = t;
        }
        private void VL(System.Windows.Forms.Label l, string t, int x, int y)
        {
            l.AutoSize = true; l.BackColor = System.Drawing.Color.Transparent;
            l.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            l.ForeColor = System.Drawing.Color.FloralWhite; l.Location = new System.Drawing.Point(x, y); l.Text = t;
        }
        private void TB(System.Windows.Forms.TextBox tb, int x, int y, int w)
        {
            tb.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            tb.Font = new System.Drawing.Font("Segoe UI", 11F);
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(w, 32);
            tb.Visible = false;
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelAppName, labelUserId;
        private System.Windows.Forms.Button btnProfile, btnViewPost, btnWishlist;
        private System.Windows.Forms.Button btnPending, btnConfirmed, btnRating;
        private System.Windows.Forms.Button btnMessages, btnBookingApproval, btnBack;

        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label labelProfileTitle;
        private System.Windows.Forms.Label labelNameHead, labelUserName;
        private System.Windows.Forms.Label labelEmailHead, labelEmail;
        private System.Windows.Forms.Label labelPhoneHead, labelPhone;
        private System.Windows.Forms.Label labelOccHead, labelOccupation;
        private System.Windows.Forms.Label labelAddrHead, labelAddress;
        private System.Windows.Forms.Label labelNIDHead, labelNID;
        private System.Windows.Forms.Label labelNewUserId, labelNewPass;
        private System.Windows.Forms.TextBox textEditName, textEditEmail, textEditPhone;
        private System.Windows.Forms.TextBox textEditOccupation, textEditAddress, textEditNID;
        private System.Windows.Forms.TextBox textEditUserId, textEditPassword;
        private System.Windows.Forms.Button btnEditProfile, btnSaveProfile, btnChangePhoto;

        private System.Windows.Forms.Panel panelPending;
        private System.Windows.Forms.Label labelPendingTitle;
        private System.Windows.Forms.ListBox listBoxPending;

        private System.Windows.Forms.Panel panelConfirmed;
        private System.Windows.Forms.Label labelConfirmedTitle;
        private System.Windows.Forms.ListBox listBoxConfirmed;
        private System.Windows.Forms.Button btnRateOwner;

        private System.Windows.Forms.Panel panelRating;
        private System.Windows.Forms.Label labelRatingTitle;
        private System.Windows.Forms.ListBox listBoxRating;

        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelMessagesTitle;
        private System.Windows.Forms.ListView listViewInbox;
        private System.Windows.Forms.ColumnHeader colName, colLastMsg, colTime;
        private System.Windows.Forms.ListBox listBoxInbox;
        private System.Windows.Forms.Button btnOpenChat;

        private System.Windows.Forms.Panel panelViewPost;
        private System.Windows.Forms.Label labelViewPostInfo;
        private System.Windows.Forms.Panel panelWishlist;
        private System.Windows.Forms.Label labelWishlistInfo;
    }
}