#nullable disable

namespace YourNxtHome
{
    partial class Developer
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
            // Sidebar
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelDevTitle = new System.Windows.Forms.Label();
            this.labelDevSub = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();

            // DB Panel
            this.panelDB = new System.Windows.Forms.Panel();
            this.labelDBTitle = new System.Windows.Forms.Label();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.labelTableSelect = new System.Windows.Forms.Label();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelRowCount = new System.Windows.Forms.Label();

            // SQL Panel
            this.panelSQL = new System.Windows.Forms.Panel();
            this.labelSQLTitle = new System.Windows.Forms.Label();
            this.labelSQLHint = new System.Windows.Forms.Label();
            this.textSQL = new System.Windows.Forms.RichTextBox();
            this.btnRunSQL = new System.Windows.Forms.Button();
            this.btnClearSQL = new System.Windows.Forms.Button();
            this.btnTplSelect = new System.Windows.Forms.Button();
            this.btnTplInsert = new System.Windows.Forms.Button();
            this.btnTplUpdate = new System.Windows.Forms.Button();
            this.btnTplDelete = new System.Windows.Forms.Button();
            this.btnTplCreate = new System.Windows.Forms.Button();
            this.labelSQLResult = new System.Windows.Forms.Label();
            this.dataGridSQL = new System.Windows.Forms.DataGridView();

            // Stats Panel
            this.panelStats = new System.Windows.Forms.Panel();
            this.labelStatsTitle = new System.Windows.Forms.Label();
            this.listBoxStats = new System.Windows.Forms.ListBox();
            this.btnRefreshStats = new System.Windows.Forms.Button();

