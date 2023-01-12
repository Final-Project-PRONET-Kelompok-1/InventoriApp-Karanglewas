using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    public partial class FormLaporan : Form
    {

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True");
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBarangKeluar_Click(object sender, EventArgs e)
        {
            FormLaporanBarangKeluar report = new FormLaporanBarangKeluar();
            report.ShowDialog();

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void btnBarangMasuk_Click(object sender, EventArgs e)
        {
            FormLaporanBarangMasuk report2 = new FormLaporanBarangMasuk();
            report2.ShowDialog();

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            FormLaporanDataBarang report3 = new FormLaporanDataBarang();
            report3.ShowDialog();

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
