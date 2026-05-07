using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YourNxtHome
{
    public partial class UserInfo : Form

    {
        Users usr = new Users();
        private string currentUserRole;
        public UserInfo(string role)
        {
            InitializeComponent();
            currentUserRole = role;
            dgvUserInfo.DataSource = usr.GetUserInfo();
            ApplyRolePermission();
        }
        private void ApplyRolePermission()
        {
            if (currentUserRole == "Admin")
            {
                cmbRole.Enabled = false;
            }
            else if (currentUserRole == "Developer")
            {
                cmbRole.Enabled = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                   string.IsNullOrWhiteSpace(txtUserid.Text))
            {
                MessageBox.Show("Please fill all required fields!");
                return;
            }

            usr.Name = txtName.Text;
            usr.Contact = txtContact.Text;
            usr.Address = txtAddress.Text;
            usr.Occupation = txtOccupation.Text;
            usr.NID = txtNid.Text;
            usr.Email = txtEmail.Text;
            usr.UserPassword = txtPass.Text;
            usr.UserId = txtUserid.Text;
            usr.Role = cmbRole.Text;
            var success = usr.InsertUser(usr);
            dgvUserInfo.DataSource = usr.GetUserInfo();
            ClearControls();
            if (success)
                MessageBox.Show("User has been added successfully");
            else
                MessageBox.Show("Error occured. Please try again...");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserid.Text))
            {
                MessageBox.Show("Select a user first!");
                return;
            }
            /*if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please select a role!");
                return;
            }*/
            usr.Name = txtName.Text;
            usr.Contact = txtContact.Text;
            usr.Address = txtAddress.Text;
            usr.Occupation = txtOccupation.Text;
            usr.NID = txtNid.Text;
            usr.Email = txtEmail.Text;
            usr.UserPassword = txtPass.Text;
            usr.UserId = txtUserid.Text;
            usr.Role = cmbRole.Text;
            var success = usr.UpdateUser(usr);
            dgvUserInfo.DataSource = usr.GetUserInfo();
            ClearControls();
            if (success)
                MessageBox.Show("User has been updated successfully");
            else
                MessageBox.Show("Error occured. Please try again...");
        }

        private void ClearControls()
        {
            txtUserid.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtOccupation.Text = "";
            txtNid.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Mainpage mp = new Mainpage();
            mp.Show();
            this.Hide();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserid.Text))
            {
                MessageBox.Show("Select a user first!");
                return;
            }
            usr.UserId = txtUserid.Text;
            var success = usr.DeleteUser(usr);
            dgvUserInfo.DataSource = usr.GetUserInfo();
            if (success)
                MessageBox.Show("User has been deleted successfully");
            else
                MessageBox.Show("Error occured. Please try again...");
        }

        private void dgvUserInfo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUserInfo.Rows[e.RowIndex];

                txtUserid.Text = row.Cells[0].Value?.ToString() ?? "";
                txtName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtContact.Text = row.Cells[2].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells[3].Value?.ToString() ?? "";
                txtNid.Text = row.Cells[4].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells[5].Value?.ToString() ?? "";
                txtOccupation.Text = row.Cells[6].Value?.ToString() ?? "";
                txtPass.Text = row.Cells[7].Value?.ToString() ?? "";
                cmbRole.Text = row.Cells[8].Value?.ToString() ?? "";
            }
        }
    }
}
