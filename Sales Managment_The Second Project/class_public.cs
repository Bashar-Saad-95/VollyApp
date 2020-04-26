using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Managment_The_Second_Project
{
    //Through this class we are accomplish the joint 
    //operations between the classes
    //through this class we will use inheritance
    class class_public
    {
        //DataTable for strored data
        public DataTable Dtpublic = new DataTable();
        public void loadpublic(string SPtext)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            //Bring the name of the procedure
            cmd.CommandText = SPtext;
            //open connection
            class_set.cn.Open();
            //Download table data
            Dtpublic.Load(cmd.ExecuteReader());
            //Close Conection
            class_set.cn.Close();
        }//End loadpublic

        public int MaxIDpublic(string SPtext)
        {
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = class_set.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPtext;
                class_set.cn.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch
            {
                id = 0;
            }

            class_set.cn.Close();
            return id;
        }//End MaxIDpublic

    }
}
