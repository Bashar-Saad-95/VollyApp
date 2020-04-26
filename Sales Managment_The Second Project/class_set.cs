using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Managment_The_Second_Project
{
    class class_set
    {
        //Create Conection with database
        public static SqlConnection cn = new SqlConnection("Server=BASHAR-SAAD;Database=Sales Managment_DB;Integrated Security=true");
    }
}
