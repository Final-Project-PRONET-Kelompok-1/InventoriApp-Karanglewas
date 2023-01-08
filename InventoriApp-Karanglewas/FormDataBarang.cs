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

namespace InventoriApp_Karanglewas
{
    public partial class FormDataBarang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KDEI2T;Initial Catalog=InventoriApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
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
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "data_barang");
            dgvDB.DataSource = ds;
            dgvDB.DataMember = "data_barang";
            dgvDB.ReadOnly = true;
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            show();   
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
        }
    }
}
