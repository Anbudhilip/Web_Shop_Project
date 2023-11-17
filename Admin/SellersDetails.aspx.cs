using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace CAR_RENTAL_WEBSITE.Admin
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("fech_Seller_all", conn);
                sc.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sqd = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();

                sqd.Fill(ds);
                conn.Close();
                GVseller.DataSource = ds;
                GVseller.DataBind();

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
            if (GVseller.SelectedRow != null)
            {
                string a = GVseller.SelectedRow.Cells[1].Text.ToString();
                string b = GVseller.SelectedRow.Cells[2].Text.ToString();
                string c = GVseller.SelectedRow.Cells[3].Text.ToString();
                string d = GVseller.SelectedRow.Cells[4].Text.ToString();
                string f = GVseller.SelectedRow.Cells[5].Text.ToString();
                string g = GVseller.SelectedRow.Cells[6].Text.ToString();
                string h = GVseller.SelectedRow.Cells[7].Text.ToString();

                Response.Redirect("New%20Seller.aspx?p1=" + a + "&p2=" + b +
                 "&p4=" + d + "&p5="
                + f + "&p6=" + g + "&p7=" + h);

            }
        }
     

        protected void Button1_Click(object sender, EventArgs e)
        {

            string val = txt_search.Text;
            string query = "select * from  tbl_Seller where fullName like '%" + val + "%' or id like '%" + val + "%' or email like '%" + val + "%' ";
            SqlCommand sc = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GVseller.DataSource = ds;
            GVseller.DataBind();
            conn.Close();
        }
    }
}