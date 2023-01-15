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
    public partial class ReportBarangKeluar : Form
    {
        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string date1;
        string date2;

        public ReportBarangKeluar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM viewBarangKeluar WHERE CAST(viewBarangKeluar.Tanggal as DATE) BETWEEN '" + date1 + "' AND '" + date2 + "'", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            laporanBarangKeluar rptKeluar = new laporanBarangKeluar();
            rptKeluar.SetDataSource(dt);
            crvKeluar.ReportSource = rptKeluar;
            crvKeluar.RefreshReport();

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
