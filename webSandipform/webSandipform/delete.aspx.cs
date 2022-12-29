using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webSandipform
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server = .; database=sandipForm; integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM tblemp WHERE id= @id;";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            conn.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                Response.Write("data deleted!!");
            }
            else
            {
                Response.Write("failed");
            }
        }
    }
}