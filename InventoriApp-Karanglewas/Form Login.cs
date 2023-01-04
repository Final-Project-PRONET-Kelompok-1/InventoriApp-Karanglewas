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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            FormMaster FM = new FormMaster(); // Instantiate a Form3 object.
            this.Hide();
            FM.ShowDialog(); // Show Form3 and
            this.Close();
        }
    }

}
