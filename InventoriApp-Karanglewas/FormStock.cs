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
using System.Windows.Controls.Primitives;

namespace InventoriApp_Karanglewas
{
    public partial class FormStock : Form
    {


      //  SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        string status;
        DateTime date;

        DataTable dataTable = new DataTable();

        FormMaster f1 = new FormMaster();
        public FormStock()
        {
            InitializeComponent();

            cbKategori();
            cekKode();

        }

        private void cekKode()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_stokopname WHERE kode_so = '" + txtKodeSO.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    btEditSO.Enabled = true;
                    btHapusSO.Enabled = true;
                    btSimpanSO.Enabled = false;
                }
                else
                {
                    btEditSO.Enabled = false;
                    btHapusSO.Enabled = false;
                    btSimpanSO.Enabled = true;
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

                DataRow row = ds.Tables["kategori"].NewRow();
                row["nama_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKategoriSO.DataSource = ds.Tables["kategori"];
                cbKategoriSO.DisplayMember = "nama_kategori";
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
                string query = "SELECT * FROM tb_barang INNER JOIN tb_kategori ON tb_kategori.id_kategori = tb_barang.id_kategori WHERE tb_kategori.nama_kategori = '" + kategori + "'";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "barang");

                DataRow row = ds.Tables["barang"].NewRow();
                row["nama_barang"] = "Pilih Barang";
                ds.Tables["barang"].Rows.InsertAt(row, 0);

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
            txtKodeSO.Enabled = false;
            fillDataSO();
            txtStokSistem.Enabled = false;

        }

        private void cbKategoriSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCB();
            cbBarang();
        }

        private void autoKode()
        {
            string kode;
            conn.Open();
            string query = "SELECT kode_so FROM tb_stokopname ORDER BY id_opname DESC";
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
            DateTime dateSO = dtSO.Value;
            setStatus();

            try
            {
                conn.Open();
                string query = "INSERT INTO tb_stokopname (kode_so, id_barang, stok_sistem, stok_fisik, tanggal, pic, status)\n" +
                                "VALUES ('" + txtKodeSO.Text + "'," +
                                "(select id_barang from tb_barang where nama_barang = '" + cbBarangSO.Text + "')," +
                                "'" + txtStokSistem.Text + "','" + txtStokFisik.Text + "','" + dateSO + "','" + txtPIC.Text + "', '" + status + "')";
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
            DateTime dateSO = dtSO.Value;

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_stokopname SET id_barang = (SELECT id_barang FROM tb_barang WHERE nama_barang = '" + cbBarangSO.Text + "'), stok_sistem = '" + txtStokSistem.Text + "'" +
                    ", stok_fisik = '" + txtStokFisik.Text + "', tanggal = '"+dateSO+"', pic = '" + txtPIC.Text + "' " +
                  "WHERE kode_so= '" + txtKodeSO.Text + "' ";
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
            string query = "SELECT total_stok FROM tb_stokbarang sb " +
                "INNER JOIN tb_barang b ON sb.id_barang = b.id_barang " +
                "WHERE b.nama_barang = '" + cbBarangSO.Text + "'";
            conn.Close();
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
            cekKode();
        }

        private void btHapusSO_Click_1(object sender, EventArgs e)
        {
            var tanya = MessageBox.Show("Apakah anda yakin ?", "Hapus", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM tb_stokopname WHERE kode_so = '" + txtKodeSO.Text + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                resetForm();
                fillDataSO();
                cekKode();
            }
        }

        private void btResetSO_Click_1(object sender, EventArgs e)
        {
            resetForm();
            cekKode();
        }

        private void btSimpanSO_Click(object sender, EventArgs e)
        {
            cekInput();
        }

        private void dataSO_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

            cekKode();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStokFisik_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStokFisik.Text, "[^0-9]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan angka.");
                txtStokFisik.Text = txtStokFisik.Text.Remove(txtStokFisik.Text.Length - 1);
            }
        }

        private void txtPIC_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIC.Text, "[^A-z]"))
            {
                MessageBox.Show("Input jumlah hanya bisa dimasukan nama.");
                txtPIC.Clear();
            }
        }
    }
}



