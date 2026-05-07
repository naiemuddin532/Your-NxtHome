namespace YourNxtHome
{
    partial class ChatWindow
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
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelChatWith = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // =====================
            // FORM
            // =====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.Copilot_20260411_212715;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChatWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your NxtHome - Chat";

            // =====================
            // APP NAME
            // =====================
            this.labelAppName.AutoSize = true;
            this.labelAppName.BackColor = System.Drawing.Color.Transparent;
            this.labelAppName.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Italic);
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            this.labelAppName.Location = new System.Drawing.Point(15, 14);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Text = "Your NxtHome";

            // =====================
            // CHAT WITH LABEL
            // =====================
            this.labelChatWith.AutoSize = true;
            this.labelChatWith.BackColor = System.Drawing.Color.Transparent;
            this.labelChatWith.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelChatWith.ForeColor = System.Drawing.Color.Cyan;
            this.labelChatWith.Location = new System.Drawing.Point(170, 14);
            this.labelChatWith.Name = "labelChatWith";
            this.labelChatWith.Text = "💬 Chat";

            // =====================
            // MESSAGES LIST
            // =====================
            this.listBoxMessages.BackColor = System.Drawing.Color.FromArgb(15, 0, 40);
            this.listBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMessages.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listBoxMessages.ForeColor = System.Drawing.Color.FloralWhite;
            this.listBoxMessages.Location = new System.Drawing.Point(15, 55);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.ScrollAlwaysVisible = true;
            this.listBoxMessages.Size = new System.Drawing.Size(570, 425);

            // =====================
            // MESSAGE INPUT
            // =====================
            this.textMessage.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            this.textMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textMessage.Location = new System.Drawing.Point(15, 496);
            this.textMessage.Name = "textMessage";
            this.textMessage.PlaceholderText = "Type a message...";
            this.textMessage.Size = new System.Drawing.Size(460, 34);
            this.textMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMessage_KeyDown);

            // =====================
            // SEND BUTTON
            // =====================
            this.btnSend.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnSend.ForeColor = System.Drawing.Color.Cyan;
            this.btnSend.Location = new System.Drawing.Point(488, 494);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 38);
            this.btnSend.Text = "Send ➤";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // Add to form
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.labelChatWith);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.btnSend);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelChatWith;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button btnSend;
    }
}