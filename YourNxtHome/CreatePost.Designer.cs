namespace YourNxtHome
{
    partial class CreatePost
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
            labelFormTitle = new Label();
            labelFieldTitle = new Label();
            textTitle = new TextBox();
            labelFieldLocation = new Label();
            textLocation = new TextBox();
            labelFieldRent = new Label();
            textRent = new TextBox();
            labelFieldDesc = new Label();
            textDescription = new TextBox();
            labelTenantType = new Label();
            radioBachelorType = new RadioButton();
            radioFamilyType = new RadioButton();
            labelRestrictionType = new Label();
            radioRestricted = new RadioButton();
            radioRestrictionLess = new RadioButton();
            btnPickPhoto = new Button();
            labelPhotoStatus = new Label();
            labelPreviewHead = new Label();
            pictureBoxPreview = new PictureBox();
            btnSubmitPost = new Button();
            btnCancelPost = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // labelFormTitle
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.BackColor = Color.Transparent;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelFormTitle.ForeColor = Color.Cyan;
            labelFormTitle.Location = new Point(200, 16);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Size = new Size(300, 41);
            labelFormTitle.TabIndex = 0;
            labelFormTitle.Text = "🏠 Create New Post";
            // 
            // labelFieldTitle
            // 
            labelFieldTitle.AutoSize = true;
            labelFieldTitle.BackColor = Color.Transparent;
            labelFieldTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldTitle.ForeColor = Color.FloralWhite;
            labelFieldTitle.Location = new Point(30, 70);
            labelFieldTitle.Name = "labelFieldTitle";
            labelFieldTitle.Size = new Size(113, 28);
            labelFieldTitle.TabIndex = 1;
            labelFieldTitle.Text = "Post Title :";
            // 
            // textTitle
            // 
            textTitle.BackColor = Color.FromArgb(220, 210, 240);
            textTitle.Font = new Font("Segoe UI", 12F);
            textTitle.Location = new Point(200, 67);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(370, 34);
            textTitle.TabIndex = 2;
            // 
            // labelFieldLocation
            // 
            labelFieldLocation.AutoSize = true;
            labelFieldLocation.BackColor = Color.Transparent;
            labelFieldLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldLocation.ForeColor = Color.FloralWhite;
            labelFieldLocation.Location = new Point(30, 125);
            labelFieldLocation.Name = "labelFieldLocation";
            labelFieldLocation.Size = new Size(104, 28);
            labelFieldLocation.TabIndex = 3;
            labelFieldLocation.Text = "Location :";
            // 
            // textLocation
            // 
            textLocation.BackColor = Color.FromArgb(220, 210, 240);
            textLocation.Font = new Font("Segoe UI", 12F);
            textLocation.Location = new Point(200, 122);
            textLocation.Name = "textLocation";
            textLocation.Size = new Size(370, 34);
            textLocation.TabIndex = 4;
            // 
            // labelFieldRent
            // 
            labelFieldRent.AutoSize = true;
            labelFieldRent.BackColor = Color.Transparent;
            labelFieldRent.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldRent.ForeColor = Color.FloralWhite;
            labelFieldRent.Location = new Point(30, 180);
            labelFieldRent.Name = "labelFieldRent";
            labelFieldRent.Size = new Size(143, 28);
            labelFieldRent.TabIndex = 5;
            labelFieldRent.Text = "Rent (৳/mo) :";
            // 
            // textRent
            // 
            textRent.BackColor = Color.FromArgb(220, 210, 240);
            textRent.Font = new Font("Segoe UI", 12F);
            textRent.Location = new Point(200, 177);
            textRent.Name = "textRent";
            textRent.Size = new Size(200, 34);
            textRent.TabIndex = 6;
            // 
            // labelFieldDesc
            // 
            labelFieldDesc.AutoSize = true;
            labelFieldDesc.BackColor = Color.Transparent;
            labelFieldDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldDesc.ForeColor = Color.FloralWhite;
            labelFieldDesc.Location = new Point(30, 235);
            labelFieldDesc.Name = "labelFieldDesc";
            labelFieldDesc.Size = new Size(130, 28);
            labelFieldDesc.TabIndex = 7;
            labelFieldDesc.Text = "Description :";
            // 
            // textDescription
            // 
            textDescription.BackColor = Color.FromArgb(220, 210, 240);
            textDescription.Font = new Font("Segoe UI", 11F);
            textDescription.Location = new Point(200, 232);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = ScrollBars.Vertical;
            textDescription.Size = new Size(370, 80);
            textDescription.TabIndex = 8;
            // 
            // labelTenantType
            // 
            labelTenantType.AutoSize = true;
            labelTenantType.BackColor = Color.Transparent;
            labelTenantType.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelTenantType.ForeColor = Color.Cyan;
            labelTenantType.Location = new Point(30, 330);
            labelTenantType.Name = "labelTenantType";
            labelTenantType.Size = new Size(140, 28);
            labelTenantType.TabIndex = 9;
            labelTenantType.Text = "Tenant Type :";
            // 
            // radioBachelorType
            // 
            radioBachelorType.AutoSize = true;
            radioBachelorType.BackColor = Color.Transparent;
            radioBachelorType.Checked = true;
            radioBachelorType.Cursor = Cursors.Hand;
            radioBachelorType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioBachelorType.ForeColor = Color.FloralWhite;
            radioBachelorType.Location = new Point(200, 328);
            radioBachelorType.Name = "radioBachelorType";
            radioBachelorType.Size = new Size(137, 29);
            radioBachelorType.TabIndex = 10;
            radioBachelorType.TabStop = true;
            radioBachelorType.Text = "\U0001f9d1 Bachelor";
            radioBachelorType.UseVisualStyleBackColor = false;
            // 
            // radioFamilyType
            // 
            radioFamilyType.AutoSize = true;
            radioFamilyType.BackColor = Color.Transparent;
            radioFamilyType.Cursor = Cursors.Hand;
            radioFamilyType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioFamilyType.ForeColor = Color.FloralWhite;
            radioFamilyType.Location = new Point(360, 328);
            radioFamilyType.Name = "radioFamilyType";
            radioFamilyType.Size = new Size(115, 29);
            radioFamilyType.TabIndex = 11;
            radioFamilyType.Text = "👨‍👩‍👧 Family";
            radioFamilyType.UseVisualStyleBackColor = false;
            // 
            // labelRestrictionType
            // 
            labelRestrictionType.AutoSize = true;
            labelRestrictionType.BackColor = Color.Transparent;
            labelRestrictionType.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelRestrictionType.ForeColor = Color.Cyan;
            labelRestrictionType.Location = new Point(30, 375);
            labelRestrictionType.Name = "labelRestrictionType";
            labelRestrictionType.Size = new Size(124, 28);
            labelRestrictionType.TabIndex = 12;
            labelRestrictionType.Text = "Restriction :";
            // 
            // radioRestricted
            // 
            radioRestricted.AutoSize = true;
            radioRestricted.BackColor = Color.Transparent;
            radioRestricted.Cursor = Cursors.Hand;
            radioRestricted.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioRestricted.ForeColor = Color.FloralWhite;
            radioRestricted.Location = new Point(380, 373);
            radioRestricted.Name = "radioRestricted";
            radioRestricted.Size = new Size(148, 29);
            radioRestricted.TabIndex = 14;
            radioRestricted.Text = "🚫 Restricted";
            radioRestricted.UseVisualStyleBackColor = false;
            // 
            // radioRestrictionLess
            // 
            radioRestrictionLess.AutoSize = true;
            radioRestrictionLess.BackColor = Color.Transparent;
            radioRestrictionLess.Checked = true;
            radioRestrictionLess.Cursor = Cursors.Hand;
            radioRestrictionLess.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioRestrictionLess.ForeColor = Color.FloralWhite;
            radioRestrictionLess.Location = new Point(200, 373);
            radioRestrictionLess.Name = "radioRestrictionLess";
            radioRestrictionLess.Size = new Size(187, 29);
            radioRestrictionLess.TabIndex = 13;
            radioRestrictionLess.TabStop = true;
            radioRestrictionLess.Text = "✅ No Restriction";
            radioRestrictionLess.UseVisualStyleBackColor = false;
            // 
            // btnPickPhoto
            // 
            btnPickPhoto.BackColor = Color.DarkSlateBlue;
            btnPickPhoto.Cursor = Cursors.Hand;
            btnPickPhoto.FlatAppearance.BorderColor = Color.Cyan;
            btnPickPhoto.FlatStyle = FlatStyle.Flat;
            btnPickPhoto.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnPickPhoto.ForeColor = Color.Cyan;
            btnPickPhoto.Location = new Point(620, 360);
            btnPickPhoto.Name = "btnPickPhoto";
            btnPickPhoto.Size = new Size(155, 42);
            btnPickPhoto.TabIndex = 15;
            btnPickPhoto.Text = "📷 Pick Photo";
            btnPickPhoto.UseVisualStyleBackColor = false;
            btnPickPhoto.Click += btnPickPhoto_Click;
            // 
            // labelPhotoStatus
            // 
            labelPhotoStatus.AutoSize = true;
            labelPhotoStatus.BackColor = Color.Transparent;
            labelPhotoStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            labelPhotoStatus.ForeColor = Color.Gray;
            labelPhotoStatus.Location = new Point(635, 328);
            labelPhotoStatus.Name = "labelPhotoStatus";
            labelPhotoStatus.Size = new Size(135, 21);
            labelPhotoStatus.TabIndex = 16;
            labelPhotoStatus.Text = "No photo selected";
            // 
            // labelPreviewHead
            // 
            labelPreviewHead.AutoSize = true;
            labelPreviewHead.BackColor = Color.Transparent;
            labelPreviewHead.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelPreviewHead.ForeColor = Color.Cyan;
            labelPreviewHead.Location = new Point(620, 55);
            labelPreviewHead.Name = "labelPreviewHead";
            labelPreviewHead.Size = new Size(114, 23);
            labelPreviewHead.TabIndex = 17;
            labelPreviewHead.Text = "Photo Preview";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.BackColor = Color.FromArgb(30, 0, 60);
            pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPreview.Location = new Point(595, 81);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(210, 239);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            // 
            // btnSubmitPost
            // 
            btnSubmitPost.BackColor = Color.FromArgb(0, 70, 20);
            btnSubmitPost.Cursor = Cursors.Hand;
            btnSubmitPost.FlatAppearance.BorderColor = Color.LightGreen;
            btnSubmitPost.FlatStyle = FlatStyle.Flat;
            btnSubmitPost.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnSubmitPost.ForeColor = Color.LightGreen;
            btnSubmitPost.Location = new Point(181, 467);
            btnSubmitPost.Name = "btnSubmitPost";
            btnSubmitPost.Size = new Size(195, 48);
            btnSubmitPost.TabIndex = 18;
            btnSubmitPost.Text = "✅ Publish Post";
            btnSubmitPost.UseVisualStyleBackColor = false;
            btnSubmitPost.Click += btnSubmitPost_Click;
            // 
            // btnCancelPost
            // 
            btnCancelPost.BackColor = Color.FromArgb(70, 15, 0);
            btnCancelPost.Cursor = Cursors.Hand;
            btnCancelPost.FlatAppearance.BorderColor = Color.Tomato;
            btnCancelPost.FlatStyle = FlatStyle.Flat;
            btnCancelPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCancelPost.ForeColor = Color.Tomato;
            btnCancelPost.Location = new Point(477, 467);
            btnCancelPost.Name = "btnCancelPost";
            btnCancelPost.Size = new Size(130, 48);
            btnCancelPost.TabIndex = 19;
            btnCancelPost.Text = "✖ Cancel";
            btnCancelPost.UseVisualStyleBackColor = false;
            btnCancelPost.Click += btnCancelPost_Click;
            // 
            // CreatePost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(860, 560);
            Controls.Add(labelFormTitle);
            Controls.Add(labelFieldTitle);
            Controls.Add(textTitle);
            Controls.Add(labelFieldLocation);
            Controls.Add(textLocation);
            Controls.Add(labelFieldRent);
            Controls.Add(textRent);
            Controls.Add(labelFieldDesc);
            Controls.Add(textDescription);
            Controls.Add(labelTenantType);
            Controls.Add(radioBachelorType);
            Controls.Add(radioFamilyType);
            Controls.Add(labelRestrictionType);
            Controls.Add(radioRestrictionLess);
            Controls.Add(radioRestricted);
            Controls.Add(btnPickPhoto);
            Controls.Add(labelPhotoStatus);
            Controls.Add(labelPreviewHead);
            Controls.Add(pictureBoxPreview);
            Controls.Add(btnSubmitPost);
            Controls.Add(btnCancelPost);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CreatePost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Your NxtHome - Create Post";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelFieldTitle, labelFieldLocation, labelFieldRent, labelFieldDesc;
        private System.Windows.Forms.TextBox textTitle, textLocation, textRent, textDescription;
        private System.Windows.Forms.Label labelTenantType, labelRestrictionType;
        private System.Windows.Forms.RadioButton radioBachelorType, radioFamilyType;
        private System.Windows.Forms.RadioButton radioRestricted, radioRestrictionLess;
        private System.Windows.Forms.Button btnPickPhoto;
        private System.Windows.Forms.Label labelPhotoStatus, labelPreviewHead;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnSubmitPost, btnCancelPost;
    }
}