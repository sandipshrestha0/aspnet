using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSandipform
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnins_Click(object sender, EventArgs e)
        {
            Response.Redirect("insert.aspx");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("update.aspx");
        }

        protected void btnshow_Click(object sender, EventArgs e)
        {
            Response.Redirect("showall.aspx");
        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete.aspx");
        }
    }
}