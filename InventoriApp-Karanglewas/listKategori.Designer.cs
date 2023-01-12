namespace InventoriApp_Karanglewas
{
    partial class listKategori
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
            this.btSimpanKategori = new System.Windows.Forms.Button();
            this.btEditKategori = new System.Windows.Forms.Button();
            this.txtKodeKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNamaKategori = new System.Windows.Forms.TextBox();
            this.dataKategori = new System.Windows.Forms.DataGridView();
            this.btResetKategori = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // btSimpanKategori
            // 
            this.btSimpanKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSimpanKategori.Location = new System.Drawing.Point(403, 20);
            this.btSimpanKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanKategori.Name = "btSimpanKategori";
            this.btSimpanKategori.Size = new System.Drawing.Size(75, 33);
            this.btSimpanKategori.TabIndex = 12;
            this.btSimpanKategori.Text = "Simpan";
            this.btSimpanKategori.UseVisualStyleBackColor = true;
            this.btSimpanKategori.Click += new System.EventHandler(this.btSimpanKategori_Click);
            // 
            // btEditKategori
            // 
            this.btEditKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditKategori.Location = new System.Drawing.Point(403, 62);
            this.btEditKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditKategori.Name = "btEditKategori";
            this.btEditKategori.Size = new System.Drawing.Size(79, 31);
            this.btEditKategori.TabIndex = 9;
            this.btEditKategori.Text = "Edit";
            this.btEditKategori.UseVisualStyleBackColor = true;
            this.btEditKategori.Click += new System.EventHandler(this.btEditKategori_Click);
            // 
            // txtKodeKategori
            // 
            this.txtKodeKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeKategori.Location = new System.Drawing.Point(170, 28);
            this.txtKodeKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeKategori.Name = "txtKodeKategori";
            this.txtKodeKategori.Size = new System.Drawing.Size(175, 22);
            this.txtKodeKategori.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btResetKategori);
            this.panel2.Controls.Add(this.txtNamaKategori);
            this.panel2.Controls.Add(this.btSimpanKategori);
            this.panel2.Controls.Add(this.btEditKategori);
            this.panel2.Controls.Add(this.txtKodeKategori);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 136);
            this.panel2.TabIndex = 5;
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNamaKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaKategori.Location = new System.Drawing.Point(170, 67);
            this.txtNamaKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaKategori.Name = "txtNamaKategori";
            this.txtNamaKategori.Size = new System.Drawing.Size(175, 22);
            this.txtNamaKategori.TabIndex = 13;
            // 
            // dataKategori
            // 
            this.dataKategori.AllowUserToOrderColumns = true;
            this.dataKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataKategori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataKategori.BackgroundColor = System.Drawing.Color.White;
            this.dataKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKategori.Location = new System.Drawing.Point(10, 142);
            this.dataKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataKategori.Name = "dataKategori";
            this.dataKategori.RowHeadersWidth = 51;
            this.dataKategori.RowTemplate.Height = 24;
            this.dataKategori.Size = new System.Drawing.Size(801, 493);
            this.dataKategori.TabIndex = 4;
            this.dataKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKategori_CellContentClick);
            // 
            // btResetKategori
            // 
            this.btResetKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetKategori.Location = new System.Drawing.Point(497, 62);
            this.btResetKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetKategori.Name = "btResetKategori";
            this.btResetKategori.Size = new System.Drawing.Size(79, 31);
            this.btResetKategori.TabIndex = 14;
            this.btResetKategori.Text = "Reset";
            this.btResetKategori.UseVisualStyleBackColor = true;
            this.btResetKategori.Click += new System.EventHandler(this.btResetKategori_Click);
            // 
            // listKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataKategori);
            this.Name = "listKategori";
            this.Text = "listKategori";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSimpanKategori;
        private System.Windows.Forms.Button btEditKategori;
        private System.Windows.Forms.TextBox txtKodeKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNamaKategori;
        private System.Windows.Forms.DataGridView dataKategori;
        private System.Windows.Forms.Button btResetKategori;
    }
}