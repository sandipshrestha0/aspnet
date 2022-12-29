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
    public partial class show : Form
    {
        //global declaration
        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn coldelete = new DataGridViewButtonColumn();
        public show()
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

        private void show_Load(object sender, EventArgs e)
        {
            dgvEventhandling.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "event", "tblevent1");
        }
    }
}
