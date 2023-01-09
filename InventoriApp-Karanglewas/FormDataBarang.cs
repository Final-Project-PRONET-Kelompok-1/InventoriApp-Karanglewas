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
using System.Windows.Controls.Primitives;

namespace InventoriApp_Karanglewas
{
    public partial class FormDataBarang : Form
    {
        SqlConnection conn = new SqlConnection(dbConfig.conn); 
        SqlCommand cmd;
        SqlDataReader reader;

        DataTable dataTable = new DataTable();
        public FormDataBarang()
        {
            InitializeComponent();
        }
        private void show()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from data_barang";
            //cmd.CommandText = "select * from data_coba";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "data_barang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "data_barang";
            dgvDB.ReadOnly = true;
        }

        private void cbKategoridb()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from data_barang where Kategori like '%" + cbKategoriBM.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "data_barang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "data_barang";
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            show();
            //fillDataBarang();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {

            FormKategoriBarang FM = new FormKategoriBarang(); // Instantiate a Form3 object.
          //  this.Hide();
            FM.ShowDialog(); // Show Form3 and
           // this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbKategoriBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKategoridb();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from data_barang where Barang like '%" + txtDB.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "data_barang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "data_barang";
        }

        private void btnrefres_Click(object sender, EventArgs e)
        {
            show();
            //fillDataBarang();
        }
    }
}
