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
    public partial class FormRiwayat : Form
    {

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        DataTable dataTable = new DataTable();

        public FormRiwayat()
        {
            InitializeComponent();
            fillDataRiwayat();
        }

        private DataTable getDataRiwayat()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT r.tanggal as Tanggal, r.aktifitas as Aktifitas, k.nama_kategori as Kategori, b.nama_barang as Barang, r.jumlah as Jumlah, r.keterangan as Ket, a.username as Admin\n" +
                                "FROM tb_riwayat r " +
                                "INNER JOIN tb_barang b ON r.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "INNER JOIN tb_admin a ON r.id_admin = a.id_admin\n" +
                                "ORDER BY r.id_riwayat DESC";
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

        private void fillDataRiwayat()
        {

            dataRiwayat.DataSource = getDataRiwayat();
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {

        }

        private void dataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
