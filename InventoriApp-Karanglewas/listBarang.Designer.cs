namespace InventoriApp_Karanglewas
{
    partial class listBarang
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
            this.btSimpanBarang = new System.Windows.Forms.Button();
            this.btEditBarang = new System.Windows.Forms.Button();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btHapusBarang = new System.Windows.Forms.Button();
            this.btResetBarang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategoriBarang = new System.Windows.Forms.ComboBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.dataBarang = new System.Windows.Forms.DataGridView();
            this.btCari = new System.Windows.Forms.Button();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // btSimpanBarang
            // 
            this.btSimpanBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSimpanBarang.Location = new System.Drawing.Point(403, 59);
            this.btSimpanBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanBarang.Name = "btSimpanBarang";
            this.btSimpanBarang.Size = new System.Drawing.Size(75, 33);
            this.btSimpanBarang.TabIndex = 12;
            this.btSimpanBarang.Text = "Simpan";
            this.btSimpanBarang.UseVisualStyleBackColor = true;
            this.btSimpanBarang.Click += new System.EventHandler(this.btSimpanBarang_Click);
            // 
            // btEditBarang
            // 
            this.btEditBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditBarang.Location = new System.Drawing.Point(487, 61);
            this.btEditBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditBarang.Name = "btEditBarang";
            this.btEditBarang.Size = new System.Drawing.Size(75, 31);
            this.btEditBarang.TabIndex = 9;
            this.btEditBarang.Text = "Edit";
            this.btEditBarang.UseVisualStyleBackColor = true;
            this.btEditBarang.Click += new System.EventHandler(this.btEditBarang_Click);
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeBarang.Location = new System.Drawing.Point(173, 32);
            this.txtKodeBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(175, 22);
            this.txtKodeBarang.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.btCari);
            this.panel2.Controls.Add(this.txtFilterText);
            this.panel2.Controls.Add(this.btHapusBarang);
            this.panel2.Controls.Add(this.btResetBarang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbKategoriBarang);
            this.panel2.Controls.Add(this.txtNamaBarang);
            this.panel2.Controls.Add(this.btSimpanBarang);
            this.panel2.Controls.Add(this.btEditBarang);
            this.panel2.Controls.Add(this.txtKodeBarang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 173);
            this.panel2.TabIndex = 7;
            // 
            // btHapusBarang
            // 
            this.btHapusBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHapusBarang.Location = new System.Drawing.Point(487, 96);
            this.btHapusBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusBarang.Name = "btHapusBarang";
            this.btHapusBarang.Size = new System.Drawing.Size(75, 33);
            this.btHapusBarang.TabIndex = 17;
            this.btHapusBarang.Text = "Hapus";
            this.btHapusBarang.UseVisualStyleBackColor = true;
            this.btHapusBarang.Click += new System.EventHandler(this.btHapusBarang_Click);
            // 
            // btResetBarang
            // 
            this.btResetBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetBarang.Location = new System.Drawing.Point(403, 96);
            this.btResetBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetBarang.Name = "btResetBarang";
            this.btResetBarang.Size = new System.Drawing.Size(75, 31);
            this.btResetBarang.TabIndex = 16;
            this.btResetBarang.Text = "Reset";
            this.btResetBarang.UseVisualStyleBackColor = true;
            this.btResetBarang.Click += new System.EventHandler(this.btResetBarang_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kategori";
            // 
            // cbKategoriBarang
            // 
            this.cbKategoriBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBarang.FormattingEnabled = true;
            this.cbKategoriBarang.Location = new System.Drawing.Point(173, 66);
            this.cbKategoriBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriBarang.Name = "cbKategoriBarang";
            this.cbKategoriBarang.Size = new System.Drawing.Size(176, 24);
            this.cbKategoriBarang.TabIndex = 14;
            this.cbKategoriBarang.SelectedIndexChanged += new System.EventHandler(this.cbKategoriBarang_SelectedIndexChanged);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaBarang.Location = new System.Drawing.Point(173, 103);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(175, 22);
            this.txtNamaBarang.TabIndex = 13;
            // 
            // dataBarang
            // 
            this.dataBarang.AllowUserToOrderColumns = true;
            this.dataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBarang.BackgroundColor = System.Drawing.Color.White;
            this.dataBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBarang.Location = new System.Drawing.Point(12, 179);
            this.dataBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.RowHeadersWidth = 51;
            this.dataBarang.RowTemplate.Height = 24;
            this.dataBarang.Size = new System.Drawing.Size(787, 431);
            this.dataBarang.TabIndex = 6;
            this.dataBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBarang_CellContentClick);
            // 
            // btCari
            // 
            this.btCari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCari.Location = new System.Drawing.Point(192, 140);
            this.btCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(75, 31);
            this.btCari.TabIndex = 19;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // txtFilterText
            // 
            this.txtFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtFilterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterText.Location = new System.Drawing.Point(11, 147);
            this.txtFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(175, 22);
            this.txtFilterText.TabIndex = 18;
            this.txtFilterText.TextChanged += new System.EventHandler(this.txtFilterText_TextChanged);
            // 
            // listBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(811, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataBarang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "listBarang";
            this.Text = "listBarang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSimpanBarang;
        private System.Windows.Forms.Button btEditBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.DataGridView dataBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategoriBarang;
        private System.Windows.Forms.Button btResetBarang;
        private System.Windows.Forms.Button btHapusBarang;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.TextBox txtFilterText;
    }
}