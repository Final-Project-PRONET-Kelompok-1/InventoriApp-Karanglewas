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
    public partial class FormRiwayatAdmin1 : Form
    {
        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string date1;
        string date2;
        DateTime date;
        DataTable dataTable = new DataTable();

        public FormRiwayatAdmin1()
        {
            InitializeComponent();
            fillDataRiwayatadmin();

            cbFilterRiwayatadmin.Text = "Semua Data";
        }
        private DataTable tampilSemua()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT ra.username AS Username, ra.keterangan AS Keterangan,  ra.tanggal AS tanggal\n" +
                                        "FROM tb_riwayatadmin ra\n" +
                                        "LEFT JOIN tb_admin a ON a.id_admin = ra.id_admin\n" +
                                        "ORDER BY ra.tanggal DESC";
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
        private void fillDataRiwayatadmin()
        {
            dataRiwayatadmin.DataSource = tampilSemua();
        }
        private void btnSemua_Click(object sender, EventArgs e)
        {
            dataRiwayatadmin.DataSource = tampilSemua();
        }
        private void resetDTP()
        {
            date = DateTime.Now;
            dateTimePicker2.Text = date.ToString();
            dateTimePicker3.Text = date.ToString();
        }

        private void cbFilterRiwayat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterRiwayatadmin.Text == "Semua Data")
            {
                fillDataRiwayatadmin();
                panelFilterTanggaladmin.Visible = false;
                panelFilterTextadmin.Visible = false;

                resetDTP();
                txtFilterRiwayatadmin.Text = "";
            }
            else if (cbFilterRiwayatadmin.Text == "By Tanggal")
            {
                panelFilterTanggaladmin.Visible = true;
                panelFilterTextadmin.Visible = false;
                resetDTP();
                txtFilterRiwayatadmin.Text = "";
            }

            else if (cbFilterRiwayatadmin.Text == "By Text")
            {
                panelFilterTanggaladmin.Visible = false;
                panelFilterTextadmin.Visible = true;

                resetDTP();
                fillDataRiwayatadmin();
            }
        }

        private void filterByText()
        {
            try
            {

                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT ra.username AS Username, ra.keterangan AS Keterangan, ra.tanggal AS tanggal\n" +
                                "FROM tb_riwayatadmin ra\n" +
                                "LEFT JOIN tb_admin a ON a.id_admin = ra.id_admin\n" +
                                "WHERE ra.username LIKE '%" + txtFilterRiwayatadmin.Text + "%' OR ra.keterangan LIKE '%" + txtFilterRiwayatadmin.Text + "%' OR ra.tanggal LIKE '%" + txtFilterRiwayatadmin.Text + "%'\n" +
                                "ORDER BY ra.tanggal DESC";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataRiwayatadmin.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilterRiwayat_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterRiwayatadmin.Text == "")
            {
                fillDataRiwayatadmin();
            }
        }

        private void filterbytanggal()
        {
            date1 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            date2 = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
            try
            {

                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT ra.username AS Username, ra.keterangan AS Keterangan, ra.tanggal AS tanggal\n" +
                                        "FROM tb_riwayatadmin ra\n" +
                                        "LEFT JOIN tb_admin a ON a.id_admin = ra.id_admin\n" +
                                       " WHERE CAST(ra.tanggal as DATE) BETWEEN '" + date1 + "' AND '" + date2 + "'\n" +
                                       " ORDER BY tanggal DESC";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();

                dataRiwayatadmin.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtFilterRiwayat_TextChanged_1(object sender, EventArgs e)
        {
            if (txtFilterRiwayatadmin.Text == "")
            {
                fillDataRiwayatadmin();
            }
        }

        private void btCariTextRwtadmin_Click(object sender, EventArgs e)
        {
            filterByText();
        }

        private void btCariTanggaladmin_Click(object sender, EventArgs e)
        {
            filterbytanggal();
        }
    }
}