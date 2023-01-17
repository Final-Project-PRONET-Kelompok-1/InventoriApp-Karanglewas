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
using System.Windows.Input;
using static InventoriApp_Karanglewas.dbConfig;



namespace InventoriApp_Karanglewas
{
    public partial class FormAdmin : Form
    {

        SqlConnection conn = dbConfig.conn;

        SqlCommand cmd;
        SqlDataReader reader;
        string validasi, admin, adminReady;
        FormMaster f1 = new FormMaster();

        DataTable dataTable = new DataTable();

        public static string getUsername;
        public FormAdmin()
        {
            InitializeComponent();
            cekAdminMaster();

            dgvAdmin.ReadOnly = true;
            btUbah.Visible = false;
            getAdmin();

            fillDataAdmin();
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
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
                simpanRiwayat("Simpan");
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

        public void fillDataAdmin()
        {

            dgvAdmin.DataSource = getDataAdmin();
        }

        public void resetData()
        {
            txtNamaAdmin.Text = "";
            txtUsernameAdmin.Text = "";
            txtPasswordAdmin.Text = "";
            txtUsernameAdmin.Enabled = true;
            txtPasswordAdmin.Enabled = true;
            btUbah.Visible = false;
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
                    simpanRiwayat("Hapus");
                    resetData();
                    fillDataAdmin();
                }
            }
        }

        private void btEditAdmin_Click(object sender, EventArgs e)
        {
            if(cekValidasi() == "oke" && cekNama() == "oke")
            {
                updateAdmin();
                simpanRiwayat("Edit Nama");
                resetData();
                fillDataAdmin();
                MessageBox.Show("Data berhasil diedit");
            }
        }

        private string cekNama()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '"+ txtUsernameAdmin.Text+"' AND nama_panjang = '" + txtNamaAdmin.Text + "' ";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tidak ada perubahan data, cek kembali!");
                    txtNamaAdmin.Focus();

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
                string queryUpdate = "UPDATE tb_admin SET nama_panjang = '"+nama+ "'" +
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

        private void dgvAdmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (adminReady == "admin")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];
                    txtUsernameAdmin.Text = row.Cells["Username"].Value.ToString();
                    txtNamaAdmin.Text = row.Cells["Nama"].Value.ToString();
                }
                txtUsernameAdmin.Enabled = false;
                txtPasswordAdmin.Text = "123456";
                txtPasswordAdmin.Enabled = false;
                btUbah.Visible = true;
                getUsername = txtUsernameAdmin.Text;


                cekAdminMaster();
            }
                

        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            getUsername = txtUsernameAdmin.Text;
            FormPassword fp = new FormPassword();
            fp.Show();

        }

        private string getAdmin()
        {
            conn.Open();
            string query = "SELECT a.username FROM tb_log l INNER JOIN tb_admin a ON l.id_admin = a.id_admin ORDER BY id_log DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                adminReady = reader["username"].ToString();

            }
            conn.Close();

            return adminReady;
        }

        private void cekAdminMaster()
        {
            

            if (adminReady == "admin")
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
        public void simpanRiwayat(string status)
        {
            string keterangan = status;
            DateTime date = DateTime.Now;
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_riwayatadmin (tanggal , username, keterangan, id_admin) \n" +
                                        "SELECT '" + date + "', '" + txtUsernameAdmin.Text + "', '" + keterangan + "', a.id_admin \n" +
                                        "FROM tb_admin a \n" +
                                        "WHERE a.username = '" + adminReady + "' ";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
    
}
