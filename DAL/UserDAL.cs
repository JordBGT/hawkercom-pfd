using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using PFD_Team3.Models;

namespace PFD_Team3.DAL
{
    public class UserDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        public UserDAL()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString("HawkerComConnectionString");

            conn = new SqlConnection(strConn);
        }

        //Add user to database
        public int Add(User user)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an INSERT SQL statement which will
            //return the auto-generated AreaInterestID after insertion
            cmd.CommandText = @"INSERT INTO Users(Name, EmailAddr, Password) OUTPUT INSERTED.UserID VALUES(@name, @email, @pwd)";

            //parameter
            cmd.Parameters.AddWithValue("@name", user.UserName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@pwd", user.Password);

            conn.Open();
            user.UserID = (int)cmd.ExecuteScalar();

            conn.Close();

            return user.UserID;
        }

        //Check whether email exist in database
        public bool IsEmailExist(string email)
        {
            //bool emailFound = false;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT UserID FROM Users WHERE EmailAddr = @selectedEmail";
            cmd.Parameters.AddWithValue("@selectedEmail", email);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return true;

            }

            reader.Close();
            conn.Close();
            return false;
        }

        public User GetDetails(int userID)
        {
            User user = new User();

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify the SELECT SQL statement that 
            //retrieves all attributes of a AreaInterest record.
            cmd.CommandText = @"SELECT * FROM Users WHERE UserID = @selectedUserID";

            //Define the parameter used in SQL statement, value for the
            //parameter is retrieved from the method parameter “AreaInterestID”.
            cmd.Parameters.AddWithValue("@selectedUserID", userID);

            //Open a database connection
            conn.Open();

            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user.UserID = userID;
                    user.UserName = !reader.IsDBNull(1) ? reader.GetString(1) : null;
                    user.Email = !reader.IsDBNull(2) ? reader.GetString(2) : null;
                    user.Password = !reader.IsDBNull(3) ? reader.GetString(3) : null;

                }
            }
            reader.Close();
            conn.Close();
            return user;
        }

        public int Update(User user)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an UPDATE SQL statement
            cmd.CommandText = @"UPDATE Users SET Name= @name, EmailAddr= @email, Password= @pass WHERE UserID = @selectedUserID";

            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@name", user.UserName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@pass", user.Password);
            cmd.Parameters.AddWithValue("@selectedUserID", user.UserID);

            //Open a database connection
            conn.Open();

            //ExecuteNonQuery is used for UPDATE and DELETE
            int count = cmd.ExecuteNonQuery();

            //Close the database connection
            conn.Close();

            return count;
        }

    }

    
}
