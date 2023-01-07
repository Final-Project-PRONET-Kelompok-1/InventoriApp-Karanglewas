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

namespace InventoriApp_Karanglewas
{
    public partial class FormKategoriBarang : Form
    {

        SqlConnection conn = new SqlConnection
               (@"Data Source=.\SQLEXPRESS;Initial Catalog = InventoriApp; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        int autoId;

        public FormKategoriBarang()

        {
            InitializeComponent();
            autoKode();
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
        private void autoKode()
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
            autoId = Convert.ToInt32(id);
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
                                "VALUES ('" + autoId + "','" + txtKBarang.Text + "')";
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

        private void FormKategoriBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoriAppDataSet11.tb_kategori' table. You can move, or remove it, as needed.
            this.tb_kategoriTableAdapter.Fill(this.inventoriAppDataSet11.tb_kategori);

        }

        private void btTambahBarang_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
