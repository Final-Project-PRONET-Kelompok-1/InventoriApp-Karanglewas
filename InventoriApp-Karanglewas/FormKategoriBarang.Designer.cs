﻿namespace InventoriApp_Karanglewas
{
    partial class FormKategoriBarang
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
            this.components = new System.ComponentModel.Container();
            this.txtKBarang = new System.Windows.Forms.TextBox();
            this.btTambahKBarang = new System.Windows.Forms.Button();
            this.cbKBarang = new System.Windows.Forms.ComboBox();
            this.tbkategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoriAppDataSet11 = new InventoriApp_Karanglewas.InventoriAppDataSet1();
            this.txtTambahBarang = new System.Windows.Forms.TextBox();
            this.btTambahBarang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventoriAppDataSet = new InventoriApp_Karanglewas.InventoriAppDataSet();
            this.inventoriAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoriAppDataSet1 = new InventoriApp_Karanglewas.InventoriAppDataSet();
            this.inventoriAppDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_kategoriTableAdapter = new InventoriApp_Karanglewas.InventoriAppDataSet1TableAdapters.tb_kategoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbkategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKBarang
            // 
            this.txtKBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKBarang.Location = new System.Drawing.Point(31, 58);
            this.txtKBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKBarang.Name = "txtKBarang";
            this.txtKBarang.Size = new System.Drawing.Size(109, 20);
            this.txtKBarang.TabIndex = 0;
            // 
            // btTambahKBarang
            // 
            this.btTambahKBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btTambahKBarang.Location = new System.Drawing.Point(143, 57);
            this.btTambahKBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTambahKBarang.Name = "btTambahKBarang";
            this.btTambahKBarang.Size = new System.Drawing.Size(72, 25);
            this.btTambahKBarang.TabIndex = 1;
            this.btTambahKBarang.Text = "TAMBAH";
            this.btTambahKBarang.UseVisualStyleBackColor = true;
            this.btTambahKBarang.Click += new System.EventHandler(this.btTambahKBarang_Click_1);
            // 
            // cbKBarang
            // 
            this.cbKBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKBarang.DataSource = this.tbkategoriBindingSource;
            this.cbKBarang.DisplayMember = "jenis_kategori";
            this.cbKBarang.FormattingEnabled = true;
            this.cbKBarang.Location = new System.Drawing.Point(370, 57);
            this.cbKBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKBarang.Name = "cbKBarang";
            this.cbKBarang.Size = new System.Drawing.Size(116, 21);
            this.cbKBarang.TabIndex = 4;
            this.cbKBarang.ValueMember = "jenis_kategori";
            this.cbKBarang.SelectedIndexChanged += new System.EventHandler(this.cbKBarang_SelectedIndexChanged);
            // 
            // tbkategoriBindingSource
            // 
            this.tbkategoriBindingSource.DataMember = "tb_kategori";
            this.tbkategoriBindingSource.DataSource = this.inventoriAppDataSet11;
            // 
            // inventoriAppDataSet11
            // 
            this.inventoriAppDataSet11.DataSetName = "InventoriAppDataSet1";
            this.inventoriAppDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTambahBarang
            // 
            this.txtTambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTambahBarang.Location = new System.Drawing.Point(370, 92);
            this.txtTambahBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTambahBarang.Multiline = true;
            this.txtTambahBarang.Name = "txtTambahBarang";
            this.txtTambahBarang.Size = new System.Drawing.Size(116, 22);
            this.txtTambahBarang.TabIndex = 5;
            // 
            // btTambahBarang
            // 
            this.btTambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btTambahBarang.Location = new System.Drawing.Point(490, 58);
            this.btTambahBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTambahBarang.Name = "btTambahBarang";
            this.btTambahBarang.Size = new System.Drawing.Size(68, 25);
            this.btTambahBarang.TabIndex = 6;
            this.btTambahBarang.Text = "TAMBAH";
            this.btTambahBarang.UseVisualStyleBackColor = true;
            this.btTambahBarang.Click += new System.EventHandler(this.btTambahBarang_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barang";
            // 
            // inventoriAppDataSet
            // 
            this.inventoriAppDataSet.DataSetName = "InventoriAppDataSet";
            this.inventoriAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoriAppDataSetBindingSource
            // 
            this.inventoriAppDataSetBindingSource.DataSource = this.inventoriAppDataSet;
            this.inventoriAppDataSetBindingSource.Position = 0;
            // 
            // inventoriAppDataSet1
            // 
            this.inventoriAppDataSet1.DataSetName = "InventoriAppDataSet";
            this.inventoriAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoriAppDataSet1BindingSource
            // 
            this.inventoriAppDataSet1BindingSource.DataSource = this.inventoriAppDataSet1;
            this.inventoriAppDataSet1BindingSource.Position = 0;
            // 
            // tb_kategoriTableAdapter
            // 
            this.tb_kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // FormKategoriBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(600, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTambahBarang);
            this.Controls.Add(this.txtTambahBarang);
            this.Controls.Add(this.cbKBarang);
            this.Controls.Add(this.btTambahKBarang);
            this.Controls.Add(this.txtKBarang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKategoriBarang";
            this.Text = "FormKategoriBarang";
            this.Load += new System.EventHandler(this.FormKategoriBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbkategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriAppDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKBarang;
        private System.Windows.Forms.Button btTambahKBarang;
        private System.Windows.Forms.ComboBox cbKBarang;
        private System.Windows.Forms.TextBox txtTambahBarang;
        private System.Windows.Forms.Button btTambahBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private InventoriAppDataSet inventoriAppDataSet;
        private System.Windows.Forms.BindingSource inventoriAppDataSetBindingSource;
        private System.Windows.Forms.BindingSource inventoriAppDataSet1BindingSource;
        private InventoriAppDataSet inventoriAppDataSet1;
        private InventoriAppDataSet1 inventoriAppDataSet11;
        private System.Windows.Forms.BindingSource tbkategoriBindingSource;
        private InventoriAppDataSet1TableAdapters.tb_kategoriTableAdapter tb_kategoriTableAdapter;
    }
}