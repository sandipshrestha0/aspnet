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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "admin" ||  txtpassword.Text == "admin")
            {
                this.Hide();
                Form frm2 = new Home();
                frm2.ShowDialog();
            }
        }
    }
}
