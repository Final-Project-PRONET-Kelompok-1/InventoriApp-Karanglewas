using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    
    public partial class Form_Login : Form
    {
        SqlConnection conn = new SqlConnection
            (@"Data Source=MSI;Initial Catalog = InventoriApp; Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader reader;
        string admin;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
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
    }

}
