namespace InventoriApp_Karanglewas
{
    partial class FormDataBarang
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
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panelFilterText.SuspendLayout();
            this.panelFilterKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.panelFilterText);
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.panelFilterKategori);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 78);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelFilterText
            // 
            this.panelFilterText.Controls.Add(this.btCariText);
            this.panelFilterText.Controls.Add(this.txtFilterBarang);
            this.panelFilterText.Location = new System.Drawing.Point(206, 28);
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
            this.btCariText.Size = new System.Drawing.Size(67, 24);
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
            "By Kategori",
            "By Text"});
            this.cbFilter.Location = new System.Drawing.Point(10, 28);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(160, 24);
            this.cbFilter.TabIndex = 22;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // panelFilterKategori
            // 
            this.panelFilterKategori.Controls.Add(this.cbFilterKategori);
            this.panelFilterKategori.Location = new System.Drawing.Point(206, 27);
            this.panelFilterKategori.Name = "panelFilterKategori";
            this.panelFilterKategori.Size = new System.Drawing.Size(210, 40);
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
            this.cbFilterKategori.SelectedIndexChanged += new System.EventHandler(this.cbFilterKategori_SelectedIndexChanged);
            // 
            // dgvDB
            // 
            this.dgvDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDB.ColumnHeadersHeight = 29;
            this.dgvDB.Location = new System.Drawing.Point(12, 74);
            this.dgvDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.RowHeadersWidth = 51;
            this.dgvDB.Size = new System.Drawing.Size(795, 778);
            this.dgvDB.TabIndex = 6;
            this.dgvDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDB_CellContentClick);
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.dgvDB);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            this.panel2.ResumeLayout(false);
            this.panelFilterText.ResumeLayout(false);
            this.panelFilterText.PerformLayout();
            this.panelFilterKategori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panelFilterKategori;
        private System.Windows.Forms.ComboBox cbFilterKategori;
        private System.Windows.Forms.Panel panelFilterText;
        private System.Windows.Forms.Button btCariText;
        private System.Windows.Forms.TextBox txtFilterBarang;
    }
}