using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourNxtHome
{
    internal class Users
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public string Name { get; set; }= string.Empty;
        public string Contact { get; set; }=string.Empty;
        public string Address { get; set; }=String.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string NID { get; set; }= String.Empty;
        public string Email { get; set; }= String.Empty;
        public string UserId { get; set; } = String.Empty;
        public string Role { get; set; } = string.Empty;
        public string UserPassword { get; set; }= String.Empty;
        private const string SelectQuery = "Select * from User_info";
        private const string InsertQuery = "INSERT INTO dbo.User_info ([Name], [Phone], [Address], [Occupation], [NID], [Email], [UserId], [UserPassword],[Role]) VALUES (@Name, @Phone, @Address, @Occupation, @NID, @Email, @UserId, @UserPassword,@Role)";
        private const string UpdateQuery = "Update User_info set Name=@Name, Phone=@Phone, Address=@Address, Occupation=@Occupation, NID=@NID, Email=@Email, UserPassword=@UserPassword, Role=@Role where UserId=@UserId";
        private const string DeleteQuery = "Delete from User_info where UserId=@UserId";

        public DataTable GetUserInfo()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertUser(Users user)
        {
            int rows = 0;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Name", user.Name);
                    com.Parameters.AddWithValue("@Phone", user.Contact);
                    com.Parameters.AddWithValue("@Address", user.Address);
                    com.Parameters.AddWithValue("@Occupation", user.Occupation);
                    com.Parameters.AddWithValue("@NID", user.NID);
                    com.Parameters.AddWithValue("@Email", user.Email);
                    com.Parameters.AddWithValue("@UserId", user.UserId);
                    com.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                    com.Parameters.AddWithValue("@Role", user.Role);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool UpdateUser(Users user)
        {
            int rows = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                    {
                        com.Parameters.AddWithValue("@Name", user.Name);
                        com.Parameters.AddWithValue("@Phone", user.Contact);
                        com.Parameters.AddWithValue("@Address", user.Address);
                        com.Parameters.AddWithValue("@Occupation", user.Occupation);
                        com.Parameters.AddWithValue("@NID", user.NID);
                        com.Parameters.AddWithValue("@Email", user.Email);
                        com.Parameters.AddWithValue("@UserId", user.UserId);
                        com.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                        com.Parameters.AddWithValue("@Role", user.Role);
                        rows = com.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteUser(Users user)
        {
            int rows = 0;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@UserId", user.UserId);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}