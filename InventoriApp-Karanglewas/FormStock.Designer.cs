namespace InventoriApp_Karanglewas
{
    partial class FormStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSO = new System.Windows.Forms.DataGridView();
            this.txtPIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSimpanSO = new System.Windows.Forms.Button();
            this.btResetSO = new System.Windows.Forms.Button();
            this.btHapusSO = new System.Windows.Forms.Button();
            this.btEditSO = new System.Windows.Forms.Button();
            this.dtSO = new System.Windows.Forms.DateTimePicker();
            this.txtStokSistem = new System.Windows.Forms.TextBox();
            this.cbBarangSO = new System.Windows.Forms.ComboBox();
            this.cbKategoriSO = new System.Windows.Forms.ComboBox();
            this.txtKodeSO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFilterKategori = new System.Windows.Forms.Panel();
            this.cbFilterKategori = new System.Windows.Forms.ComboBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtStokFisik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFilterText = new System.Windows.Forms.Panel();
            this.btCariText = new System.Windows.Forms.Button();
            this.txtFilterBarang = new System.Windows.Forms.TextBox();
            this.panelFilterTanggal = new System.Windows.Forms.Panel();
            this.btCariTanggal = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataSO)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelFilterKategori.SuspendLayout();
            this.panelFilterText.SuspendLayout();
            this.panelFilterTanggal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSO
            // 
            this.dataSO.AllowUserToOrderColumns = true;
            this.dataSO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSO.BackgroundColor = System.Drawing.Color.White;
            this.dataSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSO.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataSO.GridColor = System.Drawing.Color.White;
            this.dataSO.Location = new System.Drawing.Point(15, 260);
            this.dataSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSO.Name = "dataSO";
            this.dataSO.RowHeadersWidth = 51;
            this.dataSO.RowTemplate.Height = 24;
            this.dataSO.Size = new System.Drawing.Size(781, 514);
            this.dataSO.TabIndex = 6;
            this.dataSO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSO_CellContentClick_1);
            // 
            // txtPIC
            // 
            this.txtPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIC.Location = new System.Drawing.Point(507, 114);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(243, 22);
            this.txtPIC.TabIndex = 14;
            this.txtPIC.TextChanged += new System.EventHandler(this.txtPIC_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "PIC";
            // 
            // btSimpanSO
            // 
            this.btSimpanSO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSimpanSO.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSimpanSO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSimpanSO.FlatAppearance.BorderSize = 0;
            this.btSimpanSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimpanSO.Location = new System.Drawing.Point(675, 153);
            this.btSimpanSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanSO.Name = "btSimpanSO";
            this.btSimpanSO.Size = new System.Drawing.Size(75, 34);
            this.btSimpanSO.TabIndex = 12;
            this.btSimpanSO.Text = "Simpan";
            this.btSimpanSO.UseVisualStyleBackColor = false;
            this.btSimpanSO.Click += new System.EventHandler(this.btSimpanSO_Click);
            // 
            // btResetSO
            // 
            this.btResetSO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btResetSO.BackColor = System.Drawing.Color.CadetBlue;
            this.btResetSO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResetSO.FlatAppearance.BorderSize = 0;
            this.btResetSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetSO.Location = new System.Drawing.Point(581, 153);
            this.btResetSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetSO.Name = "btResetSO";
            this.btResetSO.Size = new System.Drawing.Size(75, 34);
            this.btResetSO.TabIndex = 11;
            this.btResetSO.Text = "Reset";
            this.btResetSO.UseVisualStyleBackColor = false;
            this.btResetSO.Click += new System.EventHandler(this.btResetSO_Click_1);
            // 
            // btHapusSO
            // 
            this.btHapusSO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btHapusSO.BackColor = System.Drawing.Color.Tomato;
            this.btHapusSO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHapusSO.FlatAppearance.BorderSize = 0;
            this.btHapusSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHapusSO.Location = new System.Drawing.Point(491, 153);
            this.btHapusSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusSO.Name = "btHapusSO";
            this.btHapusSO.Size = new System.Drawing.Size(75, 34);
            this.btHapusSO.TabIndex = 10;
            this.btHapusSO.Text = "Hapus";
            this.btHapusSO.UseVisualStyleBackColor = false;
            this.btHapusSO.Click += new System.EventHandler(this.btHapusSO_Click_1);
            // 
            // btEditSO
            // 
            this.btEditSO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEditSO.BackColor = System.Drawing.Color.Khaki;
            this.btEditSO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditSO.FlatAppearance.BorderSize = 0;
            this.btEditSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditSO.Location = new System.Drawing.Point(403, 154);
            this.btEditSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditSO.Name = "btEditSO";
            this.btEditSO.Size = new System.Drawing.Size(75, 32);
            this.btEditSO.TabIndex = 9;
            this.btEditSO.Text = "Edit";
            this.btEditSO.UseVisualStyleBackColor = false;
            this.btEditSO.Click += new System.EventHandler(this.btEditSO_Click_1);
            // 
            // dtSO
            // 
            this.dtSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtSO.Location = new System.Drawing.Point(507, 38);
            this.dtSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSO.Name = "dtSO";
            this.dtSO.Size = new System.Drawing.Size(243, 22);
            this.dtSO.TabIndex = 8;
            // 
            // txtStokSistem
            // 
            this.txtStokSistem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStokSistem.Location = new System.Drawing.Point(147, 129);
            this.txtStokSistem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokSistem.Name = "txtStokSistem";
            this.txtStokSistem.Size = new System.Drawing.Size(211, 22);
            this.txtStokSistem.TabIndex = 7;
            // 
            // cbBarangSO
            // 
            this.cbBarangSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBarangSO.FormattingEnabled = true;
            this.cbBarangSO.Location = new System.Drawing.Point(147, 98);
            this.cbBarangSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBarangSO.Name = "cbBarangSO";
            this.cbBarangSO.Size = new System.Drawing.Size(211, 24);
            this.cbBarangSO.TabIndex = 6;
            this.cbBarangSO.SelectedIndexChanged += new System.EventHandler(this.cbBarangSO_SelectedIndexChanged);
            // 
            // cbKategoriSO
            // 
            this.cbKategoriSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriSO.FormattingEnabled = true;
            this.cbKategoriSO.Location = new System.Drawing.Point(147, 68);
            this.cbKategoriSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriSO.Name = "cbKategoriSO";
            this.cbKategoriSO.Size = new System.Drawing.Size(211, 24);
            this.cbKategoriSO.TabIndex = 5;
            this.cbKategoriSO.Text = "Pilih Kategori";
            this.cbKategoriSO.SelectedIndexChanged += new System.EventHandler(this.cbKategoriSO_SelectedIndexChanged);
            // 
            // txtKodeSO
            // 
            this.txtKodeSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeSO.Location = new System.Drawing.Point(147, 38);
            this.txtKodeSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeSO.Name = "txtKodeSO";
            this.txtKodeSO.Size = new System.Drawing.Size(211, 22);
            this.txtKodeSO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Sistem";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barang";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.panelFilterKategori);
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.txtStokFisik);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPIC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btSimpanSO);
            this.panel2.Controls.Add(this.btResetSO);
            this.panel2.Controls.Add(this.btHapusSO);
            this.panel2.Controls.Add(this.btEditSO);
            this.panel2.Controls.Add(this.dtSO);
            this.panel2.Controls.Add(this.txtStokSistem);
            this.panel2.Controls.Add(this.cbBarangSO);
            this.panel2.Controls.Add(this.cbKategoriSO);
            this.panel2.Controls.Add(this.txtKodeSO);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelFilterText);
            this.panel2.Controls.Add(this.panelFilterTanggal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 254);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelFilterKategori
            // 
            this.panelFilterKategori.Controls.Add(this.cbFilterKategori);
            this.panelFilterKategori.Location = new System.Drawing.Point(200, 210);
            this.panelFilterKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterKategori.Name = "panelFilterKategori";
            this.panelFilterKategori.Size = new System.Drawing.Size(211, 39);
            this.panelFilterKategori.TabIndex = 22;
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
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Semua Data",
            "By Tanggal",
            "By Kategori",
            "By Text"});
            this.cbFilter.Location = new System.Drawing.Point(23, 210);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(160, 24);
            this.cbFilter.TabIndex = 21;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged_1);
            // 
            // txtStokFisik
            // 
            this.txtStokFisik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStokFisik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStokFisik.Location = new System.Drawing.Point(507, 76);
            this.txtStokFisik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokFisik.Name = "txtStokFisik";
            this.txtStokFisik.Size = new System.Drawing.Size(243, 22);
            this.txtStokFisik.TabIndex = 17;
            this.txtStokFisik.TextChanged += new System.EventHandler(this.txtStokFisik_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stok Fisik";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tanggal";
            // 
            // panelFilterText
            // 
            this.panelFilterText.Controls.Add(this.btCariText);
            this.panelFilterText.Controls.Add(this.txtFilterBarang);
            this.panelFilterText.Location = new System.Drawing.Point(200, 210);
            this.panelFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterText.Name = "panelFilterText";
            this.panelFilterText.Size = new System.Drawing.Size(243, 60);
            this.panelFilterText.TabIndex = 24;
            // 
            // btCariText
            // 
            this.btCariText.BackColor = System.Drawing.Color.Salmon;
            this.btCariText.FlatAppearance.BorderSize = 0;
            this.btCariText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCariText.Location = new System.Drawing.Point(192, 0);
            this.btCariText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariText.Name = "btCariText";
            this.btCariText.Size = new System.Drawing.Size(50, 25);
            this.btCariText.TabIndex = 21;
            this.btCariText.Text = "Cari";
            this.btCariText.UseVisualStyleBackColor = false;
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
            // panelFilterTanggal
            // 
            this.panelFilterTanggal.Controls.Add(this.btCariTanggal);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker2);
            this.panelFilterTanggal.Controls.Add(this.label8);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker1);
            this.panelFilterTanggal.Location = new System.Drawing.Point(200, 210);
            this.panelFilterTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterTanggal.Name = "panelFilterTanggal";
            this.panelFilterTanggal.Size = new System.Drawing.Size(583, 30);
            this.panelFilterTanggal.TabIndex = 23;
            // 
            // btCariTanggal
            // 
            this.btCariTanggal.BackColor = System.Drawing.Color.Salmon;
            this.btCariTanggal.FlatAppearance.BorderSize = 0;
            this.btCariTanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCariTanggal.Location = new System.Drawing.Point(523, -1);
            this.btCariTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariTanggal.Name = "btCariTanggal";
            this.btCariTanggal.Size = new System.Drawing.Size(57, 25);
            this.btCariTanggal.TabIndex = 19;
            this.btCariTanggal.Text = "Cari";
            this.btCariTanggal.UseVisualStyleBackColor = false;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(243, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "--";
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
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.dataSO);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFilterKategori.ResumeLayout(false);
            this.panelFilterText.ResumeLayout(false);
            this.panelFilterText.PerformLayout();
            this.panelFilterTanggal.ResumeLayout(false);
            this.panelFilterTanggal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSO;
        private System.Windows.Forms.TextBox txtPIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSimpanSO;
        private System.Windows.Forms.Button btResetSO;
        private System.Windows.Forms.Button btHapusSO;
        private System.Windows.Forms.Button btEditSO;
        private System.Windows.Forms.DateTimePicker dtSO;
        private System.Windows.Forms.TextBox txtStokSistem;
        private System.Windows.Forms.ComboBox cbBarangSO;
        private System.Windows.Forms.ComboBox cbKategoriSO;
        private System.Windows.Forms.TextBox txtKodeSO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStokFisik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panelFilterKategori;
        private System.Windows.Forms.ComboBox cbFilterKategori;
        private System.Windows.Forms.Panel panelFilterTanggal;
        private System.Windows.Forms.Button btCariTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelFilterText;
        private System.Windows.Forms.Button btCariText;
        private System.Windows.Forms.TextBox txtFilterBarang;
    }
}