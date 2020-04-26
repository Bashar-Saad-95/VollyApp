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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void aci_login_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.ShowDialog();
        }

        private void aci_logout_Click(object sender, EventArgs e)
        {
            //Close sub-options
            ac_store.Expanded = false;
            ac_sales.Expanded = false;
            ac_purcheses.Expanded = false;
            ac_suppliers.Expanded = false;
            ac_users.Expanded = false;
            ac_customers.Expanded = false;

            //Deactive all options and enable login process option
            aci_logout.Enabled   = false;
            ac_store.Enabled     = false;
            ac_sales.Enabled     = false;
            ac_purcheses.Enabled = false;
            ac_suppliers.Enabled = false;
            ac_users.Enabled     = false;
            ac_customers.Enabled = false;
            aci_login.Enabled    = true;
            aci_product.Enabled = false;
            aci_customersmanagment.Enabled = false;
            aci_purchesesmanagment.Enabled = false;
            aci_purchesesorder.Enabled = false;
            aci_salesmanagment.Enabled = false;
            aci_salesoreder.Enabled = false;
            aci_suppliersmanagment.Enabled = false;
            aci_usersmanagment.Enabled = false;
            aci_class.Enabled = false;
        }

        private void ac_login_Click(object sender, EventArgs e)
        {
            
        }

        private void aci_class_Click(object sender, EventArgs e)
        {
            frm_item frm = new frm_item();
            frm.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void aci_product_Click(object sender, EventArgs e)
        {
            frm_product frm = new frm_product();
            frm.ShowDialog();
        }
    }
}
