namespace InventoriApp_Karanglewas
{
    partial class FormDataBarang
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
            this.DBarang = new System.Windows.Forms.DataGridView();
            this.txtKodeDB = new System.Windows.Forms.TextBox();
            this.cbKategoriBM = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GRVDB = new System.Windows.Forms.DataGridView();
            this.KategoriDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarangDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarangMasukDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarangKeluarDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTambah = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DBarang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRVDB)).BeginInit();
            this.SuspendLayout();
            // 
            // DBarang
            // 
            this.DBarang.AllowUserToOrderColumns = true;
            this.DBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DBarang.BackgroundColor = System.Drawing.Color.White;
            this.DBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBarang.Enabled = false;
            this.DBarang.Location = new System.Drawing.Point(0, 203);
            this.DBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBarang.Name = "DBarang";
            this.DBarang.RowHeadersWidth = 51;
            this.DBarang.RowTemplate.Height = 24;
            this.DBarang.Size = new System.Drawing.Size(900, 510);
            this.DBarang.TabIndex = 4;
            // 
            // txtKodeDB
            // 
            this.txtKodeDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeDB.Enabled = false;
            this.txtKodeDB.Location = new System.Drawing.Point(335, 69);
            this.txtKodeDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeDB.Name = "txtKodeDB";
            this.txtKodeDB.Size = new System.Drawing.Size(175, 22);
            this.txtKodeDB.TabIndex = 11;
            this.txtKodeDB.Text = "Nama Barang";
            this.txtKodeDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbKategoriBM
            // 
            this.cbKategoriBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBM.Enabled = false;
            this.cbKategoriBM.FormattingEnabled = true;
            this.cbKategoriBM.Location = new System.Drawing.Point(528, 67);
            this.cbKategoriBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriBM.Name = "cbKategoriBM";
            this.cbKategoriBM.Size = new System.Drawing.Size(176, 24);
            this.cbKategoriBM.TabIndex = 5;
            this.cbKategoriBM.Text = "Kategori";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btTambah);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbKategoriBM);
            this.panel2.Controls.Add(this.txtKodeDB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 207);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(711, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GRVDB
            // 
            this.GRVDB.BackgroundColor = System.Drawing.Color.White;
            this.GRVDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRVDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategoriDB,
            this.BarangDB,
            this.BarangMasukDB,
            this.BarangKeluarDB,
            this.TotalDB});
            this.GRVDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.GRVDB.Location = new System.Drawing.Point(0, 207);
            this.GRVDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GRVDB.Name = "GRVDB";
            this.GRVDB.RowHeadersWidth = 51;
            this.GRVDB.Size = new System.Drawing.Size(903, 342);
            this.GRVDB.TabIndex = 6;
            // 
            // KategoriDB
            // 
            this.KategoriDB.HeaderText = "Kategori";
            this.KategoriDB.MinimumWidth = 6;
            this.KategoriDB.Name = "KategoriDB";
            this.KategoriDB.Width = 125;
            // 
            // BarangDB
            // 
            this.BarangDB.HeaderText = "Barang";
            this.BarangDB.MinimumWidth = 6;
            this.BarangDB.Name = "BarangDB";
            this.BarangDB.Width = 125;
            // 
            // BarangMasukDB
            // 
            this.BarangMasukDB.HeaderText = "Barang Masuk";
            this.BarangMasukDB.MinimumWidth = 6;
            this.BarangMasukDB.Name = "BarangMasukDB";
            this.BarangMasukDB.Width = 125;
            // 
            // BarangKeluarDB
            // 
            this.BarangKeluarDB.HeaderText = "Barang Keluar";
            this.BarangKeluarDB.MinimumWidth = 6;
            this.BarangKeluarDB.Name = "BarangKeluarDB";
            this.BarangKeluarDB.Width = 125;
            // 
            // TotalDB
            // 
            this.TotalDB.HeaderText = "Total";
            this.TotalDB.MinimumWidth = 6;
            this.TotalDB.Name = "TotalDB";
            this.TotalDB.Width = 125;
            // 
            // btTambah
            // 
            this.btTambah.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btTambah.IconColor = System.Drawing.Color.Black;
            this.btTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btTambah.Location = new System.Drawing.Point(711, 118);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(100, 32);
            this.btTambah.TabIndex = 13;
            this.btTambah.Text = "TAMBAH";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 554);
            this.Controls.Add(this.GRVDB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DBarang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBarang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRVDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBarang;
        private System.Windows.Forms.TextBox txtKodeDB;
        private System.Windows.Forms.ComboBox cbKategoriBM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GRVDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarangDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarangMasukDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarangKeluarDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDB;
        private FontAwesome.Sharp.IconButton btTambah;
    }
}