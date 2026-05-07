#nullable disable

namespace YourNxtHome
{
    partial class AdminEditPost
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
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelFTitle = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelFLocation = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.labelFRent = new System.Windows.Forms.Label();
            this.textRent = new System.Windows.Forms.TextBox();
            this.labelFDesc = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelTenant = new System.Windows.Forms.Label();
            this.radioBachelor = new System.Windows.Forms.RadioButton();
            this.radioFamily = new System.Windows.Forms.RadioButton();
            this.labelRestrict = new System.Windows.Forms.Label();
            this.radioRestricted = new System.Windows.Forms.RadioButton();
            this.radioRestrictionLess = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.Copilot_20260411_212715;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminEditPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Edit Post";

            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelFormTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelFormTitle.Location = new System.Drawing.Point(210, 18);
            this.labelFormTitle.Text = "✏️ Edit Post (Admin)";

            int lx = 30, tx = 200, tw = 460, rh = 50;
            FL(this.labelFTitle, "Post Title :", lx, 70); FT(this.textTitle, tx, 67, tw);
            FL(this.labelFLocation, "Location :", lx, 120); FT(this.textLocation, tx, 117, tw);
            FL(this.labelFRent, "Rent (৳/mo) :", lx, 170); FT(this.textRent, tx, 167, 200);

            FL(this.labelFDesc, "Description :", lx, 220);
            this.textDescription.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            this.textDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textDescription.Location = new System.Drawing.Point(tx, 217);
            this.textDescription.Multiline = true;
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(tw, 80);

            FL(this.labelTenant, "Tenant :", lx, 318);
            RB(this.radioBachelor, "🧑 Bachelor", tx, 316, true);
            RB(this.radioFamily, "👨‍👩‍👧 Family", tx + 155, 316, false);

            FL(this.labelRestrict, "Restriction :", lx, 360);
            RB(this.radioRestrictionLess, "✅ No Restriction", tx, 358, true);
            RB(this.radioRestricted, "🚫 Restricted", tx + 195, 358, false);

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 70, 20);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnSave.ForeColor = System.Drawing.Color.LightGreen;
            this.btnSave.Location = new System.Drawing.Point(160, 430);
            this.btnSave.Size = new System.Drawing.Size(175, 48);
            this.btnSave.Text = "💾 Save Changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(70, 15, 0);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnCancel.ForeColor = System.Drawing.Color.Tomato;
            this.btnCancel.Location = new System.Drawing.Point(360, 430);
            this.btnCancel.Size = new System.Drawing.Size(140, 48);
            this.btnCancel.Text = "✖ Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.Add(this.labelFormTitle);
            this.Controls.Add(this.labelFTitle); this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelFLocation); this.Controls.Add(this.textLocation);
            this.Controls.Add(this.labelFRent); this.Controls.Add(this.textRent);
            this.Controls.Add(this.labelFDesc); this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelTenant); this.Controls.Add(this.radioBachelor);
            this.Controls.Add(this.radioFamily);
            this.Controls.Add(this.labelRestrict); this.Controls.Add(this.radioRestrictionLess);
            this.Controls.Add(this.radioRestricted);
            this.Controls.Add(this.btnSave); this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void FL(System.Windows.Forms.Label l, string t, int x, int y)
        {
            l.AutoSize = true; l.BackColor = System.Drawing.Color.Transparent;
            l.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            l.ForeColor = System.Drawing.Color.FloralWhite;
            l.Location = new System.Drawing.Point(x, y); l.Text = t;
        }

        private void FT(System.Windows.Forms.TextBox tb, int x, int y, int w)
        {
            tb.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            tb.Font = new System.Drawing.Font("Segoe UI", 11F);
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(w, 32);
        }

        private void RB(System.Windows.Forms.RadioButton rb, string text, int x, int y, bool chk)
        {
            rb.AutoSize = true; rb.BackColor = System.Drawing.Color.Transparent;
            rb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            rb.ForeColor = System.Drawing.Color.FloralWhite;
            rb.Location = new System.Drawing.Point(x, y);
            rb.Text = text; rb.Checked = chk;
            rb.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelFTitle, labelFLocation, labelFRent, labelFDesc;
        private System.Windows.Forms.TextBox textTitle, textLocation, textRent, textDescription;
        private System.Windows.Forms.Label labelTenant, labelRestrict;
        private System.Windows.Forms.RadioButton radioBachelor, radioFamily;
        private System.Windows.Forms.RadioButton radioRestricted, radioRestrictionLess;
        private System.Windows.Forms.Button btnSave, btnCancel;
    }
}