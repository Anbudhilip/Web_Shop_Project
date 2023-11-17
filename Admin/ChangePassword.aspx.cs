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
    public partial class Change_Password : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_Click(object sender, EventArgs e)
        {

            try
            {
                string a = txt_uname.Text.ToString();
                string b = txt_password.Text.ToString();
                string c = txt_cpassword.Text.ToString();
                if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
                {
                    if (b == c)
                    {
                        SqlCommand sc = new SqlCommand("update  admin  set admin_name=@uname,password=@pwd", conn);

                        sc.Parameters.AddWithValue("@uname",a);
                        sc.Parameters.AddWithValue("@pwd",b);
                       
                        conn.Open();
                        int i = sc.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {

                            errorMsg.Text = "User Name and Password Updated !!!";

                            clear();

                        }
                        else
                        {
                            errorMsg.Text = "Password Updated Successfully !!!";
                        }
                    }
                    else
                    {
                        errorMsg.Text = "Password MissMatch  !!!";
                        clear();
                    }
                }
                else
                {
                    errorMsg.Text = "All feild Must be Filled !!!";
                   
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

        void clear()
        {

             txt_uname.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_cpassword.Text = string.Empty;
    }

        protected void Cancel_Click(object sender, EventArgs e)
        {

            clear();

        }
    }

   
}