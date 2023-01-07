namespace InventoriApp_Karanglewas
{
    partial class FormKategoriBarang
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
            this.txtKBarang = new System.Windows.Forms.TextBox();
            this.btTambahKBarang = new System.Windows.Forms.Button();
            this.cbKBarang = new System.Windows.Forms.ComboBox();
            this.txtTambahBarang = new System.Windows.Forms.TextBox();
            this.btTambahBarang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKBarang
            // 
            this.txtKBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKBarang.Location = new System.Drawing.Point(41, 72);
            this.txtKBarang.Name = "txtKBarang";
            this.txtKBarang.Size = new System.Drawing.Size(144, 22);
            this.txtKBarang.TabIndex = 0;
            // 
            // btTambahKBarang
            // 
            this.btTambahKBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btTambahKBarang.Location = new System.Drawing.Point(191, 70);
            this.btTambahKBarang.Name = "btTambahKBarang";
            this.btTambahKBarang.Size = new System.Drawing.Size(96, 31);
            this.btTambahKBarang.TabIndex = 1;
            this.btTambahKBarang.Text = "TAMBAH";
            this.btTambahKBarang.UseVisualStyleBackColor = true;
            // 
            // cbKBarang
            // 
            this.cbKBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbKBarang.FormattingEnabled = true;
            this.cbKBarang.Location = new System.Drawing.Point(494, 70);
            this.cbKBarang.Name = "cbKBarang";
            this.cbKBarang.Size = new System.Drawing.Size(153, 24);
            this.cbKBarang.TabIndex = 4;
            // 
            // txtTambahBarang
            // 
            this.txtTambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTambahBarang.Location = new System.Drawing.Point(494, 113);
            this.txtTambahBarang.Multiline = true;
            this.txtTambahBarang.Name = "txtTambahBarang";
            this.txtTambahBarang.Size = new System.Drawing.Size(153, 26);
            this.txtTambahBarang.TabIndex = 5;
            // 
            // btTambahBarang
            // 
            this.btTambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btTambahBarang.Location = new System.Drawing.Point(653, 70);
            this.btTambahBarang.Name = "btTambahBarang";
            this.btTambahBarang.Size = new System.Drawing.Size(91, 31);
            this.btTambahBarang.TabIndex = 6;
            this.btTambahBarang.Text = "TAMBAH";
            this.btTambahBarang.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(767, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormKategoriBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 205);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTambahBarang);
            this.Controls.Add(this.txtTambahBarang);
            this.Controls.Add(this.cbKBarang);
            this.Controls.Add(this.btTambahKBarang);
            this.Controls.Add(this.txtKBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKategoriBarang";
            this.Text = "FormKategoriBarang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKBarang;
        private System.Windows.Forms.Button btTambahKBarang;
        private System.Windows.Forms.ComboBox cbKBarang;
        private System.Windows.Forms.TextBox txtTambahBarang;
        private System.Windows.Forms.Button btTambahBarang;
        private System.Windows.Forms.Button button1;
    }
}