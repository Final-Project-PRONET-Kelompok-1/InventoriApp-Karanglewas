using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace InventoriApp_Karanglewas.Config
{
    class DBConfig
    {
        private SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-TMHK1OT;Initial Catalog = InventoriApp; Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public DataTable dt;

        public void Eksekusi_Query(string query)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Eksekusi_Stored(string stored)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Isi_CBO(string query, ComboBox cbo, int dataKolom)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                rd = cmd.ExecuteReader();


                cbo.Items.Clear();
                while (rd.Read())
                {
                    cbo.Items.Add(rd.GetString(dataKolom));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                conn.Close();
            }

        }
    }

}
