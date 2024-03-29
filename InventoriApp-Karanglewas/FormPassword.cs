﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp_Karanglewas
{
    public partial class FormPassword : Form
    {

        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;

        string validasi;

        
        public FormPassword()
        {
            InitializeComponent();

            lblUsername.Text = "Username: '"+FormAdmin.getUsername+"'";
        }

        

        private string cekPasswordLama()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '"+ FormAdmin.getUsername + "' AND password = HASHBYTES('MD5', '" + txtPassLama.Text + "') ";

                //string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                var cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {

                    validasi = "oke";
                }
                else
                {

                    MessageBox.Show("Password lama salah!");
                    txtPassLama.Focus();
                    validasi = "gagal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return validasi;
        }

        private void simpanPassBaru()
        {
            
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tb_admin SET password = HASHBYTES('MD5', '" + txtPassBaru.Text + "') " +
                  "WHERE username= '" + FormAdmin.getUsername + "' ";
                cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSimpanPassword_Click(object sender, EventArgs e)
        {

            if (txtPassLama.Text == "")
            {
                MessageBox.Show("Password lama harus diisi!","Peringatan");
                txtPassLama.Focus();
            }
            else if (txtPassBaru.Text == "")
            {
                MessageBox.Show("Password baru harus diisi!","Peringatan");
                txtPassBaru.Focus();
            }
            else if (txtPassLama.Text == txtPassBaru.Text)
            {
                MessageBox.Show("Password baru anda sama dengan password yang lama!", "Peringatan");
                txtPassBaru.Focus();
            }
            else
            {
                FormAdmin fa = new FormAdmin();
                var mainForm = Application.OpenForms.OfType<FormAdmin>().Single();
                if (cekPasswordLama() == "oke")
                {
                    simpanPassBaru();
                    txtPassBaru.Text = "";
                    txtPassLama.Text = "";
                    this.Close();
                    mainForm.resetData();
                    mainForm.fillDataAdmin();
                    MessageBox.Show("Password berhasil diubah!");
                }
            }
        }
    }
}
