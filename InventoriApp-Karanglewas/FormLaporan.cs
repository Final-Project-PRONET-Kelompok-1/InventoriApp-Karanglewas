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
    public partial class FormLaporan : Form
    {

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        DataTable dataTable = new DataTable();

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


        private DataTable getDataBK()
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


        private DataTable getDataSO()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT so.kode_so as Kode, so.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, so.stok_sistem as StokSistem, so.stok_fisik as StokFisik, so.pic as PIC, so.status as Status\n" +
                                "FROM tb_stokopname so\n" +
                                "INNER JOIN tb_barang b ON so.id_barang = b.id_barang\n" +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori\n" +
                                "ORDER BY so.kode_so DESC";
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


        public FormLaporan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void cbPilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPilih.Text.ToString() == "Data Barang")
            {
                dgvLaporan.DataSource = getDataDB();

            }

            if (cbPilih.Text.ToString() == "Barang Masuk")
            {
                dgvLaporan.DataSource = getDataBM();

            }

            if (cbPilih.Text.ToString() == "Barang Keluar")
            {
                dgvLaporan.DataSource = getDataBK();

            }

            if (cbPilih.Text.ToString() == "Stok Opname")
            {
                dgvLaporan.DataSource = getDataSO();
                
            }

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (cbPilih.Text.ToString() == "Stok Opname")
            {
                ReportStokOpname report = new ReportStokOpname();
                report.Show();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }

            if (cbPilih.Text.ToString() == "Barang Masuk")
            {
                ReportBarangMasuk report1 = new ReportBarangMasuk();
                report1.Show();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }

            if (cbPilih.Text.ToString() == "Barang Keluar")
            {
                ReportBarangKeluar report2 = new ReportBarangKeluar();
                report2.Show();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
        }
    }
}
