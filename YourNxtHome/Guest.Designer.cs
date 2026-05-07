#nullable disable

namespace YourNxtHome
{
    partial class Guest
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
            labelAppTitle = new Label();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnLoginToBook = new Button();
            btnBack = new Button();
            labelGuestNote = new Label();
            labelFilterTenant = new Label();
            chkBachelor = new CheckBox();
            chkFamily = new CheckBox();
            labelFilterRestrict = new Label();
            chkRestricted = new CheckBox();
            chkFree = new CheckBox();
            flowPanelPosts = new FlowLayoutPanel();
            panelDetail = new Panel();
            btnDetailClose = new Button();
            pictureBoxDetail = new PictureBox();
            labelDetailTitle = new Label();
            labelDetailLocation = new Label();
            labelDetailRent = new Label();
            labelDetailOwner = new Label();
            labelDetailRating = new Label();
            labelDetailTags = new Label();
            labelDetailDesc = new Label();
            labelLoginPrompt = new Label();
            btnDetailLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetail).BeginInit();
            SuspendLayout();
            // 
            // labelAppTitle
            // 
            labelAppTitle.AutoSize = true;
            labelAppTitle.BackColor = Color.Transparent;
            labelAppTitle.Font = new Font("Algerian", 13F, FontStyle.Italic);
            labelAppTitle.ForeColor = Color.FromArgb(128, 255, 255);
            labelAppTitle.Location = new Point(14, 14);
            labelAppTitle.Name = "labelAppTitle";
            labelAppTitle.Size = new Size(172, 25);
            labelAppTitle.TabIndex = 0;
            labelAppTitle.Text = "Your NxtHome";
            // 
            // textSearch
            // 
            textSearch.BackColor = Color.FromArgb(220, 210, 240);
            textSearch.Font = new Font("Segoe UI", 11F);
            textSearch.Location = new Point(190, 16);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "🔍 Search by title or location...";
            textSearch.Size = new Size(340, 32);
            textSearch.TabIndex = 1;
            textSearch.KeyDown += textSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Cyan;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Cyan;
            btnSearch.Location = new Point(542, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoginToBook
            // 
            btnLoginToBook.BackColor = Color.DarkSlateBlue;
            btnLoginToBook.Cursor = Cursors.Hand;
            btnLoginToBook.FlatAppearance.BorderColor = Color.Cyan;
            btnLoginToBook.FlatStyle = FlatStyle.Flat;
            btnLoginToBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnLoginToBook.ForeColor = Color.Cyan;
            btnLoginToBook.Location = new Point(1010, 14);
            btnLoginToBook.Name = "btnLoginToBook";
            btnLoginToBook.Size = new Size(120, 32);
            btnLoginToBook.TabIndex = 4;
            btnLoginToBook.Text = "🔐 Sign In";
            btnLoginToBook.UseVisualStyleBackColor = false;
            btnLoginToBook.Click += btnLoginToBook_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(80, 20, 0);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.Tomato;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnBack.ForeColor = Color.Tomato;
            btnBack.Location = new Point(1142, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 32);
            btnBack.TabIndex = 5;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelGuestNote
            // 
            labelGuestNote.AutoSize = true;
            labelGuestNote.BackColor = Color.Transparent;
            labelGuestNote.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelGuestNote.ForeColor = Color.Yellow;
            labelGuestNote.Location = new Point(648, 20);
            labelGuestNote.Name = "labelGuestNote";
            labelGuestNote.Size = new Size(356, 17);
            labelGuestNote.TabIndex = 3;
            labelGuestNote.Text = "👀 Browsing as Guest — Sign In to Book, Chat or Make Offers";
            // 
            // labelFilterTenant
            // 
            labelFilterTenant.AutoSize = true;
            labelFilterTenant.BackColor = Color.Transparent;
            labelFilterTenant.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            labelFilterTenant.ForeColor = Color.FloralWhite;
            labelFilterTenant.Location = new Point(14, 60);
            labelFilterTenant.Name = "labelFilterTenant";
            labelFilterTenant.Size = new Size(70, 23);
            labelFilterTenant.TabIndex = 6;
            labelFilterTenant.Text = "Tenant:";
            // 
            // chkBachelor
            // 
            chkBachelor.BackColor = Color.Transparent;
            chkBachelor.Location = new Point(90, 61);
            chkBachelor.Name = "chkBachelor";
            chkBachelor.Size = new Size(36, 24);
            chkBachelor.TabIndex = 7;
            chkBachelor.UseVisualStyleBackColor = false;
            chkBachelor.CheckedChanged += chkFilter_CheckedChanged;
            // 
            // chkFamily
            // 
            chkFamily.BackColor = Color.Transparent;
            chkFamily.Location = new Point(216, 58);
            chkFamily.Name = "chkFamily";
            chkFamily.Size = new Size(19, 24);
            chkFamily.TabIndex = 8;
            chkFamily.UseVisualStyleBackColor = false;
            chkFamily.CheckedChanged += chkFilter_CheckedChanged;
            // 
            // labelFilterRestrict
            // 
            labelFilterRestrict.AutoSize = true;
            labelFilterRestrict.BackColor = Color.Transparent;
            labelFilterRestrict.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            labelFilterRestrict.ForeColor = Color.FloralWhite;
            labelFilterRestrict.Location = new Point(318, 60);
            labelFilterRestrict.Name = "labelFilterRestrict";
            labelFilterRestrict.Size = new Size(53, 23);
            labelFilterRestrict.TabIndex = 9;
            labelFilterRestrict.Text = "Type:";
            // 
            // chkRestricted
            // 
            chkRestricted.BackColor = Color.Transparent;
            chkRestricted.Location = new Point(377, 59);
            chkRestricted.Name = "chkRestricted";
            chkRestricted.Size = new Size(17, 24);
            chkRestricted.TabIndex = 10;
            chkRestricted.UseVisualStyleBackColor = false;
            chkRestricted.CheckedChanged += chkFilter_CheckedChanged;
            // 
            // chkFree
            // 
            chkFree.BackColor = Color.Transparent;
            chkFree.ForeColor = Color.Black;
            chkFree.Location = new Point(486, 58);
            chkFree.Name = "chkFree";
            chkFree.Size = new Size(21, 24);
            chkFree.TabIndex = 11;
            chkFree.UseVisualStyleBackColor = false;
            chkFree.CheckedChanged += chkFilter_CheckedChanged;
            // 
            // flowPanelPosts
            // 
            flowPanelPosts.AutoScroll = true;
            flowPanelPosts.BackColor = Color.Transparent;
            flowPanelPosts.Location = new Point(0, 88);
            flowPanelPosts.Name = "flowPanelPosts";
            flowPanelPosts.Padding = new Padding(10);
            flowPanelPosts.Size = new Size(1250, 632);
            flowPanelPosts.TabIndex = 12;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.FromArgb(230, 15, 0, 45);
            panelDetail.BorderStyle = BorderStyle.FixedSingle;
            panelDetail.Controls.Add(btnDetailClose);
            panelDetail.Controls.Add(pictureBoxDetail);
            panelDetail.Controls.Add(labelDetailTitle);
            panelDetail.Controls.Add(labelDetailLocation);
            panelDetail.Controls.Add(labelDetailRent);
            panelDetail.Controls.Add(labelDetailOwner);
            panelDetail.Controls.Add(labelDetailRating);
            panelDetail.Controls.Add(labelDetailTags);
            panelDetail.Controls.Add(labelDetailDesc);
            panelDetail.Controls.Add(labelLoginPrompt);
            panelDetail.Controls.Add(btnDetailLogin);
            panelDetail.Location = new Point(660, 55);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(580, 655);
            panelDetail.TabIndex = 13;
            panelDetail.Visible = false;
            // 
            // btnDetailClose
            // 
            btnDetailClose.BackColor = Color.FromArgb(80, 20, 0);
            btnDetailClose.Cursor = Cursors.Hand;
            btnDetailClose.FlatAppearance.BorderColor = Color.Tomato;
            btnDetailClose.FlatStyle = FlatStyle.Flat;
            btnDetailClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDetailClose.ForeColor = Color.Tomato;
            btnDetailClose.Location = new Point(530, 8);
            btnDetailClose.Name = "btnDetailClose";
            btnDetailClose.Size = new Size(40, 32);
            btnDetailClose.TabIndex = 0;
            btnDetailClose.Text = "✖";
            btnDetailClose.UseVisualStyleBackColor = false;
            btnDetailClose.Click += btnDetailClose_Click;
            // 
            // pictureBoxDetail
            // 
            pictureBoxDetail.BackColor = Color.FromArgb(30, 0, 60);
            pictureBoxDetail.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDetail.Location = new Point(15, 50);
            pictureBoxDetail.Name = "pictureBoxDetail";
            pictureBoxDetail.Size = new Size(550, 210);
            pictureBoxDetail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDetail.TabIndex = 0;
            pictureBoxDetail.TabStop = false;
            // 
            // labelDetailTitle
            // 
            labelDetailTitle.Location = new Point(0, 0);
            labelDetailTitle.Name = "labelDetailTitle";
            labelDetailTitle.Size = new Size(100, 23);
            labelDetailTitle.TabIndex = 1;
            // 
            // labelDetailLocation
            // 
            labelDetailLocation.Location = new Point(0, 0);
            labelDetailLocation.Name = "labelDetailLocation";
            labelDetailLocation.Size = new Size(100, 23);
            labelDetailLocation.TabIndex = 2;
            // 
            // labelDetailRent
            // 
            labelDetailRent.Location = new Point(0, 0);
            labelDetailRent.Name = "labelDetailRent";
            labelDetailRent.Size = new Size(100, 23);
            labelDetailRent.TabIndex = 3;
            // 
            // labelDetailOwner
            // 
            labelDetailOwner.Location = new Point(0, 0);
            labelDetailOwner.Name = "labelDetailOwner";
            labelDetailOwner.Size = new Size(100, 23);
            labelDetailOwner.TabIndex = 4;
            // 
            // labelDetailRating
            // 
            labelDetailRating.Location = new Point(0, 0);
            labelDetailRating.Name = "labelDetailRating";
            labelDetailRating.Size = new Size(100, 23);
            labelDetailRating.TabIndex = 5;
            // 
            // labelDetailTags
            // 
            labelDetailTags.Location = new Point(0, 0);
            labelDetailTags.Name = "labelDetailTags";
            labelDetailTags.Size = new Size(100, 23);
            labelDetailTags.TabIndex = 6;
            // 
            // labelDetailDesc
            // 
            labelDetailDesc.BackColor = Color.Transparent;
            labelDetailDesc.Font = new Font("Segoe UI", 9.5F);
            labelDetailDesc.ForeColor = Color.FromArgb(210, 210, 255);
            labelDetailDesc.Location = new Point(15, 408);
            labelDetailDesc.Name = "labelDetailDesc";
            labelDetailDesc.Size = new Size(550, 70);
            labelDetailDesc.TabIndex = 7;
            // 
            // labelLoginPrompt
            // 
            labelLoginPrompt.AutoSize = true;
            labelLoginPrompt.BackColor = Color.Transparent;
            labelLoginPrompt.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            labelLoginPrompt.ForeColor = Color.Gold;
            labelLoginPrompt.Location = new Point(80, 500);
            labelLoginPrompt.Name = "labelLoginPrompt";
            labelLoginPrompt.Size = new Size(352, 25);
            labelLoginPrompt.TabIndex = 8;
            labelLoginPrompt.Text = "🔐 Sign In to Book, Chat or Make an Offer";
            // 
            // btnDetailLogin
            // 
            btnDetailLogin.BackColor = Color.DarkSlateBlue;
            btnDetailLogin.Cursor = Cursors.Hand;
            btnDetailLogin.FlatAppearance.BorderColor = Color.Cyan;
            btnDetailLogin.FlatStyle = FlatStyle.Flat;
            btnDetailLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnDetailLogin.ForeColor = Color.Cyan;
            btnDetailLogin.Location = new Point(170, 540);
            btnDetailLogin.Name = "btnDetailLogin";
            btnDetailLogin.Size = new Size(210, 42);
            btnDetailLogin.TabIndex = 9;
            btnDetailLogin.Text = "🔐 Sign In / Sign Up";
            btnDetailLogin.UseVisualStyleBackColor = false;
            btnDetailLogin.Click += btnLoginToBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(116, 61);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 14;
            label1.Text = "Bechelor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(241, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 15;
            label2.Text = "Family";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(400, 59);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "Restricted";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(513, 60);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 17;
            label4.Text = "Restrictionless";
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1250, 720);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAppTitle);
            Controls.Add(textSearch);
            Controls.Add(btnSearch);
            Controls.Add(labelGuestNote);
            Controls.Add(btnLoginToBook);
            Controls.Add(btnBack);
            Controls.Add(labelFilterTenant);
            Controls.Add(chkBachelor);
            Controls.Add(chkFamily);
            Controls.Add(labelFilterRestrict);
            Controls.Add(chkRestricted);
            Controls.Add(chkFree);
            Controls.Add(flowPanelPosts);
            Controls.Add(panelDetail);
            Name = "Guest";
            Text = "Your NxtHome - Browse Posts (Guest)";
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetChk(System.Windows.Forms.CheckBox cb, string text, int x, int y)
        {
            cb.AutoSize = true;
            cb.BackColor = System.Drawing.Color.Transparent;
            cb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cb.ForeColor = System.Drawing.Color.FloralWhite;
            cb.Location = new System.Drawing.Point(x, y);
            cb.Text = text;
            cb.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void SetDetLbl(System.Windows.Forms.Label lbl, string text, int x, int y,
            int width, float size, System.Drawing.FontStyle style, System.Drawing.Color fore)
        {
            lbl.AutoSize = false;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Segoe UI", size, style);
            lbl.ForeColor = fore;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(width, 26);
            lbl.Text = text;
        }

        #endregion

        private System.Windows.Forms.Label labelAppTitle, labelGuestNote;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch, btnLoginToBook, btnBack;
        private System.Windows.Forms.Label labelFilterTenant, labelFilterRestrict;
        private System.Windows.Forms.CheckBox chkBachelor, chkFamily, chkRestricted, chkFree;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPosts;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnDetailClose, btnDetailLogin;
        private System.Windows.Forms.PictureBox pictureBoxDetail;
        private System.Windows.Forms.Label labelDetailTitle, labelDetailLocation;
        private System.Windows.Forms.Label labelDetailRent, labelDetailOwner;
        private System.Windows.Forms.Label labelDetailRating, labelDetailTags, labelDetailDesc;
        private System.Windows.Forms.Label labelLoginPrompt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}