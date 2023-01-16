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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSimpanKategori = new System.Windows.Forms.Button();
            this.btEditKategori = new System.Windows.Forms.Button();
            this.txtKodeKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCari = new System.Windows.Forms.Button();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.btHapusKategori = new System.Windows.Forms.Button();
            this.btResetKategori = new System.Windows.Forms.Button();
            this.txtNamaKategori = new System.Windows.Forms.TextBox();
            this.dataKategori = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // btSimpanKategori
            // 
            this.btSimpanKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSimpanKategori.Location = new System.Drawing.Point(402, 20);
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
            this.btEditKategori.Location = new System.Drawing.Point(496, 22);
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
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kategori";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
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
            this.panel2.Controls.Add(this.btHapusKategori);
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
            this.panel2.Size = new System.Drawing.Size(811, 135);
            this.panel2.TabIndex = 5;
            // 
            // btCari
            // 
            this.btCari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCari.Location = new System.Drawing.Point(191, 102);
            this.btCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(75, 31);
            this.btCari.TabIndex = 21;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // txtFilterText
            // 
            this.txtFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtFilterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterText.Location = new System.Drawing.Point(10, 109);
            this.txtFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(175, 22);
            this.txtFilterText.TabIndex = 20;
            this.txtFilterText.TextChanged += new System.EventHandler(this.txtFilterText_TextChanged);
            // 
            // btHapusKategori
            // 
            this.btHapusKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHapusKategori.Location = new System.Drawing.Point(496, 64);
            this.btHapusKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusKategori.Name = "btHapusKategori";
            this.btHapusKategori.Size = new System.Drawing.Size(79, 31);
            this.btHapusKategori.TabIndex = 15;
            this.btHapusKategori.Text = "Hapus";
            this.btHapusKategori.UseVisualStyleBackColor = true;
            this.btHapusKategori.Click += new System.EventHandler(this.btHapusKategori_Click);
            // 
            // btResetKategori
            // 
            this.btResetKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetKategori.Location = new System.Drawing.Point(402, 64);
            this.btResetKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetKategori.Name = "btResetKategori";
            this.btResetKategori.Size = new System.Drawing.Size(79, 31);
            this.btResetKategori.TabIndex = 14;
            this.btResetKategori.Text = "Reset";
            this.btResetKategori.UseVisualStyleBackColor = true;
            this.btResetKategori.Click += new System.EventHandler(this.btResetKategori_Click);
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNamaKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaKategori.Location = new System.Drawing.Point(170, 66);
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
            this.dataKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKategori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataKategori.BackgroundColor = System.Drawing.Color.White;
            this.dataKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKategori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKategori.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataKategori.Location = new System.Drawing.Point(11, 142);
            this.dataKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataKategori.Name = "dataKategori";
            this.dataKategori.RowHeadersWidth = 51;
            this.dataKategori.RowTemplate.Height = 24;
            this.dataKategori.Size = new System.Drawing.Size(786, 644);
            this.dataKategori.TabIndex = 4;
            this.dataKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKategori_CellContentClick);
            // 
            // listKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataKategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btHapusKategori;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.TextBox txtFilterText;
    }
}