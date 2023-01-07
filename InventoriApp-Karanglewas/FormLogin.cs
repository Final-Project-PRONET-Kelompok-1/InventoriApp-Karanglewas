using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    
    public partial class Form_Login : Form
    {
        //SqlConnection conn = new SqlConnection
        //(@"Data Source=.\SQLEXPRESS;Initial Catalog = InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string admin;
        int autoId;


        public Form_Login()
        {
            InitializeComponent();
            autoID();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            simpanLog();

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);
                
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    admin = txtUsername.Text;
                    FormMaster FM = new FormMaster(); // Instantiate a Form3 object.
                    this.Hide();
                    FM.ShowDialog(); // Show Form3 and
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
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

        private void autoID()
        {
            int id;
            conn.Open();
            string query = "SELECT id_log FROM tb_log ORDER BY id_log DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no = reader["id_log"].ToString();
                id = Convert.ToInt32(no) + 1;

            }
            else
            {
                id = 1;
            }
            autoId = id;
            conn.Close();
        }

        private void simpanLog()
        {
            string ket = "login";
            DateTime date = DateTime.Now;
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_log (id_log, id_admin, keterangan, waktu)\n" +
                                "SELECT '" + autoId + "', a.id_admin, '" + ket + "','" + date + "'\n" +
                                "FROM tb_admin a\n" +
                                "WHERE a.username = '" + txtUsername.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
