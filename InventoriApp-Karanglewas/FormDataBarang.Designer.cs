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
            this.DBarang = new System.Windows.Forms.DataGridView();
            this.cbKategoriSB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.btncari = new System.Windows.Forms.Button();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DBarang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // DBarang
            // 
            this.DBarang.AllowUserToOrderColumns = true;
            this.DBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DBarang.BackgroundColor = System.Drawing.Color.White;
            this.DBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBarang.Enabled = false;
            this.DBarang.Location = new System.Drawing.Point(0, 203);
            this.DBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBarang.Name = "DBarang";
            this.DBarang.RowHeadersWidth = 51;
            this.DBarang.RowTemplate.Height = 24;
            this.DBarang.Size = new System.Drawing.Size(900, 510);
            this.DBarang.TabIndex = 4;
            // 
            // cbKategoriSB
            // 
            this.cbKategoriSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriSB.FormattingEnabled = true;
            this.cbKategoriSB.Location = new System.Drawing.Point(335, 69);
            this.cbKategoriSB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriSB.Name = "cbKategoriSB";
            this.cbKategoriSB.Size = new System.Drawing.Size(176, 24);
            this.cbKategoriSB.TabIndex = 5;
            this.cbKategoriSB.SelectedIndexChanged += new System.EventHandler(this.cbKategoriSB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSB);
            this.panel2.Controls.Add(this.btncari);
            this.panel2.Controls.Add(this.cbKategoriSB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 207);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtSB
            // 
            this.txtSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSB.Location = new System.Drawing.Point(534, 69);
            this.txtSB.Margin = new System.Windows.Forms.Padding(4);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(156, 22);
            this.txtSB.TabIndex = 14;
            this.txtSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSB.TextChanged += new System.EventHandler(this.txtSB_TextChanged);
            // 
            // btncari
            // 
            this.btncari.BackColor = System.Drawing.SystemColors.Control;
            this.btncari.Location = new System.Drawing.Point(711, 59);
            this.btncari.Margin = new System.Windows.Forms.Padding(4);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(100, 42);
            this.btncari.TabIndex = 12;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // dgvDB
            // 
            this.dgvDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDB.Location = new System.Drawing.Point(0, 207);
            this.dgvDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.RowHeadersWidth = 51;
            this.dgvDB.Size = new System.Drawing.Size(903, 342);
            this.dgvDB.TabIndex = 6;
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 554);
            this.Controls.Add(this.dgvDB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DBarang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBarang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBarang;
        private System.Windows.Forms.ComboBox cbKategoriSB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.TextBox txtSB;
    }
}