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
        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;

        string getKategori;

        DataTable dataTable = new DataTable();
        public FormDataBarang()
        {
            InitializeComponent();
            fillDataBarang();

            dgvDB.ReadOnly = true;
            cbFilter.Text = "Semua Data";
        }

        private void cbKategori(ComboBox cb)
        {
            try
            {
                conn.Open();
                string query = "SELECT nama_kategori FROM tb_kategori";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "kategori");

                DataRow row = ds.Tables["kategori"].NewRow();
                row["nama_kategori"] = "Semua Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cb.DataSource = ds.Tables["kategori"];
                cb.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private DataTable getFilter()
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
                                "LEFT JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                                "WHERE k.nama_kategori = '"+getKategori+"' ";
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


        public void fillDataBarang()
        {

            dgvDB.DataSource = getDataDB();
        }



        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            //show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void txtSB_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Semua Data")
            {
                fillDataBarang();
                panelFilterKategori.Visible = false;
                panelFilterText.Visible = false;

                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Kategori")
            {
                panelFilterKategori.Visible = true;
                panelFilterText.Visible = false;

                cbKategori(cbFilterKategori);
                fillDataBarang();
                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Text")
            {
                panelFilterKategori.Visible = false;
                panelFilterText.Visible = true;

                fillDataBarang();
            }
        }

        private void btCariText_Click(object sender, EventArgs e)
        {
            filterByText();
        }

        private void filterByText()
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
                                "LEFT JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                                "WHERE (k.nama_kategori LIKE '%" + txtFilterBarang.Text + "%' OR b.nama_barang LIKE '%" + txtFilterBarang.Text + "%' " +
                                "OR sb.total_masuk LIKE '%" + txtFilterBarang.Text + "%' OR sb.total_keluar LIKE '%" + txtFilterBarang.Text + "%' OR sb.total_stok LIKE '%" + txtFilterBarang.Text + "%') ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dgvDB.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFilterKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            filterByKategori();
        }

        private void filterByKategori()
        {

            try
            {
                if (cbFilterKategori.Text == "Semua Kategori")
                {
                    fillDataBarang();
                }
                else
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
                                    "LEFT JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                                    "WHERE k.nama_kategori = '" + cbFilterKategori.Text + "' ";
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    conn.Close();

                    dgvDB.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilterBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBarang.Text == "")
            {
                fillDataBarang();
            }
        }
    }
}
