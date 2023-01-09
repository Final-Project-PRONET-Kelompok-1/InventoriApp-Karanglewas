﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    public partial class FormBarangMasuk : Form
    {
        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        int autoId;
        string kategori;

        DateTime date;
        DataTable dataTable = new DataTable();
        public FormBarangMasuk()
        {
            InitializeComponent();
            autoID();
            autoKode();
            cbKategori();
            cbBarang();
            fillDataBM();
            txtKodeBM.Enabled = false;
        }

        private void FormBarangMasuk_Load(object sender, EventArgs e)
        {

        }

        private void txtKodeBM_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataBM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataBM.Rows[e.RowIndex];
            txtKodeBM.Text = row.Cells["Kode"].Value.ToString();
            cbKategoriBM.Text = row.Cells["Kategori"].Value.ToString();
            cbBarangBM.Text = row.Cells["Barang"].Value.ToString();
            txtJumlahBM.Text = row.Cells["Jumlah"].Value.ToString();
            dtBM.Value = (DateTime)row.Cells["Tanggal"].Value;
            txtPIC.Text = row.Cells["PIC"].Value.ToString();
        }

        private void autoID()
        {
            int id;
            conn.Open();
            string query = "SELECT * FROM tb_barangmasuk ORDER BY id_barangmasuk DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //string no = reader.GetString("id_barangkeluar");
                string no = reader[0].ToString();
                id = Convert.ToInt32(no) + 1;

            }
            else
            {
                id = 1;
            }
            autoId = id;
            conn.Close();
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_bm FROM tb_barangmasuk ORDER BY kode_bm DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            date = DateTime.Now;
            string dateBK = date.ToString("yyMMdd");

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no =  reader["kode_bm"].ToString();
                no = no.Substring(8, 4);
                int str = Convert.ToInt32(no) + 1;
                kode = "BM" + dateBK + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = "BM" + dateBK + "0001";
            }
            txtKodeBM.Text = kode;
            conn.Close();
        }

        private void simpanBM()
        {
            date = Convert.ToDateTime(dtBM.Text);
            string dateBK = date.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barangmasuk (id_barangmasuk, kode_bm, id_kategori, id_barang, jumlah, tanggal, pic)\n" +
                                "SELECT '" + autoId + "', '" + txtKodeBM.Text + "', k.id_kategori, b.id_barang, '" + txtJumlahBM.Text + "','" + dateBK + "','" + txtPIC.Text + "'" +
                                "FROM tb_barang b, tb_kategori k\n" +
                                "WHERE k.jenis_kategori = '" + cbKategoriBM.Text + "'\n" +
                                "AND b.nama_barang = '" + cbBarangBM.Text + "' ";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBM()
        {
            date = Convert.ToDateTime(dtBM.Text);
            string dateBK = date.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barangmasuk SET id_kategori = k.id_kategori, id_barang = b.id_barang, jumlah = '" + int.Parse(txtJumlahBM.Text) + "', pic = '" + txtPIC.Text + "' " +
                  "FROM tb_barangmasuk bm " +
                  "INNER JOIN tb_kategori k ON bm.id_kategori = k.id_kategori " +
                  "INNER JOIN tb_barang b ON bm.id_barang = b.id_barang " +
                  "WHERE bm.kode_bm= '" + txtKodeBM.Text + "' " +
                  "AND k.jenis_kategori = '" + cbKategoriBM.Text + "' " +
                  "AND b.nama_barang = '" + cbBarangBM.Text + "'";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbBarang()
        {
            kategori = cbKategoriBM.Text;
            try
            {
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.jenis_kategori = '" + kategori + "'";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "barang");

                DataRow row = ds.Tables["barang"].NewRow();
                row["nama_barang"] = "Pilih Barang";
                ds.Tables["barang"].Rows.InsertAt(row, 0);

                cbBarangBM.DataSource = ds.Tables["barang"];
                cbBarangBM.DisplayMember = "nama_barang";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                row["jenis_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKategoriBM.DataSource = ds.Tables["kategori"];
                cbKategoriBM.DisplayMember = "jenis_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetForm()
        {
            autoID();

            //fr.autoIDRiwayat();
            autoKode();

            cbKategoriBM.Text = "Pilih Kategori";
            txtJumlahBM.Clear();
            txtPIC.Clear();
            cbBarangBM.Text = "Pilih Barang";
            

            date = DateTime.Now;
            dtBM.Text = date.ToString();
        }

        private void btSimpanBM_Click(object sender, EventArgs e)
        {
            simpanBM();
        }

        private void cbKategoriBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBarang();
        }

        private DataTable getDataBM()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT  bm.kode_bm as Kode, bm.tanggal as Tanggal, k.jenis_kategori as Kategori, b.nama_barang as Barang, bm.jumlah as Jumlah, bm.pic as PIC\n" +
                                "FROM tb_barangmasuk bm\n" +
                                "INNER JOIN tb_barang b ON bm.id_barang = b.id_barang\n" +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori\n" +
                                "ORDER BY bm.tanggal DESC";
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

        private void btHapusBM_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM tb_barangmasuk WHERE kode_bm = '" + txtKodeBM.Text + "'";
            var cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            resetForm();
            fillDataBM();


        }

        private void fillDataBM()
        {

            dataBM.DataSource = getDataBM();
        }

        private void btEditBM_Click(object sender, EventArgs e)
        {
            updateBM();
            resetForm();
            fillDataBM();
        }
    }
}
