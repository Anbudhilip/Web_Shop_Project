using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CAR_RENTAL_WEBSITE.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
          
           
                if (!IsPostBack)
                {
                txt_id.Text = Request.QueryString["p1"];
                txt_code.Text = Request.QueryString["p2"];
                    txt_name.Text = Request.QueryString["p3"];
                    txt_category.Text = Request.QueryString["p4"];
                    txt_date.Text = Request.QueryString["p5"];
                    txt_price.Text = Request.QueryString["p6"];
                    txt_stock.Text = Request.QueryString["p7"];

                if (!string.IsNullOrEmpty(txt_id.Text))
                {
                    btn_update.Visible = true;
                    btn_save.Visible = false;
                        btn_delete.Visible = true;
                }
                    GetCategories();

                }

            }
            catch (Exception ex)
            {
                errorMsg.ForeColor = System.Drawing.Color.Red;

                errorMsg.Text = " Some Thing got Error in Querystring!!..";
            }
        }

        private void GetCategories()
        {

            string Query = " select  cat_name from tbl_Category";
                SqlCommand sc = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            conn.Close();
            txt_category.DataSource = dt;
                txt_category.DataTextField = "cat_name";
                txt_category.DataValueField = "cat_name";
                txt_category.DataBind();

                //Model.dbConnection obj = new Model.dbConnection();

                //SqlCommand sc;
                //conn.Open();

                //txt_cat.DataSource = obj.GetData(Query);
                //txt_cat.DataValueField = "cat_name";
                //txt_cat.DataBind();
           
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

           


        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("med_update", conn);
                sc.CommandType = CommandType.StoredProcedure;

                sc.Parameters.AddWithValue("@med_id ",txt_id.Text.ToString());
                sc.Parameters.AddWithValue("@med_code",txt_code.Text.ToString());
                sc.Parameters.AddWithValue("@med_name",txt_name.Text.ToString());
                sc.Parameters.AddWithValue("@med_category",txt_category.SelectedValue.ToString());
                sc.Parameters.AddWithValue("@med_expire_date",txt_date.Text.ToString());
                sc.Parameters.AddWithValue("@med_price",txt_price.Text.ToString());
                sc.Parameters.AddWithValue("@med_stock",txt_stock.Text.ToString());
                
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
            catch (Exception ex)
            {
                errorMsg.ForeColor = System.Drawing.Color.Red;
                   
                errorMsg.Text=ex.Message;
                clear();

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
            txt_id.Text   =string.Empty;
            txt_code.Text =string.Empty;
            txt_name.Text =string.Empty;
          
            txt_date.Text =string.Empty;
            txt_price.Text=string.Empty;
            txt_stock.Text = string.Empty;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_code.Text) &&
                     !string.IsNullOrEmpty(txt_name.Text) && 
                    !string.IsNullOrEmpty(txt_date.Text) &&
                    !string.IsNullOrEmpty(txt_category.Text) &&
                    !string.IsNullOrEmpty(txt_price.Text) &&
                    !string.IsNullOrEmpty(txt_stock.Text))
                    
                {                

                 
                    SqlCommand sc = new SqlCommand("med_insert", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@med_code ", txt_code.Text.ToString());
                    sc.Parameters.AddWithValue("@med_name ", txt_name.Text.ToString());
                    sc.Parameters.AddWithValue("@med_category", txt_category.Text.ToString());
                    sc.Parameters.AddWithValue("@med_expire ", txt_date.Text.ToString());
                    sc.Parameters.AddWithValue("@med_price ", txt_price.Text.ToString());
                    sc.Parameters.AddWithValue("@med_stock ", txt_stock.Text.ToString());                   
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
                else
                {
                    errorMsg.ForeColor = System.Drawing.Color.Red;

                    errorMsg.Text = " All Filled Must be Filled !!..";
                 
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

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("del_medicines", conn);
                sc.CommandType = CommandType.StoredProcedure;

                sc.Parameters.AddWithValue("@id", txt_id.Text.ToString());
               
                conn.Open();
                int i = sc.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {

                    errorMsg.Text = "Medicines Deleted !!!";

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