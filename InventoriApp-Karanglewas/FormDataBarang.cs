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
using System.Windows.Controls.Primitives;

namespace InventoriApp_Karanglewas
{
    public partial class FormDataBarang : Form
    {
        SqlConnection conn = new SqlConnection(dbConfig.conn); 
        SqlCommand cmd;
        SqlDataReader reader;

        DataTable dataTable = new DataTable();
        public FormDataBarang()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn.Open();
            string query = "SELECT k.jenis_kategori AS Kategori, b.nama_barang AS Barang, " +
                           "SUM(bm.jumlah) AS Masuk, SUM(bk.jumlah) AS keluar, " +
                           "b.total As Total" +
                           "FROM tb_barang b"+
                           "INNER JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                           "INNER JOIN tb_barangmasuk bm ON b.id_barang = bm.id_barang " +
                           "INNER JOIN tb_barangkeluar bk ON b.id_barang = bk.id_barang " +
                           "GROUP BY b.id_kategori,k.jenis_kategori,b.nama_barang, b.total";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDB.DataSource = ds.Tables[0];
            conn.Close();
        }

        private DataTable getDataBarang()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT tb_kategori.jenis_kategori AS Kategori, tb_barang.nama_barang AS Barang,\n" +
                    "SUM(tb_barangmasuk.jumlah) AS Masuk, SUM(tb_barangkeluar.jumlah) AS keluar, \n" +
                    "tb_barang.total As Total \n" +
                    "FROM tb_barang \n" +
                    "INNER JOIN tb_kategori ON tb_barang.id_kategori = tb_kategori.id_kategori \n" +
                    "INNER JOIN tb_barangmasuk ON tb_barang.id_barang = tb_barangmasuk.id_barang \n" +
                    "INNER JOIN tb_barangkeluar ON tb_barang.id_barang = tb_barangkeluar.id_barang \n" +
                    "GROUP BY tb_barang.id_kategori,tb_kategori.jenis_kategori,tb_barang.nama_barang, tb_barang.total";
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

            dgvDB.DataSource = getDataBarang();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            //show();
            fillDataBarang();
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
            //show();
            fillDataBarang();
        }
    }
}
