namespace InventoriApp_Karanglewas
{
    partial class FormRiwayat
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
            this.GrvRiwayat = new System.Windows.Forms.DataGridView();
            this.dtRiwayat = new System.Windows.Forms.DateTimePicker();
            this.TanggalRwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransaksiRwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriRwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarangRwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahRwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeteranganRwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // GrvRiwayat
            // 
            this.GrvRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.GrvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TanggalRwt,
            this.TransaksiRwt,
            this.KategoriRwt,
            this.BarangRwt,
            this.JumlahRwt,
            this.KeteranganRwt});
            this.GrvRiwayat.Location = new System.Drawing.Point(1, 48);
            this.GrvRiwayat.Name = "GrvRiwayat";
            this.GrvRiwayat.Size = new System.Drawing.Size(809, 409);
            this.GrvRiwayat.TabIndex = 0;
            // 
            // dtRiwayat
            // 
            this.dtRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtRiwayat.Location = new System.Drawing.Point(575, 11);
            this.dtRiwayat.Margin = new System.Windows.Forms.Padding(2);
            this.dtRiwayat.Name = "dtRiwayat";
            this.dtRiwayat.Size = new System.Drawing.Size(183, 20);
            this.dtRiwayat.TabIndex = 9;
            // 
            // TanggalRwt
            // 
            this.TanggalRwt.HeaderText = "Tanggal";
            this.TanggalRwt.Name = "TanggalRwt";
            // 
            // TransaksiRwt
            // 
            this.TransaksiRwt.HeaderText = "Transaksi";
            this.TransaksiRwt.Name = "TransaksiRwt";
            // 
            // KategoriRwt
            // 
            this.KategoriRwt.HeaderText = "Kategori";
            this.KategoriRwt.Name = "KategoriRwt";
            // 
            // BarangRwt
            // 
            this.BarangRwt.HeaderText = "Barang";
            this.BarangRwt.Name = "BarangRwt";
            // 
            // JumlahRwt
            // 
            this.JumlahRwt.HeaderText = "Jumlah";
            this.JumlahRwt.Name = "JumlahRwt";
            // 
            // KeteranganRwt
            // 
            this.KeteranganRwt.HeaderText = "Keterangan";
            this.KeteranganRwt.Name = "KeteranganRwt";
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtRiwayat);
            this.Controls.Add(this.GrvRiwayat);
            this.Name = "FormRiwayat";
            this.Text = "FormRiwayat";
            ((System.ComponentModel.ISupportInitialize)(this.GrvRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalRwt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaksiRwt;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriRwt;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarangRwt;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahRwt;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeteranganRwt;
        private System.Windows.Forms.DateTimePicker dtRiwayat;
    }
}