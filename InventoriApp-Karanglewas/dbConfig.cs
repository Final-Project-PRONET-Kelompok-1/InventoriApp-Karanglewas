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
        SqlConnection conn = new SqlConnection(@"Data Source = MSI;Initial Catalog = InventoriApp;Integrated Security=True"); //sesuai pc masing2
    }

    


}
