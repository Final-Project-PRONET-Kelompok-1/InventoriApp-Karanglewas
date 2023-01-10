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
            this.dtRiwayat = new System.Windows.Forms.DateTimePicker();
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
            this.dataRiwayat.Location = new System.Drawing.Point(1, 48);
            this.dataRiwayat.Name = "dataRiwayat";
            this.dataRiwayat.Size = new System.Drawing.Size(809, 409);
            this.dataRiwayat.TabIndex = 0;
            this.dataRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRiwayat_CellContentClick);
            // 
            // dtRiwayat
            // 
            this.dtRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtRiwayat.Location = new System.Drawing.Point(575, 11);
            this.dtRiwayat.Margin = new System.Windows.Forms.Padding(2);
            this.dtRiwayat.Name = "dtRiwayat";
            this.dtRiwayat.Size = new System.Drawing.Size(183, 20);
            this.dtRiwayat.TabIndex = 9;
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtRiwayat);
            this.Controls.Add(this.dataRiwayat);
            this.Name = "FormRiwayat";
            this.Text = "FormRiwayat";
            this.Load += new System.EventHandler(this.FormRiwayat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRiwayat;
        private System.Windows.Forms.DateTimePicker dtRiwayat;
    }
}