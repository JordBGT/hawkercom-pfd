using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using PFD_Team3.Models;
using Microsoft.AspNetCore.Http;

namespace PFD_Team3.DAL
{
    public class PostDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;
        

        public PostDAL()
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
        public Post GetDetails(int id)
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Post WHERE UserID = @selectedUserID";
            cmd.Parameters.AddWithValue("@selectedUserID", id);

            //Open a database connection
            conn.Open();

            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Post post = new Post
                    {
                        PostID = reader.GetInt32(0),
                        UserID = reader.GetInt32(1),
                        Title = reader.GetString(2),
                        HawkerName = reader.GetString(3),
                        HawkerStore = reader.GetString(4),
                        Rating = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        FileSubmitted = reader.GetString(7)
                    };
                    return post;
                }
            }
            reader.Close();
            conn.Close();
            return null;
            
        }
        public int Add(Post post, int id)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an INSERT SQL statement which will
            //return the auto-generated AreaInterestID after insertion
            cmd.CommandText = @"INSERT INTO Post(UserID, Title, HawkerName, HawkerStore, Rating, Description, FileSubmitted) OUTPUT INSERTED.PostID VALUES(@userid, @title, @hawkername, @hawkerstore, @rating, @description, @filesubmitted)";

            //parameter
            post.UserID = id;
            cmd.Parameters.AddWithValue("@userid", post.UserID);
            cmd.Parameters.AddWithValue("@title", post.Title);
            cmd.Parameters.AddWithValue("@hawkername", post.HawkerName);
            cmd.Parameters.AddWithValue("@hawkerstore", post.HawkerStore);
            cmd.Parameters.AddWithValue("@rating", post.Rating);
            cmd.Parameters.AddWithValue("@description", post.Description);
            if (post.FileSubmitted != null)
            {
                cmd.Parameters.AddWithValue("@filesubmitted", post.FileSubmitted);
            }
            else
            {
                cmd.Parameters.AddWithValue("@filesubmitted", DBNull.Value);
            }

            conn.Open();
            post.PostID = (int)cmd.ExecuteScalar();

            conn.Close();

            return post.PostID;
        }

        public int UpdateFileSubmitted(Post post, int id)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE Post SET FileSubmitted=@filesubmit
                              WHERE PostID = @postid";
            cmd.Parameters.AddWithValue("@filesubmit", post.FileSubmitted);
            cmd.Parameters.AddWithValue("@postid", id);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;

        }
    }
}
