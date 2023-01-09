using FontAwesome.Sharp;
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
using static InventoriApp_Karanglewas.dbConfig;



namespace InventoriApp_Karanglewas
{
    public partial class FormAdmin : Form
    {
        //SqlConnection conn = new SqlConnection
        //(@"Data Source=(local);Initial Catalog = InventoriApp; Integrated Security=True");

        SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        int autoId;
        DateTime date;

        DataTable dataTable = new DataTable();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void autoKode()
        {
            string id;
            conn.Open();
            string query = "SELECT id_admin FROM tb_admin ORDER BY id_admin DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();



            if (reader.HasRows && reader != null)
            {
                reader.Read();
                //                string no = reader.GetString(int.Parse(reader[0].ToString()));
                string no = reader["id_admin"].ToString();

                
                int str = Convert.ToInt32(no) + 1;
                id = Convert.ToString(str);

            }
            else
            {
                id = "1";
            }
            autoId = Convert.ToInt32(id);
            txtIdAdmin.Text = id;
            conn.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            autoKode();
            txtIdAdmin.Enabled = false;
            fillDataAdmin();
        }

        private void btSimpanAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                /*conn.Open();
                string query = "INSERT INTO tb_admin (id_admin, username, nama_panjang, password)\n" +
                                "VALUES ('" + autoId + "','" + txtUsernameAdmin.Text + "','" + txtNamaAdmin.Text + "','" + txtPasswordAdmin.Text + "')";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();*/

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_addAdmin";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idAdmin = new SqlParameter("@id_admin", SqlDbType.VarChar);
                SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter namaPanjang = new SqlParameter("@nama_panjang", SqlDbType.VarChar);
                SqlParameter pass = new SqlParameter("@password", SqlDbType.VarChar);

                idAdmin.Value = txtIdAdmin.Text;
                username.Value = txtUsernameAdmin.Text;
                namaPanjang.Value = txtNamaAdmin.Text;
                pass.Value = txtPasswordAdmin.Text;


                cmd.Parameters.Add(idAdmin);
                cmd.Parameters.Add(username);
                cmd.Parameters.Add(namaPanjang);
                cmd.Parameters.Add(pass);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fillDataAdmin();
            resetData();
            
        }

        private DataTable getDataAdmin()
        {
            try
            {
                dataTable.Reset();
                dataTable = new DataTable();
                conn.Open();
                string query = "SELECT id_admin as ID, username as Username, nama_panjang as Nama FROM tb_admin";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        private void fillDataAdmin()
        {

            dgvAdmin.DataSource = getDataAdmin();
        }

        private void resetData()
        {
            txtNamaAdmin.Text = "";
            txtUsernameAdmin.Text = "";
            txtPasswordAdmin.Text = "";
        }

        private void btResetAdmin_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
