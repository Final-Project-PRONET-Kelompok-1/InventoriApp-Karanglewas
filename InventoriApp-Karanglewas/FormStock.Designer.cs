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
            this.txtStokFisik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSO)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSO
            // 
            this.dataSO.AllowUserToOrderColumns = true;
            this.dataSO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataSO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSO.BackgroundColor = System.Drawing.Color.White;
            this.dataSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSO.Location = new System.Drawing.Point(11, 173);
            this.dataSO.Margin = new System.Windows.Forms.Padding(2);
            this.dataSO.Name = "dataSO";
            this.dataSO.RowHeadersWidth = 51;
            this.dataSO.RowTemplate.Height = 24;
            this.dataSO.Size = new System.Drawing.Size(619, 266);
            this.dataSO.TabIndex = 6;
            this.dataSO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSO_CellContentClick_1);
            // 
            // txtPIC
            // 
            this.txtPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIC.Location = new System.Drawing.Point(373, 92);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(129, 20);
            this.txtPIC.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PIC";
            // 
            // btSimpanSO
            // 
            this.btSimpanSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanSO.Location = new System.Drawing.Point(522, 124);
            this.btSimpanSO.Margin = new System.Windows.Forms.Padding(2);
            this.btSimpanSO.Name = "btSimpanSO";
            this.btSimpanSO.Size = new System.Drawing.Size(56, 28);
            this.btSimpanSO.TabIndex = 12;
            this.btSimpanSO.Text = "Simpan";
            this.btSimpanSO.UseVisualStyleBackColor = true;
            this.btSimpanSO.Click += new System.EventHandler(this.btSimpanSO_Click);
            // 
            // btResetSO
            // 
            this.btResetSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btResetSO.Location = new System.Drawing.Point(452, 124);
            this.btResetSO.Margin = new System.Windows.Forms.Padding(2);
            this.btResetSO.Name = "btResetSO";
            this.btResetSO.Size = new System.Drawing.Size(56, 28);
            this.btResetSO.TabIndex = 11;
            this.btResetSO.Text = "Reset";
            this.btResetSO.UseVisualStyleBackColor = true;
            this.btResetSO.Click += new System.EventHandler(this.btResetSO_Click_1);
            // 
            // btHapusSO
            // 
            this.btHapusSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btHapusSO.Location = new System.Drawing.Point(384, 124);
            this.btHapusSO.Margin = new System.Windows.Forms.Padding(2);
            this.btHapusSO.Name = "btHapusSO";
            this.btHapusSO.Size = new System.Drawing.Size(56, 28);
            this.btHapusSO.TabIndex = 10;
            this.btHapusSO.Text = "Hapus";
            this.btHapusSO.UseVisualStyleBackColor = true;
            this.btHapusSO.Click += new System.EventHandler(this.btHapusSO_Click_1);
            // 
            // btEditSO
            // 
            this.btEditSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEditSO.Location = new System.Drawing.Point(319, 125);
            this.btEditSO.Margin = new System.Windows.Forms.Padding(2);
            this.btEditSO.Name = "btEditSO";
            this.btEditSO.Size = new System.Drawing.Size(56, 26);
            this.btEditSO.TabIndex = 9;
            this.btEditSO.Text = "Edit";
            this.btEditSO.UseVisualStyleBackColor = true;
            this.btEditSO.Click += new System.EventHandler(this.btEditSO_Click_1);
            // 
            // dtSO
            // 
            this.dtSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtSO.Location = new System.Drawing.Point(319, 34);
            this.dtSO.Margin = new System.Windows.Forms.Padding(2);
            this.dtSO.Name = "dtSO";
            this.dtSO.Size = new System.Drawing.Size(183, 20);
            this.dtSO.TabIndex = 8;
            // 
            // txtStokSistem
            // 
            this.txtStokSistem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStokSistem.Location = new System.Drawing.Point(127, 105);
            this.txtStokSistem.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokSistem.Name = "txtStokSistem";
            this.txtStokSistem.Size = new System.Drawing.Size(159, 20);
            this.txtStokSistem.TabIndex = 7;
            // 
            // cbBarangSO
            // 
            this.cbBarangSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBarangSO.FormattingEnabled = true;
            this.cbBarangSO.Location = new System.Drawing.Point(127, 80);
            this.cbBarangSO.Margin = new System.Windows.Forms.Padding(2);
            this.cbBarangSO.Name = "cbBarangSO";
            this.cbBarangSO.Size = new System.Drawing.Size(159, 21);
            this.cbBarangSO.TabIndex = 6;
            this.cbBarangSO.SelectedIndexChanged += new System.EventHandler(this.cbBarangSO_SelectedIndexChanged);
            // 
            // cbKategoriSO
            // 
            this.cbKategoriSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriSO.FormattingEnabled = true;
            this.cbKategoriSO.Location = new System.Drawing.Point(127, 55);
            this.cbKategoriSO.Margin = new System.Windows.Forms.Padding(2);
            this.cbKategoriSO.Name = "cbKategoriSO";
            this.cbKategoriSO.Size = new System.Drawing.Size(159, 21);
            this.cbKategoriSO.TabIndex = 5;
            this.cbKategoriSO.Text = "Pilih Kategori";
            this.cbKategoriSO.SelectedIndexChanged += new System.EventHandler(this.cbKategoriSO_SelectedIndexChanged);
            // 
            // txtKodeSO
            // 
            this.txtKodeSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeSO.Location = new System.Drawing.Point(127, 31);
            this.txtKodeSO.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeSO.Name = "txtKodeSO";
            this.txtKodeSO.Size = new System.Drawing.Size(159, 20);
            this.txtKodeSO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Sistem";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barang";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // panel2
            // 
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 168);
            this.panel2.TabIndex = 7;
            // 
            // txtStokFisik
            // 
            this.txtStokFisik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStokFisik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStokFisik.Location = new System.Drawing.Point(373, 61);
            this.txtStokFisik.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokFisik.Name = "txtStokFisik";
            this.txtStokFisik.Size = new System.Drawing.Size(129, 20);
            this.txtStokFisik.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stok Fisik";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tanggal";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.dataSO);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}