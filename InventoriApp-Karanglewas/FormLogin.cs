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
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        //SqlConnection conn = new SqlConnection(dbConfig.conn);

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        string admin, validasi;
        


        public Form_Login()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private string cekValidasi()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Harapan masukan username!");
                txtUsername.Focus();
                validasi = "gagal";

            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Harap masukan password!");
                txtPass.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }

            return validasi;
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            cekValidasi();
            if(validasi == "oke")
            {
                simpanLog("Login");

                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = HASHBYTES('MD5', '" + txtPass.Text + "')";

                    //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
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
                        MessageBox.Show("Username atau Password salah!");
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


        private void simpanLog(string ket)
        {
            DateTime date = DateTime.Now;
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_log (id_admin, keterangan, waktu)\n" +
                                "SELECT a.id_admin, '" + ket + "','" + date + "'\n" +
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

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btMasuk_Click(this, new EventArgs());
            }
        }
    }

}
