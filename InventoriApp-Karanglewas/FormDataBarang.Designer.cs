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
            this.DBarang.Location = new System.Drawing.Point(0, 165);
            this.DBarang.Margin = new System.Windows.Forms.Padding(2);
            this.DBarang.Name = "DBarang";
            this.DBarang.RowHeadersWidth = 51;
            this.DBarang.RowTemplate.Height = 24;
            this.DBarang.Size = new System.Drawing.Size(675, 414);
            this.DBarang.TabIndex = 4;
            // 
            // txtKodeDB
            // 
            this.txtKodeDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeDB.Enabled = false;
            this.txtKodeDB.Location = new System.Drawing.Point(251, 56);
            this.txtKodeDB.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeDB.Name = "txtKodeDB";
            this.txtKodeDB.Size = new System.Drawing.Size(132, 20);
            this.txtKodeDB.TabIndex = 11;
            this.txtKodeDB.Text = "Nama Barang";
            this.txtKodeDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbKategoriBM
            // 
            this.cbKategoriBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBM.Enabled = false;
            this.cbKategoriBM.FormattingEnabled = true;
            this.cbKategoriBM.Location = new System.Drawing.Point(396, 56);
            this.cbKategoriBM.Margin = new System.Windows.Forms.Padding(2);
            this.cbKategoriBM.Name = "cbKategoriBM";
            this.cbKategoriBM.Size = new System.Drawing.Size(133, 21);
            this.cbKategoriBM.TabIndex = 5;
            this.cbKategoriBM.Text = "Kategori";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbKategoriBM);
            this.panel2.Controls.Add(this.txtKodeDB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 168);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(532, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.GRVDB.Location = new System.Drawing.Point(0, 168);
            this.GRVDB.Name = "GRVDB";
            this.GRVDB.Size = new System.Drawing.Size(677, 278);
            this.GRVDB.TabIndex = 6;
            // 
            // KategoriDB
            // 
            this.KategoriDB.HeaderText = "Kategori";
            this.KategoriDB.Name = "KategoriDB";
            // 
            // BarangDB
            // 
            this.BarangDB.HeaderText = "Barang";
            this.BarangDB.Name = "BarangDB";
            // 
            // BarangMasukDB
            // 
            this.BarangMasukDB.HeaderText = "Barang Masuk";
            this.BarangMasukDB.Name = "BarangMasukDB";
            // 
            // BarangKeluarDB
            // 
            this.BarangKeluarDB.HeaderText = "Barang Keluar";
            this.BarangKeluarDB.Name = "BarangKeluarDB";
            // 
            // TotalDB
            // 
            this.TotalDB.HeaderText = "Total";
            this.TotalDB.Name = "TotalDB";
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.GRVDB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DBarang);
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
    }
}