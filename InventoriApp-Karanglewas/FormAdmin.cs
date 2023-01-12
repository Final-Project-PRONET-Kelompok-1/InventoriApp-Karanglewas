using FontAwesome.Sharp;
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
using static InventoriApp_Karanglewas.dbConfig;



namespace InventoriApp_Karanglewas
{
    public partial class FormAdmin : Form
    {
      //  SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string validasi;

        DataTable dataTable = new DataTable();
        public FormAdmin()
        {
            InitializeComponent();
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            fillDataAdmin();
        }
        private string cekValidasi()
        {
            if (txtUsernameAdmin.Text == "")
            {
                MessageBox.Show("Username tidak boleh kosong!");
                txtUsernameAdmin.Focus();
                validasi = "gagal";
            }
            else if(txtNamaAdmin.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                txtNamaAdmin.Focus();
                validasi = "gagal";
            }
            else if (txtPasswordAdmin.Text == "")
            {
                MessageBox.Show("Password tidak boleh kosong!");
                txtPasswordAdmin.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }
            return validasi;
        }

        private void simpanAdmin()
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_addAdmin";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter namaPanjang = new SqlParameter("@nama_panjang", SqlDbType.VarChar);
                SqlParameter pass = new SqlParameter("@password", SqlDbType.VarChar);

                username.Value = txtUsernameAdmin.Text;
                namaPanjang.Value = txtNamaAdmin.Text;
                pass.Value = txtPasswordAdmin.Text;

                cmd.Parameters.Add(username);
                cmd.Parameters.Add(namaPanjang);
                cmd.Parameters.Add(pass);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username sudah Ada");
                conn.Close();
            }
        }

        private void btSimpanAdmin_Click(object sender, EventArgs e)
        {
            cekValidasi();
            if (validasi == "oke")
            {
                simpanAdmin();
                resetData();
                MessageBox.Show("Data berhasil disimpan");
                fillDataAdmin();
            }
            
        }

        private DataTable getDataAdmin()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "sp_showAdmin";
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        private void fillDataAdmin()
        {

            dgvAdmin.DataSource = getDataAdmin();
        }

        private void resetData()
        {
            txtNamaAdmin.Text = "";
            txtUsernameAdmin.Text = "";
            txtPasswordAdmin.Text = "";
        }

        private void btResetAdmin_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
