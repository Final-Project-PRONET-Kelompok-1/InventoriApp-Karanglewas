namespace InventoriApp_Karanglewas
{
    partial class FormLaporan
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
            this.btnDataBarang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBarangMasuk = new System.Windows.Forms.Button();
            this.btnBarangKeluar = new System.Windows.Forms.Button();
            this.btnOpname = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDataBarang
            // 
            this.btnDataBarang.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDataBarang.Location = new System.Drawing.Point(308, 244);
            this.btnDataBarang.Margin = new System.Windows.Forms.Padding(5);
            this.btnDataBarang.Name = "btnDataBarang";
            this.btnDataBarang.Size = new System.Drawing.Size(174, 42);
            this.btnDataBarang.TabIndex = 0;
            this.btnDataBarang.Text = "Data Barang";
            this.btnDataBarang.UseVisualStyleBackColor = false;
            this.btnDataBarang.Click += new System.EventHandler(this.btnDataBarang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CETAK LAPORAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih laporan yang akan dicetak:";
            // 
            // btnBarangMasuk
            // 
            this.btnBarangMasuk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBarangMasuk.Location = new System.Drawing.Point(299, 416);
            this.btnBarangMasuk.Margin = new System.Windows.Forms.Padding(5);
            this.btnBarangMasuk.Name = "btnBarangMasuk";
            this.btnBarangMasuk.Size = new System.Drawing.Size(193, 42);
            this.btnBarangMasuk.TabIndex = 3;
            this.btnBarangMasuk.Text = "Barang Masuk";
            this.btnBarangMasuk.UseVisualStyleBackColor = false;
            this.btnBarangMasuk.Click += new System.EventHandler(this.btnBarangMasuk_Click);
            // 
            // btnBarangKeluar
            // 
            this.btnBarangKeluar.BackColor = System.Drawing.Color.Red;
            this.btnBarangKeluar.Location = new System.Drawing.Point(299, 324);
            this.btnBarangKeluar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBarangKeluar.Name = "btnBarangKeluar";
            this.btnBarangKeluar.Size = new System.Drawing.Size(193, 42);
            this.btnBarangKeluar.TabIndex = 4;
            this.btnBarangKeluar.Text = "Barang Keluar";
            this.btnBarangKeluar.UseVisualStyleBackColor = false;
            this.btnBarangKeluar.Click += new System.EventHandler(this.btnBarangKeluar_Click);
            // 
            // btnOpname
            // 
            this.btnOpname.BackColor = System.Drawing.Color.Khaki;
            this.btnOpname.Location = new System.Drawing.Point(299, 496);
            this.btnOpname.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpname.Name = "btnOpname";
            this.btnOpname.Size = new System.Drawing.Size(193, 42);
            this.btnOpname.TabIndex = 5;
            this.btnOpname.Text = "Stock Opname";
            this.btnOpname.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 130);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 749);
            this.Controls.Add(this.btnOpname);
            this.Controls.Add(this.btnBarangKeluar);
            this.Controls.Add(this.btnBarangMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDataBarang);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDataBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBarangMasuk;
        private System.Windows.Forms.Button btnBarangKeluar;
        private System.Windows.Forms.Button btnOpname;
        private System.Windows.Forms.Panel panel1;
    }
}