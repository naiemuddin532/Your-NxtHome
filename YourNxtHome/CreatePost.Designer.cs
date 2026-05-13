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

            // ✅ দুইটা Panel — এটাই মূল fix
            panelTenantType = new Panel();
            panelRestriction = new Panel();

            btnPickPhoto = new Button();
            labelPhotoStatus = new Label();
            labelPreviewHead = new Label();
            pictureBoxPreview = new PictureBox();
            btnSubmitPost = new Button();
            btnCancelPost = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            panelTenantType.SuspendLayout();
            panelRestriction.SuspendLayout();
            SuspendLayout();

            // ── labelFormTitle ──
            labelFormTitle.AutoSize = true;
            labelFormTitle.BackColor = Color.Transparent;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelFormTitle.ForeColor = Color.Cyan;
            labelFormTitle.Location = new Point(200, 16);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Text = "🏠 Create New Post";

            // ── labelFieldTitle ──
            labelFieldTitle.AutoSize = true;
            labelFieldTitle.BackColor = Color.Transparent;
            labelFieldTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldTitle.ForeColor = Color.FloralWhite;
            labelFieldTitle.Location = new Point(30, 70);
            labelFieldTitle.Text = "Post Title :";

            // ── textTitle ──
            textTitle.BackColor = Color.FromArgb(220, 210, 240);
            textTitle.Font = new Font("Segoe UI", 12F);
            textTitle.Location = new Point(200, 67);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(370, 34);

            // ── labelFieldLocation ──
            labelFieldLocation.AutoSize = true;
            labelFieldLocation.BackColor = Color.Transparent;
            labelFieldLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldLocation.ForeColor = Color.FloralWhite;
            labelFieldLocation.Location = new Point(30, 125);
            labelFieldLocation.Text = "Location :";

            // ── textLocation ──
            textLocation.BackColor = Color.FromArgb(220, 210, 240);
            textLocation.Font = new Font("Segoe UI", 12F);
            textLocation.Location = new Point(200, 122);
            textLocation.Name = "textLocation";
            textLocation.Size = new Size(370, 34);

            // ── labelFieldRent ──
            labelFieldRent.AutoSize = true;
            labelFieldRent.BackColor = Color.Transparent;
            labelFieldRent.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldRent.ForeColor = Color.FloralWhite;
            labelFieldRent.Location = new Point(30, 180);
            labelFieldRent.Text = "Rent (৳/mo) :";

            // ── textRent ──
            textRent.BackColor = Color.FromArgb(220, 210, 240);
            textRent.Font = new Font("Segoe UI", 12F);
            textRent.Location = new Point(200, 177);
            textRent.Name = "textRent";
            textRent.Size = new Size(200, 34);

            // ── labelFieldDesc ──
            labelFieldDesc.AutoSize = true;
            labelFieldDesc.BackColor = Color.Transparent;
            labelFieldDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelFieldDesc.ForeColor = Color.FloralWhite;
            labelFieldDesc.Location = new Point(30, 235);
            labelFieldDesc.Text = "Description :";

            // ── textDescription ──
            textDescription.BackColor = Color.FromArgb(220, 210, 240);
            textDescription.Font = new Font("Segoe UI", 11F);
            textDescription.Location = new Point(200, 232);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = ScrollBars.Vertical;
            textDescription.Size = new Size(370, 80);

            // ── labelTenantType ──
            labelTenantType.AutoSize = true;
            labelTenantType.BackColor = Color.Transparent;
            labelTenantType.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelTenantType.ForeColor = Color.Cyan;
            labelTenantType.Location = new Point(30, 335);
            labelTenantType.Text = "Tenant Type :";

            // ── panelTenantType (Bachelor + Family এর container) ──
            panelTenantType.BackColor = Color.Transparent;
            panelTenantType.Location = new Point(195, 325);
            panelTenantType.Size = new Size(320, 40);
            panelTenantType.Controls.Add(radioBachelorType);
            panelTenantType.Controls.Add(radioFamilyType);

            // ── radioBachelorType ──
            radioBachelorType.AutoSize = true;
            radioBachelorType.BackColor = Color.Transparent;
            radioBachelorType.Cursor = Cursors.Hand;
            radioBachelorType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioBachelorType.ForeColor = Color.FloralWhite;
            radioBachelorType.Location = new Point(0, 5);
            radioBachelorType.Name = "radioBachelorType";
            radioBachelorType.Text = "🧑 Bachelor";
            radioBachelorType.UseVisualStyleBackColor = false;

            // ── radioFamilyType ──
            radioFamilyType.AutoSize = true;
            radioFamilyType.BackColor = Color.Transparent;
            radioFamilyType.Cursor = Cursors.Hand;
            radioFamilyType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioFamilyType.ForeColor = Color.FloralWhite;
            radioFamilyType.Location = new Point(160, 5);
            radioFamilyType.Name = "radioFamilyType";
            radioFamilyType.Text = "👨‍👩‍👧 Family";
            radioFamilyType.UseVisualStyleBackColor = false;

            // ── labelRestrictionType ──
            labelRestrictionType.AutoSize = true;
            labelRestrictionType.BackColor = Color.Transparent;
            labelRestrictionType.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelRestrictionType.ForeColor = Color.Cyan;
            labelRestrictionType.Location = new Point(30, 385);
            labelRestrictionType.Text = "Restriction :";

            // ── panelRestriction (Restricted + RestrictionLess এর container) ──
            panelRestriction.BackColor = Color.Transparent;
            panelRestriction.Location = new Point(195, 375);
            panelRestriction.Size = new Size(370, 40);
            panelRestriction.Controls.Add(radioRestrictionLess);
            panelRestriction.Controls.Add(radioRestricted);

            // ── radioRestrictionLess ──
            radioRestrictionLess.AutoSize = true;
            radioRestrictionLess.BackColor = Color.Transparent;
            radioRestrictionLess.Cursor = Cursors.Hand;
            radioRestrictionLess.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioRestrictionLess.ForeColor = Color.FloralWhite;
            radioRestrictionLess.Location = new Point(0, 5);
            radioRestrictionLess.Name = "radioRestrictionLess";
            radioRestrictionLess.Text = "✅ No Restriction";
            radioRestrictionLess.UseVisualStyleBackColor = false;

            // ── radioRestricted ──
            radioRestricted.AutoSize = true;
            radioRestricted.BackColor = Color.Transparent;
            radioRestricted.Cursor = Cursors.Hand;
            radioRestricted.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioRestricted.ForeColor = Color.FloralWhite;
            radioRestricted.Location = new Point(195, 5);
            radioRestricted.Name = "radioRestricted";
            radioRestricted.Text = "🚫 Restricted";
            radioRestricted.UseVisualStyleBackColor = false;

            // ── btnPickPhoto ──
            btnPickPhoto.BackColor = Color.DarkSlateBlue;
            btnPickPhoto.Cursor = Cursors.Hand;
            btnPickPhoto.FlatAppearance.BorderColor = Color.Cyan;
            btnPickPhoto.FlatStyle = FlatStyle.Flat;
            btnPickPhoto.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnPickPhoto.ForeColor = Color.Cyan;
            btnPickPhoto.Location = new Point(620, 360);
            btnPickPhoto.Name = "btnPickPhoto";
            btnPickPhoto.Size = new Size(155, 42);
            btnPickPhoto.Text = "📷 Pick Photo";
            btnPickPhoto.UseVisualStyleBackColor = false;
            btnPickPhoto.Click += btnPickPhoto_Click;

            // ── labelPhotoStatus ──
            labelPhotoStatus.AutoSize = true;
            labelPhotoStatus.BackColor = Color.Transparent;
            labelPhotoStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            labelPhotoStatus.ForeColor = Color.Gray;
            labelPhotoStatus.Location = new Point(635, 328);
            labelPhotoStatus.Name = "labelPhotoStatus";
            labelPhotoStatus.Text = "No photo selected";

            // ── labelPreviewHead ──
            labelPreviewHead.AutoSize = true;
            labelPreviewHead.BackColor = Color.Transparent;
            labelPreviewHead.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelPreviewHead.ForeColor = Color.Cyan;
            labelPreviewHead.Location = new Point(620, 55);
            labelPreviewHead.Text = "Photo Preview";

            // ── pictureBoxPreview ──
            pictureBoxPreview.BackColor = Color.FromArgb(30, 0, 60);
            pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPreview.Location = new Point(595, 81);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(210, 239);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;

            // ── btnSubmitPost ──
            btnSubmitPost.BackColor = Color.FromArgb(0, 70, 20);
            btnSubmitPost.Cursor = Cursors.Hand;
            btnSubmitPost.FlatAppearance.BorderColor = Color.LightGreen;
            btnSubmitPost.FlatStyle = FlatStyle.Flat;
            btnSubmitPost.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnSubmitPost.ForeColor = Color.LightGreen;
            btnSubmitPost.Location = new Point(181, 467);
            btnSubmitPost.Name = "btnSubmitPost";
            btnSubmitPost.Size = new Size(195, 48);
            btnSubmitPost.Text = "✅ Publish Post";
            btnSubmitPost.UseVisualStyleBackColor = false;
            btnSubmitPost.Click += btnSubmitPost_Click;

            // ── btnCancelPost ──
            btnCancelPost.BackColor = Color.FromArgb(70, 15, 0);
            btnCancelPost.Cursor = Cursors.Hand;
            btnCancelPost.FlatAppearance.BorderColor = Color.Tomato;
            btnCancelPost.FlatStyle = FlatStyle.Flat;
            btnCancelPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCancelPost.ForeColor = Color.Tomato;
            btnCancelPost.Location = new Point(477, 467);
            btnCancelPost.Name = "btnCancelPost";
            btnCancelPost.Size = new Size(130, 48);
            btnCancelPost.Text = "✖ Cancel";
            btnCancelPost.UseVisualStyleBackColor = false;
            btnCancelPost.Click += btnCancelPost_Click;

            // ── Form ──
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
            Controls.Add(panelTenantType);       // ✅ Panel add
            Controls.Add(labelRestrictionType);
            Controls.Add(panelRestriction);      // ✅ Panel add
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
            panelTenantType.ResumeLayout(false);
            panelTenantType.PerformLayout();
            panelRestriction.ResumeLayout(false);
            panelRestriction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFormTitle;
        private Label labelFieldTitle, labelFieldLocation, labelFieldRent, labelFieldDesc;
        private TextBox textTitle, textLocation, textRent, textDescription;
        private Label labelTenantType, labelRestrictionType;
        private RadioButton radioBachelorType, radioFamilyType;
        private RadioButton radioRestricted, radioRestrictionLess;
        private Panel panelTenantType;      // ✅ নতুন
        private Panel panelRestriction;     // ✅ নতুন
        private Button btnPickPhoto;
        private Label labelPhotoStatus, labelPreviewHead;
        private PictureBox pictureBoxPreview;
        private Button btnSubmitPost, btnCancelPost;
    }
}