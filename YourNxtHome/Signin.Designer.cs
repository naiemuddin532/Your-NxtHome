namespace YourNxtHome
{
    partial class Signin
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            labelShowPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(252, 166);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(424, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 34);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(252, 234);
            label2.Name = "label2";
            label2.Size = new Size(168, 41);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientActiveCaption;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(424, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 34);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(393, 303);
            label3.Name = "label3";
            label3.Size = new Size(242, 28);
            label3.TabIndex = 4;
            label3.Text = "Don't Have An Account?";
            label3.Click += label3_Click;
            label3.MouseEnter += label_MouseEnter;
            label3.MouseLeave += label_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(449, 397);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 5;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += label_MouseEnter;
            button1.MouseLeave += label_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(696, 410);
            label4.Name = "label4";
            label4.Size = new Size(103, 38);
            label4.TabIndex = 7;
            label4.Text = "←Back";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ChatGPT_Image_Apr_12__2026__01_31_44_PM___Copy;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 66);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 255, 255);
            label5.Location = new Point(94, 31);
            label5.Name = "label5";
            label5.Size = new Size(155, 22);
            label5.TabIndex = 10;
            label5.Text = "Your NxtHome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(424, 347);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 11;
            label6.Text = "Forgot Password";
            label6.Click += label6_Click;
            label6.MouseEnter += label_MouseEnter;
            label6.MouseLeave += label_MouseLeave;
            // 
            // labelShowPass
            // 
            labelShowPass.AutoSize = true;
            labelShowPass.BackColor = Color.Transparent;
            labelShowPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelShowPass.ForeColor = Color.Cyan;
            labelShowPass.Location = new Point(643, 281);
            labelShowPass.Name = "labelShowPass";
            labelShowPass.Size = new Size(106, 17);
            labelShowPass.TabIndex = 12;
            labelShowPass.Text = "Show Password ";
            labelShowPass.Click += labelShowPass_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copilot_20260411_212715;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 587);
            Controls.Add(labelShowPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Signin";
            Text = "Your NxtHome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label labelShowPass;
    }
}