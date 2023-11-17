using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;



namespace CAR_RENTAL_WEBSITE.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {


        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_med_code.Text = Request.QueryString["p2"];
                txt_med_id.Text = Request.QueryString["p"];
                txt_med_cat.Text = Request.QueryString["p3"];

                if(!string.IsNullOrEmpty(txt_med_id.Text) )
                {
                    btn_del.Visible = true;
                    btn_update.Visible =true;
                    btn_submit.Visible =false;

                }
            }
        }

        protected void cat_edit(object sender, EventArgs s)
        {
            try
            {
                SqlCommand sc = new SqlCommand("edit_cat", conn);
                sc.CommandType = CommandType.StoredProcedure;

                sc.Parameters.AddWithValue("@id", txt_med_id.Text.ToString());
                sc.Parameters.AddWithValue("@code",txt_med_code .Text.ToString());
                sc.Parameters.AddWithValue("@name",txt_med_cat .Text.ToString());
                conn.Open();
                int i =sc.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {

                    errorMsg.Text = "Catagory Name Added !!!";

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

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_med_cat.Text != "" && txt_med_code.Text != "")
                {
                    string code = txt_med_code.Text;
                    string name = txt_med_cat.Text;

                    string query = "Insert into tbl_Category values('"+code+"','"+name+"')";
                   
                    SqlCommand sc = new SqlCommand(query,conn);
                    conn.Open();
                    int i = sc.ExecuteNonQuery();

                    if (i > 0)
                    {
                        errorMsg.Text = "Catagory Name Added !!!";

                        clear();


                    }

                }
                else
                {
                   
                    errorMsg.Text = "All Filled must be Filled!!!";
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

        protected void Cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txt_med_id.Text = string.Empty;
            txt_med_code.Text = string.Empty;
            txt_med_cat.Text = string.Empty;
           

        }

        protected void btn_del_Click(object sender, EventArgs e)
        {


            try
            {
                SqlCommand sc = new SqlCommand("del_category", conn);
                sc.CommandType = CommandType.StoredProcedure;

                sc.Parameters.AddWithValue("@id", txt_med_id.Text.ToString());
   
                conn.Open();
                int i = sc.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {

                    errorMsg.Text = "Catagory Deleted !!!";

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