using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoriApp_Karanglewas
{
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            // Buat koneksi ke database
            string connectionString = "Data Source=DESKTOP-5KDEI2T;Initial Catalog=InventoriApp;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Buat query untuk mengambil data dari beberapa tabel dengan relasi
            string query = "SELECT tb_barangmasuk.id_kategori AS Kategori, tb_barangmasuk.kode_bm AS Barang, tb_barangmasuk.jumlah AS Masuk, tb_barangkeluar.jumlah AS keluar FROM tb_barangmasuk " +
                           "INNER JOIN tb_barangkeluar ON tb_barangmasuk.id_kategori = tb_barangkeluar.id_kategori ";

            // Buat adapter untuk menjalankan query dan mengisi dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            // Tambahkan dataset ke dalam gridview
            dgvDB.DataSource = dataset;
            dgvDB.DataMember = "Table";
            // Tabel yang dihasilkan oleh query

        }

        private void btTambah_Click(object sender, EventArgs e)
        {

            FormKategoriBarang FM = new FormKategoriBarang(); // Instantiate a Form3 object.
          //  this.Hide();
            FM.ShowDialog(); // Show Form3 and
           // this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
