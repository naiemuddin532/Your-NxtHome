namespace YourNxtHome
{
    partial class Mainpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(467, 43);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            label1.MouseEnter += label_MouseEnter;
            label1.MouseLeave += label_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(771, 43);
            label2.Name = "label2";
            label2.Size = new Size(167, 50);
            label2.TabIndex = 1;
            label2.Text = "Continue As Guest\n\r\n";
            label2.Click += label2_Click;
            label2.MouseEnter += label_MouseEnter;
            label2.MouseLeave += label_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(558, 43);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Sign Up";
            label3.Click += label3_Click;
            label3.MouseEnter += label_MouseEnter;
            label3.MouseLeave += label_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(652, 43);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "About Us";
            label4.Click += label4_Click;
            label4.MouseEnter += label_MouseEnter;
            label4.MouseLeave += label_MouseLeave;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            BackgroundImage = Properties.Resources.mp1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 594);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Mainpage";
            Text = "Your NxtHome";
            Load += Mainpage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
