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
            ((System.ComponentModel.ISupportInitialize)(this.dataBK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 168);
            this.panel2.TabIndex = 5;
            // 
            // txtPIC
            // 
            this.txtPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIC.Location = new System.Drawing.Point(418, 69);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(158, 20);
            this.txtPIC.TabIndex = 14;
            this.txtPIC.TextChanged += new System.EventHandler(this.txtPIC_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PIC";
            // 
            // btSimpanBK
            // 
            this.btSimpanBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanBK.Location = new System.Drawing.Point(520, 106);
            this.btSimpanBK.Margin = new System.Windows.Forms.Padding(2);
            this.btSimpanBK.Name = "btSimpanBK";
            this.btSimpanBK.Size = new System.Drawing.Size(56, 28);
            this.btSimpanBK.TabIndex = 12;
            this.btSimpanBK.Text = "Simpan";
            this.btSimpanBK.UseVisualStyleBackColor = true;
            this.btSimpanBK.Click += new System.EventHandler(this.btSimpanBK_Click);
            // 
            // btResetBK
            // 
            this.btResetBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btResetBK.Location = new System.Drawing.Point(450, 106);
            this.btResetBK.Margin = new System.Windows.Forms.Padding(2);
            this.btResetBK.Name = "btResetBK";
            this.btResetBK.Size = new System.Drawing.Size(56, 28);
            this.btResetBK.TabIndex = 11;
            this.btResetBK.Text = "Reset";
            this.btResetBK.UseVisualStyleBackColor = true;
            this.btResetBK.Click += new System.EventHandler(this.btResetBK_Click);
            // 
            // btHapusBK
            // 
            this.btHapusBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btHapusBK.Location = new System.Drawing.Point(382, 106);
            this.btHapusBK.Margin = new System.Windows.Forms.Padding(2);
            this.btHapusBK.Name = "btHapusBK";
            this.btHapusBK.Size = new System.Drawing.Size(56, 28);
            this.btHapusBK.TabIndex = 10;
            this.btHapusBK.Text = "Hapus";
            this.btHapusBK.UseVisualStyleBackColor = true;
            this.btHapusBK.Click += new System.EventHandler(this.btHapusBK_Click);
            // 
            // btEditBK
            // 
            this.btEditBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEditBK.Location = new System.Drawing.Point(317, 107);
            this.btEditBK.Margin = new System.Windows.Forms.Padding(2);
            this.btEditBK.Name = "btEditBK";
            this.btEditBK.Size = new System.Drawing.Size(56, 26);
            this.btEditBK.TabIndex = 9;
            this.btEditBK.Text = "Edit";
            this.btEditBK.UseVisualStyleBackColor = true;
            this.btEditBK.Click += new System.EventHandler(this.btEditBK_Click);
            // 
            // dtBK
            // 
            this.dtBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtBK.Location = new System.Drawing.Point(393, 35);
            this.dtBK.Margin = new System.Windows.Forms.Padding(2);
            this.dtBK.Name = "dtBK";
            this.dtBK.Size = new System.Drawing.Size(183, 20);
            this.dtBK.TabIndex = 8;
            // 
            // txtJumlahBK
            // 
            this.txtJumlahBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtJumlahBK.Location = new System.Drawing.Point(125, 109);
            this.txtJumlahBK.Margin = new System.Windows.Forms.Padding(2);
            this.txtJumlahBK.Name = "txtJumlahBK";
            this.txtJumlahBK.Size = new System.Drawing.Size(159, 20);
            this.txtJumlahBK.TabIndex = 7;
            this.txtJumlahBK.TextChanged += new System.EventHandler(this.txtJumlahBK_TextChanged);
            // 
            // cbBarangBK
            // 
            this.cbBarangBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBarangBK.FormattingEnabled = true;
            this.cbBarangBK.Location = new System.Drawing.Point(125, 84);
            this.cbBarangBK.Margin = new System.Windows.Forms.Padding(2);
            this.cbBarangBK.Name = "cbBarangBK";
            this.cbBarangBK.Size = new System.Drawing.Size(159, 21);
            this.cbBarangBK.TabIndex = 6;
            // 
            // cbKategoriBK
            // 
            this.cbKategoriBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBK.FormattingEnabled = true;
            this.cbKategoriBK.Location = new System.Drawing.Point(125, 59);
            this.cbKategoriBK.Margin = new System.Windows.Forms.Padding(2);
            this.cbKategoriBK.Name = "cbKategoriBK";
            this.cbKategoriBK.Size = new System.Drawing.Size(159, 21);
            this.cbKategoriBK.TabIndex = 5;
            this.cbKategoriBK.SelectedIndexChanged += new System.EventHandler(this.cbKategoriBK_SelectedIndexChanged);
            // 
            // txtKodeBK
            // 
            this.txtKodeBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeBK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeBK.Location = new System.Drawing.Point(126, 35);
            this.txtKodeBK.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeBK.Name = "txtKodeBK";
            this.txtKodeBK.Size = new System.Drawing.Size(158, 20);
            this.txtKodeBK.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 86);
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
            this.label2.Location = new System.Drawing.Point(50, 59);
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
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // dataBK
            // 
            this.dataBK.AllowUserToOrderColumns = true;
            this.dataBK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBK.BackgroundColor = System.Drawing.Color.White;
            this.dataBK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBK.Location = new System.Drawing.Point(11, 173);
            this.dataBK.Margin = new System.Windows.Forms.Padding(2);
            this.dataBK.Name = "dataBK";
            this.dataBK.RowHeadersWidth = 51;
            this.dataBK.RowTemplate.Height = 24;
            this.dataBK.Size = new System.Drawing.Size(614, 421);
            this.dataBK.TabIndex = 4;
            this.dataBK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBK_CellContentClick);
            // 
            // FormBarangKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataBK);
            this.Name = "FormBarangKeluar";
            this.Text = "FormBarangKeluar";
            this.Load += new System.EventHandler(this.FormBarangKeluar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}