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
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string date1;
        string date2;
        DateTime date;
        DataTable dataTable = new DataTable();



        public FormRiwayat()
        {
            InitializeComponent();
            fillDataRiwayat();

            cbFilterRiwayat.Text = "Semua Data";
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
            dataRiwayat.DataSource = tampilSemua();
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {

        }


        private void dataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            dataRiwayat.DataSource = tampilSemua();
        }

        private void resetDTP()
        {
            date = DateTime.Now;
            dateTimePicker2.Text = date.ToString();
            dateTimePicker3.Text = date.ToString();
        }
        private void cbFilterRiwayat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterRiwayat.Text == "Semua Data")
            {
                fillDataRiwayat();
                panelFilterTanggal.Visible = false;
                panelFilterText.Visible = false;

                resetDTP();
                txtFilterRiwayat.Text = "";
            }
            else if (cbFilterRiwayat.Text == "By Tanggal")
            {
                panelFilterTanggal.Visible = true;
                panelFilterText.Visible = false;
                resetDTP();
                txtFilterRiwayat.Text = "";
            }

            else if (cbFilterRiwayat.Text == "By Text")
            {
                panelFilterTanggal.Visible = false;
                panelFilterText.Visible = true;

                resetDTP();
                fillDataRiwayat();
            }
        }

        private void filterByText()
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
                                "WHERE (k.nama_kategori LIKE '%" + txtFilterRiwayat.Text + "%' OR b.nama_barang LIKE '%" + txtFilterRiwayat.Text +
                                "%' OR r.jumlah LIKE '%" + txtFilterRiwayat.Text + "%' OR r.aktifitas LIKE '%" + txtFilterRiwayat.Text + "%' OR r.keterangan LIKE '%" + txtFilterRiwayat.Text + "%' OR a.username LIKE '%" + txtFilterRiwayat.Text + "%') " +
                                "ORDER BY r.id_riwayat DESC";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataRiwayat.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilterRiwayat_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterRiwayat.Text == "")
            {
                fillDataRiwayat();
            }
        }

        private void panelFilterTanggalRwt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCariTextRwt_Click_1(object sender, EventArgs e)
        {
            filterByText();
        }

        private void btCariTanggal_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            date2 = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
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
                                "WHERE r.tanggal BETWEEN '" + date1 + "' AND '" + date2 + "' " +
                                "ORDER BY r.id_riwayat DESC";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataRiwayat.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
