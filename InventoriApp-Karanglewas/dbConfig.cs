using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{

    internal class dbConfig
    {
        //public static string conn = @"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        public void Open()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method untuk menutup koneksi
        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

    


}
