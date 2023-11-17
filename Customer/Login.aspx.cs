using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CAR_RENTAL_WEBSITE
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string a = txt_email.Text.ToString();
            string b = txt_pwd.Text.ToString();

            try
            {
                if (a != "" && b != "")
                {
                    SqlCommand sc = new SqlCommand("admin_login", conn);
                    sc.CommandType = CommandType.StoredProcedure;

                    sc.Parameters.AddWithValue("@uname", a);
                    sc.Parameters.AddWithValue("@pwd ", b);
                    SqlDataAdapter sqd = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    sqd.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Session["admin"] = a;
                        Response.Redirect("Admin/Dashboard.aspx");
                    }
                    else
                    {
                        errorMsg.ForeColor = System.Drawing.Color.Red;

                        errorMsg.Text = " Incorrect Username or Password  !!..";
                    }
                }
                else
                {
                    errorMsg.ForeColor = System.Drawing.Color.Red;

                    errorMsg.Text = " All Filled Must be Filled !!..";
                }
            }
            catch (Exception ex)
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            txt_email.Text = string.Empty;
            txt_pwd.Text = string.Empty;
        }
    }
}