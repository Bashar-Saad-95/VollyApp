using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Sales_Managment_The_Second_Project
{
    class class_product : class_public
    {
        public SqlCommand cmd;
        //Function to fetch the product data without image
        public void insertproductNotImage(int id,string code,string name,double saleprice,double buyprice,double earnprice,double storedquantity, int iditem)
        {
            cmd = new SqlCommand();
            cmd.Connection  = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insertproduct_SM";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("code", SqlDbType.VarChar,50).Value = code;
            cmd.Parameters.Add("name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("saleprice", SqlDbType.Decimal).Value = saleprice;
            cmd.Parameters.Add("buyprice", SqlDbType.Decimal).Value = buyprice;
            cmd.Parameters.Add("earnprice", SqlDbType.Decimal).Value = earnprice;
            cmd.Parameters.Add("storedquantity", SqlDbType.Decimal).Value = storedquantity;
            cmd.Parameters.Add("iditem", SqlDbType.Int).Value = iditem;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End Fun insertproductNotImage


        //Function to fetch the product data with an image
        public void insertproductImage(int id, string code, string name, double saleprice, double buyprice, double earnprice, double storedquantity, byte[] imageproduct, int iditem)
        {
            cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertProductImage_SM";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("code", SqlDbType.VarChar, 50).Value = code;
            cmd.Parameters.Add("name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("saleprice", SqlDbType.Decimal).Value = saleprice;
            cmd.Parameters.Add("buyprice", SqlDbType.Decimal).Value = buyprice;
            cmd.Parameters.Add("earnprice", SqlDbType.Decimal).Value = earnprice;
            cmd.Parameters.Add("storedquantity", SqlDbType.Decimal).Value = storedquantity;
            cmd.Parameters.Add("img", SqlDbType.Image).Value = imageproduct;
            cmd.Parameters.Add("iditem", SqlDbType.Int).Value = iditem;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End Fun insertproductImage

        //Function To Store Image
        public DataTable getimageproduct(string code)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetImageProduct_SM";
            cmd.Parameters.Add("code", SqlDbType.VarChar, 50).Value = code;
            class_set.cn.Open();
            dt.Load(cmd.ExecuteReader());
            class_set.cn.Close();
            return dt;
        }//End getimageproduct

        //Function To Upadta Product Data Without An Image
        public void updateproduct(string name, double saleprice, double buyprice, double earnprice, double storedquantity, int iditem , string code)
        {           
            cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProduct_SM";
            //cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("saleprice", SqlDbType.Decimal).Value = saleprice;
            cmd.Parameters.Add("buyprice", SqlDbType.Decimal).Value = buyprice;
            cmd.Parameters.Add("earnprice", SqlDbType.Decimal).Value = earnprice;
            cmd.Parameters.Add("storedquantity", SqlDbType.Decimal).Value = storedquantity;
            cmd.Parameters.Add("iditem", SqlDbType.Int).Value = iditem;
            cmd.Parameters.Add("code", SqlDbType.VarChar, 50).Value = code;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End Fun updateproduct

        //Function To Upadta Product Data With An Image
        public void updateproductimage(string name, double saleprice, double buyprice, double earnprice, double storedquantity,byte[] img, int iditem, string code)
        {
            cmd = new SqlCommand();
            cmd.Connection = class_set.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProductImage_SM";
            //cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("saleprice", SqlDbType.Decimal).Value = saleprice;
            cmd.Parameters.Add("buyprice", SqlDbType.Decimal).Value = buyprice;
            cmd.Parameters.Add("earnprice", SqlDbType.Decimal).Value = earnprice;
            cmd.Parameters.Add("storedquantity", SqlDbType.Decimal).Value = storedquantity;
            cmd.Parameters.Add("img", SqlDbType.Image).Value = img;
            cmd.Parameters.Add("iditem", SqlDbType.Int).Value = iditem;
            cmd.Parameters.Add("code", SqlDbType.VarChar, 50).Value = code;
            class_set.cn.Open();
            cmd.ExecuteNonQuery();
            class_set.cn.Close();
        }//End Fun updateproductimage

    }//End class_product
}
