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

    public partial class listBarang : Form
    {
        SqlConnection conn = new SqlConnection(dbConfig.conn);
        // SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori, getKategori, kode, validasi;
        DateTime date;

        DataTable dataTable = new DataTable();
        public listBarang()
        {
            InitializeComponent();
            cbKategori();

            txtKodeBarang.Enabled = false;
            txtKodeBarang.Text = "";

            fillDataBarang();
            cekKode();

        }

        private void cbKategori()
        {
            try
            {
                conn.Open();
                string query = "SELECT nama_kategori FROM tb_kategori";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "kategori");

                DataRow row = ds.Tables["kategori"].NewRow();
                row["nama_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKategoriBarang.DataSource = ds.Tables["kategori"];
                cbKategoriBarang.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void autoKode()
        {

            conn.Open();
            string query = "SELECT kode_barang FROM tb_barang b " +
                            "INNER JOIN tb_kategori k ON k.id_kategori = b.id_kategori " +
                            "WHERE k.nama_kategori = '" + getKategori + "' " +
                            "ORDER BY id_barang DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no = reader["kode_barang"].ToString();
                no = no.Substring(no.Length - 4);
                int str = Convert.ToInt32(no) + 1;
                kode = getKategori + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = getKategori + "0001";
            }
            txtKodeBarang.Text = kode;
            conn.Close();
        }

        private void btSimpanBarang_Click(object sender, EventArgs e)
        {
            cekInput();
            if (validasi == "oke")
            {
                simpanBarang();
            }
        }

        private void simpanBarang()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barang(kode_barang, id_kategori, nama_barang) " +
                                "SELECT '" + txtKodeBarang.Text + "', tb_kategori.id_kategori, '" + txtNamaBarang.Text + "' " +
                                "FROM tb_kategori " +
                                "WHERE tb_kategori.nama_kategori = '" + cbKategoriBarang.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Barang berhasil ditambahkan !");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            resetForm();
            autoKode();
            fillDataBarang();
            cekKode();
        }

        private DataTable getDataBarang()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT b.kode_barang as Kode, k.nama_kategori as Kategori, b.nama_barang as Barang " +
                                "FROM tb_barang b " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "ORDER BY b.id_kategori ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        private void fillDataBarang()
        {

            dataBarang.DataSource = getDataBarang();
        }

        private void resetForm()
        {
            txtNamaBarang.Text = "";
            cbKategori();
            txtKodeBarang.Text = "";
            cekKode();

        }

        private void btEditBarang_Click(object sender, EventArgs e)
        {
            cekInput();
            if (validasi == "oke")
            {
                updateBarang();
            }
        }

        private void updateBarang()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barang SET  " +
                    "nama_barang = '" + txtNamaBarang.Text + "' " +
                  "WHERE kode_barang = '" + txtKodeBarang.Text + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            resetForm();
            autoKode();
            fillDataBarang();
            cekKode();
        }

        private void dataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataBarang.Rows[e.RowIndex];
                txtKodeBarang.Text = row.Cells["Kode"].Value.ToString();
                cbKategoriBarang.Text = row.Cells["Kategori"].Value.ToString();
                txtNamaBarang.Text = row.Cells["Barang"].Value.ToString();
            }
            cekKode();
        }

        private void btResetBarang_Click(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }

        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_barang WHERE kode_barang = '" + txtKodeBarang.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditBarang.Enabled = true;
                    btSimpanBarang.Enabled = false;
                }
                else
                {
                    btEditBarang.Enabled = false;
                    btSimpanBarang.Enabled = true;
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

        private string cekInput()
        {
            if (cbKategoriBarang.Text == "Pilih Kategori")
            {
                MessageBox.Show("Pilih kategori dulu!");
                cbKategoriBarang.Focus();
                validasi = "gagal";

            }
            else if (txtNamaBarang.Text == "")
            {
                MessageBox.Show("Nama Barang tidak boleh kosong!");
                txtNamaBarang.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }

            return validasi;
        }

        private void cbKategoriBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            getKategori = cbKategoriBarang.Text;

            if(getKategori == "Pilih Kategori")
            {
                txtKodeBarang.Text = "";
            }
            else
            {
                autoKode();

            }

            cekKode();


        }
    }
}
