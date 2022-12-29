using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventsHandling
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

       

        private void Insert_Load(object sender, EventArgs e)
        {

        }
        private void DatabaseInsert()
        {

           }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=event; integrated security = true;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into tblevent1" +
                "( event, org, address, phone, email, cost)" +
                "values( @event, @org, @address, @phone, @email, @cost)");
           // cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@event", txtevent.Text);
            cmd.Parameters.AddWithValue("@org", txtorg.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@cost", txtCost.Text);

            cmd.Connection = conn;

            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data saved!");
            else
                MessageBox.Show("data save Failed!");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
