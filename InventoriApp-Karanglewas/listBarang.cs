﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{

    public partial class listBarang : Form
    {
        SqlConnection conn = dbConfig.conn; 
        SqlCommand cmd;
        SqlDataReader reader;
        string getKategori, kode, validasi;
        
        int id_barang,id_kategori;

        DataTable dataTable = new DataTable();
        public listBarang()
        {
            InitializeComponent();
            cbKategori();
            fillDataBarang();
            cekKode();

            dataBarang.ReadOnly = true;
            txtKodeBarang.Enabled = false;
            txtKodeBarang.Text = "";

        }

        private void cbKategori()
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
                row["nama_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKategoriBarang.DataSource = ds.Tables["kategori"];
                cbKategoriBarang.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getidKategori()
        {
            string query = "SELECT id_kategori FROM tb_kategori where nama_kategori = '"+cbKategoriBarang.Text+"' ";
            conn.Close();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                id_kategori = int.Parse(rd[0].ToString());
                rd.Close();
            }
            conn.Close();

        }

        private void autoKode()
        {

            conn.Open();
            string query = "SELECT kode_barang FROM tb_barang b " +
                            "INNER JOIN tb_kategori k ON k.id_kategori = b.id_kategori " +
                            "WHERE k.nama_kategori = '" + getKategori + "' " +
                            "ORDER BY id_barang DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no = reader["kode_barang"].ToString();
                no = no.Substring(no.Length - 4);
                int str = Convert.ToInt32(no) + 1;
                kode = getKategori + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = getKategori + "0001";
            }
            txtKodeBarang.Text = kode;
            conn.Close();
        }

        private string cekNamaBarang()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_barang WHERE nama_barang = '" + txtNamaBarang.Text + "' ";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Barang '" + txtNamaBarang.Text + "' sudah ada!");
                    txtNamaBarang.Focus();

                    validasi = "gagal";
                }
                else
                {
                    validasi = "oke";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return validasi;
        }

        private void btSimpanBarang_Click(object sender, EventArgs e)
        {
            if (cekInput() == "oke" && cekNamaBarang() == "oke" )
            {
                simpanBarang();
            }
        }

        private void simpanBarang()
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_addBarang";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter kodeBarang = new SqlParameter("@kode_barang", SqlDbType.VarChar);
                SqlParameter namaKategori = new SqlParameter("@nama_kategori", SqlDbType.VarChar);
                SqlParameter namaBarang = new SqlParameter("@nama_barang", SqlDbType.VarChar);

                kodeBarang.Value = txtKodeBarang.Text;
                namaKategori.Value = cbKategoriBarang.Text;
                namaBarang.Value = txtNamaBarang.Text;

                cmd.Parameters.Add(kodeBarang);
                cmd.Parameters.Add(namaKategori);
                cmd.Parameters.Add(namaBarang);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Barang berhasil ditambahkan", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            autoKode();
            fillDataBarang();
            resetForm();
            cekKode();
        }


        private DataTable getDataBarang()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "sp_showBarang";
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

            dataBarang.DataSource = getDataBarang();
            dataBarang.Columns["id_barang"].Visible = false;
            dataBarang.Columns["id_kategori"].Visible = false;
        }

        private void resetForm()
        {
            txtNamaBarang.Text = "";
            cbKategori();
            txtKodeBarang.Text = "";
            id_barang = 0;
            cekKode();

        }

        private void btEditBarang_Click(object sender, EventArgs e)
        {
            if (cekInput() == "oke" && cekData() == "oke")
            {
                updateBarang();

                MessageBox.Show("Barang berhasil diedit","Info");
            }
        }

        private string cekData()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) " +
                    "FROM tb_barang " +
                    "WHERE id_kategori = (SELECT id_kategori FROM tb_kategori WHERE nama_kategori = '" + cbKategoriBarang.Text + "') " +
                    "AND nama_barang = '" + txtNamaBarang.Text + "'";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tidak ada perubahan data, cek kembali!","Peringatan");
                    txtNamaBarang.Focus();

                    validasi = "gagal";
                }
                else
                {
                    validasi = "oke";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return validasi;
        }

        private void updateBarang()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barang SET  " +
                    "kode_barang = '"+txtKodeBarang.Text+"', "+
                    "id_kategori = '" + id_kategori + "', " +
                    "nama_barang = '" + txtNamaBarang.Text + "' " +
                  "WHERE id_barang = '" + id_barang + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            autoKode();
            fillDataBarang();
            resetForm();
            cekKode();
        }

        private void dataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataBarang.Rows[e.RowIndex];
                id_barang = int.Parse(row.Cells["id_barang"].Value.ToString());
                cbKategoriBarang.Text = row.Cells["Kategori"].Value.ToString();
                txtNamaBarang.Text = row.Cells["Barang"].Value.ToString();
                txtKodeBarang.Text = row.Cells["Kode"].Value.ToString();
            }
            cekKode();
        }

        private void btResetBarang_Click(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }

        private void hapusBarang()
        {
            var tanya = MessageBox.Show("Semua data yang berhubungan dengan barang '" + txtNamaBarang.Text + "' akan terhapus.\n" +
                "Apakah anda yakin akan menghapusnya ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_delBarang";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter kodeBarang = new SqlParameter("@kode_barang", SqlDbType.VarChar);

                kodeBarang.Value = txtKodeBarang.Text;
                cmd.Parameters.Add(kodeBarang);
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Barang berhasil dihapus","Info");
            }
        }

        private void btHapusBarang_Click(object sender, EventArgs e)
        {
            hapusBarang();
            resetForm();
            fillDataBarang();
            cekKode();
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
            if(txtFilterText.Text == "")
            {
                fillDataBarang();
            }
        }

        private void btCari_Click(object sender, EventArgs e)
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
                string query = "SELECT b.kode_barang as Kode, k.nama_kategori as Kategori, b.nama_barang as Barang " +
                                "FROM tb_barang b " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "WHERE (b.kode_barang LIKE '%"+txtFilterText.Text+"%' OR b.nama_barang LIKE '%" + txtFilterText.Text +"%' OR k.nama_kategori LIKE '%"+ txtFilterText.Text +"%') " +
                                "ORDER BY b.id_kategori ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataBarang.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_barang WHERE id_barang = '" + id_barang + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditBarang.Enabled = true;
                    btSimpanBarang.Enabled = false;
                    btHapusBarang.Enabled = true;
                }
                else
                {
                    btEditBarang.Enabled = false;
                    btHapusBarang.Enabled = false;
                    btSimpanBarang.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private string cekInput()
        {
            if (cbKategoriBarang.Text == "Pilih Kategori")
            {
                MessageBox.Show("Pilih kategori dulu!","Peringatan");
                cbKategoriBarang.Focus();
                validasi = "gagal";

            }
            else if (txtNamaBarang.Text == "")
            {
                MessageBox.Show("Nama Barang tidak boleh kosong!", "Peringatan");
                txtNamaBarang.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }

            return validasi;
        }

        private void cbKategoriBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            getidKategori();
            getKategori = cbKategoriBarang.Text;

            if(getKategori == "Pilih Kategori")
            {
                txtKodeBarang.Text = "";
            }
            else
            {
                autoKode();

            }

            cekKode();


        }
    }
}