            // Logs Panel
            this.panelLogs = new System.Windows.Forms.Panel();
            this.labelLogsTitle = new System.Windows.Forms.Label();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.btnRefreshLogs = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQL)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelDB.SuspendLayout();
            this.panelSQL.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelLogs.SuspendLayout();
            this.SuspendLayout();

            // ===========================
            // FORM
            // ===========================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.gradient_wallpapers_5Q9Gf0WSyLk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Name = "DeveloperPanel";
            this.Text = "🛠️ Developer Panel — Full Access";

            // ===========================
            // SIDEBAR
            // ===========================
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(220, 5, 0, 20);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(230, 720);

            this.labelDevTitle.AutoSize = true;
            this.labelDevTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDevTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelDevTitle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.labelDevTitle.Location = new System.Drawing.Point(14, 14);
            this.labelDevTitle.Text = "🛠️ Developer Panel";

            this.labelDevSub.AutoSize = true;
            this.labelDevSub.BackColor = System.Drawing.Color.Transparent;
            this.labelDevSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.labelDevSub.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            this.labelDevSub.Location = new System.Drawing.Point(18, 44);
            this.labelDevSub.Text = "Your NxtHome — Full Access";

            this.labelWarning.AutoSize = false;
            this.labelWarning.BackColor = System.Drawing.Color.FromArgb(100, 80, 0, 0);
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelWarning.ForeColor = System.Drawing.Color.Tomato;
            this.labelWarning.Location = new System.Drawing.Point(5, 68);
            this.labelWarning.Size = new System.Drawing.Size(220, 38);
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarning.Text = "⚠️ Admin cannot access this panel";

            SB(this.btnDB, "🗄️  DB Browser", 118);
            SB(this.btnSQL, "⚡  SQL Runner", 164);
            SB(this.btnStats, "📊  Full Stats", 210);
            SB(this.btnLogs, "📜  Activity Logs", 256);
            SB(this.btnUserInfo, "👤  User Info", 302);
            SB(this.btnBack, "← Sign Out", 660);
            this.btnBack.ForeColor = System.Drawing.Color.Tomato;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;

            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.panelSidebar.Controls.Add(this.labelDevTitle);
            this.panelSidebar.Controls.Add(this.labelDevSub);
            this.panelSidebar.Controls.Add(this.labelWarning);
            this.panelSidebar.Controls.Add(this.btnDB);
            this.panelSidebar.Controls.Add(this.btnSQL);
            this.panelSidebar.Controls.Add(this.btnStats);
            this.panelSidebar.Controls.Add(this.btnLogs);
            this.panelSidebar.Controls.Add(this.btnUserInfo);
            this.panelSidebar.Controls.Add(this.btnBack);

            // ===========================
            // DB BROWSER PANEL
            // ===========================
            CP(this.panelDB, true);

            this.labelDBTitle.AutoSize = true;
            this.labelDBTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDBTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelDBTitle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.labelDBTitle.Location = new System.Drawing.Point(290, 16);
            this.labelDBTitle.Text = "🗄️ Database Browser";

            this.labelTableSelect.AutoSize = true;
            this.labelTableSelect.BackColor = System.Drawing.Color.Transparent;
            this.labelTableSelect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelTableSelect.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelTableSelect.Location = new System.Drawing.Point(20, 62);
            this.labelTableSelect.Text = "Select Table :";

            this.comboTables.BackColor = System.Drawing.Color.FromArgb(220, 210, 240);
            this.comboTables.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboTables.Location = new System.Drawing.Point(160, 59);
            this.comboTables.Size = new System.Drawing.Size(240, 33);
            this.comboTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTables.SelectedIndexChanged += new System.EventHandler(this.comboTables_SelectedIndexChanged);

            this.labelRowCount.AutoSize = true;
            this.labelRowCount.BackColor = System.Drawing.Color.Transparent;
            this.labelRowCount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.labelRowCount.ForeColor = System.Drawing.Color.Cyan;
            this.labelRowCount.Location = new System.Drawing.Point(420, 64);
            this.labelRowCount.Text = "Select a table to view data";

            // DataGrid
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(18, 0, 48);
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 0, 100);
            this.dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Cyan;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 0, 48);
            this.dataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FloralWhite;
            this.dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(40, 40, 80);
            this.dataGridView.Location = new System.Drawing.Point(20, 100);
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(990, 510);
            this.dataGridView.TabIndex = 0;

            // Action buttons
            AB(this.btnRefreshTable, "🔄 Refresh", 20, 628, System.Drawing.Color.DarkSlateBlue, System.Drawing.Color.Cyan);
            AB(this.btnDeleteRow, "🗑️ Delete Row", 185, 628, System.Drawing.Color.FromArgb(80, 15, 0), System.Drawing.Color.Tomato);
            AB(this.btnClearTable, "☠️ Clear Table", 360, 628, System.Drawing.Color.FromArgb(60, 0, 0), System.Drawing.Color.FromArgb(255, 80, 80));
            AB(this.btnExport, "📥 Export CSV", 535, 628, System.Drawing.Color.FromArgb(0, 60, 40), System.Drawing.Color.LightGreen);

            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.panelDB.Controls.Add(this.labelDBTitle);
            this.panelDB.Controls.Add(this.labelTableSelect);
            this.panelDB.Controls.Add(this.comboTables);
            this.panelDB.Controls.Add(this.labelRowCount);
            this.panelDB.Controls.Add(this.dataGridView);
            this.panelDB.Controls.Add(this.btnRefreshTable);
            this.panelDB.Controls.Add(this.btnDeleteRow);
            this.panelDB.Controls.Add(this.btnClearTable);
            this.panelDB.Controls.Add(this.btnExport);

            // ===========================
            // SQL RUNNER PANEL
            // ===========================
            CP(this.panelSQL, false);

            this.labelSQLTitle.AutoSize = true;
            this.labelSQLTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSQLTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelSQLTitle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.labelSQLTitle.Location = new System.Drawing.Point(290, 16);
            this.labelSQLTitle.Text = "⚡ SQL Runner";

            this.labelSQLHint.AutoSize = true;
            this.labelSQLHint.BackColor = System.Drawing.Color.Transparent;
            this.labelSQLHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelSQLHint.ForeColor = System.Drawing.Color.Gold;
            this.labelSQLHint.Location = new System.Drawing.Point(20, 58);
            this.labelSQLHint.Text = "⚠️ Run any SQL — SELECT returns results below. INSERT/UPDATE/DELETE executes directly.";

            // Templates row
            TP(this.btnTplSelect, "SELECT", 20, 80);
            TP(this.btnTplInsert, "INSERT", 135, 80);
            TP(this.btnTplUpdate, "UPDATE", 250, 80);
            TP(this.btnTplDelete, "DELETE", 365, 80);
            TP(this.btnTplCreate, "TABLES", 480, 80);

            this.btnTplSelect.Click += new System.EventHandler(this.btnTplSelect_Click);
            this.btnTplInsert.Click += new System.EventHandler(this.btnTplInsert_Click);
            this.btnTplUpdate.Click += new System.EventHandler(this.btnTplUpdate_Click);
            this.btnTplDelete.Click += new System.EventHandler(this.btnTplDelete_Click);
            this.btnTplCreate.Click += new System.EventHandler(this.btnTplCreate_Click);

            // SQL text box
            this.textSQL.BackColor = System.Drawing.Color.FromArgb(10, 0, 30);
            this.textSQL.Font = new System.Drawing.Font("Consolas", 11F);
            this.textSQL.ForeColor = System.Drawing.Color.LightGreen;
            this.textSQL.Location = new System.Drawing.Point(20, 120);
            this.textSQL.Size = new System.Drawing.Size(990, 130);
            this.textSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            AB(this.btnRunSQL, "▶ Run Query", 20, 260, System.Drawing.Color.FromArgb(0, 80, 20), System.Drawing.Color.LightGreen);
            AB(this.btnClearSQL, "✖ Clear", 210, 260, System.Drawing.Color.FromArgb(60, 15, 0), System.Drawing.Color.Tomato);
            this.btnRunSQL.Click += new System.EventHandler(this.btnRunSQL_Click);
            this.btnClearSQL.Click += new System.EventHandler(this.btnClearSQL_Click);

            this.labelSQLResult.AutoSize = false;
            this.labelSQLResult.BackColor = System.Drawing.Color.Transparent;
            this.labelSQLResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelSQLResult.ForeColor = System.Drawing.Color.LightGreen;
            this.labelSQLResult.Location = new System.Drawing.Point(420, 270);
            this.labelSQLResult.Size = new System.Drawing.Size(590, 28);
            this.labelSQLResult.Text = "";

            this.dataGridSQL.BackgroundColor = System.Drawing.Color.FromArgb(18, 0, 48);
            this.dataGridSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridSQL.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 0, 100);
            this.dataGridSQL.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Cyan;
            this.dataGridSQL.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridSQL.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 0, 48);
            this.dataGridSQL.DefaultCellStyle.ForeColor = System.Drawing.Color.FloralWhite;
            this.dataGridSQL.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridSQL.GridColor = System.Drawing.Color.FromArgb(40, 40, 80);
            this.dataGridSQL.Location = new System.Drawing.Point(20, 308);
            this.dataGridSQL.ReadOnly = true;
            this.dataGridSQL.RowHeadersVisible = false;
            this.dataGridSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSQL.Size = new System.Drawing.Size(990, 380);
            this.dataGridSQL.TabIndex = 0;

            this.panelSQL.Controls.Add(this.labelSQLTitle);
            this.panelSQL.Controls.Add(this.labelSQLHint);
            this.panelSQL.Controls.Add(this.btnTplSelect);
            this.panelSQL.Controls.Add(this.btnTplInsert);
            this.panelSQL.Controls.Add(this.btnTplUpdate);
            this.panelSQL.Controls.Add(this.btnTplDelete);
            this.panelSQL.Controls.Add(this.btnTplCreate);
            this.panelSQL.Controls.Add(this.textSQL);
            this.panelSQL.Controls.Add(this.btnRunSQL);
            this.panelSQL.Controls.Add(this.btnClearSQL);
            this.panelSQL.Controls.Add(this.labelSQLResult);
            this.panelSQL.Controls.Add(this.dataGridSQL);

            // ===========================
            // STATS PANEL
            // ===========================
            CP(this.panelStats, false);

            this.labelStatsTitle.AutoSize = true;
            this.labelStatsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelStatsTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelStatsTitle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.labelStatsTitle.Location = new System.Drawing.Point(290, 16);
            this.labelStatsTitle.Text = "📊 Full Platform Statistics";

            this.listBoxStats.BackColor = System.Drawing.Color.FromArgb(10, 0, 30);
            this.listBoxStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxStats.Font = new System.Drawing.Font("Consolas", 11F);
            this.listBoxStats.ForeColor = System.Drawing.Color.LightGreen;
            this.listBoxStats.Location = new System.Drawing.Point(20, 65);
            this.listBoxStats.Size = new System.Drawing.Size(990, 580);

            AB(this.btnRefreshStats, "🔄 Refresh Stats", 20, 658, System.Drawing.Color.DarkSlateBlue, System.Drawing.Color.Cyan);
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);

            this.panelStats.Controls.Add(this.labelStatsTitle);
            this.panelStats.Controls.Add(this.listBoxStats);
            this.panelStats.Controls.Add(this.btnRefreshStats);

            // ===========================
            // LOGS PANEL
            // ===========================
            CP(this.panelLogs, false);

            this.labelLogsTitle.AutoSize = true;
            this.labelLogsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelLogsTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.labelLogsTitle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.labelLogsTitle.Location = new System.Drawing.Point(290, 16);
            this.labelLogsTitle.Text = "📜 Recent Activity Logs";

            this.listBoxLogs.BackColor = System.Drawing.Color.FromArgb(10, 0, 30);
            this.listBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLogs.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.listBoxLogs.ForeColor = System.Drawing.Color.Cyan;
            this.listBoxLogs.Location = new System.Drawing.Point(20, 65);
            this.listBoxLogs.Size = new System.Drawing.Size(990, 580);

            AB(this.btnRefreshLogs, "🔄 Refresh Logs", 20, 658, System.Drawing.Color.DarkSlateBlue, System.Drawing.Color.Cyan);
            this.btnRefreshLogs.Click += new System.EventHandler(this.btnRefreshLogs_Click);

            this.panelLogs.Controls.Add(this.labelLogsTitle);
            this.panelLogs.Controls.Add(this.listBoxLogs);
            this.panelLogs.Controls.Add(this.btnRefreshLogs);

            // ===========================
            // ADD TO FORM
            // ===========================
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelDB);
            this.Controls.Add(this.panelSQL);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelLogs);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQL)).EndInit();
            this.panelSidebar.ResumeLayout(false); this.panelSidebar.PerformLayout();
            this.panelDB.ResumeLayout(false); this.panelDB.PerformLayout();
            this.panelSQL.ResumeLayout(false); this.panelSQL.PerformLayout();
            this.panelStats.ResumeLayout(false); this.panelStats.PerformLayout();
            this.panelLogs.ResumeLayout(false); this.panelLogs.PerformLayout();
            this.ResumeLayout(false);
        }

        // helpers
        private void SB(System.Windows.Forms.Button b, string text, int y)
        {
            b.BackColor = System.Drawing.Color.FromArgb(20, 0, 60);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 0, 0);
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            b.ForeColor = System.Drawing.Color.FromArgb(255, 120, 120);
            b.Location = new System.Drawing.Point(5, y);
            b.Size = new System.Drawing.Size(220, 40);
            b.Text = text;
            b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            b.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            b.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
        }

        private void CP(System.Windows.Forms.Panel p, bool visible)
        {
            p.BackColor = System.Drawing.Color.Transparent;
            p.Location = new System.Drawing.Point(230, 0);
            p.Size = new System.Drawing.Size(1050, 720);
            p.Visible = visible;
        }

        private void AB(System.Windows.Forms.Button b, string text, int x, int y,
            System.Drawing.Color back, System.Drawing.Color fore)
        {
            b.BackColor = back; b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = fore;
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            b.ForeColor = fore; b.Location = new System.Drawing.Point(x, y);
            b.Size = new System.Drawing.Size(165, 40); b.Text = text;
        }

        private void TP(System.Windows.Forms.Button b, string text, int x, int y)
        {
            b.BackColor = System.Drawing.Color.FromArgb(30, 0, 60);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 0, 120);
            b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            b.ForeColor = System.Drawing.Color.FromArgb(200, 150, 255);
            b.Location = new System.Drawing.Point(x, y);
            b.Size = new System.Drawing.Size(105, 30); b.Text = text;
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelDevTitle, labelDevSub, labelWarning;
        private System.Windows.Forms.Button btnDB, btnSQL, btnStats, btnLogs, btnUserInfo, btnBack;

        private System.Windows.Forms.Panel panelDB;
        private System.Windows.Forms.Label labelDBTitle, labelTableSelect, labelRowCount;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefreshTable, btnDeleteRow, btnClearTable, btnExport;

        private System.Windows.Forms.Panel panelSQL;
        private System.Windows.Forms.Label labelSQLTitle, labelSQLHint, labelSQLResult;
        private System.Windows.Forms.RichTextBox textSQL;
        private System.Windows.Forms.DataGridView dataGridSQL;
        private System.Windows.Forms.Button btnRunSQL, btnClearSQL;
        private System.Windows.Forms.Button btnTplSelect, btnTplInsert, btnTplUpdate, btnTplDelete, btnTplCreate;

        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label labelStatsTitle;
        private System.Windows.Forms.ListBox listBoxStats;
        private System.Windows.Forms.Button btnRefreshStats;

        private System.Windows.Forms.Panel panelLogs;
        private System.Windows.Forms.Label labelLogsTitle;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Button btnRefreshLogs;
    }
}