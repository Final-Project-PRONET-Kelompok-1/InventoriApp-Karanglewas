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
using FontAwesome.Sharp;
using System.Xml;
using System.Windows.Controls.Primitives;

namespace InventoriApp_Karanglewas
{
    public partial class FormKategoriBarang : Form
    {

        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriKaranglewas; Integrated Security=True");

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        


        public FormKategoriBarang()

        {
            InitializeComponent();
            cbKategori();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTambahBarang_Click(object sender, EventArgs e)
        {

        }

        

        private void resetData()
        {
            txtKBarang.Text = "";

        }

        private void cbKBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btTambahKBarang_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_kategori (nama_kategori)\n" +
                                "VALUES ('" + txtKBarang.Text + "')";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kategori berhasil ditambahkan !");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            resetData();
            this.Close();


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

                cbKBarang.DataSource = ds.Tables["kategori"];
                cbKBarang.DisplayMember = "nama_kategori";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormKategoriBarang_Load(object sender, EventArgs e)
        {
           

        }

        private void btTambahBarang_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                string query =  "INSERT INTO tb_barang(id_kategori, nama_barang) " +
                                "SELECT  tb_kategori.id_kategori, '" + txtTambahBarang.Text+ "' "+
                                "FROM tb_kategori "+
                                "WHERE tb_kategori.nama_kategori = '"+ cbKBarang.Text+ "'";


                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                FormDataBarang fdb = new FormDataBarang();
                fdb.fillDataBarang();
                MessageBox.Show("Barang berhasil ditambahkan !");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            resetData();
            
            this.Close();
        }
    }
}
