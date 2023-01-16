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

        SqlConnection conn = dbConfig.conn;

        SqlCommand cmd;
        SqlDataReader reader;
        string validasi, admin;

        DataTable dataTable = new DataTable();
        FormMaster f1 = new FormMaster();
        public FormAdmin()
        {
            InitializeComponent();
            cekAdminMaster();

            dgvAdmin.ReadOnly = true;
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

        private string cekUsername()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsernameAdmin.Text + "' ";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Username '" + txtUsernameAdmin.Text +"' sudah dipakai!\n" +
                        "Masukan username lain!");
                    txtUsernameAdmin.Focus();

                    validasi = "gagal";
                } 
                else
                {
                    validasi = "oke";
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
            return validasi;
        }

        private void simpanAdmin()
        {
            string Nama = txtNamaAdmin.Text;
            Nama = Nama.Replace("'", "''");
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
                namaPanjang.Value = Nama;
                pass.Value = txtPasswordAdmin.Text;

                cmd.Parameters.Add(username);
                cmd.Parameters.Add(namaPanjang);
                cmd.Parameters.Add(pass);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btSimpanAdmin_Click(object sender, EventArgs e)
        {
            if (cekValidasi() == "oke" && cekUsername() == "oke")
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
            txtUsernameAdmin.Enabled = true;
            cekAdminMaster();
        }

        private void btResetAdmin_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNamaAdmin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNamaAdmin.Text, "[^A-Za-z'\\s]"))
            {
                MessageBox.Show("Input Nama hanya bisa dimasukan huruf.");
                txtNamaAdmin.Clear();
            }
        }

        private void btHapusAdmin_Click(object sender, EventArgs e)
        {
            if(txtUsernameAdmin.Text == "admin")
            {
                MessageBox.Show("Akun dengan username = '"+txtUsernameAdmin.Text+"' tidak bisa dihapus");
                resetData();
            }
            else
            {
                var tanya = MessageBox.Show("Apakah anda yakin \n" +
                "akan menghapus akun dengan username = " + txtUsernameAdmin.Text + " ?", "Hapus", MessageBoxButtons.YesNo);
                if (tanya == DialogResult.Yes)
                {
                    conn.Open();
                    string query = "DELETE FROM tb_admin WHERE username = '" + txtUsernameAdmin.Text + "'";
                    var cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus");
                    conn.Close();
                    resetData();
                    fillDataAdmin();
                }
            }
        }

        private void btEditAdmin_Click(object sender, EventArgs e)
        {
            updateAdmin();
            resetData();
            fillDataAdmin();
        }

        public string getPassword()
        {
            conn.Open();
            string query = "SELECT password FROM tb_admin " +
                "WHERE username = '"+txtUsernameAdmin.Text+"' ";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                admin = reader["password"].ToString();
                txtPasswordAdmin.Text = admin;
            }
            conn.Close();

            return admin;
        }

        private void updateAdmin()
        {
            string nama = txtNamaAdmin.Text;
            nama = nama.Replace("'", "''");

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_admin SET nama_panjang = '"+nama+ "', password = HASHBYTES('MD5','" + txtPasswordAdmin.Text + "') " +
                  "WHERE username= '" + txtUsernameAdmin.Text + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (f1.admin == "admin")
            {
                txtUsernameAdmin.Enabled = false;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];
                    txtUsernameAdmin.Text = row.Cells["Username"].Value.ToString();
                    txtNamaAdmin.Text = row.Cells["Nama"].Value.ToString();
                }
            }
            getPassword();
            cekAdminMaster();

        }

        private void cekAdminMaster()
        {
            

            if (f1.admin == "admin")
            {
                btHapusAdmin.Visible = true;
                btEditAdmin.Visible = true;

                if(txtUsernameAdmin.Text == "")
                {
                    btHapusAdmin.Enabled = false;
                    btEditAdmin.Enabled = false;
                    btSimpanAdmin.Enabled = true;
                }
                else
                {
                    btHapusAdmin.Enabled = true;
                    btEditAdmin.Enabled = true;
                    btSimpanAdmin.Enabled = false;
                }
            }
            else
            {
                btHapusAdmin.Visible = false;
                btEditAdmin.Visible = false;
            }
       
        }

    }
    
}
