namespace YourNxtHome
{
    partial class RateOwner
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
            labelSelectOwner = new Label();
            comboOwner = new ComboBox();
            labelStarPrompt = new Label();
            star1 = new Label();
            star2 = new Label();
            star3 = new Label();
            star4 = new Label();
            star5 = new Label();
            labelRatingValue = new Label();
            labelCommentPrompt = new Label();
            textComment = new TextBox();
            btnSubmitRating = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelTitle.ForeColor = Color.Gold;
            labelTitle.Location = new Point(118, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(281, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "⭐ Rate Flat Owner";
            // 
            // labelSelectOwner
            // 
            labelSelectOwner.AutoSize = true;
            labelSelectOwner.BackColor = Color.Transparent;
            labelSelectOwner.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelSelectOwner.ForeColor = Color.FloralWhite;
            labelSelectOwner.Location = new Point(118, 95);
            labelSelectOwner.Name = "labelSelectOwner";
            labelSelectOwner.Size = new Size(137, 25);
            labelSelectOwner.TabIndex = 1;
            labelSelectOwner.Text = "Select Owner :";
            // 
            // comboOwner
            // 
            comboOwner.BackColor = Color.FromArgb(220, 210, 240);
            comboOwner.FlatStyle = FlatStyle.Flat;
            comboOwner.Font = new Font("Segoe UI", 11F);
            comboOwner.Location = new Point(130, 132);
            comboOwner.Name = "comboOwner";
            comboOwner.Size = new Size(269, 33);
            comboOwner.TabIndex = 2;
            // 
            // labelStarPrompt
            // 
            labelStarPrompt.AutoSize = true;
            labelStarPrompt.BackColor = Color.Transparent;
            labelStarPrompt.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelStarPrompt.ForeColor = Color.FloralWhite;
            labelStarPrompt.Location = new Point(118, 181);
            labelStarPrompt.Name = "labelStarPrompt";
            labelStarPrompt.Size = new Size(127, 25);
            labelStarPrompt.TabIndex = 3;
            labelStarPrompt.Text = "Your Rating :";
            // 
            // star1
            // 
            star1.AutoSize = true;
            star1.BackColor = Color.Transparent;
            star1.Cursor = Cursors.Hand;
            star1.Font = new Font("Segoe UI", 24F);
            star1.ForeColor = Color.FromArgb(80, 80, 80);
            star1.Location = new Point(130, 206);
            star1.Name = "star1";
            star1.Size = new Size(56, 54);
            star1.TabIndex = 4;
            star1.Tag = 1;
            star1.Text = "★";
            star1.Click += star_Click;
            // 
            // star2
            // 
            star2.AutoSize = true;
            star2.BackColor = Color.Transparent;
            star2.Cursor = Cursors.Hand;
            star2.Font = new Font("Segoe UI", 24F);
            star2.ForeColor = Color.FromArgb(80, 80, 80);
            star2.Location = new Point(192, 206);
            star2.Name = "star2";
            star2.Size = new Size(56, 54);
            star2.TabIndex = 5;
            star2.Tag = 2;
            star2.Text = "★";
            star2.Click += star_Click;
            // 
            // star3
            // 
            star3.AutoSize = true;
            star3.BackColor = Color.Transparent;
            star3.Cursor = Cursors.Hand;
            star3.Font = new Font("Segoe UI", 24F);
            star3.ForeColor = Color.FromArgb(80, 80, 80);
            star3.Location = new Point(254, 206);
            star3.Name = "star3";
            star3.Size = new Size(56, 54);
            star3.TabIndex = 6;
            star3.Tag = 3;
            star3.Text = "★";
            star3.Click += star_Click;
            // 
            // star4
            // 
            star4.AutoSize = true;
            star4.BackColor = Color.Transparent;
            star4.Cursor = Cursors.Hand;
            star4.Font = new Font("Segoe UI", 24F);
            star4.ForeColor = Color.FromArgb(80, 80, 80);
            star4.Location = new Point(300, 206);
            star4.Name = "star4";
            star4.Size = new Size(56, 54);
            star4.TabIndex = 7;
            star4.Tag = 4;
            star4.Text = "★";
            star4.Click += star_Click;
            // 
            // star5
            // 
            star5.AutoSize = true;
            star5.BackColor = Color.Transparent;
            star5.Cursor = Cursors.Hand;
            star5.Font = new Font("Segoe UI", 24F);
            star5.ForeColor = Color.FromArgb(80, 80, 80);
            star5.Location = new Point(355, 206);
            star5.Name = "star5";
            star5.Size = new Size(56, 54);
            star5.TabIndex = 8;
            star5.Tag = 5;
            star5.Text = "★";
            star5.Click += star_Click;
            // 
            // labelRatingValue
            // 
            labelRatingValue.AutoSize = true;
            labelRatingValue.BackColor = Color.Transparent;
            labelRatingValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelRatingValue.ForeColor = Color.Cyan;
            labelRatingValue.Location = new Point(258, 181);
            labelRatingValue.Name = "labelRatingValue";
            labelRatingValue.Size = new Size(52, 25);
            labelRatingValue.TabIndex = 9;
            labelRatingValue.Text = "0 / 5";
            // 
            // labelCommentPrompt
            // 
            labelCommentPrompt.AutoSize = true;
            labelCommentPrompt.BackColor = Color.Transparent;
            labelCommentPrompt.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelCommentPrompt.ForeColor = Color.FloralWhite;
            labelCommentPrompt.Location = new Point(118, 260);
            labelCommentPrompt.Name = "labelCommentPrompt";
            labelCommentPrompt.Size = new Size(200, 25);
            labelCommentPrompt.TabIndex = 10;
            labelCommentPrompt.Text = "Comment (optional) :";
            // 
            // textComment
            // 
            textComment.BackColor = Color.FromArgb(220, 210, 240);
            textComment.Font = new Font("Segoe UI", 11F);
            textComment.Location = new Point(118, 288);
            textComment.Multiline = true;
            textComment.Name = "textComment";
            textComment.ScrollBars = ScrollBars.Vertical;
            textComment.Size = new Size(281, 50);
            textComment.TabIndex = 11;
            // 
            // btnSubmitRating
            // 
            btnSubmitRating.BackColor = Color.FromArgb(60, 50, 0);
            btnSubmitRating.Cursor = Cursors.Hand;
            btnSubmitRating.FlatAppearance.BorderColor = Color.Gold;
            btnSubmitRating.FlatStyle = FlatStyle.Flat;
            btnSubmitRating.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnSubmitRating.ForeColor = Color.Gold;
            btnSubmitRating.Location = new Point(90, 355);
            btnSubmitRating.Name = "btnSubmitRating";
            btnSubmitRating.Size = new Size(185, 44);
            btnSubmitRating.TabIndex = 12;
            btnSubmitRating.Text = "⭐ Submit Rating";
            btnSubmitRating.UseVisualStyleBackColor = false;
            btnSubmitRating.Click += btnSubmitRating_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(60, 20, 0);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.Tomato;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.ForeColor = Color.Tomato;
            btnCancel.Location = new Point(300, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 44);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // RateOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copilot_20260411_212715;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(520, 440);
            Controls.Add(labelTitle);
            Controls.Add(labelSelectOwner);
            Controls.Add(comboOwner);
            Controls.Add(labelStarPrompt);
            Controls.Add(star1);
            Controls.Add(star2);
            Controls.Add(star3);
            Controls.Add(star4);
            Controls.Add(star5);
            Controls.Add(labelRatingValue);
            Controls.Add(labelCommentPrompt);
            Controls.Add(textComment);
            Controls.Add(btnSubmitRating);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RateOwner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rate Owner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSelectOwner;
        private System.Windows.Forms.ComboBox comboOwner;
        private System.Windows.Forms.Label labelStarPrompt;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star5;
        private System.Windows.Forms.Label labelRatingValue;
        private System.Windows.Forms.Label labelCommentPrompt;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.Button btnSubmitRating;
        private System.Windows.Forms.Button btnCancel;
    }
}