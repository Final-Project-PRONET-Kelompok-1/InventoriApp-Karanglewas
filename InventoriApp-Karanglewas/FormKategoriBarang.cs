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
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        int autoIdKategori;
        int autoIdBarang;

        int totalBarang = 0;


        public FormKategoriBarang()

        {
            InitializeComponent();
            autoIdK();
            autoIdB();
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
        private void autoIdK()
        {
            string id;
            conn.Open();
            string query = "SELECT id_kategori FROM tb_kategori ORDER BY id_kategori DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();



            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //                string no = reader.GetString(int.Parse(reader[0].ToString()));
                string no = reader["id_kategori"].ToString();
                int str = Convert.ToInt32(no) + 1;
                id = Convert.ToString(str);

            }
            else
            {
                id = "1";
            }
            autoIdKategori = Convert.ToInt32(id);
            //  txtIdAdmin.Text = id;
            conn.Close();
        }

        private void autoIdB()
        {
            string id;
            conn.Open();
            string query = "SELECT id_barang FROM tb_barang ORDER BY id_barang DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();



            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //                string no = reader.GetString(int.Parse(reader[0].ToString()));
                string no = reader["id_barang"].ToString();
                int str = Convert.ToInt32(no) + 1;
                id = Convert.ToString(str);

            }
            else
            {
                id = "1";
            }
            autoIdBarang = Convert.ToInt32(id);
            //  txtIdAdmin.Text = id;
            conn.Close();
        }

        private void cbKBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btTambahKBarang_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_kategori (id_kategori, jenis_kategori)\n" +
                                "VALUES ('" + autoIdKategori + "','" + txtKBarang.Text + "')";
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
                string query = "SELECT * FROM tb_kategori";
                cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "kategori");

                DataRow row = ds.Tables["kategori"].NewRow();
                row["jenis_kategori"] = "Pilih Kategori";
                ds.Tables["kategori"].Rows.InsertAt(row, 0);

                cbKBarang.DataSource = ds.Tables["kategori"];
                cbKBarang.DisplayMember = "jenis_kategori";
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
                string query =  "INSERT INTO tb_barang(id_barang, id_kategori, nama_barang, total)\n" +
                                "SELECT '" + autoIdBarang + "', tb_kategori.id_kategori, '" + txtTambahBarang.Text+ "', '"+totalBarang+"'"+
                                "FROM tb_kategori "+
                                "WHERE tb_kategori.jenis_kategori = '"+ cbKBarang.Text+ "'";


                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
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
