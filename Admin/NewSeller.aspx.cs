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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {


                if (!IsPostBack)
                {
                    id.Text = Request.QueryString["p1"];
                  name.Text = Request.QueryString["p2"];
               //   gender.SelectedValue = Request.QueryString["p3"];
                  address.Text= Request.QueryString["p4"];
                  email.Text = Request.QueryString["p5"];
                  phoneNo.Text = Request.QueryString["p6"];
                    pwd.Text = Request.QueryString["p7"];
                 
                    if (!string.IsNullOrEmpty(id.Text))
                    {
                        btn_update.Visible = true;
                        submit.Visible = false;
                        delete.Visible = true;
                    }
                    

                }

            }
            catch (Exception ex)
            {
                errorMsg.ForeColor = System.Drawing.Color.Red;

                errorMsg.Text = " Some Thing got Error in Querystring!!..";
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(name.Text) &&
                    !string.IsNullOrEmpty(gender.Text) &&
                    !string.IsNullOrEmpty(address.Text) &&
                    !string.IsNullOrEmpty(email.Text) &&
                    !string.IsNullOrEmpty(phoneNo.Text) &&
                    !string.IsNullOrEmpty(pwd.Text) &&
                    !string.IsNullOrEmpty(cpwd.Text))

                {
                    SqlCommand sc = new SqlCommand("seller_insert", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@fullName ", name.Text.ToString());
                    sc.Parameters.AddWithValue("@gender ", gender.Text.ToString());
                    sc.Parameters.AddWithValue("@address", address.Text);
                    sc.Parameters.AddWithValue("@email", email.Text.ToString());
                    sc.Parameters.AddWithValue("@mobileNo", phoneNo.Text.ToString());
                    if (pwd.Text != cpwd.Text)
                    {
                        errorMsg.ForeColor = System.Drawing.Color.Red;

                        errorMsg.Text = " Incorrect Password";
                    }
                    else
                    {
                       
                        sc.Parameters.AddWithValue("@password", pwd.Text.ToString());
                        conn.Open();
                        int i = sc.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {
                            errorMsg.ForeColor = System.Drawing.Color.Green;

                            errorMsg.Text = "Data Added Successfully  !!..";
                            clear();
                        }

                    }
                    
                }
                else
                {
                    errorMsg.ForeColor = System.Drawing.Color.Red;

                    errorMsg.Text = " All Filled Must be Filled !!..";
                    clear();
                }

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
        void clear()
        {
            name.Text = string.Empty;
            gender.SelectedValue = null;
            address.Text = string.Empty;
            email.Text = string.Empty;
            phoneNo.Text = string.Empty;
            pwd.Text = string.Empty;
            cpwd.Text = string.Empty;
            id.Text = string.Empty;
            

        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(name.Text) &&
                   !string.IsNullOrEmpty(gender.Text) &&
                   !string.IsNullOrEmpty(address.Text) &&
                   !string.IsNullOrEmpty(email.Text) &&
                   !string.IsNullOrEmpty(phoneNo.Text) &&
                   !string.IsNullOrEmpty(pwd.Text) &&
                   !string.IsNullOrEmpty(cpwd.Text))

                {
                    SqlCommand sc = new SqlCommand("seller_update", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@id", id.Text.ToString());
                    sc.Parameters.AddWithValue("@fullName ", name.Text.ToString());
                    sc.Parameters.AddWithValue("@gender ", gender.Text.ToString());
                    sc.Parameters.AddWithValue("@address", address.Text);
                    sc.Parameters.AddWithValue("@email", email.Text.ToString());
                    sc.Parameters.AddWithValue("@mobileNo", phoneNo.Text.ToString());

                    if (pwd.Text != cpwd.Text)
                    {
                        errorMsg.ForeColor = System.Drawing.Color.Red;

                        errorMsg.Text = " Incorrect Password";
                    }
                    else
                    {

                        sc.Parameters.AddWithValue("@password", pwd.Text.ToString());

                        conn.Open();
                        int i = sc.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {
                            errorMsg.ForeColor = System.Drawing.Color.Green;

                            errorMsg.Text = " Data Updated Successfully !!..";

                            clear();


                        }

                    }

                 
                }
                else
                {
                    errorMsg.ForeColor = System.Drawing.Color.Red;

                    errorMsg.Text = " All Filled Must be Filled !!..";
                    clear();
                }

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

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand(" del_seller ", conn);
                sc.CommandType = CommandType.StoredProcedure;

                sc.Parameters.AddWithValue("@id", id.Text.ToString());
               
                conn.Open();
                int i = sc.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {

                    errorMsg.Text = "Seller ID Deleted !!!";

                    clear();


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
    }
}
    
