﻿using System;
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
        SqlConnection conn = new SqlConnection(dbConfig.conn);
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        DataTable dataTable = new DataTable();
        public FormDataBarang()
        {
            InitializeComponent();
            fillDataBarang();
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

                DataRow row = ds.Tables["kategori"].NewRow();
                row["nama_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKategoriSB.DataSource = ds.Tables["kategori"];
                cbKategoriSB.DisplayMember = "nama_kategori";
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
                string query= "SELECT k.nama_kategori AS Kategori, b.nama_barang AS Barang, " +
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

        public void fillDataBarang()
        {

            dgvDB.DataSource = getDataDB();
        }

        private DataTable cbKategori1(string kategori)
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT k.nama_kategori AS Kategori, b.nama_barang AS Barang, " +
                                "sb.total_masuk AS Total_Masuk, " +
                                "sb.total_keluar AS Total_Keluar, " +
                                "sb.total_stok AS Sisa_Stok " +
                                "FROM tb_stokbarang sb " +
                                "JOIN tb_barang b ON sb.id_barang = b.id_barang " +
                                "JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                                "WHERE k.nama_kategori = '"+kategori+"'";
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
            string kategori = cbKategoriSB.Text;
            cbKategori1(kategori);
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
