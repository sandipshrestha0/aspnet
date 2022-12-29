using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webSandipform
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server = .; database=sandipForm; integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update tblemp set id=@id, name=@name, age=@age, dob=@dob, gender=@gender where id=@id ";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@age", txtage.Text);
            cmd.Parameters.AddWithValue("@dob", txtdob.Text);
            cmd.Parameters.AddWithValue("@gender", ddlgen.Text);
            conn.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                Response.Write("data updated!!");
            }
            else
            {
                Response.Write("failed");
            }
        }
    }
}