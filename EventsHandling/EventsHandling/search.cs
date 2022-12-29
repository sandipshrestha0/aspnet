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
    public partial class search : Form
    {

        //global declaration
        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn coldelete = new DataGridViewButtonColumn();

        public search()
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
        private void search_Load(object sender, EventArgs e)
        {

            dgvEventhandling.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "event", "tblevent1");
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //create the temproray datasource i.e. bindingsource becoz it can filter
            BindingSource bs = new BindingSource();
            // assign original datasource(i.e) data to binding source
            bs.DataSource = dgvEventhandling.DataSource;

            //now filter the binding source
            bs.Filter = "event like '*" + txtsearch.Text + "*'";
            //now assign filtered data in grid
            dgvEventhandling.DataSource = bs;
            //clear any selection if any on datagrid
            dgvEventhandling.ClearSelection();
        }
    }
}
