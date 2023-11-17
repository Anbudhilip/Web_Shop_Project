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
    public partial class Purchase_Details : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("fech_Bill_all", conn);
                sc.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sqd = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();

                sqd.Fill(ds);
                conn.Close();
                GV_Bill.DataSource = ds;
                GV_Bill.DataBind();

            }
            catch (Exception ex)
            {
                errorMsg.ForeColor = System.Drawing.Color.Red;

                errorMsg.Text = ex.Message;

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void GV_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void txt_search_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string val = txt_search.Text.Trim();
                string query = "select * from  tbl_Bill where b_id like '%" + val + "%' or b_amount like '%" + val + "%' or b_seller_id like '%" + val + "%' ";
                SqlCommand sc = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                GV_Bill.DataSource = ds;
                GV_Bill.DataBind();
                conn.Close();
            }catch(Exception ex)
            
 
            {
                errorMsg.Text = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        }
    
}