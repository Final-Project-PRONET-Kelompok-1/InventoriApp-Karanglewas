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
        SqlConnection conn = new SqlConnection
            (@"Data Source=(local);Initial Catalog = InventoriApp; Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader reader;
        string kategori;
        int autoId;
        DateTime date;

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
            showdata();
        }

        private void btSimpanAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_admin (id_admin, username, nama_panjang, password)\n" +
                                "VALUES ('" + autoId + "','" + txtUsernameAdmin.Text + "','" + txtNamaAdmin.Text + "','" + txtPasswordAdmin.Text + "')";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showdata();
            resetData();
            
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tb_admin";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tb_admin");

            dgvAdmin.DataSource = ds;
            dgvAdmin.DataMember = "tb_admin";
            dgvAdmin.Columns["password"].Visible = false;
            dgvAdmin.ReadOnly = true;
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
