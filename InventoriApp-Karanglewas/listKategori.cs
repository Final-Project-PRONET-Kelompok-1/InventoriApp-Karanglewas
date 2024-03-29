﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    public partial class listKategori : Form
    {
        SqlConnection conn = dbConfig.conn; 
        SqlCommand cmd;
        SqlDataReader reader;
        string validasi;
        

        DataTable dataTable = new DataTable();
        public listKategori()
        {
            InitializeComponent();
            autoKode();
            fillDataKategori();
            cekKode();

            dataKategori.ReadOnly = true;
            txtKodeKategori.Enabled = false;
        }

        private string cekInput()
        {
            if (txtNamaKategori.Text == "")
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong!","Peringatan");
                validasi = "gagal";

            } else
            {
                validasi = "oke";
            }

            return validasi;
        }

        private void simpanKategori()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_addKategori";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter kodeKategori = new SqlParameter("@kode_kategori", SqlDbType.VarChar);
                SqlParameter namaKategori = new SqlParameter("@nama_kategori", SqlDbType.VarChar);

                kodeKategori.Value = txtKodeKategori.Text;
                namaKategori.Value = txtNamaKategori.Text;

                cmd.Parameters.Add(kodeKategori);
                cmd.Parameters.Add(namaKategori);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Kategori berhasil ditambahkan","Info");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            resetForm();
            autoKode();
            fillDataKategori();
            cekKode();
        }

        private void updateKategori()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_kategori SET nama_kategori = '" + txtNamaKategori.Text + "' " +
                  "WHERE kode_kategori= '" + txtKodeKategori.Text + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            resetForm();
            autoKode();
            fillDataKategori();
            cekKode();
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_kategori FROM tb_kategori ORDER BY id_kategori DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no = reader["kode_kategori"].ToString();
                no = no.Substring(1, 4);
                int str = Convert.ToInt32(no) + 1;
                kode = "K" + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = "K" + "0001";
            }
            txtKodeKategori.Text = kode;
            conn.Close();
        }

        private string cekKategori()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_kategori WHERE nama_kategori = '" + txtNamaKategori.Text + "' ";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Kategori '" + txtNamaKategori.Text + "' sudah ada!");
                    txtNamaKategori.Focus();

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

        private void btSimpanKategori_Click(object sender, EventArgs e)
        {
            if (cekInput() == "oke" && cekKategori() == "oke")
            {
                simpanKategori();
            }

        }

        private void resetForm()
        {
            txtNamaKategori.Text = "";
            autoKode();
            cekKode();

        }

        private DataTable getDataKategori()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "sp_showKategori";
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

        private void fillDataKategori()
        {

            dataKategori.DataSource = getDataKategori();
        }

        private void dataKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataKategori.Rows[e.RowIndex];
                txtKodeKategori.Text = row.Cells["Kode"].Value.ToString();
                txtNamaKategori.Text = row.Cells["Kategori"].Value.ToString();
            }
            cekKode();
        }

        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_kategori WHERE kode_kategori = '" + txtKodeKategori.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditKategori.Enabled = true;
                    btHapusKategori.Enabled = true;
                    btSimpanKategori.Enabled = false;
                }
                else
                {
                    btEditKategori.Enabled = false;
                    btHapusKategori.Enabled = false;
                    btSimpanKategori.Enabled = true;
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

        private void btResetKategori_Click(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }

        private void btEditKategori_Click(object sender, EventArgs e)
        {
            if (cekInput() == "oke" && cekData() == "oke")
            {
                updateKategori();
                MessageBox.Show("Kategori berhasil diedit", "Info");
            }
        }

        private string cekData()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_kategori WHERE kode_kategori = '" + txtKodeKategori.Text + "'AND nama_kategori = '" + txtNamaKategori.Text + "' ";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tidak ada perubahan data, cek kembali!", "Peringatan");
                    txtNamaKategori.Focus();

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

        private void hapusKategori()
        {
            var tanya = MessageBox.Show("Semua data yang berhubungan dengan kategori '" + txtNamaKategori.Text + "' akan terhapus.\n" +
                "Apakah anda yakin akan menghapusnya ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_delKategori";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter kodeKategori = new SqlParameter("@kode_kategori", SqlDbType.VarChar);

                kodeKategori.Value = txtKodeKategori.Text;
                cmd.Parameters.Add(kodeKategori);
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Kategori berhasil dihaopus","Info");
            }
        }

        private void btHapusKategori_Click(object sender, EventArgs e)
        {
            hapusKategori();
            resetForm();
            fillDataKategori();
            cekKode();
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
                string query = "SELECT  kode_kategori as Kode, nama_kategori as Kategori " +
                                "FROM tb_kategori " +
                                "WHERE kode_kategori LIKE '%"+ txtFilterText.Text + "%' OR nama_kategori LIKE '%"+ txtFilterText.Text +"%' " +
                                "ORDER BY id_kategori ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataKategori.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
            if(txtFilterText.Text == "")
            {
                fillDataKategori();
            }
        }
    }
}
