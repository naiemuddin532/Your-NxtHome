namespace YourNxtHome
{
    partial class Wishlist
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
            this.labelWishTitle = new System.Windows.Forms.Label();
            this.listViewWishlist = new System.Windows.Forms.ListView();
            this.colWId = new System.Windows.Forms.ColumnHeader();
            this.colWTitle = new System.Windows.Forms.ColumnHeader();
            this.colWLocation = new System.Windows.Forms.ColumnHeader();
            this.colWRent = new System.Windows.Forms.ColumnHeader();
            this.colWOwner = new System.Windows.Forms.ColumnHeader();
            this.colWDate = new System.Windows.Forms.ColumnHeader();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // =====================
            // FORM
            // =====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Name = "Wishlist";
            this.Text = "Your NxtHome - Wishlist";

            // =====================
            // TITLE
            // =====================
            this.labelWishTitle.AutoSize = true;
            this.labelWishTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelWishTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelWishTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelWishTitle.Location = new System.Drawing.Point(270, 20);
            this.labelWishTitle.Name = "labelWishTitle";
            this.labelWishTitle.Text = "❤️ My Wishlist";

            // =====================
            // LIST VIEW
            // =====================
            this.listViewWishlist.BackColor = System.Drawing.Color.FromArgb(20, 0, 50);
            this.listViewWishlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewWishlist.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listViewWishlist.ForeColor = System.Drawing.Color.FloralWhite;
            this.listViewWishlist.FullRowSelect = true;
            this.listViewWishlist.GridLines = false;
            this.listViewWishlist.Location = new System.Drawing.Point(30, 75);
            this.listViewWishlist.Name = "listViewWishlist";
            this.listViewWishlist.Size = new System.Drawing.Size(840, 445);
            this.listViewWishlist.View = System.Windows.Forms.View.Details;
            this.listViewWishlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colWId, this.colWTitle, this.colWLocation, this.colWRent, this.colWOwner, this.colWDate
            });

            this.colWId.Text = "ID";
            this.colWId.Width = 45;
            this.colWTitle.Text = "Title";
            this.colWTitle.Width = 200;
            this.colWLocation.Text = "Location";
            this.colWLocation.Width = 160;
            this.colWRent.Text = "Rent";
            this.colWRent.Width = 100;
            this.colWOwner.Text = "Owner";
            this.colWOwner.Width = 150;
            this.colWDate.Text = "Added";
            this.colWDate.Width = 100;

            // =====================
            // EMPTY LABEL
            // =====================
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.BackColor = System.Drawing.Color.Transparent;
            this.labelEmpty.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.labelEmpty.ForeColor = System.Drawing.Color.Cyan;
            this.labelEmpty.Location = new System.Drawing.Point(310, 275);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Text = "Your wishlist is empty 🤍";
            this.labelEmpty.Visible = false;

            // =====================
            // BUTTONS
            // =====================
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(80, 20, 0);
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnRemove.ForeColor = System.Drawing.Color.Tomato;
            this.btnRemove.Location = new System.Drawing.Point(30, 540);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 42);
            this.btnRemove.Text = "🗑️ Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btn_MouseLeave);

            this.btnViewDetails.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnViewDetails.ForeColor = System.Drawing.Color.Cyan;
            this.btnViewDetails.Location = new System.Drawing.Point(205, 540);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(155, 42);
            this.btnViewDetails.Text = "🔍 View Details";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            this.btnViewDetails.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnViewDetails.MouseLeave += new System.EventHandler(this.btn_MouseLeave);

            this.btnBack.BackColor = System.Drawing.Color.FromArgb(40, 0, 80);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnBack.ForeColor = System.Drawing.Color.Cyan;
            this.btnBack.Location = new System.Drawing.Point(715, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 42);
            this.btnBack.Text = "← Dashboard";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btn_MouseLeave);

            // Add to form
            this.Controls.Add(this.labelWishTitle);
            this.Controls.Add(this.listViewWishlist);
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnBack);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelWishTitle;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.ListView listViewWishlist;
        private System.Windows.Forms.ColumnHeader colWId;
        private System.Windows.Forms.ColumnHeader colWTitle;
        private System.Windows.Forms.ColumnHeader colWLocation;
        private System.Windows.Forms.ColumnHeader colWRent;
        private System.Windows.Forms.ColumnHeader colWOwner;
        private System.Windows.Forms.ColumnHeader colWDate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnBack;
    }
}