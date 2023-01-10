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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoriApp_Karanglewas
{
    public partial class FormBeranda : Form
    {
        FormMaster fm = new FormMaster();
        //SqlConnection conn = new SqlConnection(dbConfig.conn);
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KDEI2T;Initial Catalog=InventoriApp; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string admin;
        public FormBeranda()
        {
            InitializeComponent();
            getAdmin();
        }

        public string getAdmin()
        {
            conn.Open();
            string query = "SELECT a.username FROM tb_log l INNER JOIN tb_admin a ON l.id_admin = a.id_admin ORDER BY id_log DESC";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                admin = reader["username"].ToString();
                LblUser.Text = admin;
            }
            conn.Close();

            return admin;
        }

        private void FormBeranda_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
