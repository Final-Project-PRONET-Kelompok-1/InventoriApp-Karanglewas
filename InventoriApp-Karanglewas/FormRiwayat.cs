using Microsoft.SqlServer.Server;
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
using System.Globalization;

namespace InventoriApp_Karanglewas
{
    public partial class FormRiwayat : Form
    {

        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string date1;
        string date2;
        DataTable dataTable = new DataTable();
       
        public FormRiwayat()
        {
            InitializeComponent();
            fillDataRiwayat();
        }

        private DataTable tampilSemua()
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

        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {

        }

        private void tbTanggal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbSemua_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbTglsd_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            dataRiwayat.DataSource = tampilSemua();
        }

        private void btnTanggal_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            date2 = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
            conn.Open();
            dataTable.Reset();
            dataTable = new DataTable();
            cmd = new SqlCommand("SELECT * FROM tb_riwayat WHERE tanggal BETWEEN '" + date1 + "' AND '" + date2 + "'", conn);
            reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            dataRiwayat.DataSource = dataTable;
            conn.Close();
        }
    }
}
