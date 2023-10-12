using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrupAppNew
{
    public class Connection
    {
        public DataTable Select(string query)
        {
            DataTable dt = new DataTable();
            string conString = @"Data Source =(localdb)\MSSQLLocalDB; database=CrupApp;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                ad.Fill(dt);
            }
            return dt;
        }
        public void Delete(string query)
        {
            
            string conString = @"Data Source =(localdb)\MSSQLLocalDB; database=CrupApp;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
               SqlCommand cmd =new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
        public void Save(string query)
        {

            string conString = @"Data Source =(localdb)\MSSQLLocalDB; database=CrupApp;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}