using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;

namespace NathanWebsiteV2.Models
{
    public class ContactRepository
    {
        public static bool InsertMessage(string name, string email, string message)
        {
            //Insert Product in the database
            //declares variable for scope of code block
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                //open database connection
                con.Open();
                try
                {

                    //sql call
                    SqlCommand command = new SqlCommand("INSERT INTO Messages (FullName, Email, Body) Values(@name, @email, @body)", con);
                    // using parameters avoids sql injections, keep your job
                    command.Parameters.Add(new SqlParameter("name", name));
                    command.Parameters.Add(new SqlParameter("email", email));
                    command.Parameters.Add(new SqlParameter("body", message));
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }
    }
}