﻿namespace InventoriApp_Karanglewas
{
    partial class Form_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDataBarang = new FontAwesome.Sharp.IconButton();
            this.btBarangMasuk = new FontAwesome.Sharp.IconButton();
            this.btBarangKeluar = new FontAwesome.Sharp.IconButton();
            this.btRiwayat = new FontAwesome.Sharp.IconButton();
            this.btLaporan = new FontAwesome.Sharp.IconButton();
            this.btAdmin = new FontAwesome.Sharp.IconButton();
            this.btKeluar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Location = new System.Drawing.Point(0, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(244, 132);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.btKeluar);
            this.panel1.Controls.Add(this.btAdmin);
            this.panel1.Controls.Add(this.btLaporan);
            this.panel1.Controls.Add(this.btRiwayat);
            this.panel1.Controls.Add(this.btBarangKeluar);
            this.panel1.Controls.Add(this.btBarangMasuk);
            this.panel1.Controls.Add(this.btDataBarang);
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 380);
            this.panel1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = global::InventoriApp_Karanglewas.Gambar.logo_Banyumas;
            this.logo.Location = new System.Drawing.Point(0, 11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(108, 107);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "KECAMATAN \r\nKARANGLEWAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btDataBarang
            // 
            this.btDataBarang.BackColor = System.Drawing.Color.Transparent;
            this.btDataBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDataBarang.FlatAppearance.BorderSize = 0;
            this.btDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDataBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataBarang.ForeColor = System.Drawing.Color.LightGray;
            this.btDataBarang.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btDataBarang.IconColor = System.Drawing.Color.LightGray;
            this.btDataBarang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDataBarang.IconSize = 52;
            this.btDataBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDataBarang.Location = new System.Drawing.Point(3, 7);
            this.btDataBarang.Name = "btDataBarang";
            this.btDataBarang.Size = new System.Drawing.Size(224, 56);
            this.btDataBarang.TabIndex = 0;
            this.btDataBarang.Text = "Data Barang";
            this.btDataBarang.UseVisualStyleBackColor = false;
            this.btDataBarang.Click += new System.EventHandler(this.btDataBarang_Click);
            // 
            // btBarangMasuk
            // 
            this.btBarangMasuk.BackColor = System.Drawing.Color.Transparent;
            this.btBarangMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btBarangMasuk.FlatAppearance.BorderSize = 0;
            this.btBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBarangMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBarangMasuk.ForeColor = System.Drawing.Color.LightGray;
            this.btBarangMasuk.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btBarangMasuk.IconColor = System.Drawing.Color.LightGray;
            this.btBarangMasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBarangMasuk.IconSize = 52;
            this.btBarangMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBarangMasuk.Location = new System.Drawing.Point(3, 58);
            this.btBarangMasuk.Name = "btBarangMasuk";
            this.btBarangMasuk.Rotation = 180D;
            this.btBarangMasuk.Size = new System.Drawing.Size(238, 56);
            this.btBarangMasuk.TabIndex = 1;
            this.btBarangMasuk.Text = "Barang Masuk";
            this.btBarangMasuk.UseVisualStyleBackColor = false;
            // 
            // btBarangKeluar
            // 
            this.btBarangKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btBarangKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btBarangKeluar.FlatAppearance.BorderSize = 0;
            this.btBarangKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBarangKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBarangKeluar.ForeColor = System.Drawing.Color.LightGray;
            this.btBarangKeluar.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btBarangKeluar.IconColor = System.Drawing.Color.LightGray;
            this.btBarangKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBarangKeluar.IconSize = 52;
            this.btBarangKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBarangKeluar.Location = new System.Drawing.Point(3, 109);
            this.btBarangKeluar.Name = "btBarangKeluar";
            this.btBarangKeluar.Size = new System.Drawing.Size(241, 56);
            this.btBarangKeluar.TabIndex = 2;
            this.btBarangKeluar.Text = "Barang Keluar";
            this.btBarangKeluar.UseVisualStyleBackColor = false;
            // 
            // btRiwayat
            // 
            this.btRiwayat.BackColor = System.Drawing.Color.Transparent;
            this.btRiwayat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRiwayat.FlatAppearance.BorderSize = 0;
            this.btRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRiwayat.ForeColor = System.Drawing.Color.LightGray;
            this.btRiwayat.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btRiwayat.IconColor = System.Drawing.Color.LightGray;
            this.btRiwayat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRiwayat.IconSize = 52;
            this.btRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRiwayat.Location = new System.Drawing.Point(3, 160);
            this.btRiwayat.Name = "btRiwayat";
            this.btRiwayat.Size = new System.Drawing.Size(197, 56);
            this.btRiwayat.TabIndex = 3;
            this.btRiwayat.Text = "Riwayat";
            this.btRiwayat.UseVisualStyleBackColor = false;
            // 
            // btLaporan
            // 
            this.btLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLaporan.FlatAppearance.BorderSize = 0;
            this.btLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLaporan.ForeColor = System.Drawing.Color.LightGray;
            this.btLaporan.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.btLaporan.IconColor = System.Drawing.Color.LightGray;
            this.btLaporan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLaporan.IconSize = 52;
            this.btLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLaporan.Location = new System.Drawing.Point(3, 211);
            this.btLaporan.Name = "btLaporan";
            this.btLaporan.Size = new System.Drawing.Size(203, 56);
            this.btLaporan.TabIndex = 4;
            this.btLaporan.Text = "Laporan";
            this.btLaporan.UseVisualStyleBackColor = false;
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAdmin.FlatAppearance.BorderSize = 0;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.ForeColor = System.Drawing.Color.LightGray;
            this.btAdmin.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btAdmin.IconColor = System.Drawing.Color.LightGray;
            this.btAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAdmin.IconSize = 52;
            this.btAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdmin.Location = new System.Drawing.Point(3, 262);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(188, 56);
            this.btAdmin.TabIndex = 5;
            this.btAdmin.Text = "Admin";
            this.btAdmin.UseVisualStyleBackColor = false;
            // 
            // btKeluar
            // 
            this.btKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btKeluar.FlatAppearance.BorderSize = 0;
            this.btKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKeluar.ForeColor = System.Drawing.Color.LightGray;
            this.btKeluar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btKeluar.IconColor = System.Drawing.Color.LightGray;
            this.btKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btKeluar.IconSize = 52;
            this.btKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKeluar.Location = new System.Drawing.Point(3, 313);
            this.btKeluar.Name = "btKeluar";
            this.btKeluar.Size = new System.Drawing.Size(188, 56);
            this.btKeluar.TabIndex = 6;
            this.btKeluar.Text = "Keluar";
            this.btKeluar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(242, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 45);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "INVENTARIS KECAMATAN KARANGLEWAS";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 466);
            this.panel3.TabIndex = 3;
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogo);
            this.Name = "Form_1";
            this.Text = "Form_1";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btDataBarang;
        private FontAwesome.Sharp.IconButton btRiwayat;
        private FontAwesome.Sharp.IconButton btBarangKeluar;
        private FontAwesome.Sharp.IconButton btBarangMasuk;
        private FontAwesome.Sharp.IconButton btKeluar;
        private FontAwesome.Sharp.IconButton btAdmin;
        private FontAwesome.Sharp.IconButton btLaporan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}