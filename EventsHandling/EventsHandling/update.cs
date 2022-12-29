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
    public partial class update : Form
    {
        //global declaration
        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn coldelete = new DataGridViewButtonColumn();

        public update()
        {
            InitializeComponent();
        }
        private DataTable GetAllRecord(string servername, string databasename, string tblname)
        {
            SqlConnection conn = new SqlConnection("server=" + servername + "; database=" + databasename + "; integrated security = true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from " + tblname + "");
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            conn.Close();
            return (dt);

        }

       
        // DataBase update code---
        private void DatabaseUpdate()
        {

            SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=event; integrated security = true;");
            conn.Open();
            //update data 
            SqlCommand cmd = new SqlCommand("update tblevent1 set event= @event," +
                " org=@org, address=@address, phone=@phone, email=@email, cost=@cost where id=@id");
            cmd.Parameters.AddWithValue("@id", txtid.Text);
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



        private void update_Load(object sender, EventArgs e)
        {
            dgvEventhandling.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "event", "tblevent1");
            //for edit button
            coledit.HeaderText = "Edit";
            coledit.MinimumWidth = 6;
            coledit.Name = "coledit";
            coledit.ReadOnly = true;
            coledit.Text = "Edit";
            coledit.UseColumnTextForButtonValue = true;
            coledit.Width = 125;
            //add column to grid
            dgvEventhandling.Columns.Add(coledit);


            //for delete button
            coldelete.HeaderText = "Delete";
            coldelete.MinimumWidth = 6;
            coldelete.Name = "coldelete";
            coldelete.ReadOnly = true;
            coldelete.Text = "Delete";
            coldelete.UseColumnTextForButtonValue = true;
            coldelete.Width = 125;
            //add column to grid
            dgvEventhandling.Columns.Add(coldelete);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DatabaseUpdate();
            dgvEventhandling.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "event", "tblevent1");

        }

        private void dgvEventhandling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == coledit.Index)
            {
                txtid.Text = dgvEventhandling.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtevent.Text = dgvEventhandling.Rows[e.RowIndex].Cells["event"].Value.ToString();
                txtorg.Text = dgvEventhandling.Rows[e.RowIndex].Cells["org"].Value.ToString();
                txtAddress.Text = dgvEventhandling.Rows[e.RowIndex].Cells["address"].Value.ToString();
                txtPhone.Text = dgvEventhandling.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                txtEmail.Text = dgvEventhandling.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtCost.Text = dgvEventhandling.Rows[e.RowIndex].Cells["cost"].Value.ToString();
                //txtCost.Text = Convert.ToInt32(dgvEventhandling.Rows[e.RowIndex].Cells["cost"].Value.ToString());

                //
                btnsave.Text = "Update";
            }
            else if (e.ColumnIndex == coldelete.Index) // delete
            {
                DialogResult ans = MessageBox.Show("Are you sure to delete ", "confirmation", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=event; " +
                        "integrated security = true;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from tblevent1 where id=@id");

                    cmd.Parameters.AddWithValue("@id", dgvEventhandling.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    cmd.Connection = conn;

                    int rtn = cmd.ExecuteNonQuery();

                    if (rtn > 0)
                        MessageBox.Show("data deleted!");
                    else
                        MessageBox.Show("data delete Failed!");

                    dgvEventhandling.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "event", "tblevent1");
                }

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtevent.Clear();
            txtorg.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCost.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}
