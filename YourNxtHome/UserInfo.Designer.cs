namespace YourNxtHome
{
    partial class UserInfo
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
            lblback = new Label();
            txtPass = new TextBox();
            lblPass = new Label();
            txtUserid = new TextBox();
            lblUserid = new Label();
            txtOccupation = new TextBox();
            lblOccupation = new Label();
            lblAddress = new Label();
            lblNid = new Label();
            txtEmail = new TextBox();
            txtNid = new TextBox();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtName = new TextBox();
            lblName = new Label();
            dgvUserInfo = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelet = new Button();
            btnClear = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            SuspendLayout();
            // 
            // lblback
            // 
            lblback.AutoSize = true;
            lblback.BackColor = Color.Transparent;
            lblback.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblback.ForeColor = Color.Red;
            lblback.Location = new Point(981, 494);
            lblback.Name = "lblback";
            lblback.Size = new Size(75, 25);
            lblback.TabIndex = 39;
            lblback.Text = "⬅Back";
            lblback.Click += lblback_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(677, 369);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(300, 27);
            txtPass.TabIndex = 35;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.Cyan;
            lblPass.Location = new Point(543, 365);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(136, 28);
            lblPass.TabIndex = 34;
            lblPass.Text = "Password    : ";
            // 
            // txtUserid
            // 
            txtUserid.Location = new Point(677, 322);
            txtUserid.Name = "txtUserid";
            txtUserid.Size = new Size(300, 27);
            txtUserid.TabIndex = 33;
            // 
            // lblUserid
            // 
            lblUserid.AutoSize = true;
            lblUserid.BackColor = Color.Transparent;
            lblUserid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserid.ForeColor = Color.Cyan;
            lblUserid.Location = new Point(544, 318);
            lblUserid.Name = "lblUserid";
            lblUserid.Size = new Size(137, 28);
            lblUserid.TabIndex = 32;
            lblUserid.Text = "UserId         : ";
            // 
            // txtOccupation
            // 
            txtOccupation.Location = new Point(677, 281);
            txtOccupation.Name = "txtOccupation";
            txtOccupation.Size = new Size(300, 27);
            txtOccupation.TabIndex = 31;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.BackColor = Color.Transparent;
            lblOccupation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupation.ForeColor = Color.Cyan;
            lblOccupation.Location = new Point(543, 277);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(137, 28);
            lblOccupation.TabIndex = 30;
            lblOccupation.Text = "Occupation : ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.Cyan;
            lblAddress.Location = new Point(89, 358);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(140, 28);
            lblAddress.TabIndex = 29;
            lblAddress.Text = "Address       : ";
            // 
            // lblNid
            // 
            lblNid.AutoSize = true;
            lblNid.BackColor = Color.Transparent;
            lblNid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNid.ForeColor = Color.Cyan;
            lblNid.Location = new Point(89, 405);
            lblNid.Name = "lblNid";
            lblNid.Size = new Size(138, 28);
            lblNid.TabIndex = 28;
            lblNid.Text = "NID             : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(243, 445);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtNid
            // 
            txtNid.Location = new Point(243, 405);
            txtNid.Name = "txtNid";
            txtNid.Size = new Size(292, 27);
            txtNid.TabIndex = 26;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(243, 362);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(292, 27);
            txtAddress.TabIndex = 25;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Cyan;
            lblEmail.Location = new Point(88, 441);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(138, 28);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "E-Mail         : ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(243, 321);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(292, 27);
            txtContact.TabIndex = 23;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = Color.Transparent;
            lblContact.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.Cyan;
            lblContact.Location = new Point(89, 317);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(138, 28);
            lblContact.TabIndex = 22;
            lblContact.Text = "Contact       : ";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonFace;
            txtName.Location = new Point(243, 279);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 27);
            txtName.TabIndex = 21;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Cyan;
            lblName.Location = new Point(89, 275);
            lblName.Name = "lblName";
            lblName.Size = new Size(139, 28);
            lblName.TabIndex = 20;
            lblName.Text = "Name          : ";
            // 
            // dgvUserInfo
            // 
            dgvUserInfo.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInfo.Location = new Point(88, 76);
            dgvUserInfo.Name = "dgvUserInfo";
            dgvUserInfo.RowHeadersWidth = 51;
            dgvUserInfo.Size = new Size(979, 188);
            dgvUserInfo.TabIndex = 40;
            dgvUserInfo.CellClick += dgvUserInfo_CellClick_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Cyan;
            btnAdd.Location = new Point(989, 291);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 29);
            btnAdd.TabIndex = 41;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Cyan;
            btnUpdate.Location = new Point(989, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 29);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelet
            // 
            btnDelet.BackColor = Color.DarkSlateBlue;
            btnDelet.Cursor = Cursors.Hand;
            btnDelet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelet.ForeColor = Color.Cyan;
            btnDelet.Location = new Point(989, 383);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(78, 29);
            btnDelet.TabIndex = 43;
            btnDelet.Text = "Delete";
            btnDelet.UseVisualStyleBackColor = false;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkSlateBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Cyan;
            btnClear.Location = new Point(989, 429);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 29);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "User", "Admin" });
            cmbRole.Location = new Point(677, 409);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(300, 28);
            cmbRole.TabIndex = 46;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.Cyan;
            lblRole.Location = new Point(544, 409);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(131, 28);
            lblRole.TabIndex = 47;
            lblRole.Text = "Role            :";
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Apr_12__2026__07_09_13_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 554);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(btnClear);
            Controls.Add(btnDelet);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvUserInfo);
            Controls.Add(lblback);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUserid);
            Controls.Add(lblUserid);
            Controls.Add(txtOccupation);
            Controls.Add(lblOccupation);
            Controls.Add(lblAddress);
            Controls.Add(lblNid);
            Controls.Add(txtEmail);
            Controls.Add(txtNid);
            Controls.Add(txtAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "UserInfo";
            Text = "User Info 👤";
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblback;
        private TextBox txtPass;
        private Label lblPass;
        private TextBox txtUserid;
        private Label lblUserid;
        private TextBox txtOccupation;
        private Label lblOccupation;
        private Label lblAddress;
        private Label lblNid;
        private TextBox txtEmail;
        private TextBox txtNid;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtContact;
        private Label lblContact;
        private TextBox txtName;
        private Label lblName;
        private DataGridView dgvUserInfo;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelet;
        private Button btnClear;
        private ComboBox cmbRole;
        private Label lblRole;
    }
}