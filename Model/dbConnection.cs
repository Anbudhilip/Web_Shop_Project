using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CAR_RENTAL_WEBSITE.Model
{
    public class dbConnection
    {

       public SqlConnection conn;
       public SqlCommand sc;
       public DataTable dt;
       public SqlDataAdapter sda;
       public string Constring;

        //public dbConnection()   //constructor
        //{
        // //   Constring = @"Data Source=DESKTOP-UJ9035U;Initial Catalog=Pharmacy_Management_System;Integrated Security=True";

        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);

        //   // conn = new SqlConnection(Constring);
        //    sc = new SqlCommand();   // SqlCommand sc = new SqlCommand("",conn);
        //    sc.Connection = conn;
             
        //}
        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, conn);
            sda.Fill(dt);
            return dt;
      
        }

        public int SetData(string Query)
        {
            int count = 0;
            sc.CommandText = Query;
            count = sc.ExecuteNonQuery();
            conn.Close();
            return count;
        }

    }

}