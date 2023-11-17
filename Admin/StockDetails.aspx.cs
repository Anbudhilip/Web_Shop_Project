using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CAR_RENTAL_WEBSITE.Admin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
       
       
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                SqlCommand sc = new SqlCommand("fech_med_all", conn);
                sc.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sqd = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();

                sqd.Fill(ds);
                conn.Close();
                GV_Stock.DataSource = ds;
                GV_Stock.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
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
            if(GV_Stock.SelectedRow != null)
            {
                string a = GV_Stock.SelectedRow.Cells[1].Text.ToString();
                string b = GV_Stock.SelectedRow.Cells[2].Text.ToString();
                string c = GV_Stock.SelectedRow.Cells[3].Text.ToString();
                string d = GV_Stock.SelectedRow.Cells[4].Text.ToString();
                string f = GV_Stock.SelectedRow.Cells[5].Text.ToString();
                string g = GV_Stock.SelectedRow.Cells[6].Text.ToString();
                string h = GV_Stock.SelectedRow.Cells[7].Text.ToString();

                Response.Redirect("Add Medicines.aspx?p1="+a+"&p2="+b+
                "&p3=" + c + "&p4=" + d + "&p5="
                + f + "&p6=" + g + "&p7=" + h);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string val = txt_search.Text;
            string query = "select * from  tbl_Medicines where med_code like '%" + val + "%' or med_name like '%" + val + "%' or med_category like '%" + val + "%' ";
            SqlCommand sc = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GV_Stock.DataSource = ds;
            GV_Stock.DataBind();
            conn.Close();
        }
    }
}