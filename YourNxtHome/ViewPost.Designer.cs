#nullable disable

namespace YourNxtHome
{
    partial class ViewPost
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
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btnBackDash = new System.Windows.Forms.Button();
            this.labelFilterTenant = new System.Windows.Forms.Label();
            this.chkBachelor = new System.Windows.Forms.CheckBox();
            this.chkFamily = new System.Windows.Forms.CheckBox();
            this.labelFilterRestrict = new System.Windows.Forms.Label();
            this.chkRestricted = new System.Windows.Forms.CheckBox();
            this.chkFree = new System.Windows.Forms.CheckBox();
            this.flowPanelPosts = new System.Windows.Forms.FlowLayoutPanel();

            // Detail panel
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnDetailClose = new System.Windows.Forms.Button();
            this.pictureBoxDetail = new System.Windows.Forms.PictureBox();
            this.labelDetailHeader = new System.Windows.Forms.Label();
            this.labelDetailTitle = new System.Windows.Forms.Label();
            this.labelDetailLocation = new System.Windows.Forms.Label();
            this.labelDetailRent = new System.Windows.Forms.Label();
            this.labelDetailOwner = new System.Windows.Forms.Label();
            this.labelDetailRating = new System.Windows.Forms.Label();
            this.labelDetailTags = new System.Windows.Forms.Label();
            this.labelDetailDesc = new System.Windows.Forms.Label();
            // Action buttons inside detail
            this.btnDetailBook = new System.Windows.Forms.Button();
            this.btnDetailWishlist = new System.Windows.Forms.Button();
            this.btnDetailChat = new System.Windows.Forms.Button();
            this.btnDetailOffer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();

            // ===========================
            // FORM
            // ===========================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Name = "ViewPost";
            this.Text = "Your NxtHome - View Posts";

