using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Managment_The_Second_Project
{
    class class_items
    {
        //Recive data
        public DataTable dtitem = new DataTable();

        public void loaditem()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            //Bring the name of the procedure
            cmd.CommandText = "loaditem_SM";
            //open connection
            class_set.cn.Open();
            //Download table data
            dtitem.Load(cmd.ExecuteReader());
            //Close Conection
            class_set.cn.Close();

        }//End Fun loaditem

        int id;
        public int maxid()
        {
            //هنا عمليه جلب اعلى قيمة id للاصناف ,
            //try : تنفيذ الكلام الموجود ضمن , وفي حال ما مشي الحال رجعلي قيمة id=0
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = class_set.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MaxIDitemsSM";
                class_set.cn.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());           
            }

            catch
            {
                id = 0;
            }
            
            class_set.cn.Close();
            return id;
        }//End fun macid

        public void Insertitems(int id , string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertItems_SM";
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End fun Insertitems

        public void Updateitems(int id, string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Updateitems_SM";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End fun Updateitems

        public void Deleteitems(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteItem_SM";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End fun Deleteitems
    }//End class_items
}
