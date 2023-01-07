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
            this.btSimpanBK = new System.Windows.Forms.Button();
            this.btResetBK = new System.Windows.Forms.Button();
            this.btHapusBK = new System.Windows.Forms.Button();
            this.btEditBK = new System.Windows.Forms.Button();
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
            this.dataSO.Location = new System.Drawing.Point(15, 213);
            this.dataSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSO.Name = "dataSO";
            this.dataSO.RowHeadersWidth = 51;
            this.dataSO.RowTemplate.Height = 24;
            this.dataSO.Size = new System.Drawing.Size(825, 327);
            this.dataSO.TabIndex = 6;
            // 
            // txtPIC
            // 
            this.txtPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIC.Location = new System.Drawing.Point(497, 113);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(171, 22);
            this.txtPIC.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "PIC";
            // 
            // btSimpanBK
            // 
            this.btSimpanBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanBK.Location = new System.Drawing.Point(696, 153);
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
            this.btResetBK.Location = new System.Drawing.Point(603, 153);
            this.btResetBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetBK.Name = "btResetBK";
            this.btResetBK.Size = new System.Drawing.Size(75, 34);
            this.btResetBK.TabIndex = 11;
            this.btResetBK.Text = "Reset";
            this.btResetBK.UseVisualStyleBackColor = true;
            // 
            // btHapusBK
            // 
            this.btHapusBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btHapusBK.Location = new System.Drawing.Point(512, 153);
            this.btHapusBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusBK.Name = "btHapusBK";
            this.btHapusBK.Size = new System.Drawing.Size(75, 34);
            this.btHapusBK.TabIndex = 10;
            this.btHapusBK.Text = "Hapus";
            this.btHapusBK.UseVisualStyleBackColor = true;
            // 
            // btEditBK
            // 
            this.btEditBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEditBK.Location = new System.Drawing.Point(425, 154);
            this.btEditBK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditBK.Name = "btEditBK";
            this.btEditBK.Size = new System.Drawing.Size(75, 32);
            this.btEditBK.TabIndex = 9;
            this.btEditBK.Text = "Edit";
            this.btEditBK.UseVisualStyleBackColor = true;
            this.btEditBK.Click += new System.EventHandler(this.btEditBK_Click);
            // 
            // dtSO
            // 
            this.dtSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtSO.Location = new System.Drawing.Point(425, 42);
            this.dtSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSO.Name = "dtSO";
            this.dtSO.Size = new System.Drawing.Size(243, 22);
            this.dtSO.TabIndex = 8;
            // 
            // txtStokSistem
            // 
            this.txtStokSistem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStokSistem.Location = new System.Drawing.Point(169, 129);
            this.txtStokSistem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokSistem.Name = "txtStokSistem";
            this.txtStokSistem.Size = new System.Drawing.Size(211, 22);
            this.txtStokSistem.TabIndex = 7;
            // 
            // cbBarangSO
            // 
            this.cbBarangSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBarangSO.FormattingEnabled = true;
            this.cbBarangSO.Location = new System.Drawing.Point(169, 98);
            this.cbBarangSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBarangSO.Name = "cbBarangSO";
            this.cbBarangSO.Size = new System.Drawing.Size(211, 24);
            this.cbBarangSO.TabIndex = 6;
            // 
            // cbKategoriSO
            // 
            this.cbKategoriSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriSO.FormattingEnabled = true;
            this.cbKategoriSO.Location = new System.Drawing.Point(169, 68);
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
            this.txtKodeSO.Location = new System.Drawing.Point(169, 38);
            this.txtKodeSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeSO.Name = "txtKodeSO";
            this.txtKodeSO.Size = new System.Drawing.Size(211, 22);
            this.txtKodeSO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Sistem";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barang";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
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
            this.panel2.Controls.Add(this.btSimpanBK);
            this.panel2.Controls.Add(this.btResetBK);
            this.panel2.Controls.Add(this.btHapusBK);
            this.panel2.Controls.Add(this.btEditBK);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 207);
            this.panel2.TabIndex = 7;
            // 
            // txtStokFisik
            // 
            this.txtStokFisik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStokFisik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStokFisik.Location = new System.Drawing.Point(497, 75);
            this.txtStokFisik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokFisik.Name = "txtStokFisik";
            this.txtStokFisik.Size = new System.Drawing.Size(171, 22);
            this.txtStokFisik.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stok Fisik";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tanggal";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.dataSO);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btSimpanBK;
        private System.Windows.Forms.Button btResetBK;
        private System.Windows.Forms.Button btHapusBK;
        private System.Windows.Forms.Button btEditBK;
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