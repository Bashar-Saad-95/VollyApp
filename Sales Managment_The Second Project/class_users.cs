using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Managment_The_Second_Project
{
    class class_users
    {
        public DataTable dtuser = new DataTable();
        public void Login(string user, string pass)
        {
            SqlCommand cmd  = new SqlCommand();
            cmd.Connection  = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginSalesManagment";
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = pass;
            class_set.cn.Open();
            dtuser.Load(cmd.ExecuteReader());
            if(dtuser.Rows.Count>0)
            {
                MessageBox.Show("Hello"+" "+dtuser.Rows[0][3]);
                //Enable other options and open main  window
                var frm = Application.OpenForms["frmMain"] as frmMain;
                frm.aci_logout.Enabled   = true;
                frm.ac_store.Enabled     = true;
                frm.ac_sales.Enabled     = true;
                frm.ac_purcheses.Enabled = true;
                frm.ac_suppliers.Enabled = true;
                frm.ac_users.Enabled     = true;
                frm.ac_customers.Enabled = true;
                frm.aci_login.Enabled    = false; 
                //frm.aci_login.Enabled     = false;
              }//End if
            else
            {
                MessageBox.Show("Login Error");
            }//End else
            class_set.cn.Close();
        }
    }
}
