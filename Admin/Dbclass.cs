using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CAR_RENTAL_WEBSITE.Admin
{
    public class Dbclass
    {
        public SqlConnection conn;
        public SqlCommand sc;
        public DataTable dt;
        public SqlDataAdapter sda;
        public string Constring;

      

        
        public int Exequery()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
            conn.Open();
            int i = sc.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public DataSet dataAdapter() {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
            conn.Open();
            SqlDataAdapter sqd = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            
            sqd.Fill(ds);
            conn.Close();
            return ds;
           


        }
        public DataTable GetData(String Query)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, conn);
            sda.Fill(dt);
            return dt;

        }
    }
}