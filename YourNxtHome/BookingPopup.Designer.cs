namespace YourNxtHome
{
    partial class BookingPopup
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
            labelStatus = new Label();
            labelInfo = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Italic);
            labelTitle.ForeColor = Color.Cyan;
            labelTitle.Location = new Point(129, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(293, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "🔖 Booking Request";
            // 
            // labelStatus
            // 
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            labelStatus.ForeColor = Color.FloralWhite;
            labelStatus.Location = new Point(54, 87);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(440, 48);
            labelStatus.TabIndex = 1;
            labelStatus.Text = "⏳ Please wait...";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelInfo.ForeColor = Color.Cyan;
            labelInfo.Location = new Point(139, 125);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(310, 126);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "⚠️ Booking is Pending.\r\nFlat owner will approve or reject. Check Pending Bookings.";
            labelInfo.TextAlign = ContentAlignment.MiddleCenter;
            labelInfo.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkSlateBlue;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.Cyan;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnClose.ForeColor = Color.Cyan;
            btnClose.Location = new Point(247, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "✔ OK";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // BookingPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copilot_20260411_212715;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 381);
            Controls.Add(labelTitle);
            Controls.Add(labelStatus);
            Controls.Add(labelInfo);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookingPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnClose;
    }
}