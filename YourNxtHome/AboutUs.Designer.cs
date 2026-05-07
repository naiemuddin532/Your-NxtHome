namespace YourNxtHome
{
    partial class AboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(1000, 649);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 21;
            label9.Text = "⬅Back";
            label9.Click += label9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(533, 45);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 22;
            label1.Text = "Sign in";
            label1.Click += label1_Click;
            label1.MouseEnter += label_MouseEnter;
            label1.MouseLeave += label_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(641, 45);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 23;
            label2.Text = "Sign Up";
            label2.Click += label2_Click;
            label2.MouseEnter += label_MouseEnter;
            label2.MouseLeave += label_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(749, 45);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 24;
            label3.Text = "About Us";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(866, 45);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 25;
            label4.Text = "Continue As   Guest";
            label4.Click += label4_Click;
            label4.MouseEnter += label_MouseEnter;
            label4.MouseLeave += label_MouseLeave;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.About;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1113, 686);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Name = "AboutUs";
            Text = "Your NxtHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}