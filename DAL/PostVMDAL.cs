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
    public class PostVMDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        public PostVMDAL()
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

        public List<PostViewModel> GetUsernameByID()
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement 
            cmd.CommandText = @"Select * from Users u INNER JOIN Post p ON u.UserID = p.UserID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a staff list
            List<PostViewModel> postVMList = new List<PostViewModel>();
            while (reader.Read())
            {
                postVMList.Add(
                new PostViewModel
                {
                        UserID = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        PostID = reader.GetInt32(4),
                        Title = reader.GetString(6),
                        HawkerName = reader.GetString(7),
                        HawkerStore = reader.GetString(8),
                        Rating = reader.GetInt32(9),
                        Description = reader.GetString(10),
                        FileSubmitted = !reader.IsDBNull(11) ? reader.GetString(11) : (String)null

                }
                );
            }
            // Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return postVMList;
        }
    }
}
