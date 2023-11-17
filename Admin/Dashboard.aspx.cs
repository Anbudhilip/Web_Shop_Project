using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CAR_RENTAL_WEBSITE
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                count_emp();
                count_cat();
                count_amount();
                count_med();
                count_purchase();
                

            }catch(Exception ex)
            {
                Response.Write("Error" + ex);
            }
        }

        void count_emp()
        {
            SqlCommand sc = new SqlCommand("select count(id) from tbl_Seller ", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();

            txt_empNo.Text = ds.Tables[0].Rows[0][0].ToString();
            


        }
         void count_cat()
        {
            SqlCommand sc = new SqlCommand("select count(cat_id) from tbl_Category ", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            txt_catagory.Text = ds.Tables[0].Rows[0][0].ToString();


        }

        void count_med()
        {
            SqlCommand sc = new SqlCommand("select count(med_id) from tbl_Medicines ", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            txt_medicines.Text = ds.Tables[0].Rows[0][0].ToString();


        }
        void count_purchase()
        {
            SqlCommand sc = new SqlCommand("select count(b_id) from tbl_Bill ", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            txt_purchases.Text = ds.Tables[0].Rows[0][0].ToString();


        }
        void count_amount()
        {
            SqlCommand sc = new SqlCommand("select sum(b_amount)from tbl_Bill ", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            txt_amount.Text = ds.Tables[0].Rows[0][0].ToString();


        }
    }
}