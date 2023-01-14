namespace InventoriApp_Karanglewas
{
    partial class FormRiwayat
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
            this.dataRiwayat = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnSemua = new System.Windows.Forms.Button();
            this.btnTanggal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRiwayat
            // 
            this.dataRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRiwayat.Location = new System.Drawing.Point(1, 139);
            this.dataRiwayat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataRiwayat.Name = "dataRiwayat";
            this.dataRiwayat.RowHeadersWidth = 51;
            this.dataRiwayat.Size = new System.Drawing.Size(1067, 423);
            this.dataRiwayat.TabIndex = 0;
            this.dataRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRiwayat_CellContentClick);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 32);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(477, 32);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // btnSemua
            // 
            this.btnSemua.Location = new System.Drawing.Point(19, 81);
            this.btnSemua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSemua.Name = "btnSemua";
            this.btnSemua.Size = new System.Drawing.Size(121, 28);
            this.btnSemua.TabIndex = 11;
            this.btnSemua.Text = "Semua";
            this.btnSemua.UseVisualStyleBackColor = true;
            this.btnSemua.Click += new System.EventHandler(this.btnSemua_Click);
            // 
            // btnTanggal
            // 
            this.btnTanggal.Location = new System.Drawing.Point(148, 81);
            this.btnTanggal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTanggal.Name = "btnTanggal";
            this.btnTanggal.Size = new System.Drawing.Size(127, 28);
            this.btnTanggal.TabIndex = 12;
            this.btnTanggal.Text = "Filter Tanggal";
            this.btnTanggal.UseVisualStyleBackColor = true;
            this.btnTanggal.Click += new System.EventHandler(this.btnTanggal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dari tanggal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sampai tanggal:";
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTanggal);
            this.Controls.Add(this.btnSemua);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dataRiwayat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRiwayat";
            this.Text = "FormRiwayat";
            this.Load += new System.EventHandler(this.FormRiwayat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRiwayat;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnSemua;
        private System.Windows.Forms.Button btnTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}