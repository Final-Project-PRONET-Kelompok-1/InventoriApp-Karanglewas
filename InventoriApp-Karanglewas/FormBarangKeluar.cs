using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace InventoriApp_Karanglewas
{
    public partial class FormBarangKeluar : Form
    {
        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;
        DateTime date;

        string validasi;
        int stoksementara;

        DataTable dataTable = new DataTable();

        FormRiwayat fr = new FormRiwayat();

        FormMaster f1 = new FormMaster();
        public FormBarangKeluar()
        {
            InitializeComponent();
            setCB();
            cbKategori(cbKategoriBK);
            autoKode();
            fillDataBK();

            cekKode();

            txtKodeBK.Enabled = false;
            cbFilter.Text = "Semua Data";
        }
        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_barangkeluar WHERE kode_bk = '" + txtKodeBK.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditBK.Enabled = true;
                    btHapusBK.Enabled = true;
                    btSimpanBK.Enabled = false;
                }
                else
                {
                    btEditBK.Enabled = false;
                    btHapusBK.Enabled = false;
                    btSimpanBK.Enabled = true;
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
            if (cbKategoriBK.Text == "Pilih Kategori")
            {
                cbBarangBK.Text = "Pilih Barang";
                cbBarangBK.Enabled = false;
            }
            else
            {
                cbBarangBK.Enabled = true;
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

                //cbKategoriBK.DataSource = ds.Tables["kategori"];
                //cbKategoriBK.DisplayMember = "nama_kategori";
                cb.DataSource = ds.Tables["kategori"];
                cb.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getStokSistem()
        {
            string query = "SELECT total_stok FROM tb_stokbarang sb " +
                "INNER JOIN tb_barang b ON sb.id_barang = b.id_barang " +
                "WHERE b.nama_barang = '" + cbBarangBK.Text + "'";
            conn.Close();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                stoksementara = int.Parse(rd[0].ToString());
                rd.Close();
            }
            conn.Close();

        }
        private void cbBarang()
        {
            
            try
            {
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.nama_kategori = '" + cbKategoriBK.Text + "'";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "barang");

                DataRow row = ds.Tables["barang"].NewRow();
                row["nama_barang"] = "Pilih Barang";
                ds.Tables["barang"].Rows.InsertAt(row, 0);

                cbBarangBK.DataSource = ds.Tables["barang"];
                cbBarangBK.DisplayMember = "nama_barang";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtJumlahBK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJumlahBK.Text, "[^0-9]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan angka.");
                txtJumlahBK.Clear();
            }
            
        }

        private void btResetBK_Click(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }
        private void resetForm()
        {
            //kodeRandom();
            autoKode();

            cbKategoriBK.Text = "Pilih Kategori";
            txtJumlahBK.Clear();
            txtPIC.Clear();
            cbBarangBK.Text = "Pilih Barang";
            cbBarangBK.Enabled = false;

            date = DateTime.Now;
            dtBK.Text = date.ToString();
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_bk FROM tb_barangkeluar ORDER BY id_barangkeluar DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            date = DateTime.Now;
            string dateBK = date.ToString("yyMMdd");

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                string no = reader["kode_bk"].ToString();
                no = no.Substring(8, 4);
                int str = Convert.ToInt32(no) + 1;
                kode = "BK" + dateBK + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = "BK" + dateBK + "0001";
            }
            txtKodeBK.Text = kode;
            conn.Close();
        }



        private void cbKategoriBK_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCB();
            cbBarang();
        }
        private string cekValidasi()
        {
            if (cbKategoriBK.Text == "Pilih Kategori")
            {
                MessageBox.Show("Anda belum memilih kategori!");
                cbKategoriBK.Focus();
                validasi = "gagal";
            }
            else if (cbBarangBK.Text == "Pilih Barang")
            {
                MessageBox.Show("Anda belum memilih barang!");
                cbBarangBK.Focus();
                validasi = "gagal";
            }
            else if (txtJumlahBK.Text == "" | txtJumlahBK.Text == "0")
            {
                MessageBox.Show("Jumlah tidak boleh kosong!");
                txtJumlahBK.Focus();
                validasi = "gagal";
            }
            else if (txtPIC.Text == "")
            {
                MessageBox.Show("PIC tidak boleh kosong!");
                txtPIC.Focus();
                validasi = "gagal";
            }
            else if (int.Parse(txtJumlahBK.Text.Trim()) > stoksementara)
            {
                MessageBox.Show("Jumlah melebihi stok tersedia!\nStok tersedia '" + stoksementara.ToString() + "'");
                txtJumlahBK.Focus();
                validasi = "gagal";
            }
            else
            {
                validasi = "oke";
            }
            return validasi;
        }
        private void simpanRiwayat(string status)
        {
            string aktifitas = "Barang Keluar";
            string keterangan = status;
            string username = f1.getAdmin();
            date = DateTime.Now;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_riwayat (tanggal, aktifitas, id_barang, jumlah, keterangan, id_admin)\n" +
                                "SELECT '" + date + "', '" + aktifitas + "', b.id_barang, '" + txtJumlahBK.Text + "', '" + keterangan + "', a.id_admin\n" +
                                "FROM tb_barang b, tb_kategori k, tb_admin a\n" +
                                "WHERE k.nama_kategori = '" + cbKategoriBK.Text + "'\n" +
                                "AND b.nama_barang = '" + cbBarangBK.Text + "'" +
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
        private void simpanBK()
        {
            DateTime dateBK = dtBK.Value;

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_barangkeluar (kode_bk, id_barang, jumlah, tanggal, pic)\n" +
                                "SELECT  '" + txtKodeBK.Text + "', b.id_barang, '" + txtJumlahBK.Text + "','" + dateBK + "','" + txtPIC.Text + "'" +
                                "FROM tb_barang b " +
                                "WHERE b.nama_barang = '" + cbBarangBK.Text + "' ";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataBK.FirstDisplayedScrollingRowIndex = dataBK.RowCount - 1;
        }

        private void btSimpanBK_Click(object sender, EventArgs e)
        {
            if(cekValidasi() == "oke")
            {
                simpanBK();
                simpanRiwayat("Simpan");
                resetForm();
                MessageBox.Show("Data berhasil disimpan");
                fillDataBK();
            }

        }
        private DataTable getDataBM()
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
        private void fillDataBK()
        {

            dataBK.DataSource = getDataBM();
        }

        private void txtPIC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIC.Text, "[^A-Za-z'\\s]"))
            {
                MessageBox.Show("Input PIC hanya bisa dimasukan nama.");
                txtPIC.Clear();
            }
        }

        private void btHapusBK_Click(object sender, EventArgs e)
        {
            var tanya = MessageBox.Show("Apakah anda yakin \n" +
                "akan menghapus data dengan kode = "+txtKodeBK.Text+" ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM tb_barangkeluar WHERE kode_bk = '" + txtKodeBK.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                conn.Close();
                simpanRiwayat("Hapus");
                resetForm();
                fillDataBK();
                cekKode();
            }
        }

        private void FormBarangKeluar_Load(object sender, EventArgs e)
        {
            cbBarangBK.Enabled = false;
        }

        private void dataBK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataBK.Rows[e.RowIndex];
                txtKodeBK.Text = row.Cells["Kode"].Value.ToString();
                cbKategoriBK.Text = row.Cells["Kategori"].Value.ToString();
                cbBarangBK.Text = row.Cells["Barang"].Value.ToString();
                txtJumlahBK.Text = row.Cells["Jumlah"].Value.ToString();
                dtBK.Value = (DateTime)row.Cells["Tanggal"].Value;
                txtPIC.Text = row.Cells["PIC"].Value.ToString();
            }
            cekKode();
        }

        private void updateBK()
        {
            DateTime dateBK = dtBK.Value;

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_barangkeluar SET id_barang = (SELECT id_barang FROM tb_barang WHERE nama_barang = '" + cbBarangBK.Text + "'), tanggal='" + dateBK + "', jumlah = '" + int.Parse(txtJumlahBK.Text) + "', pic = '" + txtPIC.Text + "' " +
                  "WHERE kode_bk= '" + txtKodeBK.Text + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btEditBK_Click(object sender, EventArgs e)
        {
            if (cekValidasi() == "oke")
            {
                updateBK();
                simpanRiwayat("Edit");
                resetForm();
                MessageBox.Show("Data berhasil diedit");
                fillDataBK();
                cekKode();
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbBarangBK_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStokSistem();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Semua Data")
            {
                fillDataBK();
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

                fillDataBK();
                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Kategori")
            {
                panelFilterKategori.Visible = true;
                panelFilterTanggal.Visible = false;
                panelFilterText.Visible = false;

                resetDTP();
                cbKategori(cbFilterKategori);
                fillDataBK();
                txtFilterBarang.Text = "";
            }
            else if (cbFilter.Text == "By Text")
            {
                panelFilterTanggal.Visible = false;
                panelFilterKategori.Visible = false;
                panelFilterText.Visible = true;

                resetDTP();
                fillDataBK();
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
                string query = "SELECT bk.kode_bk as Kode, bk.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bk.jumlah as Jumlah, bk.pic as PIC " +
                                "FROM tb_barangkeluar bk " +
                                "INNER JOIN tb_barang b ON bk.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori = k.id_kategori " +
                                "WHERE (bk.kode_bk LIKE '%" + txtFilterBarang.Text + "%' OR k.nama_kategori LIKE '%" + txtFilterBarang.Text + "%' OR b.nama_barang LIKE '%" + txtFilterBarang.Text + "%' OR bk.jumlah LIKE '%" + txtFilterBarang.Text + "%' OR bk.pic LIKE '%" + txtFilterBarang.Text + "%') " +
                                "ORDER BY bk.tanggal DESC ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataBK.DataSource = dataTable;

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
                    fillDataBK();
                }
                else
                {
                    dataTable.Reset();
                    dataTable = new DataTable();
                    conn.Open();
                    string query = "SELECT  bk.kode_bk as Kode, bk.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bk.jumlah as Jumlah, bk.pic as PIC " +
                                    "FROM tb_barangkeluar bk " +
                                    "INNER JOIN tb_barang b ON bk.id_barang = b.id_barang " +
                                    "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                    "WHERE k.nama_kategori = '" + cbFilterKategori.Text + "' " +
                                    "ORDER BY bk.tanggal DESC ";
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    conn.Close();

                    dataBK.DataSource = dataTable;
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
                string query = "SELECT  bk.kode_bk as Kode, bk.tanggal as Tanggal, k.nama_kategori as Kategori, b.nama_barang as Barang, bk.jumlah as Jumlah, bk.pic as PIC " +
                                "FROM tb_barangkeluar bk " +
                                "INNER JOIN tb_barang b ON bk.id_barang = b.id_barang " +
                                "INNER JOIN tb_kategori k ON b.id_kategori  = k.id_kategori " +
                                "WHERE CAST(bk.tanggal as DATE) BETWEEN '" + date1 + "' AND '" + date2 + "' " +
                                "ORDER BY bk.tanggal DESC ";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataBK.DataSource = dataTable;

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

        private void btCariText_Click(object sender, EventArgs e)
        {
            filterByText();
        }

        private void txtFilterBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBarang.Text == "")
            {
                fillDataBK();
            }
        }

        private void cbFilterKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conn.Close();
            filterByKategori();
        }
    }
}
