
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YourNxtHome
{
    public partial class Developer : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";

        public Developer()
        {
            InitializeComponent();
            ShowPanel(panelDB);
            LoadTableList();
        }

        // =============================================
        // PANEL SWITCH
        // =============================================
        private void ShowPanel(Panel p)
        {
            panelDB.Visible = false;
            panelSQL.Visible = false;
            panelStats.Visible = false;
            panelLogs.Visible = false;
            p.Visible = true;
        }

        private void btnDB_Click(object sender, EventArgs e) { ShowPanel(panelDB); LoadTableList(); }
        private void btnSQL_Click(object sender, EventArgs e) { ShowPanel(panelSQL); }
        private void btnStats_Click(object sender, EventArgs e) { ShowPanel(panelStats); LoadStats(); }
        private void btnLogs_Click(object sender, EventArgs e) { ShowPanel(panelLogs); LoadLogs(); }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainpage m = new Mainpage();
            m.Show();
            this.Close();
        }

        // =============================================
        // DB VIEWER — browse any table
        // =============================================
        private void LoadTableList()
        {
            comboTables.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    comboTables.Items.Add(dr["TABLE_NAME"].ToString());
                con.Close();
                if (comboTables.Items.Count > 0)
                    comboTables.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void comboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem == null) return;
            LoadTableData(comboTables.SelectedItem.ToString());
        }

        private void LoadTableData(string tableName)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [{tableName}]", con);
                con.Open();
                var adapter = new System.Data.SqlClient.SqlDataAdapter();

                // Use Microsoft.Data.SqlClient adapter
                SqlConnection con2 = new SqlConnection(connStr);
                SqlCommand cmd2 = new SqlCommand($"SELECT * FROM [{tableName}]", con2);
                con2.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dataGridView.DataSource = null;

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr2);
                con2.Close();

                dataGridView.DataSource = dt;
                dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                labelRowCount.Text = $"Table: [{tableName}]   Rows: {dt.Rows.Count}";
            }
            catch (Exception ex) { MessageBox.Show("Error loading table: " + ex.Message); }
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
                LoadTableData(comboTables.SelectedItem.ToString());
        }

        // Delete selected row
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            { MessageBox.Show("Select a row first."); return; }
            if (comboTables.SelectedItem == null) return;

            string tableName = comboTables.SelectedItem.ToString();
            var row = dataGridView.SelectedRows[0];

            if (MessageBox.Show($"Delete selected row from [{tableName}]?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                // Build WHERE clause from first column (usually PK)
                string colName = dataGridView.Columns[0].HeaderText;
                string colVal = row.Cells[0].Value?.ToString() ?? "";

                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand($"DELETE FROM [{tableName}] WHERE [{colName}]=@val", con);
                cmd.Parameters.AddWithValue("@val", colVal);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show("Row deleted! 🗑️");
                LoadTableData(tableName);
            }
            catch (Exception ex) { MessageBox.Show("Delete error: " + ex.Message); }
        }

        // Clear entire table
        private void btnClearTable_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem == null) return;
            string tableName = comboTables.SelectedItem.ToString();

            if (MessageBox.Show($"⚠️ DELETE ALL ROWS from [{tableName}]?\n\nThis cannot be undone!",
                "DANGER", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.Yes) return;

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand($"DELETE FROM [{tableName}]", con);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show($"Table [{tableName}] cleared! 🗑️");
                LoadTableData(tableName);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Export table as CSV
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem == null) return;
            string tableName = comboTables.SelectedItem.ToString();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files|*.csv";
            sfd.FileName = tableName + "_export.csv";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                // Header
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sb.Append(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.Columns.Count - 1) sb.Append(",");
                }
                sb.AppendLine();

                // Rows
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView.Rows)
                {
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value?.ToString()?.Replace(",", ";") ?? "");
                        if (i < dataGridView.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();
                }

                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show($"Exported to:\n{sfd.FileName} ✅");
            }
            catch (Exception ex) { MessageBox.Show("Export error: " + ex.Message); }
        }

        // =============================================
        // SQL RUNNER — run any query
        // =============================================
        private void btnRunSQL_Click(object sender, EventArgs e)
        {
            string sql = textSQL.Text.Trim();
            if (sql == "") { MessageBox.Show("Enter a SQL query first."); return; }

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                string sqlUpper = sql.ToUpper().TrimStart();

                if (sqlUpper.StartsWith("SELECT"))
                {
                    // SELECT → show in grid
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(dr);
                    con.Close();
                    dataGridSQL.DataSource = dt;
                    dataGridSQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    labelSQLResult.Text = $"✅ Returned {dt.Rows.Count} rows.";
                    labelSQLResult.ForeColor = Color.LightGreen;
                }
                else
                {
                    // INSERT / UPDATE / DELETE / CREATE etc.
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int affected = cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridSQL.DataSource = null;
                    labelSQLResult.Text = $"✅ Query executed. {affected} row(s) affected.";
                    labelSQLResult.ForeColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                labelSQLResult.Text = "❌ Error: " + ex.Message;
                labelSQLResult.ForeColor = Color.Tomato;
            }
        }

        private void btnClearSQL_Click(object sender, EventArgs e)
        {
            textSQL.Clear();
            dataGridSQL.DataSource = null;
            labelSQLResult.Text = "";
        }

        // Quick SQL templates
        private void btnTplSelect_Click(object sender, EventArgs e)
            => textSQL.Text = "SELECT * FROM User_info";
        private void btnTplInsert_Click(object sender, EventArgs e)
            => textSQL.Text = "INSERT INTO Posts (OwnerId, PostTitle, Location, Rent, Description, TenantType, RestrictionType, PostDate)\nVALUES ('userId', 'Title', 'Location', 10000, 'Description', 'Bachelor', 'RestrictionLess', GETDATE())";
        private void btnTplUpdate_Click(object sender, EventArgs e)
            => textSQL.Text = "UPDATE User_info SET Role='Admin' WHERE UserId='userId'";
        private void btnTplDelete_Click(object sender, EventArgs e)
            => textSQL.Text = "DELETE FROM Posts WHERE PostId=1";
        private void btnTplCreate_Click(object sender, EventArgs e)
            => textSQL.Text = "-- Check tables\nSELECT TABLE_NAME, TABLE_TYPE\nFROM INFORMATION_SCHEMA.TABLES\nORDER BY TABLE_NAME";
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo("Developer");
            ui.Show();
        }
        // =============================================
        // STATS — full platform stats
        // =============================================
        private void LoadStats()
        {
            listBoxStats.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                listBoxStats.Items.Add("════════ DATABASE STATISTICS ════════");
                listBoxStats.Items.Add("");
                listBoxStats.Items.Add("── USERS ──────────────────────────────");
                listBoxStats.Items.Add("  Total Users       : " + Q(con, "SELECT COUNT(*) FROM User_info"));
                listBoxStats.Items.Add("  Admin Users       : " + Q(con, "SELECT COUNT(*) FROM User_info WHERE Role='Admin'"));
                listBoxStats.Items.Add("  Regular Users     : " + Q(con, "SELECT COUNT(*) FROM User_info WHERE Role!='Admin' OR Role IS NULL"));
                listBoxStats.Items.Add("");
                listBoxStats.Items.Add("── POSTS ───────────────────────────────");
                listBoxStats.Items.Add("  Total Posts       : " + Q(con, "SELECT COUNT(*) FROM Posts"));
                listBoxStats.Items.Add("  Bachelor Posts    : " + Q(con, "SELECT COUNT(*) FROM Posts WHERE TenantType='Bachelor'"));
                listBoxStats.Items.Add("  Family Posts      : " + Q(con, "SELECT COUNT(*) FROM Posts WHERE TenantType='Family'"));
                listBoxStats.Items.Add("  Restricted        : " + Q(con, "SELECT COUNT(*) FROM Posts WHERE RestrictionType='Restricted'"));
                listBoxStats.Items.Add("  RestrictionLess   : " + Q(con, "SELECT COUNT(*) FROM Posts WHERE RestrictionType='RestrictionLess'"));
                listBoxStats.Items.Add("");
                listBoxStats.Items.Add("── BOOKINGS ────────────────────────────");
                listBoxStats.Items.Add("  Total Bookings    : " + Q(con, "SELECT COUNT(*) FROM Bookings"));
                listBoxStats.Items.Add("  Pending           : " + Q(con, "SELECT COUNT(*) FROM Bookings WHERE Status='Pending'"));
                listBoxStats.Items.Add("  Confirmed         : " + Q(con, "SELECT COUNT(*) FROM Bookings WHERE Status='Confirmed'"));
                listBoxStats.Items.Add("  Rejected          : " + Q(con, "SELECT COUNT(*) FROM Bookings WHERE Status='Rejected'"));
                listBoxStats.Items.Add("");
                listBoxStats.Items.Add("── MESSAGES & RATINGS ──────────────────");
                listBoxStats.Items.Add("  Total Messages    : " + Q(con, "SELECT COUNT(*) FROM Messages"));
                listBoxStats.Items.Add("  Offer Messages    : " + Q(con, "SELECT COUNT(*) FROM Messages WHERE MessageText LIKE '[OFFER]%'"));
                listBoxStats.Items.Add("  Total Ratings     : " + Q(con, "SELECT COUNT(*) FROM Ratings"));
                listBoxStats.Items.Add("  Avg Rating        : " + Q(con, "SELECT ISNULL(CAST(AVG(CAST(Rating AS FLOAT)) AS VARCHAR),'N/A') FROM Ratings"));
                listBoxStats.Items.Add("  Wishlist Items    : " + Q(con, "SELECT COUNT(*) FROM Wishlist"));
                listBoxStats.Items.Add("");
                listBoxStats.Items.Add("── TOP OWNERS (most posts) ─────────────");

                // Top 5 owners
                SqlCommand topOwners = new SqlCommand(@"
                    SELECT TOP 5 u.Name, COUNT(p.PostId) AS PostCount
                    FROM Posts p JOIN User_info u ON p.OwnerId=u.UserId
                    GROUP BY u.Name ORDER BY PostCount DESC", con);
                SqlDataReader dr = topOwners.ExecuteReader();
                while (dr.Read())
                    listBoxStats.Items.Add($"  {dr["Name"]}  →  {dr["PostCount"]} posts");
                dr.Close();

                listBoxStats.Items.Add("");
                listBoxStats.Items.Add("── TOP RENTERS (most bookings) ─────────");
                SqlCommand topRenters = new SqlCommand(@"
                    SELECT TOP 5 u.Name, COUNT(b.BookingId) AS BookCount
                    FROM Bookings b JOIN User_info u ON b.UserId=u.UserId
                    GROUP BY u.Name ORDER BY BookCount DESC", con);
                dr = topRenters.ExecuteReader();
                while (dr.Read())
                    listBoxStats.Items.Add($"  {dr["Name"]}  →  {dr["BookCount"]} bookings");
                dr.Close();

                con.Close();
                listBoxStats.Items.Add("");
                listBoxStats.Items.Add($"  Last updated: {DateTime.Now:dd MMM yyyy  hh:mm:ss tt}");
            }
            catch (Exception ex) { MessageBox.Show("Stats error: " + ex.Message); }
        }

        private string Q(SqlConnection con, string query)
        {
            try { return new SqlCommand(query, con).ExecuteScalar()?.ToString() ?? "0"; }
            catch { return "Error"; }
        }

        // =============================================
        // LOGS — recent activity
        // =============================================
        private void LoadLogs()
        {
            listBoxLogs.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                listBoxLogs.Items.Add("════════ RECENT ACTIVITY LOG ════════");
                listBoxLogs.Items.Add("");
                listBoxLogs.Items.Add("── LATEST BOOKINGS ─────────────────────");

                SqlCommand cmd = new SqlCommand(@"
                    SELECT TOP 10 u.Name AS Renter, p.PostTitle, b.Status, b.BookingDate
                    FROM Bookings b
                    JOIN Posts p ON b.PostId=p.PostId
                    JOIN User_info u ON b.UserId=u.UserId
                    ORDER BY b.BookingDate DESC", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBoxLogs.Items.Add($"  [{Convert.ToDateTime(dr["BookingDate"]):dd MMM hh:mm tt}]  {dr["Renter"]} → {dr["PostTitle"]}  [{dr["Status"]}]");
                dr.Close();

                listBoxLogs.Items.Add("");
                listBoxLogs.Items.Add("── LATEST MESSAGES ─────────────────────");
                cmd = new SqlCommand(@"
                    SELECT TOP 10 s.Name AS Sender, r.Name AS Receiver, m.MessageText, m.SentTime
                    FROM Messages m
                    JOIN User_info s ON m.SenderId=s.UserId
                    JOIN User_info r ON m.ReceiverId=r.UserId
                    ORDER BY m.SentTime DESC", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string msg = dr["MessageText"].ToString();
                    if (msg.Length > 40) msg = msg[..40] + "...";
                    listBoxLogs.Items.Add($"  [{Convert.ToDateTime(dr["SentTime"]):dd MMM hh:mm tt}]  {dr["Sender"]} → {dr["Receiver"]}:  {msg}");
                }
                dr.Close();

                listBoxLogs.Items.Add("");
                listBoxLogs.Items.Add("── LATEST POSTS ────────────────────────");
                cmd = new SqlCommand(@"
                    SELECT TOP 10 u.Name AS Owner, p.PostTitle, p.Location, p.PostDate
                    FROM Posts p JOIN User_info u ON p.OwnerId=u.UserId
                    ORDER BY p.PostDate DESC", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBoxLogs.Items.Add($"  [{Convert.ToDateTime(dr["PostDate"]):dd MMM hh:mm tt}]  {dr["Owner"]} posted: {dr["PostTitle"]}  ({dr["Location"]})");
                dr.Close();

                con.Close();
                listBoxLogs.Items.Add("");
                listBoxLogs.Items.Add($"  Loaded at: {DateTime.Now:dd MMM yyyy  hh:mm:ss tt}");
            }
            catch (Exception ex) { MessageBox.Show("Log error: " + ex.Message); }
        }

        private void btnRefreshLogs_Click(object sender, EventArgs e) => LoadLogs();
        private void btnRefreshStats_Click(object sender, EventArgs e) => LoadStats();

        // hover
        private void btn_MouseEnter(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(60, 0, 120); }
        private void btn_MouseLeave(object sender, EventArgs e)
        { if (sender is Button b) b.BackColor = Color.FromArgb(20, 0, 60); }
    }
}