namespace InventoriApp_Karanglewas
{
    partial class FormBarangMasuk
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
            this.dataBM = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSimpanBM = new System.Windows.Forms.Button();
            this.btResetBM = new System.Windows.Forms.Button();
            this.btHapusBM = new System.Windows.Forms.Button();
            this.btEditBM = new System.Windows.Forms.Button();
            this.dtBM = new System.Windows.Forms.DateTimePicker();
            this.txtJumlahBM = new System.Windows.Forms.TextBox();
            this.cbBarangBM = new System.Windows.Forms.ComboBox();
            this.cbKategoriBM = new System.Windows.Forms.ComboBox();
            this.txtKodeBM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panelFilterTanggal = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btCariTanggal = new System.Windows.Forms.Button();
            this.panelFilterKategori = new System.Windows.Forms.Panel();
            this.cbFilterKategori = new System.Windows.Forms.ComboBox();
            this.panelFilterText = new System.Windows.Forms.Panel();
            this.txtFilterBarang = new System.Windows.Forms.TextBox();
            this.btCariText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelFilterTanggal.SuspendLayout();
            this.panelFilterKategori.SuspendLayout();
            this.panelFilterText.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBM
            // 
            this.dataBM.AllowUserToOrderColumns = true;
            this.dataBM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBM.BackgroundColor = System.Drawing.Color.White;
            this.dataBM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBM.Location = new System.Drawing.Point(12, 249);
            this.dataBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBM.Name = "dataBM";
            this.dataBM.RowHeadersWidth = 51;
            this.dataBM.RowTemplate.Height = 24;
            this.dataBM.Size = new System.Drawing.Size(787, 526);
            this.dataBM.TabIndex = 2;
            this.dataBM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBM_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.txtPIC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btSimpanBM);
            this.panel2.Controls.Add(this.btResetBM);
            this.panel2.Controls.Add(this.btHapusBM);
            this.panel2.Controls.Add(this.btEditBM);
            this.panel2.Controls.Add(this.dtBM);
            this.panel2.Controls.Add(this.txtJumlahBM);
            this.panel2.Controls.Add(this.cbBarangBM);
            this.panel2.Controls.Add(this.cbKategoriBM);
            this.panel2.Controls.Add(this.txtKodeBM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelFilterText);
            this.panel2.Controls.Add(this.panelFilterKategori);
            this.panel2.Controls.Add(this.panelFilterTanggal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 243);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPIC
            // 
            this.txtPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIC.Location = new System.Drawing.Point(507, 80);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(210, 22);
            this.txtPIC.TabIndex = 16;
            this.txtPIC.TextChanged += new System.EventHandler(this.txtPIC_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "PIC";
            // 
            // btSimpanBM
            // 
            this.btSimpanBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSimpanBM.Location = new System.Drawing.Point(656, 142);
            this.btSimpanBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanBM.Name = "btSimpanBM";
            this.btSimpanBM.Size = new System.Drawing.Size(75, 34);
            this.btSimpanBM.TabIndex = 12;
            this.btSimpanBM.Text = "Simpan";
            this.btSimpanBM.UseVisualStyleBackColor = true;
            this.btSimpanBM.Click += new System.EventHandler(this.btSimpanBM_Click);
            // 
            // btResetBM
            // 
            this.btResetBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetBM.Location = new System.Drawing.Point(563, 142);
            this.btResetBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetBM.Name = "btResetBM";
            this.btResetBM.Size = new System.Drawing.Size(75, 34);
            this.btResetBM.TabIndex = 11;
            this.btResetBM.Text = "Reset";
            this.btResetBM.UseVisualStyleBackColor = true;
            this.btResetBM.Click += new System.EventHandler(this.btResetBM_Click);
            // 
            // btHapusBM
            // 
            this.btHapusBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHapusBM.Location = new System.Drawing.Point(472, 142);
            this.btHapusBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusBM.Name = "btHapusBM";
            this.btHapusBM.Size = new System.Drawing.Size(75, 34);
            this.btHapusBM.TabIndex = 10;
            this.btHapusBM.Text = "Hapus";
            this.btHapusBM.UseVisualStyleBackColor = true;
            this.btHapusBM.Click += new System.EventHandler(this.btHapusBM_Click);
            // 
            // btEditBM
            // 
            this.btEditBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditBM.Location = new System.Drawing.Point(385, 144);
            this.btEditBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditBM.Name = "btEditBM";
            this.btEditBM.Size = new System.Drawing.Size(75, 32);
            this.btEditBM.TabIndex = 9;
            this.btEditBM.Text = "Edit";
            this.btEditBM.UseVisualStyleBackColor = true;
            this.btEditBM.Click += new System.EventHandler(this.btEditBM_Click);
            // 
            // dtBM
            // 
            this.dtBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtBM.Location = new System.Drawing.Point(475, 39);
            this.dtBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBM.Name = "dtBM";
            this.dtBM.Size = new System.Drawing.Size(243, 22);
            this.dtBM.TabIndex = 8;
            // 
            // txtJumlahBM
            // 
            this.txtJumlahBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtJumlahBM.Location = new System.Drawing.Point(132, 154);
            this.txtJumlahBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlahBM.Name = "txtJumlahBM";
            this.txtJumlahBM.Size = new System.Drawing.Size(176, 22);
            this.txtJumlahBM.TabIndex = 7;
            this.txtJumlahBM.TextChanged += new System.EventHandler(this.txtJumlahBM_TextChanged);
            // 
            // cbBarangBM
            // 
            this.cbBarangBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBarangBM.FormattingEnabled = true;
            this.cbBarangBM.Location = new System.Drawing.Point(132, 114);
            this.cbBarangBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBarangBM.Name = "cbBarangBM";
            this.cbBarangBM.Size = new System.Drawing.Size(176, 24);
            this.cbBarangBM.TabIndex = 6;
            // 
            // cbKategoriBM
            // 
            this.cbKategoriBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBM.FormattingEnabled = true;
            this.cbKategoriBM.Location = new System.Drawing.Point(132, 71);
            this.cbKategoriBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriBM.Name = "cbKategoriBM";
            this.cbKategoriBM.Size = new System.Drawing.Size(176, 24);
            this.cbKategoriBM.TabIndex = 5;
            this.cbKategoriBM.SelectedIndexChanged += new System.EventHandler(this.cbKategoriBM_SelectedIndexChanged);
            // 
            // txtKodeBM
            // 
            this.txtKodeBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeBM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeBM.Location = new System.Drawing.Point(132, 30);
            this.txtKodeBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeBM.Name = "txtKodeBM";
            this.txtKodeBM.Size = new System.Drawing.Size(175, 22);
            this.txtKodeBM.TabIndex = 11;
            this.txtKodeBM.TextChanged += new System.EventHandler(this.txtKodeBM_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barang";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
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
            this.cbFilter.Location = new System.Drawing.Point(34, 201);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(160, 24);
            this.cbFilter.TabIndex = 17;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // panelFilterTanggal
            // 
            this.panelFilterTanggal.Controls.Add(this.btCariTanggal);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker2);
            this.panelFilterTanggal.Controls.Add(this.label6);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker1);
            this.panelFilterTanggal.Location = new System.Drawing.Point(216, 201);
            this.panelFilterTanggal.Name = "panelFilterTanggal";
            this.panelFilterTanggal.Size = new System.Drawing.Size(583, 29);
            this.panelFilterTanggal.TabIndex = 18;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 0);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // btCariTanggal
            // 
            this.btCariTanggal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCariTanggal.Location = new System.Drawing.Point(501, 0);
            this.btCariTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariTanggal.Name = "btCariTanggal";
            this.btCariTanggal.Size = new System.Drawing.Size(82, 24);
            this.btCariTanggal.TabIndex = 19;
            this.btCariTanggal.Text = "Cari";
            this.btCariTanggal.UseVisualStyleBackColor = true;
            this.btCariTanggal.Click += new System.EventHandler(this.btCariTanggal_Click);
            // 
            // panelFilterKategori
            // 
            this.panelFilterKategori.Controls.Add(this.cbFilterKategori);
            this.panelFilterKategori.Location = new System.Drawing.Point(216, 200);
            this.panelFilterKategori.Name = "panelFilterKategori";
            this.panelFilterKategori.Size = new System.Drawing.Size(210, 40);
            this.panelFilterKategori.TabIndex = 21;
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
            this.cbFilterKategori.SelectedIndexChanged += new System.EventHandler(this.cbFilterKategori_SelectedIndexChanged);
            // 
            // panelFilterText
            // 
            this.panelFilterText.Controls.Add(this.btCariText);
            this.panelFilterText.Controls.Add(this.txtFilterBarang);
            this.panelFilterText.Location = new System.Drawing.Point(216, 201);
            this.panelFilterText.Name = "panelFilterText";
            this.panelFilterText.Size = new System.Drawing.Size(243, 60);
            this.panelFilterText.TabIndex = 20;
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
            // btCariText
            // 
            this.btCariText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCariText.Location = new System.Drawing.Point(176, 0);
            this.btCariText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariText.Name = "btCariText";
            this.btCariText.Size = new System.Drawing.Size(67, 24);
            this.btCariText.TabIndex = 21;
            this.btCariText.Text = "Cari";
            this.btCariText.UseVisualStyleBackColor = true;
            this.btCariText.Click += new System.EventHandler(this.btCariText_Click);
            // 
            // FormBarangMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataBM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBarangMasuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarangMasuk";
            this.Load += new System.EventHandler(this.FormBarangMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFilterTanggal.ResumeLayout(false);
            this.panelFilterTanggal.PerformLayout();
            this.panelFilterKategori.ResumeLayout(false);
            this.panelFilterText.ResumeLayout(false);
            this.panelFilterText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSimpanBM;
        private System.Windows.Forms.Button btResetBM;
        private System.Windows.Forms.Button btHapusBM;
        private System.Windows.Forms.Button btEditBM;
        private System.Windows.Forms.DateTimePicker dtBM;
        private System.Windows.Forms.TextBox txtJumlahBM;
        private System.Windows.Forms.ComboBox cbBarangBM;
        private System.Windows.Forms.ComboBox cbKategoriBM;
        private System.Windows.Forms.TextBox txtKodeBM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFilterTanggal;
        private System.Windows.Forms.Button btCariTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panelFilterKategori;
        private System.Windows.Forms.ComboBox cbFilterKategori;
        private System.Windows.Forms.Panel panelFilterText;
        private System.Windows.Forms.Button btCariText;
        private System.Windows.Forms.TextBox txtFilterBarang;
    }
}