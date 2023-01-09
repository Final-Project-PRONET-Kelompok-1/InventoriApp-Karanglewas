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
        SqlConnection conn = new SqlConnection(dbConfig.conn); 
        SqlCommand cmd;
        SqlDataReader reader;
        public FormDataBarang()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn.Open();
            string query = "SELECT tb_kategori.jenis_kategori AS Kategori, tb_barang.nama_barang AS Barang, " +
                           "SUM(tb_barangmasuk.jumlah) AS Masuk, SUM(tb_barangkeluar.jumlah) AS keluar, " +
                           "SUM(tb_barangmasuk.jumlah) - SUM(tb_barangkeluar.jumlah) AS Total FROM tb_barang " +
                           "INNER JOIN tb_kategori ON tb_barang.id_kategori = tb_kategori.id_kategori " +
                           "INNER JOIN tb_barangmasuk ON tb_barang.id_barang = tb_barangmasuk.id_barang " +
                           "INNER JOIN tb_barangkeluar ON tb_barang.id_barang = tb_barangkeluar.id_barang " +
                           "GROUP BY tb_barang.id_kategori,tb_kategori.jenis_kategori,tb_barang.nama_barang";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDB.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            show();   
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

        private void cbKategoriBM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from data_barang where Barang like '%" + txtDB.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "data_barang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "data_barang";
        }

        private void btnrefres_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
