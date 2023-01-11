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
using CrystalDecisions.Shared.Json;

namespace InventoriApp_Karanglewas
{
    public partial class FormDataBarang : Form
    {
        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        DataTable dataTable = new DataTable();
        public FormDataBarang()
        {
            InitializeComponent();
        }
        /*private void show()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from totalBarang";
            
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "totalBarang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "totalBarang";
            dgvDB.ReadOnly = true;
        }*/

        /*private DataTable getDataDB()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT " +
                            "tb_kategori.jenis_kategori AS Kategori, " +
                            "tb_barang.nama_barang AS Barang, " +
                            "CASE WHEN masuk.total_masuk IS NULL THEN 0 ELSE masuk.total_masuk END AS Masuk, " +
                            "CASE WHEN keluar.total_keluar IS NULL THEN 0 ELSE keluar.total_keluar END AS Keluar, " +
                            "CASE WHEN (masuk.total_masuk - keluar.total_keluar) IS NULL THEN 0 ELSE (masuk.total_masuk - keluar.total_keluar) END AS Total " +
                        "FROM tb_barang " +
                        "LEFT JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori " +
                        "LEFT JOIN ( " +
                            "SELECT " +
                                "tb_barangmasuk.id_kategori, " +
                                "tb_barangmasuk.id_barang, " +
                                "SUM(tb_barangmasuk.jumlah) as total_masuk " +
                            "FROM tb_barangmasuk " +
                            "GROUP BY tb_barangmasuk.id_kategori,tb_barangmasuk.id_barang " +
                        ") masuk ON masuk.id_kategori = tb_kategori.id_kategori AND masuk.id_barang = tb_barang.id_barang " +
                        "LEFT JOIN ( " +
                            "SELECT " +
                                "tb_barangkeluar.id_kategori, " +
                                "tb_barangkeluar.id_barang, " +
                                "SUM(tb_barangkeluar.jumlah) as total_keluar " +
                            "FROM tb_barangkeluar " +
                            "GROUP BY tb_barangkeluar.id_kategori,tb_barangkeluar.id_barang " +
                        ") keluar ON keluar.id_kategori = tb_kategori.id_kategori AND keluar.id_barang = tb_barang.id_barang";
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
        }*/

        private DataTable getDataDB()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT k.nama_kategori AS Kategori, b.nama_barang AS Barang, " +
                                "CASE WHEN sb.total_masuk IS NULL THEN 0 ELSE sb.total_masuk END AS Total_Masuk, " +
                                "CASE WHEN sb.total_keluar IS NULL THEN 0 ELSE sb.total_keluar END AS Total_Keluar, " +
                                "CASE WHEN sb.total_stok IS NULL THEN 0 ELSE sb.total_stok END AS Sisa_Stok " +
                                "FROM tb_stokbarang sb " +
                                "LEFT JOIN tb_barang b ON sb.id_barang = b.id_barang " +
                                "LEFT JOIN tb_kategori k ON b.id_kategori = k.id_kategori ";
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

            dgvDB.DataSource = getDataDB();
        }

        private void cbKategori()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from totalBarang where kategori like '%" + cbKategoriBM.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "totalBarang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "totalBarang";
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
            cbKategori();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from totalBarang where Barang like '%" + txtDB.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "totalBarang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "totalBarang";
        }

        private void btnrefres_Click(object sender, EventArgs e)
        {
            //show();
            fillDataBarang();
        }
    }
}
