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
            this.btSimpanBM = new System.Windows.Forms.Button();
            this.btEditBM = new System.Windows.Forms.Button();
            this.txtKodeBM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataBM = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBM)).BeginInit();
            this.SuspendLayout();
            // 
            // btSimpanBM
            // 
            this.btSimpanBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanBM.Location = new System.Drawing.Point(424, 61);
            this.btSimpanBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanBM.Name = "btSimpanBM";
            this.btSimpanBM.Size = new System.Drawing.Size(75, 33);
            this.btSimpanBM.TabIndex = 12;
            this.btSimpanBM.Text = "Simpan";
            this.btSimpanBM.UseVisualStyleBackColor = true;
            // 
            // btEditBM
            // 
            this.btEditBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEditBM.Location = new System.Drawing.Point(546, 62);
            this.btEditBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditBM.Name = "btEditBM";
            this.btEditBM.Size = new System.Drawing.Size(79, 31);
            this.btEditBM.TabIndex = 9;
            this.btEditBM.Text = "Edit";
            this.btEditBM.UseVisualStyleBackColor = true;
            // 
            // txtKodeBM
            // 
            this.txtKodeBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKodeBM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeBM.Location = new System.Drawing.Point(170, 28);
            this.txtKodeBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeBM.Name = "txtKodeBM";
            this.txtKodeBM.Size = new System.Drawing.Size(175, 22);
            this.txtKodeBM.TabIndex = 11;
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
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btSimpanBM);
            this.panel2.Controls.Add(this.btEditBM);
            this.panel2.Controls.Add(this.txtKodeBM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 206);
            this.panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(170, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 13;
            // 
            // dataBM
            // 
            this.dataBM.AllowUserToOrderColumns = true;
            this.dataBM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBM.BackgroundColor = System.Drawing.Color.White;
            this.dataBM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBM.Location = new System.Drawing.Point(-23, 67);
            this.dataBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBM.Name = "dataBM";
            this.dataBM.RowHeadersWidth = 51;
            this.dataBM.RowTemplate.Height = 24;
            this.dataBM.Size = new System.Drawing.Size(836, 718);
            this.dataBM.TabIndex = 4;
            // 
            // listKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataBM);
            this.Name = "listKategori";
            this.Text = "listKategori";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSimpanBM;
        private System.Windows.Forms.Button btEditBM;
        private System.Windows.Forms.TextBox txtKodeBM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataBM;
    }
}