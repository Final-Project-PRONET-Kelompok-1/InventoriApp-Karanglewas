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
        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori,validasi;
        DateTime date;

        DataTable dataTable = new DataTable();
        
        FormRiwayat fr = new FormRiwayat();
        
        FormMaster f1 = new FormMaster();
        public FormBarangMasuk()
        {
            InitializeComponent();
            setCB();
            cbKategori(cbKategoriBM);
            autoKode();
            fillDataBM();
            cekKode();

            dataBM.ReadOnly = true;
            txtKodeBM.Enabled = false;
            cbFilter.Text = "Semua Data";
        }

        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_barangmasuk WHERE kode_bm = '" + txtKodeBM.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditBM.Enabled = true;
                    btHapusBM.Enabled = true;
                    btSimpanBM.Enabled = false;
                }
                else
                {
                    btEditBM.Enabled = false;
                    btHapusBM.Enabled = false;
                    btSimpanBM.Enabled = true;
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

        private void setCB()
        {
            if (cbKategoriBM.Text == "Pilih Kategori")
            {
                cbBarangBM.Text = "Pilih Barang";
                cbBarangBM.Enabled = false;
            }
            else
            {
                cbBarangBM.Enabled = true;
            }
        }

        private void FormBarangMasuk_Load(object sender, EventArgs e)
        {
            setCB();
        }

        private void txtKodeBM_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataBM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataBM.Rows[e.RowIndex];
                txtKodeBM.Text = row.Cells["Kode"].Value.ToString();
                cbKategoriBM.Text = row.Cells["Kategori"].Value.ToString();
                cbBarangBM.Text = row.Cells["Barang"].Value.ToString();
                txtJumlahBM.Text = row.Cells["Jumlah"].Value.ToString();
                dtBM.Value = (DateTime)row.Cells["Tanggal"].Value;
                txtPIC.Text = row.Cells["PIC"].Value.ToString();
            }

            cekKode();
         
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_bm FROM tb_barangmasuk ORDER BY id_barangmasuk DESC";
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
        private void simpanRiwayat(string status)
        {
            string aktifitas = "Barang Masuk";
            string keterangan = status;
            string username = f1.getAdmin();
            date = DateTime.Now;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_riwayat (tanggal, aktifitas, id_barang, jumlah, keterangan, id_admin)\n" +
                                "SELECT '" + date + "', '" + aktifitas + "', b.id_barang, '" + txtJumlahBM.Text + "', '" + keterangan + "', a.id_admin\n" +
                                "FROM tb_barang b, tb_admin a " +
                                "WHERE b.nama_barang = '" + cbBarangBM.Text + "'" +
                                "AND a.username = '" + username + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void simpanBM()
        {
            date = Convert.ToDateTime(dtBM.Text);
            DateTime dateBK = dtBM.Value;
            string PIC = txtPIC.Text;
            PIC = PIC.Replace("'", "''");

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barangmasuk (kode_bm, id_barang, jumlah, tanggal, pic)\n" +
                                "SELECT '" + txtKodeBM.Text + "', b.id_barang, '" + txtJumlahBM.Text + "','" + dateBK + "','" + PIC + "'" +
                                "FROM tb_barang b " +
                                "WHERE b.nama_barang = '" + cbBarangBM.Text + "' ";
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
            DateTime dateBK = dtBM.Value;
            string PIC = txtPIC.Text;
            PIC = PIC.Replace("'", "''");

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barangmasuk SET id_barang = (SELECT id_barang FROM tb_barang WHERE nama_barang = '" + cbBarangBM.Text + "'), tanggal='" + dateBK + "', jumlah = '" + int.Parse(txtJumlahBM.Text) + "', pic = '" + PIC + "' " +
                  "WHERE kode_bm= '" + txtKodeBM.Text + "' ";
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
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.nama_kategori = '" + kategori + "'";
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

        private void cbKategori(ComboBox cb)
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

                cb.DataSource = ds.Tables["kategori"];
                cb.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetForm()
        {
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
            if (cekValidasi() == "oke")
            {
                simpanBM();
                simpanRiwayat("Simpan");
                resetForm();
                MessageBox.Show("Data berhasil disimpan");
                fillDataBM();
            }
        }

        private void cbKategoriBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCB();
            cbBarang();
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

        private void btHapusBM_Click(object sender, EventArgs e)
        {
            var tanya = MessageBox.Show("Apakah anda yakin \n" +
                "akan menghapus data dengan kode = " + txtKodeBM.Text + " ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM tb_barangmasuk WHERE kode_bm = '" + txtKodeBM.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                conn.Close();
                simpanRiwayat("Hapus");
                resetForm();
                fillDataBM();
                cekKode();
            }

        }

        private string cekValidasi()
        {
            if (cbKategoriBM.Text == "Pilih Kategori")
            {
                MessageBox.Show("Anda belum memilih kategori!");
                cbKategoriBM.Focus();
                validasi = "gagal";
            }
            else if (cbBarangBM.Text == "Pilih Barang")
            {
                MessageBox.Show("Anda belum memilih barang!");
                cbBarangBM.Focus();
                validasi = "gagal";
            }
            else if (txtJumlahBM.Text == "" | txtJumlahBM.Text == "0")
            {
                MessageBox.Show("Jumlah tidak boleh kosong!");
                txtJumlahBM.Focus();
                validasi = "gagal";
            }
            else if (txtPIC.Text == "")
            {
                MessageBox.Show("PIC tidak boleh kosong!");
                txtPIC.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }
            return validasi; 
        }

        private void fillDataBM()
        {

            dataBM.DataSource = getDataBM();
        }

        private void btEditBM_Click(object sender, EventArgs e)
        {
            if (cekValidasi() == "oke")
            {
                updateBM();
                simpanRiwayat("Edit");
                resetForm();
                MessageBox.Show("Data berhasil diedit");
                fillDataBM();
                cekKode();
            }
        }

        private void txtPIC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIC.Text, "[^A-Za-z'\\s]"))
            {
                MessageBox.Show("Input PIC hanya bisa dimasukan nama.");
                txtPIC.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btResetBM_Click(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Semua Data")
            {
                fillDataBM();
                panelFilterTanggal.Visible = false;
                panelFilterKategori.Visible = false;
                panelFilterText.Visible = false;

                resetDTP();
                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Tanggal")
            {
                panelFilterTanggal.Visible = true;
                panelFilterKategori.Visible = false;
                panelFilterText.Visible = false;

                fillDataBM();
                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Kategori")
            {
                panelFilterKategori.Visible = true;
                panelFilterTanggal.Visible = false;
                panelFilterText.Visible = false;

                resetDTP();
                cbKategori(cbFilterKategori);
                fillDataBM();
                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Text")
            {
                panelFilterTanggal.Visible = false;
                panelFilterKategori.Visible = false;
                panelFilterText.Visible = true;

                resetDTP();
                fillDataBM();
            }
        }

        private void resetDTP()
        {
            date = DateTime.Now;
            dateTimePicker1.Text = date.ToString();
            dateTimePicker2.Text = date.ToString();
        }

        private void filterByText()
        {
            try
            {

                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT bm.kode_bm as Kode, bm.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bm.jumlah as Jumlah, bm.pic as PIC " +
                                "FROM tb_barangmasuk bm " +
                                "INNER JOIN tb_barang b ON bm.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                                "WHERE (bm.kode_bm LIKE '%" + txtFilterBarang.Text + "%' OR k.nama_kategori LIKE '%" + txtFilterBarang.Text + "%' OR b.nama_barang LIKE '%" + txtFilterBarang.Text + "%' OR bm.jumlah LIKE '%" + txtFilterBarang.Text + "%' OR bm.pic LIKE '%" + txtFilterBarang.Text + "%') " +
                                "ORDER BY bm.tanggal DESC ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataBM.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterByKategori()
        {
            
            try
            {
                if (cbFilterKategori.Text == "Semua Kategori")
                {
                    fillDataBM();
                }
                else
                {
                    dataTable.Reset();
                    dataTable = new DataTable();
                    conn.Open();
                    string query = "SELECT  bm.kode_bm as Kode, bm.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bm.jumlah as Jumlah, bm.pic as PIC " +
                                    "FROM tb_barangmasuk bm " +
                                    "INNER JOIN tb_barang b ON bm.id_barang = b.id_barang " +
                                    "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                    "WHERE k.nama_kategori = '" + cbFilterKategori.Text + "' " +
                                    "ORDER BY bm.tanggal DESC ";
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    conn.Close();

                    dataBM.DataSource = dataTable;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterByTanggal()
        {
            try
            {
                string date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                string date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT  bm.kode_bm as Kode, bm.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bm.jumlah as Jumlah, bm.pic as PIC " +
                                "FROM tb_barangmasuk bm " +
                                "INNER JOIN tb_barang b ON bm.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "WHERE CAST(bm.tanggal as DATE) BETWEEN '" + date1 + "' AND '" + date2 + "' " +
                                "ORDER BY bm.tanggal DESC ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataBM.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCariTanggal_Click(object sender, EventArgs e)
        {
            filterByTanggal();
        }

        private void cbFilterKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            filterByKategori();
        }

        private void btCariText_Click(object sender, EventArgs e)
        {
            filterByText();
        }

        private void txtFilterBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBarang.Text == "")
            {
                fillDataBM();
            }
        }

        private void panelFilterText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFilterKategori_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFilterTanggal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtJumlahBM_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJumlahBM.Text, "[^0-9]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan angka.");
                txtJumlahBM.Clear();
            }
        }
    }
}
