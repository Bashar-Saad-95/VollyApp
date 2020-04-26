using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Managment_The_Second_Project
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            txt_username.Select();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            class_users use = new class_users();
            use.Login(txt_username.Text , txt_password.Text);
            //Close the window after login
            this.Close();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
