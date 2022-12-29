using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventsHandling
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert obj = new Insert();
            obj.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            show obj = new show();
            obj.Show();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            update obj = new update();
            obj.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            search obj = new search();
            obj.Show();
        }
    }
}
