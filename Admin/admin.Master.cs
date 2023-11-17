using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAR_RENTAL_WEBSITE.Admin
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {
                if ((string)Session["admin"] != null)
                {
                    name.Text = "Hello " + (string)Session["admin"];
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}