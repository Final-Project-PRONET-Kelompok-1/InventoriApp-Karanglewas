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
    public partial class ReportStokOpname : Form
    {

        //SqlConnection conn = new SqlConnection(dbConfig.conn);
       // SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoriKaranglewas; Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string date1;
        string date2;
        public ReportStokOpname()
        {
            InitializeComponent();
        }

        private void ReportDataBarang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
        
            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM viewStokOpname WHERE tanggal BETWEEN '"+date1+"' AND '"+date2+"'", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            laporanStokOpname rptOpname = new laporanStokOpname();
            rptOpname.SetDataSource(dt);
            crvOpname.ReportSource =  rptOpname;
            crvOpname.RefreshReport();

            conn.Close();
        }
    }
}
