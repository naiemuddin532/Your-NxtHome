#nullable disable
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
    public partial class AdminEditPost : Form
    {
        string connStr = "Data Source=NAIEM;Initial Catalog=User_info;Integrated Security=True;TrustServerCertificate=True";
        int postId = -1;

        public AdminEditPost(int id)
        {
            InitializeComponent();
            postId = id;
            LoadPost();
        }

        private void LoadPost()
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "SELECT PostTitle,Location,Rent,Description,TenantType,RestrictionType FROM Posts WHERE PostId=@pid", con);
                cmd.Parameters.AddWithValue("@pid", postId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textTitle.Text = dr["PostTitle"].ToString();
                    textLocation.Text = dr["Location"].ToString();
                    textRent.Text = dr["Rent"].ToString();
                    textDescription.Text = dr["Description"].ToString();

                    string tenant = dr["TenantType"].ToString();
                    string restrict = dr["RestrictionType"].ToString();
                    radioBachelor.Checked = tenant == "Bachelor";
                    radioFamily.Checked = tenant == "Family";
                    radioRestricted.Checked = restrict == "Restricted";
                    radioRestrictionLess.Checked = restrict == "RestrictionLess";
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error loading: " + ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textTitle.Text.Trim() == "" || textLocation.Text.Trim() == "" || textRent.Text.Trim() == "")
            { MessageBox.Show("Title, Location and Rent are required."); return; }

            if (!int.TryParse(textRent.Text.Trim(), out int rent))
            { MessageBox.Show("Rent must be a number."); return; }

            string tenant = radioBachelor.Checked ? "Bachelor" : "Family";
            string restrict = radioRestricted.Checked ? "Restricted" : "RestrictionLess";

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Posts SET
                        PostTitle=@title, Location=@loc, Rent=@rent,
                        Description=@desc, TenantType=@tenant, RestrictionType=@restrict
                    WHERE PostId=@pid", con);
                cmd.Parameters.AddWithValue("@title", textTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@loc", textLocation.Text.Trim());
                cmd.Parameters.AddWithValue("@rent", rent);
                cmd.Parameters.AddWithValue("@desc", textDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@tenant", tenant);
                cmd.Parameters.AddWithValue("@restrict", restrict);
                cmd.Parameters.AddWithValue("@pid", postId);
                con.Open(); cmd.ExecuteNonQuery(); con.Close();
                MessageBox.Show("Post updated successfully! ✅");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}