using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSandipform
{
    public partial class logIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "admin" && txtpass.Text == "admin")
            {
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Write("Password is invalid!!");
            }
        }
    }
}