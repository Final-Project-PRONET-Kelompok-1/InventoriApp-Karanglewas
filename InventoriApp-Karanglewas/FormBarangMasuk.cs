using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    public partial class FormBarangMasuk : Form
    {
        SqlConnection conn = new SqlConnection(dbConfig.conn);
       // SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        int autoId;
        string kategori,validasi;
        DateTime date;

        DataTable dataTable = new DataTable();
        
        FormRiwayat fr = new FormRiwayat();
        
        FormMaster f1 = new FormMaster();
        public FormBarangMasuk()
        {
            InitializeComponent();
            setCB();
            cbKategori();
            autoKode();
            fillDataBM();
            cekKode();
            txtKodeBM.Enabled = false;
        }

        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_barangmasuk WHERE kode_bm = '" + txtKodeBM.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditBM.Enabled = true;
                    btHapusBM.Enabled = true;
                    btSimpanBM.Enabled = false;
                }
                else
                {
                    btEditBM.Enabled = false;
                    btHapusBM.Enabled = false;
                    btSimpanBM.Enabled = true;
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

        private void setCB()
        {
            if (cbKategoriBM.Text == "Pilih Kategori")
            {
                cbBarangBM.Text = "Pilih Barang";
                cbBarangBM.Enabled = false;
            }
            else
            {
                cbBarangBM.Enabled = true;
            }
        }

        private void FormBarangMasuk_Load(object sender, EventArgs e)
        {
            setCB();
        }

        private void txtKodeBM_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataBM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataBM.Rows[e.RowIndex];
                txtKodeBM.Text = row.Cells["Kode"].Value.ToString();
                cbKategoriBM.Text = row.Cells["Kategori"].Value.ToString();
                cbBarangBM.Text = row.Cells["Barang"].Value.ToString();
                txtJumlahBM.Text = row.Cells["Jumlah"].Value.ToString();
                dtBM.Value = (DateTime)row.Cells["Tanggal"].Value;
                txtPIC.Text = row.Cells["PIC"].Value.ToString();
            }

            cekKode();
         
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_bm FROM tb_barangmasuk ORDER BY id_barangmasuk DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            date = DateTime.Now;
            string dateBK = date.ToString("yyMMdd");

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no =  reader["kode_bm"].ToString();
                no = no.Substring(8, 4);
                int str = Convert.ToInt32(no) + 1;
                kode = "BM" + dateBK + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = "BM" + dateBK + "0001";
            }
            txtKodeBM.Text = kode;
            conn.Close();
        }
        private void simpanRiwayat(string status)
        {
            string aktifitas = "Barang Masuk";
            string keterangan = status;
            string username = f1.getAdmin();
            date = DateTime.Now;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_riwayat (tanggal, aktifitas, id_barang, jumlah, keterangan, id_admin)\n" +
                                "SELECT '" + date + "', '" + aktifitas + "', b.id_barang, '" + txtJumlahBM.Text + "', '" + keterangan + "', a.id_admin\n" +
                                "FROM tb_barang b, tb_admin a " +
                                "WHERE b.nama_barang = '" + cbBarangBM.Text + "'" +
                                "AND a.username = '" + username + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void simpanBM()
        {
            date = Convert.ToDateTime(dtBM.Text);
            DateTime dateBK = dtBM.Value;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barangmasuk (kode_bm, id_barang, jumlah, tanggal, pic)\n" +
                                "SELECT '" + txtKodeBM.Text + "', b.id_barang, '" + txtJumlahBM.Text + "','" + dateBK + "','" + txtPIC.Text + "'" +
                                "FROM tb_barang b " +
                                "WHERE b.nama_barang = '" + cbBarangBM.Text + "' ";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBM()
        {
            DateTime dateBK = dtBM.Value;

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barangmasuk SET id_barang = (SELECT id_barang FROM tb_barang WHERE nama_barang = '" + cbBarangBM.Text + "'), tanggal='" + dateBK + "', jumlah = '" + int.Parse(txtJumlahBM.Text) + "', pic = '" + txtPIC.Text + "' " +
                  "WHERE kode_bm= '" + txtKodeBM.Text + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbBarang()
        {
            kategori = cbKategoriBM.Text;
            try
            {
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.nama_kategori = '" + kategori + "'";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "barang");

                DataRow row = ds.Tables["barang"].NewRow();
                row["nama_barang"] = "Pilih Barang";
                ds.Tables["barang"].Rows.InsertAt(row, 0);

                cbBarangBM.DataSource = ds.Tables["barang"];
                cbBarangBM.DisplayMember = "nama_barang";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbKategori()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tb_kategori";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "kategori");

                DataRow row = ds.Tables["kategori"].NewRow();
                row["nama_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKategoriBM.DataSource = ds.Tables["kategori"];
                cbKategoriBM.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetForm()
        {
            autoKode();

            cbKategoriBM.Text = "Pilih Kategori";
            txtJumlahBM.Clear();
            txtPIC.Clear();
            cbBarangBM.Text = "Pilih Barang";
            

            date = DateTime.Now;
            dtBM.Text = date.ToString();
        }

        private void btSimpanBM_Click(object sender, EventArgs e)
        {
            cekValidasi();
            if (validasi == "oke")
            {
                simpanBM();
                simpanRiwayat("Simpan");
                resetForm();
                MessageBox.Show("Data berhasil disimpan");
                fillDataBM();
            }
        }

        private void cbKategoriBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCB();
            cbBarang();
        }

        private DataTable getDataBM()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT  bm.kode_bm as Kode, bm.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bm.jumlah as Jumlah, bm.pic as PIC " +
                                "FROM tb_barangmasuk bm " +
                                "INNER JOIN tb_barang b ON bm.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "ORDER BY bm.tanggal DESC ";
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

        private void btHapusBM_Click(object sender, EventArgs e)
        {
            var tanya = MessageBox.Show("Apakah anda yakin \n" +
                "akan menghapus data dengan kode = " + txtKodeBM.Text + " ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM tb_barangmasuk WHERE kode_bm = '" + txtKodeBM.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                simpanRiwayat("Hapus");
                resetForm();
                fillDataBM();
                cekKode();
            }

        }

        private string cekValidasi()
        {
            if (cbKategoriBM.Text == "Pilih Kategori")
            {
                MessageBox.Show("Anda belum memilih kategori!");
                cbKategoriBM.Focus();
                validasi = "gagal";
            }
            else if (cbBarangBM.Text == "Pilih Barang")
            {
                MessageBox.Show("Anda belum memilih barang!");
                cbBarangBM.Focus();
                validasi = "gagal";
            }
            else if (txtJumlahBM.Text == "" | txtJumlahBM.Text == "0")
            {
                MessageBox.Show("Jumlah tidak boleh kosong!");
                txtJumlahBM.Focus();
                validasi = "gagal";
            }
            else if (txtPIC.Text == "")
            {
                MessageBox.Show("PIC tidak boleh kosong!");
                txtPIC.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }
            return validasi; 
        }

        private void fillDataBM()
        {

            dataBM.DataSource = getDataBM();
        }

        private void btEditBM_Click(object sender, EventArgs e)
        {
            cekValidasi();
            if (validasi == "oke")
            {
                updateBM();
                simpanRiwayat("Edit");
                resetForm();
                MessageBox.Show("Data berhasil diedit");
                fillDataBM();
                cekKode();
            }
        }

        private void txtPIC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIC.Text, "[^A-z]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan nama.");
                txtPIC.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btResetBM_Click(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }

        private void txtJumlahBM_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJumlahBM.Text, "[^0-9]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan angka.");
                txtJumlahBM.Clear();
            }
        }
    }
}
