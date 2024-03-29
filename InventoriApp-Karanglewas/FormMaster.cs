﻿using FontAwesome.Sharp;
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
using static InventoriApp_Karanglewas.dataTransfer;

namespace InventoriApp_Karanglewas
{
    public partial class FormMaster : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;
       

        public string admin;


        public FormMaster()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 56);
            panelSidebar.Controls.Add(leftBorderBtn);

            getAdmin();
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        private void hideChild(Panel child)
        {
            child.Visible = false;
           
        }

        private void showChild(Panel childMenu)
        {
            if (childMenu.Visible == false)
            {
                childMenu.Visible = true;
            }
            else
            {
                childMenu.Visible = false;
            }
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

            }
            conn.Close();

            return admin;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
            public static Color color2 = Color.FromArgb(249, 118, 176);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(39, 123, 192); 
                currentBtn.Font = new Font("", 9F, FontStyle.Bold);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
                lblChildForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(1, 125, 194); 
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }

        /*public string getAdmin()
        {
            conn.Open();
            string query = "SELECT a.username FROM tb_log l INNER JOIN tb_admin a ON l.id_admin = a.id_admin ORDER BY id_log DESC LIMIT 1";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                admin = reader.GetString("username");

            }
            conn.Close();

            return admin;
        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormMaster_Load(object sender, EventArgs e)
        {

        }

        private void FormMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            simpanLog("Logout");
        }



        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
            OpenChildForm(new FormBeranda());
            lblChildForm.Text = "Inventaris Kecamatan Karanglewas";

            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }





        private void btDataBarang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        //    OpenChildForm(new FormDataBarang());
            showChild(panelChildSliding);
            button1_Click(sender, e);
            hideChild(panelChildAdmin);
        }

        private void btnBarangMasuk_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormBarangMasuk());
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        private void btnBarangKeluar_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormBarangKeluar());
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        private void btnStockOpname_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormStock());
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        private void btnLaporan_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormLaporan());
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        private void btnRiwayat_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormRiwayat());
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        public void btnAdmin_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //  OpenChildForm(new FormAdmin());
            if (getAdmin() == "admin")
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new FormAdmin());
                showChild(panelChildAdmin);
            }
            else
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new FormAdmin());
            }
            //customDesignChild();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBeranda());
            lblChildForm.Text = "Inventaris Kecamatan Karanglewas";
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBeranda());
            lblChildForm.Text = "Inventaris Kecamatan Karanglewas";
            hideChild(panelChildAdmin);
            hideChild(panelChildSliding);
        }


        private void simpanLog(string ket)
        {
            DateTime date = DateTime.Now;
            try
            {
                conn.Open();
                string query = "INSERT INTO tb_log (id_admin, keterangan, waktu)\n" +
                                "SELECT a.id_admin, '" + ket + "','" + date + "'\n" +
                                "FROM tb_admin a\n" +
                                "WHERE a.username = '" + admin + "'";
                var cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new listBarang());
            lblChildForm.Text = "Data Barang - List Barang";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDataBarang());
            lblChildForm.Text = "Data Barang - Stok Barang";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new listKategori());
            lblChildForm.Text = "Data Barang - List Kategori";
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            simpanLog("Logout");
            Form_Login FL = new Form_Login(); // Instantiate a Form3 object.
            this.Hide();
            FL.ShowDialog(); // Show Form3 and
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdmin());
            lblChildForm.Text = "Admin";
        }

        private void btnRiwayatAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRiwayatAdmin1());
            lblChildForm.Text = "Admin - Riwayat Admin";
        }

        private void btnLogAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLogAdmin1());
            lblChildForm.Text = "Admin - Log Admin";
        }
    }
}
