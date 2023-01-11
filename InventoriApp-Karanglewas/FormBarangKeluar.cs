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
    public partial class FormBarangKeluar : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        int autoId;
        int stoksementara;
        DateTime date;

        DataTable dataTable = new DataTable();

        FormRiwayat fr = new FormRiwayat();

        FormMaster f1 = new FormMaster();
        public FormBarangKeluar()
        {
            InitializeComponent();
            setCB();
            cbKategori();
            autoKode();
            fillDataBK();

            txtKodeBK.Enabled = false;
        }
        private void setCB()
        {
            if (cbKategoriBK.Text == "Pilih Kategori")
            {
                cbBarangBK.Text = "Pilih Barang";
                cbBarangBK.Enabled = false;
            }
            else
            {
                cbBarangBK.Enabled = true;
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

                cbKategoriBK.DataSource = ds.Tables["kategori"];
                cbKategoriBK.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getStokSistem()
        {
            string query = "SELECT CASE WHEN (masuk.total_masuk - keluar.total_keluar) IS NULL THEN 0 ELSE (masuk.total_masuk - keluar.total_keluar) END AS Total " +
                "FROM dbo.tb_barang LEFT OUTER JOIN " +
                "dbo.tb_kategori ON dbo.tb_kategori.id_kategori = dbo.tb_barang.id_kategori LEFT OUTER JOIN " +
                "(SELECT id_kategori, id_barang, SUM(jumlah) AS total_masuk " +
                "FROM      dbo.tb_barangmasuk " +
                "GROUP BY id_kategori, id_barang) AS masuk ON masuk.id_kategori = dbo.tb_kategori.id_kategori AND masuk.id_barang = dbo.tb_barang.id_barang LEFT OUTER JOIN " +
                "(SELECT id_kategori, id_barang, SUM(jumlah) AS total_keluar " +
                "FROM      dbo.tb_barangkeluar " +
                "GROUP BY id_kategori, id_barang) AS keluar ON keluar.id_kategori = dbo.tb_kategori.id_kategori AND keluar.id_barang = dbo.tb_barang.id_barang " +
                "WHERE dbo.tb_barang.nama_barang = '" + cbBarangBK.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                stoksementara =int.Parse(rd[0].ToString());
                rd.Close();
            }
            conn.Close();

        }
        private void cbBarang()
        {
            kategori = cbKategoriBK.Text;
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

                cbBarangBK.DataSource = ds.Tables["barang"];
                cbBarangBK.DisplayMember = "nama_barang";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtJumlahBK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJumlahBK.Text, "[^0-9]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan angka.");
                
            }
            
        }

        private void btResetBK_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            //kodeRandom();
            autoKode();

            cbKategoriBK.Text = "Pilih Kategori";
            txtJumlahBK.Clear();
            txtPIC.Clear();
            cbBarangBK.Text = "Pilih Barang";
            cbBarangBK.Enabled = false;

            date = DateTime.Now;
            dtBK.Text = date.ToString();
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_bk FROM tb_barangkeluar ORDER BY id_barangkeluar DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            date = DateTime.Now;
            string dateBK = date.ToString("yyMMdd");

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no = reader["kode_bk"].ToString();
                no = no.Substring(8, 4);
                int str = Convert.ToInt32(no) + 1;
                kode = "BK" + dateBK + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = "BK" + dateBK + "0001";
            }
            txtKodeBK.Text = kode;
            conn.Close();
        }

        //private static Random random = new Random();

        /*public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string (Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            
        }

        public void kodeRandom()
        {
            int length = 12;
            string randomString = RandomString(length);
            while (ValueExistsInDatabase(randomString))
            {
                
                randomString = RandomString(length);
            }
                                 
            txtKodeBK.Text = randomString;
        }

        private bool ValueExistsInDatabase(string value)
        {
            
            {
                string query = "SELECT COUNT(*) FROM tb_barangkeluar WHERE kode_bk = @value";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return count > 0;
                }
            }
        }*/


        private void cbKategoriBK_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCB();
            cbBarangBK.Text = "Pilih Barang";
            cbBarang();
        }
        private void cekInput()
        {
            if (cbKategoriBK.Text == "Pilih Kategori")
            {
                MessageBox.Show("Anda belum memilih kategori!");
                cbKategoriBK.Focus();
            }
            else if (cbBarangBK.Text == "Pilih Barang")
            {
                MessageBox.Show("Anda belum memilih barang!");
                cbBarangBK.Focus();
            }
            else if (txtJumlahBK.Text == "" | txtJumlahBK.Text == "0")
            {
                MessageBox.Show("Jumlah tidak boleh kosong!");
                txtJumlahBK.Focus();
            }
            else if (txtPIC.Text == "")
            {
                MessageBox.Show("PIC tidak boleh kosong!");
                txtPIC.Focus();
            }
            else
            {
                simpanBK();
                simpanRiwayat("Simpan");
                resetForm();
                fillDataBK();
            }
        }
        private void simpanRiwayat(string status)
        {
            string aktifitas = "Barang Keluar";
            string keterangan = status;
            string username = f1.getAdmin();
            date = DateTime.Now;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_riwayat (tanggal, aktifitas, id_barang, jumlah, keterangan, id_admin)\n" +
                                "SELECT '" + date + "', '" + aktifitas + "', b.id_barang, '" + txtJumlahBK.Text + "', '" + keterangan + "', a.id_admin\n" +
                                "FROM tb_barang b, tb_kategori k, tb_admin a\n" +
                                "WHERE k.nama_kategori = '" + cbKategoriBK.Text + "'\n" +
                                "AND b.nama_barang = '" + cbBarangBK.Text + "'" +
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
        private void simpanBK()
        {
            DateTime dateBK = dtBK.Value;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barangkeluar (kode_bk, id_barang, jumlah, tanggal, pic)\n" +
                                "SELECT  '" + txtKodeBK.Text + "', b.id_barang, '" + txtJumlahBK.Text + "','" + dateBK + "','" + txtPIC.Text + "'" +
                                "FROM tb_barang b " +
                                "WHERE b.nama_barang = '" + cbBarangBK.Text + "' ";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataBK.FirstDisplayedScrollingRowIndex = dataBK.RowCount - 1;
        }

        private void btSimpanBK_Click(object sender, EventArgs e)
        {
            /*if (int.Parse(txtJumlahBK.Text.Trim()) >= stoksementara)
            {
                MessageBox.Show("Jumlah melebihi stok tersedia!\nStok tersedia '" + stoksementara.ToString() + "'");
                txtJumlahBK.Focus();
            }
            else
            {
                cekInput();
                MessageBox.Show("Data berhasil disimpan");
            }*/
            cekInput();
            MessageBox.Show("Data berhasil disimpan");

        }
        private DataTable getDataBM()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT bk.kode_bk as Kode, bk.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bk.jumlah as Jumlah, bk.pic as PIC " +
                                "FROM tb_barangkeluar bk " +
                                "INNER JOIN tb_barang b ON bk.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "ORDER BY bk.tanggal DESC";

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
        private void fillDataBK()
        {

            dataBK.DataSource = getDataBM();
        }

        private void txtPIC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIC.Text, "[^A-z]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan nama.");
                txtPIC.Clear();
            }
        }

        private void btHapusBK_Click(object sender, EventArgs e)
        {
            var tanya = MessageBox.Show("Apakah anda yakin ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM tb_barangkeluar WHERE kode_bk = '" + txtKodeBK.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                simpanRiwayat("Hapus");
                resetForm();
                fillDataBK();

            }
        }

        private void FormBarangKeluar_Load(object sender, EventArgs e)
        {

        }

        private void dataBK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataBK.Rows[e.RowIndex];
                txtKodeBK.Text = row.Cells["Kode"].Value.ToString();
                cbKategoriBK.Text = row.Cells["Kategori"].Value.ToString();
                cbBarangBK.Text = row.Cells["Barang"].Value.ToString();
                txtJumlahBK.Text = row.Cells["Jumlah"].Value.ToString();
                dtBK.Value = (DateTime)row.Cells["Tanggal"].Value;
                txtPIC.Text = row.Cells["PIC"].Value.ToString();
            }
        }

        private void updateBK()
        {
            DateTime dateBK = dtBK.Value;

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barangkeluar SET id_barang = (SELECT id_barang FROM tb_barang WHERE nama_barang = '" + cbBarangBK.Text + "'), tanggal='" + dateBK + "', jumlah = '" + int.Parse(txtJumlahBK.Text) + "', pic = '" + txtPIC.Text + "' " +
                  "WHERE kode_bk= '" + txtKodeBK.Text + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btEditBK_Click(object sender, EventArgs e)
        {
            updateBK();
            simpanRiwayat("Edit");
            resetForm();
            fillDataBK();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbBarangBK_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getStokSistem();
        }
    }
}
