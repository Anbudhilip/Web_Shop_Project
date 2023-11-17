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

    public partial class category_Details : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("fech_cat", conn);
            sc.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqd = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sqd.Fill(ds);
            GV_cat.DataSource = ds;
            GV_cat.DataBind();

        }

        protected void GV_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Add_Categories obj = new Add_Categories();

            if(GV_cat.SelectedRow != null)
            {
                string p = GV_cat.SelectedRow.Cells[1].Text .ToString();
                string p2 = GV_cat.SelectedRow.Cells[2].Text.ToString();
                string p3 = GV_cat.SelectedRow.Cells[3].Text.ToString();
                                                           
                Response.Redirect("Add Categories.aspx?p="+p +"&p2="+p2+"&p3="+p3);

            }

          
           // txt_.Text = GV_cat.SelectedRow.Cells[2].Text;
        }

        protected void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string val = txt_search.Text;
            string query = "select * from  tbl_Category where cat_id like '%" + val + "%' or cat_code like '%" + val + "%' or cat_name like '%" + val + "%' ";
            SqlCommand sc = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GV_cat.DataSource = ds;
            GV_cat.DataBind();
            conn.Close();
        }
    }
}