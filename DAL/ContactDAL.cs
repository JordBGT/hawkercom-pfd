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
    public class ContactDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        public ContactDAL()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString("HawkerComConnectionString");

            conn = new SqlConnection(strConn);
        }

        //Add user to database
        public int Add(Contact contact)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an INSERT SQL statement which will
            //return the auto-generated AreaInterestID after insertion
            cmd.CommandText = @"INSERT INTO Contact(Name, Description) OUTPUT INSERTED.ContactID VALUES(@name, @desc)";

            //parameter
            cmd.Parameters.AddWithValue("@name", contact.Name);
            cmd.Parameters.AddWithValue("@desc", contact.Description);

            conn.Open();
            contact.ContactID = (int)cmd.ExecuteScalar();

            conn.Close();

            return contact.ContactID;
        }
    }
}
