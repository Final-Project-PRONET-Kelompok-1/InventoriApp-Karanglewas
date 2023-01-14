namespace InventoriApp_Karanglewas
{
    partial class FormBarangKeluar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFilterText = new System.Windows.Forms.Panel();
            this.btCariText = new System.Windows.Forms.Button();
            this.txtFilterBarang = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panelFilterKategori = new System.Windows.Forms.Panel();
            this.cbFilterKategori = new System.Windows.Forms.ComboBox();
            this.panelFilterTanggal = new System.Windows.Forms.Panel();
            this.btCariTanggal = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSimpanBK = new System.Windows.Forms.Button();
            this.btResetBK = new System.Windows.Forms.Button();
            this.btHapusBK = new System.Windows.Forms.Button();
            this.btEditBK = new System.Windows.Forms.Button();
            this.dtBK = new System.Windows.Forms.DateTimePicker();
            this.txtJumlahBK = new System.Windows.Forms.TextBox();
            this.cbBarangBK = new System.Windows.Forms.ComboBox();
            this.cbKategoriBK = new System.Windows.Forms.ComboBox();
            this.txtKodeBK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBK = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panelFilterText.SuspendLayout();
            this.panelFilterKategori.SuspendLayout();
            this.panelFilterTanggal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.panelFilterText);
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.panelFilterKategori);
            this.panel2.Controls.Add(this.panelFilterTanggal);
            this.panel2.Controls.Add(this.txtPIC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btSimpanBK);
            this.panel2.Controls.Add(this.btResetBK);
            this.panel2.Controls.Add(this.btHapusBK);
            this.panel2.Controls.Add(this.btEditBK);
            this.panel2.Controls.Add(this.dtBK);
            this.panel2.Controls.Add(this.txtJumlahBK);
            this.panel2.Controls.Add(this.cbBarangBK);
            this.panel2.Controls.Add(this.cbKategoriBK);
            this.panel2.Controls.Add(this.txtKodeBK);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 207);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelFilterText
            // 
            this.panelFilterText.Controls.Add(this.btCariText);
            this.panelFilterText.Controls.Add(this.txtFilterBarang);
            this.panelFilterText.Location = new System.Drawing.Point(225, 160);
            this.panelFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterText.Name = "panelFilterText";
            this.panelFilterText.Size = new System.Drawing.Size(243, 60);
            this.panelFilterText.TabIndex = 24;
            // 
            // btCariText
            // 
            this.btCariText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCariText.Location = new System.Drawing.Point(176, 0);
            this.btCariText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariText.Name = "btCariText";
            this.btCariText.Size = new System.Drawing.Size(67, 25);
            this.btCariText.TabIndex = 21;
            this.btCariText.Text = "Cari";
            this.btCariText.UseVisualStyleBackColor = true;
            this.btCariText.Click += new System.EventHandler(this.btCariText_Click);
            // 
            // txtFilterBarang
            // 
            this.txtFilterBarang.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFilterBarang.Location = new System.Drawing.Point(0, 0);
            this.txtFilterBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilterBarang.Name = "txtFilterBarang";
            this.txtFilterBarang.Size = new System.Drawing.Size(176, 22);
            this.txtFilterBarang.TabIndex = 22;
            this.txtFilterBarang.TextChanged += new System.EventHandler(this.txtFilterBarang_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Semua Data",
            "By Tanggal",
            "By Kategori",
            "By Text"});
            this.cbFilter.Location = new System.Drawing.Point(101, 160);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(160, 24);
            this.cbFilter.TabIndex = 22;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // panelFilterKategori
            // 
            this.panelFilterKategori.Controls.Add(this.cbFilterKategori);
            this.panelFilterKategori.Location = new System.Drawing.Point(224, 159);
            this.panelFilterKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterKategori.Name = "panelFilterKategori";
            this.panelFilterKategori.Size = new System.Drawing.Size(211, 39);
            this.panelFilterKategori.TabIndex = 25;
            // 
            // cbFilterKategori
            // 
            this.cbFilterKategori.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbFilterKategori.FormattingEnabled = true;
            this.cbFilterKategori.Location = new System.Drawing.Point(0, 0);
            this.cbFilterKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterKategori.Name = "cbFilterKategori";
            this.cbFilterKategori.Size = new System.Drawing.Size(176, 24);
            this.cbFilterKategori.TabIndex = 19;
            this.cbFilterKategori.SelectedIndexChanged += new System.EventHandler(this.cbFilterKategori_SelectedIndexChanged_1);
            // 
            // panelFilterTanggal
            // 
            this.panelFilterTanggal.Controls.Add(this.btCariTanggal);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker2);
            this.panelFilterTanggal.Controls.Add(this.label6);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker1);
            this.panelFilterTanggal.Location = new System.Drawing.Point(224, 160);
            this.panelFilterTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterTanggal.Name = "panelFilterTanggal";
            this.panelFilterTanggal.Size = new System.Drawing.Size(583, 30);
            this.panelFilterTanggal.TabIndex = 23;
            // 
            // btCariTanggal
            // 
            this.btCariTanggal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCariTanggal.Location = new System.Drawing.Point(501, 0);
            this.btCariTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariTanggal.Name = "btCariTanggal";
            this.btCariTanggal.Size = new System.Drawing.Size(82, 25);
            this.btCariTanggal.TabIndex = 19;
            this.btCariTanggal.Text = "Cari";
            this.btCariTanggal.UseVisualStyleBackColor = true;
            this.btCariTanggal.Click += new System.EventHandler(this.btCariTanggal_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 0);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(243, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "--";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txtPIC
            // 
            this.txtPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIC.Location = new System.Drawing.Point(652, 64);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(210, 22);
            this.txtPIC.TabIndex = 14;
            this.txtPIC.TextChanged += new System.EventHandler(this.txtPIC_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "PIC";
            // 
            // btSimpanBK
            // 
            this.btSimpanBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanBK.Location = new System.Drawing.Point(788, 110);
            this.btSimpanBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanBK.Name = "btSimpanBK";
            this.btSimpanBK.Size = new System.Drawing.Size(75, 34);
            this.btSimpanBK.TabIndex = 12;
            this.btSimpanBK.Text = "Simpan";
            this.btSimpanBK.UseVisualStyleBackColor = true;
            this.btSimpanBK.Click += new System.EventHandler(this.btSimpanBK_Click);
            // 
            // btResetBK
            // 
            this.btResetBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btResetBK.Location = new System.Drawing.Point(694, 110);
            this.btResetBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetBK.Name = "btResetBK";
            this.btResetBK.Size = new System.Drawing.Size(75, 34);
            this.btResetBK.TabIndex = 11;
            this.btResetBK.Text = "Reset";
            this.btResetBK.UseVisualStyleBackColor = true;
            this.btResetBK.Click += new System.EventHandler(this.btResetBK_Click);
            // 
            // btHapusBK
            // 
            this.btHapusBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btHapusBK.Location = new System.Drawing.Point(604, 110);
            this.btHapusBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusBK.Name = "btHapusBK";
            this.btHapusBK.Size = new System.Drawing.Size(75, 34);
            this.btHapusBK.TabIndex = 10;
            this.btHapusBK.Text = "Hapus";
            this.btHapusBK.UseVisualStyleBackColor = true;
            this.btHapusBK.Click += new System.EventHandler(this.btHapusBK_Click);
            // 
            // btEditBK
            // 
            this.btEditBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEditBK.Location = new System.Drawing.Point(517, 111);
            this.btEditBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditBK.Name = "btEditBK";
            this.btEditBK.Size = new System.Drawing.Size(75, 32);
            this.btEditBK.TabIndex = 9;
            this.btEditBK.Text = "Edit";
            this.btEditBK.UseVisualStyleBackColor = true;
            this.btEditBK.Click += new System.EventHandler(this.btEditBK_Click);
            // 
            // dtBK
            // 
            this.dtBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtBK.Location = new System.Drawing.Point(618, 22);
            this.dtBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBK.Name = "dtBK";
            this.dtBK.Size = new System.Drawing.Size(243, 22);
            this.dtBK.TabIndex = 8;
            // 
            // txtJumlahBK
            // 
            this.txtJumlahBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtJumlahBK.Location = new System.Drawing.Point(198, 113);
            this.txtJumlahBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlahBK.Name = "txtJumlahBK";
            this.txtJumlahBK.Size = new System.Drawing.Size(211, 22);
            this.txtJumlahBK.TabIndex = 7;
            this.txtJumlahBK.TextChanged += new System.EventHandler(this.txtJumlahBK_TextChanged);
            // 
            // cbBarangBK
            // 
            this.cbBarangBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBarangBK.FormattingEnabled = true;
            this.cbBarangBK.Location = new System.Drawing.Point(198, 82);
            this.cbBarangBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBarangBK.Name = "cbBarangBK";
            this.cbBarangBK.Size = new System.Drawing.Size(211, 24);
            this.cbBarangBK.TabIndex = 6;
            this.cbBarangBK.SelectedIndexChanged += new System.EventHandler(this.cbBarangBK_SelectedIndexChanged);
            // 
            // cbKategoriBK
            // 
            this.cbKategoriBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBK.FormattingEnabled = true;
            this.cbKategoriBK.Location = new System.Drawing.Point(198, 52);
            this.cbKategoriBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriBK.Name = "cbKategoriBK";
            this.cbKategoriBK.Size = new System.Drawing.Size(211, 24);
            this.cbKategoriBK.TabIndex = 5;
            this.cbKategoriBK.SelectedIndexChanged += new System.EventHandler(this.cbKategoriBK_SelectedIndexChanged);
            // 
            // txtKodeBK
            // 
            this.txtKodeBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeBK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeBK.Location = new System.Drawing.Point(200, 22);
            this.txtKodeBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeBK.Name = "txtKodeBK";
            this.txtKodeBK.Size = new System.Drawing.Size(210, 22);
            this.txtKodeBK.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barang";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // dataBK
            // 
            this.dataBK.AllowUserToOrderColumns = true;
            this.dataBK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBK.BackgroundColor = System.Drawing.Color.White;
            this.dataBK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBK.Location = new System.Drawing.Point(15, 213);
            this.dataBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBK.Name = "dataBK";
            this.dataBK.RowHeadersWidth = 51;
            this.dataBK.RowTemplate.Height = 24;
            this.dataBK.Size = new System.Drawing.Size(934, 518);
            this.dataBK.TabIndex = 4;
            this.dataBK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBK_CellContentClick);
            // 
            // FormBarangKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataBK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBarangKeluar";
            this.Text = "FormBarangKeluar";
            this.Load += new System.EventHandler(this.FormBarangKeluar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFilterText.ResumeLayout(false);
            this.panelFilterText.PerformLayout();
            this.panelFilterKategori.ResumeLayout(false);
            this.panelFilterTanggal.ResumeLayout(false);
            this.panelFilterTanggal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSimpanBK;
        private System.Windows.Forms.Button btResetBK;
        private System.Windows.Forms.Button btHapusBK;
        private System.Windows.Forms.Button btEditBK;
        private System.Windows.Forms.DateTimePicker dtBK;
        private System.Windows.Forms.TextBox txtJumlahBK;
        private System.Windows.Forms.ComboBox cbBarangBK;
        private System.Windows.Forms.ComboBox cbKategoriBK;
        private System.Windows.Forms.TextBox txtKodeBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataBK;
        private System.Windows.Forms.TextBox txtPIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFilterText;
        private System.Windows.Forms.Button btCariText;
        private System.Windows.Forms.TextBox txtFilterBarang;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panelFilterKategori;
        private System.Windows.Forms.ComboBox cbFilterKategori;
        private System.Windows.Forms.Panel panelFilterTanggal;
        private System.Windows.Forms.Button btCariTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}