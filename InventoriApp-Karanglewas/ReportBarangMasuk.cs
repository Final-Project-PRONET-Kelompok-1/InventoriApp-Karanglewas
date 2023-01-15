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
    public partial class ReportBarangMasuk : Form
    {
        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        //SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string date1;
        string date2;

        public ReportBarangMasuk()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM viewBarangMasuk WHERE tanggal BETWEEN '" + date1 + "' AND '" + date2 + "'", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            laporanBarangMasuk rptMasuk = new laporanBarangMasuk();
            rptMasuk.SetDataSource(dt);
            crvMasuk.ReportSource = rptMasuk;
            crvMasuk.RefreshReport();

            conn.Close();
        }
    }
}
