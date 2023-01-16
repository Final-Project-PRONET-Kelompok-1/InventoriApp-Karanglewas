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
    
    public partial class FormLogAdmin1 : Form
    {
        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string date1;
        string date2;
        DateTime date;
        DataTable dataTable = new DataTable();
        public FormLogAdmin1()
        {
            InitializeComponent();
            fillDataRiwayat();

            dataRiwayat.ReadOnly = true;
            cbFilterRiwayat.Text = "Semua Data";
        }
        private DataTable tampilSemua()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT a.username AS Username, l.keterangan AS Keterangan, l.waktu\n" +
                    "FROM tb_log l\n" +
                    "LEFT JOIN tb_admin a ON a.id_admin = l.id_admin\n" +
                    "ORDER BY waktu DESC";
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

        private void fillDataRiwayat()
        {
            dataRiwayat.DataSource = tampilSemua();
        }
        private void resetDTP()
        {
            date = DateTime.Now;
            dateTimePicker2.Text = date.ToString();
            dateTimePicker3.Text = date.ToString();
        }

        private void cbFilterRiwayat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterRiwayat.Text == "Semua Data")
            {
                fillDataRiwayat();
                panelFilterTanggal.Visible = false;
                panelFilterText.Visible = false;

                resetDTP();
                txtFilterRiwayat.Text = "";
            }
            else if (cbFilterRiwayat.Text == "By Tanggal")
            {
                panelFilterTanggal.Visible = true;
                panelFilterText.Visible = false;
                resetDTP();
                txtFilterRiwayat.Text = "";
            }

            else if (cbFilterRiwayat.Text == "By Text")
            {
                panelFilterTanggal.Visible = false;
                panelFilterText.Visible = true;

                resetDTP();
                fillDataRiwayat();
            }
        }
            private void filterByText()
            {
                try
                {

                    dataTable.Reset();
                    dataTable = new DataTable();
                    conn.Open();
                string query = "SELECT a.username AS Username, l.keterangan AS Keterangan, l.waktu AS Tanggal\n" +
                    "FROM tb_log l\n" +
                    "LEFT JOIN tb_admin a ON a.id_admin = l.id_admin\n" +
                    "WHERE a.username LIKE '%" + txtFilterRiwayat.Text + "%' OR l.keterangan LIKE '%" + txtFilterRiwayat.Text + "%' OR l.waktu LIKE '%" + txtFilterRiwayat.Text + "%'\n" +
                    "ORDER BY waktu DESC";
                                    
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    conn.Close();

                    dataRiwayat.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void txtFilterRiwayat_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterRiwayat.Text == "")
            {
                fillDataRiwayat();
            
            }
        }

        private void btCariTextRwt_Click(object sender, EventArgs e)
        {
            filterByText();
        }

        private void btCariTanggal_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            date2 = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
            try
            {

                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT a.username AS Username, l.keterangan AS Keterangan, l.waktu AS Tanggal\n" +
                    "FROM tb_log l\n" +
                    "LEFT JOIN tb_admin a ON a.id_admin = l.id_admin\n" +
                    "WHERE CAST(l.waktu as DATE) BETWEEN '" + date1 + "' AND '" + date2 + "' \n" +
                    "ORDER BY waktu DESC";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataRiwayat.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
    
}
