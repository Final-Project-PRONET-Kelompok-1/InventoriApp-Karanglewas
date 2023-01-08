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
        //SqlConnection conn = new SqlConnection
        // (@"Data Source=.\SQLEXPRESS;Initial Catalog = InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        int autoId;
        DateTime date;

        DataTable dataTable = new DataTable();

        //FormRiwayat fr = new FormRiwayat();

        FormMaster f1 = new FormMaster();
        public FormBarangKeluar()
        {
            InitializeComponent();
            setCB();
            cbKategori();
            kodeRandom();
            autoID();
            fillDataBK();
            //fr.autoIDRiwayat();

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
                cbKategoriBK.DataSource = ds.Tables["kategori"];
                cbKategoriBK.DisplayMember = "jenis_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbBarang()
        {
            kategori = cbKategoriBK.Text;
            try
            {
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.jenis_kategori = '" + kategori + "'";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "barang");
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
                txtJumlahBK.Text = txtJumlahBK.Text.Remove(txtJumlahBK.Text.Length - 1);
            }
        }

        private void btResetBK_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            autoID();
            
            //fr.autoIDRiwayat();
            kodeRandom();

            cbKategoriBK.Text = "Pilih Kategori";
            txtJumlahBK.Clear();
            txtPIC.Clear();
            cbBarangBK.Text = "Pilih Barang";
            cbBarangBK.Enabled = false;

            date = DateTime.Now;
            dtBK.Text = date.ToString();
        }
        private void autoID()
        {
            int id;
            conn.Open();
            string query = "SELECT * FROM tb_barangkeluar ORDER BY id_barangkeluar DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //string no = reader.GetString("id_barangkeluar");
                string no = reader[0].ToString();
                id = Convert.ToInt32(no) + 1;

            }
            else
            {
                id = 1;
            }
            autoId = id;
            conn.Close();
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string (Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            
        }

        public void kodeRandom()
        {
            int length = 12; // Specify the desired length of the random string
            string randomString = RandomString(length);
            txtKodeBK.Text = randomString;
        }
        
        

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
                //simpanRiwayat();
                resetForm();
                fillDataBK();
            }
        }
        private void simpanBK()
        {
            date = Convert.ToDateTime(dtBK.Text);
            string dateBK = date.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barangkeluar (id_barangkeluar, kode_bk, id_kategori, id_barang, jumlah, tanggal, pic)\n" +
                                "SELECT '" + autoId + "', '" + txtKodeBK.Text + "', k.id_kategori, b.id_barang, '" + txtJumlahBK.Text + "','" + dateBK + "','" + txtPIC.Text + "'" +
                                "FROM tb_barang b, tb_kategori k\n" +
                                "WHERE k.jenis_kategori = '" + cbKategoriBK.Text + "'\n" +
                                "AND b.nama_barang = '" + cbBarangBK.Text + "' ";
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
            cekInput();
        }
        private DataTable getDataBM()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT bk.kode_bk as Kode, bk.tanggal as Tanggal, k.jenis_kategori as Kategori, b.nama_barang as Barang, bk.jumlah as Jumlah, bk.pic as PIC\n" +
                                "FROM tb_barangkeluar bk\n" +
                                "INNER JOIN tb_barang b ON bk.id_barang = b.id_barang\n" +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori\n" +
                                "ORDER BY bk.kode_bk DESC";
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
            foreach (DataGridViewRow item in this.dataBK.SelectedRows)
            {
                conn.Open();
                string query = "DELETE FROM tb_barangkeluar WHERE id_barangkeluar = '" + dataBK.SelectedRows[0].Cells[0].Value + "'";
                var cmd = new SqlCommand(query, conn);
                dataBK.Rows.RemoveAt(this.dataBK.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void FormBarangKeluar_Load(object sender, EventArgs e)
        {

        }
    }
}
