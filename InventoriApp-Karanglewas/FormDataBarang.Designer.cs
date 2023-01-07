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
            this.cbKategoriBM = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTambah = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.txtDB = new System.Windows.Forms.TextBox();
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
            this.DBarang.Location = new System.Drawing.Point(0, 165);
            this.DBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DBarang.Name = "DBarang";
            this.DBarang.RowHeadersWidth = 51;
            this.DBarang.RowTemplate.Height = 24;
            this.DBarang.Size = new System.Drawing.Size(675, 414);
            this.DBarang.TabIndex = 4;
            // 
            // cbKategoriBM
            // 
            this.cbKategoriBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKategoriBM.Enabled = false;
            this.cbKategoriBM.FormattingEnabled = true;
            this.cbKategoriBM.Location = new System.Drawing.Point(396, 54);
            this.cbKategoriBM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKategoriBM.Name = "cbKategoriBM";
            this.cbKategoriBM.Size = new System.Drawing.Size(133, 21);
            this.cbKategoriBM.TabIndex = 5;
            this.cbKategoriBM.Text = "Kategori";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDB);
            this.panel2.Controls.Add(this.btTambah);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbKategoriBM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 168);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btTambah
            // 
            this.btTambah.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btTambah.IconColor = System.Drawing.Color.Black;
            this.btTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btTambah.Location = new System.Drawing.Point(533, 96);
            this.btTambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(75, 26);
            this.btTambah.TabIndex = 13;
            this.btTambah.Text = "TAMBAH";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(533, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvDB
            // 
            this.dgvDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDB.Location = new System.Drawing.Point(0, 168);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.RowHeadersWidth = 51;
            this.dgvDB.Size = new System.Drawing.Size(677, 278);
            this.dgvDB.TabIndex = 6;
            // 
            // txtDB
            // 
            this.txtDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDB.Location = new System.Drawing.Point(259, 56);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(118, 20);
            this.txtDB.TabIndex = 14;
            this.txtDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.dgvDB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DBarang);
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
        private System.Windows.Forms.ComboBox cbKategoriBM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDB;
        private FontAwesome.Sharp.IconButton btTambah;
        private System.Windows.Forms.TextBox txtDB;
    }
}