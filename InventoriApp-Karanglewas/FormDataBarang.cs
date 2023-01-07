using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {

        }

        private void btTambah_Click(object sender, EventArgs e)
        {

            FormKategoriBarang FM = new FormKategoriBarang(); // Instantiate a Form3 object.
          //  this.Hide();
            FM.ShowDialog(); // Show Form3 and
           // this.Close();
        }
    }
}
