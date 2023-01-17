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
        FormAdmin fa = new FormAdmin();

        SqlConnection conn = dbConfig.conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public string username;
        string validasi;

        
        public FormPassword()
        {
            InitializeComponent();

            lblUsername.Text = "Username: '"+fa.getUsername+"'";
        }

        

        private string cekPasswordLama()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_admin WHERE username = '"+fa.getUsername+"' AND password = HASHBYTES('MD5', '" + txtPassLama.Text + "') ";

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
                  "WHERE username= '" + fa.getUsername + "' ";
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
            if(cekPasswordLama() == "oke")
            {
                simpanPassBaru();
                txtPassBaru.Text = "";
                txtPassLama.Text = "";
                this.Close();
                fa.resetData();
                MessageBox.Show("Password berhasil diubah!");
                fa.fillDataAdmin();
            }
        }
    }
}