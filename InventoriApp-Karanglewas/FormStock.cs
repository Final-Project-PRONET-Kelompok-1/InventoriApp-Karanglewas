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
using System.Windows.Media;
using System.Net.NetworkInformation;
using System.Reflection;

namespace InventoriApp_Karanglewas
{
    public partial class FormStock : Form
    {


        //SqlConnection conn = new SqlConnection
        //(@"Data Source=(local);Initial Catalog = InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        string status;
        int autoId;
        DateTime date;

        DataTable dataTable = new DataTable();

        FormMaster f1 = new FormMaster();
        public FormStock()
        {
            InitializeComponent();

            cbKategori();

        }
        private void setCB()
        {
            if (cbKategoriSO.Text == "Pilih Kategori")
            {
                cbBarangSO.Text = "Pilih Barang";
                cbBarangSO.Enabled = false;
            }
            else
            {
                cbBarangSO.Enabled = true;
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
                cbKategoriSO.DataSource = ds.Tables["kategori"];
                cbKategoriSO.DisplayMember = "jenis_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbBarang()
        {
            kategori = cbKategoriSO.Text;
            try
            {
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.jenis_kategori = '" + kategori + "'";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "barang");
                cbBarangSO.DataSource = ds.Tables["barang"];
                cbBarangSO.DisplayMember = "nama_barang";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void FormStock_Load(object sender, EventArgs e)
        {
            cbKategoriSO.Text = "Pilih Kategori";
            setCB();
            autoKode();
            autoID();
            txtKodeSO.Enabled = false;
            fillDataSO();

        }

        private void cbKategoriSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCB();
            cbBarangSO.Text = "Pilih Barang";
            cbBarang();
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_so FROM tb_opname ORDER BY id_opname DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            date = DateTime.Now;
            string dateBM = date.ToString("yyMMdd");



            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //                string no = reader.GetString(int.Parse(reader[0].ToString()));
                string no = reader["kode_so"].ToString();

                no = no.Substring(8, 4);
                int str = Convert.ToInt32(no) + 1;
                kode = "SO" + dateBM + Convert.ToString(str).PadLeft(no.Length, '0');

            }
            else
            {
                kode = "SO" + dateBM + "0001";
            }
            txtKodeSO.Text = kode;
            conn.Close();
        }

        private void autoID()
        {
            int id;
            conn.Open();
            string query = "SELECT * FROM tb_opname ORDER BY id_opname DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //                string no = reader.GetString(int.Parse(reader[0].ToString()));

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

        private DataTable getDataSO()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT so.kode_so as Kode, so.tanggal as Tanggal, k.jenis_kategori as Kategori, b.nama_barang as Barang, so.st_sistem as StokSistem, so.st_fisik as StokFisik, so.pic as PIC, so.status as Status\n" +
                                "FROM tb_opname so\n" +
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

        private void fillDataSO()
        {
            dataSO.DataSource = getDataSO();
        }

        private void cekInput()
        {
            if (cbKategoriSO.Text == "Pilih Kategori")
            {
                MessageBox.Show("Anda belum memilih kategori!");
                cbKategoriSO.Focus();
            }
            else if (cbBarangSO.Text == "Pilih Barang")
            {
                MessageBox.Show("Anda belum memilih barang!");
                cbBarangSO.Focus();
            }
            else if (txtStokSistem.Text == "" | txtStokSistem.Text == "0")
            {
                MessageBox.Show("Jumlah tidak boleh kosong!");
                txtStokSistem.Focus();
            }
            else if (txtStokFisik.Text == "" | txtStokFisik.Text == "0")
            {
                MessageBox.Show("Jumlah tidak boleh kosong!");
                txtStokFisik.Focus();
            }
            else if (txtPIC.Text == "")
            {
                MessageBox.Show("PIC tidak boleh kosong!");
                txtPIC.Focus();
            }
            else
            {
                simpanSO();
                //simpanRiwayat();
                resetForm();
                fillDataSO();
            }
        }
        private void simpanSO()
        {
            date = Convert.ToDateTime(dtSO.Text);
            string dateBM = date.ToString("yyyy-MM-dd");
            setStatus();

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_opname (id_opname, kode_so, id_kategori, id_barang, st_sistem, st_fisik, tanggal, pic, status)\n" +
                                "VALUES ('" + autoId + "','" + txtKodeSO.Text + "'," +
                                "(select id_kategori from tb_kategori where jenis_kategori = '" + cbKategoriSO.Text + "')," +
                                "(select id_barang from tb_barang where nama_barang = '" + cbBarangSO.Text + "')," +
                                "'" + txtStokSistem.Text + "','" + txtStokFisik.Text + "','" + dateBM + "','" + txtPIC.Text + "', '" + status + "')";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataSO.FirstDisplayedScrollingRowIndex = dataSO.RowCount - 1;
        }

        private void UpdateSO()
        {
            date = Convert.ToDateTime(dtSO.Text);
            string dateBK = date.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_opname SET id_kategori = k.id_kategori, id_barang = b.id_barang, st_sistem = '" + txtStokSistem.Text + "'" +
                    ", st_fisik = '" + txtStokFisik.Text + "', pic = '" + txtPIC.Text + "' " +
                  "FROM tb_opname so " +
                  "INNER JOIN tb_kategori k ON so.id_kategori = k.id_kategori " +
                  "INNER JOIN tb_barang b ON so.id_barang = b.id_barang " +
                  "WHERE so.kode_so= '" + txtKodeSO.Text + "' " +
                  "AND k.jenis_kategori = '" + cbKategoriSO.Text + "' " +
                  "AND b.nama_barang = '" + cbBarangSO.Text + "'";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
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
            //kodeRandom();
            autoKode();

            cbKategoriSO.Text = "Pilih Kategori";
            txtStokSistem.Clear();
            txtStokFisik.Clear();
            txtPIC.Clear();
            cbBarangSO.Text = "Pilih Barang";
            cbBarangSO.Enabled = false;

            date = DateTime.Now;
            dtSO.Text = date.ToString();
        }

        private void getStokSistem()
        {
            string query = "SELECT (bm.jumlah - bk.jumlah) as stoksistem FROM tb_opname so " +
                "INNER JOIN tb_barang b ON so.id_barang = b.id_barang " +
                "INNER JOIN tb_barangmasuk bm ON b.id_barang = bm.id_barang " +
                "INNER JOIN tb_barangkeluar bk ON b.id_barang = bk.id_barang " +
                "WHERE b.nama_barang='" + cbBarangSO.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtStokSistem.Text = rd[0].ToString();
                rd.Close();
            }
            conn.Close();

        }

        private void cbBarangSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStokSistem();
        }

        private void dataSO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataSO.Rows[e.RowIndex];
                txtPIC.Text = row.Cells["PIC"].Value.ToString();
                txtStokFisik.Text = row.Cells["StokFisik"].Value.ToString();
                txtStokSistem.Text = row.Cells["StokSistem"].Value.ToString();
                cbBarangSO.Text = row.Cells["Barang"].Value.ToString();
                cbKategoriSO.Text = row.Cells["Kategori"].Value.ToString();
                txtKodeSO.Text = row.Cells["Kode"].Value.ToString();
                dtSO.Text = row.Cells["Tanggal"].Value.ToString();
            }
        }

        private void setStatus()
        {
            if (txtStokSistem.Text == txtStokFisik.Text)
            {
                status = "OK";
            }
            else
            {
                status = "Selisih";
            }
        }

        private void btEditSO_Click_1(object sender, EventArgs e)
        {
            UpdateSO();
            resetForm();
            fillDataSO();
        }

        private void btHapusSO_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataSO.SelectedRows)
            {
                conn.Open();
                string query = "DELETE FROM tb_opname WHERE kode_so = '" + dataSO.SelectedRows[0].Cells[0].Value + "'";
                var cmd = new SqlCommand(query, conn);
                dataSO.Rows.RemoveAt(this.dataSO.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btResetSO_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btSimpanSO_Click(object sender, EventArgs e)
        {
            cekInput();
        }
    }
}



