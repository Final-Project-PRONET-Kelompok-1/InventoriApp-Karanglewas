using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoriApp_Karanglewas
{

    internal class dbConfig
    {
        public static string conn = @"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True";
        //public static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriApp; Integrated Security=True");
    }

    


}