            // ===========================
            // TOP BAR  (y=16)
            // ===========================
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAppTitle.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Italic);
            this.labelAppTitle.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            this.labelAppTitle.Location = new System.Drawing.Point(14, 16);
            this.labelAppTitle.Text = "Your NxtHome";

            this.textSearch.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textSearch.Location = new System.Drawing.Point(190, 16);
            this.textSearch.PlaceholderText = "🔍 Search by title or location...";
            this.textSearch.Size = new System.Drawing.Size(340, 32);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);

            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Cyan;
            this.btnSearch.Location = new System.Drawing.Point(542, 16);
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnCreatePost.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCreatePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePost.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnCreatePost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnCreatePost.ForeColor = System.Drawing.Color.Cyan;
            this.btnCreatePost.Location = new System.Drawing.Point(665, 16);
            this.btnCreatePost.Size = new System.Drawing.Size(150, 32);
            this.btnCreatePost.Text = "➕ Create Post";
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);

            this.btnBackDash.BackColor = System.Drawing.Color.FromArgb(80, 20, 0);
            this.btnBackDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackDash.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnBackDash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnBackDash.ForeColor = System.Drawing.Color.Tomato;
            this.btnBackDash.Location = new System.Drawing.Point(1098, 16);
            this.btnBackDash.Size = new System.Drawing.Size(140, 32);
            this.btnBackDash.Text = "🏠 Dashboard";
            this.btnBackDash.Click += new System.EventHandler(this.btnBackDash_Click);

            // ===========================
            // FILTER BAR  (y=58)
            // ===========================
            this.labelFilterTenant.AutoSize = true;
            this.labelFilterTenant.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterTenant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelFilterTenant.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelFilterTenant.Location = new System.Drawing.Point(14, 60);
            this.labelFilterTenant.Text = "Tenant:";

            Ck(this.chkBachelor, "🧑 Bachelor", 90, 58);
            Ck(this.chkFamily, "👨‍👩‍👧 Family", 210, 58);

            this.labelFilterRestrict.AutoSize = true;
            this.labelFilterRestrict.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterRestrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelFilterRestrict.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelFilterRestrict.Location = new System.Drawing.Point(348, 60);
            this.labelFilterRestrict.Text = "Type:";

            Ck(this.chkRestricted, "🚫 Restricted", 408, 58);
            Ck(this.chkFree, "✅ RestrictionLess", 538, 58);

            this.chkBachelor.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            this.chkFamily.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            this.chkRestricted.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            this.chkFree.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);

            // ===========================
            // FLOW PANEL  (y=88)
            // ===========================
            this.flowPanelPosts.AutoScroll = true;
            this.flowPanelPosts.BackColor = System.Drawing.Color.Transparent;
            this.flowPanelPosts.Location = new System.Drawing.Point(0, 88);
            this.flowPanelPosts.Size = new System.Drawing.Size(1250, 632);
            this.flowPanelPosts.Padding = new System.Windows.Forms.Padding(10);
            this.flowPanelPosts.WrapContents = true;

            // ===========================
            // DETAIL PANEL (overlay, right side)
            // ===========================
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(235, 12, 0, 42);
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Location = new System.Drawing.Point(638, 55);
            this.panelDetail.Size = new System.Drawing.Size(604, 660);
            this.panelDetail.Visible = false;

            // Close button  ✖
            this.btnDetailClose.BackColor = System.Drawing.Color.FromArgb(80, 20, 0);
            this.btnDetailClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailClose.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnDetailClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetailClose.ForeColor = System.Drawing.Color.Tomato;
            this.btnDetailClose.Location = new System.Drawing.Point(556, 6);
            this.btnDetailClose.Size = new System.Drawing.Size(40, 34);
            this.btnDetailClose.Text = "✖";
            this.btnDetailClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailClose.Click += new System.EventHandler(this.btnDetailClose_Click);

            // Post image
            this.pictureBoxDetail.BackColor = System.Drawing.Color.FromArgb(30, 0, 60);
            this.pictureBoxDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetail.Location = new System.Drawing.Point(14, 48);
            this.pictureBoxDetail.Size = new System.Drawing.Size(574, 210);
            this.pictureBoxDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetail.TabIndex = 0;
            this.pictureBoxDetail.TabStop = false;

            // "Post Details" header
            this.labelDetailHeader.AutoSize = true;
            this.labelDetailHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelDetailHeader.ForeColor = System.Drawing.Color.Cyan;
            this.labelDetailHeader.Location = new System.Drawing.Point(14, 12);
            this.labelDetailHeader.Text = "📄 Post Details";

            // Info labels
            DL(this.labelDetailTitle, 14, 268, 574, 13F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.Color.FloralWhite, 32);
            DL(this.labelDetailLocation, 14, 305, 574, 10F, System.Drawing.FontStyle.Italic, System.Drawing.Color.Cyan, 24);
            DL(this.labelDetailRent, 14, 330, 574, 10F, System.Drawing.FontStyle.Bold, System.Drawing.Color.LightGreen, 24);
            DL(this.labelDetailOwner, 14, 355, 574, 10F, System.Drawing.FontStyle.Italic, System.Drawing.Color.FloralWhite, 24);
            DL(this.labelDetailRating, 14, 380, 574, 10F, System.Drawing.FontStyle.Bold, System.Drawing.Color.Gold, 24);
            DL(this.labelDetailTags, 14, 405, 574, 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.Color.FromArgb(200, 200, 255), 24);

            this.labelDetailDesc.AutoSize = false;
            this.labelDetailDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelDetailDesc.ForeColor = System.Drawing.Color.FromArgb(210, 210, 255);
            this.labelDetailDesc.Location = new System.Drawing.Point(14, 432);
            this.labelDetailDesc.Size = new System.Drawing.Size(574, 64);
            this.labelDetailDesc.Text = "";

            // ===========================
            // ACTION BUTTONS (y=506..570)
            // Row 1: Book | Wishlist
            // Row 2: Chat | Make Offer
            // ===========================

            // 🔖 Book
            this.btnDetailBook.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDetailBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailBook.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnDetailBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnDetailBook.ForeColor = System.Drawing.Color.Cyan;
            this.btnDetailBook.Location = new System.Drawing.Point(14, 506);
            this.btnDetailBook.Size = new System.Drawing.Size(274, 46);
            this.btnDetailBook.Text = "🔖 Book Now";
            this.btnDetailBook.Click += new System.EventHandler(this.btnDetailBook_Click);

            // 🤍 Wishlist
            this.btnDetailWishlist.BackColor = System.Drawing.Color.FromArgb(80, 0, 40);
            this.btnDetailWishlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailWishlist.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnDetailWishlist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnDetailWishlist.ForeColor = System.Drawing.Color.Tomato;
            this.btnDetailWishlist.Location = new System.Drawing.Point(300, 506);
            this.btnDetailWishlist.Size = new System.Drawing.Size(288, 46);
            this.btnDetailWishlist.Text = "🤍 Add to Wishlist";
            this.btnDetailWishlist.Click += new System.EventHandler(this.btnDetailWishlist_Click);

            // 💬 Chat with Owner
            this.btnDetailChat.BackColor = System.Drawing.Color.FromArgb(0, 55, 80);
            this.btnDetailChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailChat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 200, 255);
            this.btnDetailChat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnDetailChat.ForeColor = System.Drawing.Color.FromArgb(0, 220, 255);
            this.btnDetailChat.Location = new System.Drawing.Point(14, 562);
            this.btnDetailChat.Size = new System.Drawing.Size(274, 46);
            this.btnDetailChat.Text = "💬 Chat with Owner";
            this.btnDetailChat.Click += new System.EventHandler(this.btnDetailChat_Click);

            // 💸 Make an Offer
            this.btnDetailOffer.BackColor = System.Drawing.Color.FromArgb(40, 65, 0);
            this.btnDetailOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailOffer.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnDetailOffer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnDetailOffer.ForeColor = System.Drawing.Color.LightGreen;
            this.btnDetailOffer.Location = new System.Drawing.Point(300, 562);
            this.btnDetailOffer.Size = new System.Drawing.Size(288, 46);
            this.btnDetailOffer.Text = "💸 Make an Offer";
            this.btnDetailOffer.Click += new System.EventHandler(this.btnDetailOffer_Click);

            // Add to detail panel
            this.panelDetail.Controls.Add(this.labelDetailHeader);
            this.panelDetail.Controls.Add(this.btnDetailClose);
            this.panelDetail.Controls.Add(this.pictureBoxDetail);
            this.panelDetail.Controls.Add(this.labelDetailTitle);
            this.panelDetail.Controls.Add(this.labelDetailLocation);
            this.panelDetail.Controls.Add(this.labelDetailRent);
            this.panelDetail.Controls.Add(this.labelDetailOwner);
            this.panelDetail.Controls.Add(this.labelDetailRating);
            this.panelDetail.Controls.Add(this.labelDetailTags);
            this.panelDetail.Controls.Add(this.labelDetailDesc);
            this.panelDetail.Controls.Add(this.btnDetailBook);
            this.panelDetail.Controls.Add(this.btnDetailWishlist);
            this.panelDetail.Controls.Add(this.btnDetailChat);
            this.panelDetail.Controls.Add(this.btnDetailOffer);

            // Add to form
            this.Controls.Add(this.labelAppTitle);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.btnBackDash);
            this.Controls.Add(this.labelFilterTenant);
            this.Controls.Add(this.chkBachelor);
            this.Controls.Add(this.chkFamily);
            this.Controls.Add(this.labelFilterRestrict);
            this.Controls.Add(this.chkRestricted);
            this.Controls.Add(this.chkFree);
            this.Controls.Add(this.flowPanelPosts);
            this.Controls.Add(this.panelDetail);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetail)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Ck(System.Windows.Forms.CheckBox cb, string text, int x, int y)
        {
            cb.AutoSize = true;
            cb.BackColor = System.Drawing.Color.Transparent;
            cb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cb.ForeColor = System.Drawing.Color.FloralWhite;
            cb.Location = new System.Drawing.Point(x, y);
            cb.Text = text;
            cb.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void DL(System.Windows.Forms.Label lbl, int x, int y, int w,
            float size, System.Drawing.FontStyle style,
            System.Drawing.Color fore, int h)
        {
            lbl.AutoSize = false;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Segoe UI", size, style);
            lbl.ForeColor = fore;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(w, h);
            lbl.Text = "";
        }

        #endregion

        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch, btnCreatePost, btnBackDash;
        private System.Windows.Forms.Label labelFilterTenant, labelFilterRestrict;
        private System.Windows.Forms.CheckBox chkBachelor, chkFamily, chkRestricted, chkFree;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPosts;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnDetailClose;
        private System.Windows.Forms.PictureBox pictureBoxDetail;
        private System.Windows.Forms.Label labelDetailHeader;
        private System.Windows.Forms.Label labelDetailTitle, labelDetailLocation;
        private System.Windows.Forms.Label labelDetailRent, labelDetailOwner;
        private System.Windows.Forms.Label labelDetailRating, labelDetailTags, labelDetailDesc;
        private System.Windows.Forms.Button btnDetailBook, btnDetailWishlist;
        private System.Windows.Forms.Button btnDetailChat, btnDetailOffer;
    }
}