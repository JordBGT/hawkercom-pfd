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
    public class LoginDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        public LoginDAL()
        {
            //Read connection string from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString("HawkerComConnectionString");

            //Instantiate a Sql connection object with connection string read
            conn = new SqlConnection(strConn);
        }

        public bool ValidateUser(string email, string password)
        {
            bool userFound = false;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Users WHERE EmailAddr = @enteredEmail";
            cmd.Parameters.AddWithValue("@enteredEmail", email);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(3) == password)
                    {
                        userFound = true;
                    }
                }
            }
            else
            {
                userFound = false;
            }
            reader.Close();
            conn.Close();

            return userFound;
        }

        public int GetUserID(string email)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Users WHERE EmailAddr = @enteredEmail";
            cmd.Parameters.AddWithValue("@enteredEmail", email);

            int userid = 0;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userid = reader.GetInt32(0);
                }
            }


            reader.Close();
            conn.Close();
            return userid;
        }
        public string GetUserName(string email)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Users WHERE EmailAddr = @enteredEmail";
            cmd.Parameters.AddWithValue("@enteredEmail", email);

            string userName = "";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userName = reader.GetString(1);
                }
            }


            reader.Close();
            conn.Close();
            return userName;
        }

        public string GetUserEmail(string email)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Users WHERE EmailAddr = @enteredEmail";
            cmd.Parameters.AddWithValue("@enteredEmail", email);

            string userEmail = "";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userEmail = reader.GetString(2);
                }
            }


            reader.Close();
            conn.Close();
            return userEmail;
        }

        public string GetUserPassword(string email)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Users WHERE EmailAddr = @enteredEmail";
            cmd.Parameters.AddWithValue("@enteredEmail", email);

            string userPassword = "";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userPassword = reader.GetString(3);
                }
            }


            reader.Close();
            conn.Close();
            return userPassword;
        }


    }



   
}
