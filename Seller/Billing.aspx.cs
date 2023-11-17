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
    public partial class Billing : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmacy"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowMedicines();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(
                    new DataColumn[5]
                    {
                        new DataColumn("ID"),
                        new DataColumn("Product"),
                        new DataColumn("Price"),
                        new DataColumn("Quantity"),
                        new DataColumn("Total")
                    }

                   );
                ViewState["Bill"] = dt;
                this.BindGrid();

      

            }
        }

        protected void BindGrid()
        {
            MedList.DataSource = (DataTable)ViewState["Bill"];
            MedList.DataBind();
        }

        private void UpdateStock()
        {
            int a = Convert.ToInt32(GridView2.SelectedRow.Cells[4].Text);
             int b = Convert.ToInt32(txt_quantity.Text);

            int newQty = (a - b);

            SqlCommand sc = new SqlCommand("update_Stock", conn);
            sc.CommandType = CommandType.StoredProcedure;

            sc.Parameters.AddWithValue("@code", GridView2.SelectedRow.Cells[1].Text);
            sc.Parameters.AddWithValue("@value", newQty);
            conn.Open();
            sc.ExecuteNonQuery();
            conn.Close();
            ShowMedicines();
        }

        private void InsertBill()
        {
            try
            {
                int Login_user = 1;  

                SqlCommand sc = new SqlCommand("ins_bill", conn);
                sc.CommandType = CommandType.StoredProcedure;

                sc.Parameters.AddWithValue("@date ",txt_date.Text.ToString());
                sc.Parameters.AddWithValue("@seller",Login_user);
                sc.Parameters.AddWithValue("@amount", Amount);
                conn.Open(); 
               int i= sc.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    Response.Write("Successfully Paid.....!");
                    clear();
                }

            }
            catch (Exception ex)
            {
                Response.Write("" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  Response.Redirect(".aspx");
            txt_code.Text = GridView2.SelectedRow.Cells[1].Text;
            txt_name.Text = GridView2.SelectedRow.Cells[2].Text;
            txt_Price.Text = GridView2.SelectedRow.Cells[3].Text;
        }

        private void ShowMedicines()
        {
            SqlCommand sc = new SqlCommand("fech_Med_Bill", conn);
            sc.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }

        int GridTotal = 0;
       public static int Amount;
        protected void txt_addbill_Click(object sender, EventArgs e)
        {
            try
            {
                int Total = Convert.ToInt32(txt_Price.Text) * Convert.ToInt32(txt_quantity.Text);
                DataTable dt = (DataTable)ViewState["Bill"];
                dt.Rows.Add(MedList.Rows.Count + 1,
                    txt_name.Text.Trim(),
                    txt_Price.Text.Trim(),
                    txt_quantity.Text.Trim(),
                    Total

                  );
                ViewState["Bill"] = dt;
                this.BindGrid();
                UpdateStock();

                GridTotal = 0;
                for (int i = 0; i <= MedList.Rows.Count - 1; i++)
                {
                    GridTotal = GridTotal + Int32.Parse(MedList.Rows[i].Cells[4].Text);

                }
                Amount = GridTotal;
                lblcost.Text = "Rupees  " + GridTotal;
            }
            catch (Exception ex)
            {
               Response.Write( ""+ ex.Message);
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
            InsertBill();
        }

        void clear()
        {
            txt_code.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_quantity.Text= string.Empty;
            txt_date.Text = string.Empty;
            MedList.DataSource = null;
        }
    }
}