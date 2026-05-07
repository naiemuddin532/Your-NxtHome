
namespace YourNxtHome
{
    partial class BookingApproval
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
            labelTitle = new Label();
            labelSubTitle = new Label();
            listViewRequests = new ListView();
            colBookId = new ColumnHeader();
            colRenter = new ColumnHeader();
            colPost = new ColumnHeader();
            colLocation = new ColumnHeader();
            colDate = new ColumnHeader();
            labelNoRequest = new Label();
            btnAccept = new Button();
            btnReject = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            labelHint = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelTitle.ForeColor = Color.Cyan;
            labelTitle.Location = new Point(230, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(441, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "📋 Pending Booking Requests";
            // 
            // labelSubTitle
            // 
            labelSubTitle.AutoSize = true;
            labelSubTitle.BackColor = Color.Transparent;
            labelSubTitle.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelSubTitle.ForeColor = Color.Gold;
            labelSubTitle.Location = new Point(300, 59);
            labelSubTitle.Name = "labelSubTitle";
            labelSubTitle.Size = new Size(317, 23);
            labelSubTitle.TabIndex = 1;
            labelSubTitle.Text = "Select a request then click Accept or Reject";
            // 
            // listViewRequests
            // 
            listViewRequests.BackColor = Color.MidnightBlue;
            listViewRequests.BorderStyle = BorderStyle.FixedSingle;
            listViewRequests.Columns.AddRange(new ColumnHeader[] { colBookId, colRenter, colPost, colLocation, colDate });
            listViewRequests.Font = new Font("Segoe UI", 10.5F);
            listViewRequests.ForeColor = Color.FloralWhite;
            listViewRequests.FullRowSelect = true;
            listViewRequests.Location = new Point(25, 85);
            listViewRequests.Name = "listViewRequests";
            listViewRequests.Size = new Size(848, 380);
            listViewRequests.TabIndex = 2;
            listViewRequests.UseCompatibleStateImageBehavior = false;
            listViewRequests.View = View.Details;
            listViewRequests.SelectedIndexChanged += listViewRequests_SelectedIndexChanged;
            // 
            // colBookId
            // 
            colBookId.Text = "ID";
            colBookId.Width = 40;
            // 
            // colRenter
            // 
            colRenter.Text = "Renter Name";
            colRenter.Width = 160;
            // 
            // colPost
            // 
            colPost.Text = "Post Title";
            colPost.Width = 220;
            // 
            // colLocation
            // 
            colLocation.Text = "Location";
            colLocation.Width = 160;
            // 
            // colDate
            // 
            colDate.Text = "Booking Date";
            colDate.Width = 200;
            // 
            // labelNoRequest
            // 
            labelNoRequest.AutoSize = true;
            labelNoRequest.BackColor = Color.Transparent;
            labelNoRequest.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            labelNoRequest.ForeColor = Color.Cyan;
            labelNoRequest.Location = new Point(300, 250);
            labelNoRequest.Name = "labelNoRequest";
            labelNoRequest.Size = new Size(329, 30);
            labelNoRequest.TabIndex = 3;
            labelNoRequest.Text = "No pending booking requests 🎉";
            labelNoRequest.Visible = false;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(0, 80, 20);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.Enabled = false;
            btnAccept.FlatAppearance.BorderColor = Color.LightGreen;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAccept.ForeColor = Color.LightGreen;
            btnAccept.Location = new Point(25, 500);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(185, 48);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "✅ Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(80, 15, 0);
            btnReject.Cursor = Cursors.Hand;
            btnReject.Enabled = false;
            btnReject.FlatAppearance.BorderColor = Color.Tomato;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnReject.ForeColor = Color.Tomato;
            btnReject.Location = new Point(225, 500);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(185, 48);
            btnReject.TabIndex = 6;
            btnReject.Text = "❌ Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkSlateBlue;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.Cyan;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnRefresh.ForeColor = Color.Cyan;
            btnRefresh.Location = new Point(580, 500);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 48);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(40, 0, 80);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.Cyan;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnClose.ForeColor = Color.Cyan;
            btnClose.Location = new Point(728, 500);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 48);
            btnClose.TabIndex = 8;
            btnClose.Text = "← Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.BackColor = Color.Transparent;
            labelHint.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            labelHint.ForeColor = Color.FromArgb(180, 180, 255);
            labelHint.Location = new Point(25, 475);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(765, 21);
            labelHint.TabIndex = 4;
            labelHint.Text = "ℹ️  On Accept → Booking moves to Confirmed & renter gets notified. On Reject → Renter gets a sorry message.";
            // 
            // BookingApproval
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copilot_20260411_212715;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 580);
            Controls.Add(labelTitle);
            Controls.Add(labelSubTitle);
            Controls.Add(listViewRequests);
            Controls.Add(labelNoRequest);
            Controls.Add(labelHint);
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BookingApproval";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Your NxtHome - Booking Requests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle, labelSubTitle, labelNoRequest, labelHint;
        private System.Windows.Forms.ListView listViewRequests;
        private System.Windows.Forms.ColumnHeader colBookId, colRenter, colPost, colLocation, colDate;
        private System.Windows.Forms.Button btnAccept, btnReject, btnRefresh, btnClose;
    }
}