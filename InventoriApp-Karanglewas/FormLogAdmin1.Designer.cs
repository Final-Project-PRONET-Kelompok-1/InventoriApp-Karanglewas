﻿namespace InventoriApp_Karanglewas
{
    partial class FormLogAdmin1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFilterText = new System.Windows.Forms.Panel();
            this.btCariTextRwt = new System.Windows.Forms.Button();
            this.txtFilterRiwayat = new System.Windows.Forms.TextBox();
            this.panelFilterTanggal = new System.Windows.Forms.Panel();
            this.btCariTanggal = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbFilterRiwayat = new System.Windows.Forms.ComboBox();
            this.dataRiwayat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelFilterText.SuspendLayout();
            this.panelFilterTanggal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.panelFilterText);
            this.panel1.Controls.Add(this.panelFilterTanggal);
            this.panel1.Controls.Add(this.cbFilterRiwayat);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 254);
            this.panel1.TabIndex = 4;
            // 
            // panelFilterText
            // 
            this.panelFilterText.Controls.Add(this.btCariTextRwt);
            this.panelFilterText.Controls.Add(this.txtFilterRiwayat);
            this.panelFilterText.Location = new System.Drawing.Point(191, 11);
            this.panelFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterText.Name = "panelFilterText";
            this.panelFilterText.Size = new System.Drawing.Size(243, 39);
            this.panelFilterText.TabIndex = 21;
            // 
            // btCariTextRwt
            // 
            this.btCariTextRwt.BackColor = System.Drawing.Color.Salmon;
            this.btCariTextRwt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCariTextRwt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCariTextRwt.FlatAppearance.BorderSize = 0;
            this.btCariTextRwt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCariTextRwt.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.btCariTextRwt.Location = new System.Drawing.Point(176, 0);
            this.btCariTextRwt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariTextRwt.Name = "btCariTextRwt";
            this.btCariTextRwt.Size = new System.Drawing.Size(67, 30);
            this.btCariTextRwt.TabIndex = 21;
            this.btCariTextRwt.Text = "Cari";
            this.btCariTextRwt.UseVisualStyleBackColor = false;
            this.btCariTextRwt.Click += new System.EventHandler(this.btCariTextRwt_Click);
            // 
            // txtFilterRiwayat
            // 
            this.txtFilterRiwayat.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFilterRiwayat.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.txtFilterRiwayat.Location = new System.Drawing.Point(0, 0);
            this.txtFilterRiwayat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilterRiwayat.Name = "txtFilterRiwayat";
            this.txtFilterRiwayat.Size = new System.Drawing.Size(176, 25);
            this.txtFilterRiwayat.TabIndex = 22;
            this.txtFilterRiwayat.TextChanged += new System.EventHandler(this.txtFilterRiwayat_TextChanged);
            // 
            // panelFilterTanggal
            // 
            this.panelFilterTanggal.Controls.Add(this.btCariTanggal);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker3);
            this.panelFilterTanggal.Controls.Add(this.label6);
            this.panelFilterTanggal.Controls.Add(this.dateTimePicker2);
            this.panelFilterTanggal.Location = new System.Drawing.Point(196, 12);
            this.panelFilterTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilterTanggal.Name = "panelFilterTanggal";
            this.panelFilterTanggal.Size = new System.Drawing.Size(583, 30);
            this.panelFilterTanggal.TabIndex = 23;
            // 
            // btCariTanggal
            // 
            this.btCariTanggal.BackColor = System.Drawing.Color.Salmon;
            this.btCariTanggal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCariTanggal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCariTanggal.FlatAppearance.BorderSize = 0;
            this.btCariTanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCariTanggal.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.btCariTanggal.Location = new System.Drawing.Point(501, 0);
            this.btCariTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCariTanggal.Name = "btCariTanggal";
            this.btCariTanggal.Size = new System.Drawing.Size(82, 25);
            this.btCariTanggal.TabIndex = 19;
            this.btCariTanggal.Text = "Cari";
            this.btCariTanggal.UseVisualStyleBackColor = false;
            this.btCariTanggal.Click += new System.EventHandler(this.btCariTanggal_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker3.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.dateTimePicker3.Location = new System.Drawing.Point(258, 0);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(243, 25);
            this.dateTimePicker3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(243, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "--";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker2.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 25);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // cbFilterRiwayat
            // 
            this.cbFilterRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterRiwayat.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterRiwayat.FormattingEnabled = true;
            this.cbFilterRiwayat.Items.AddRange(new object[] {
            "Semua Data",
            "By Tanggal",
            "By Text"});
            this.cbFilterRiwayat.Location = new System.Drawing.Point(13, 12);
            this.cbFilterRiwayat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterRiwayat.Name = "cbFilterRiwayat";
            this.cbFilterRiwayat.Size = new System.Drawing.Size(160, 25);
            this.cbFilterRiwayat.TabIndex = 18;
            this.cbFilterRiwayat.SelectedIndexChanged += new System.EventHandler(this.cbFilterRiwayat_SelectedIndexChanged);
            // 
            // dataRiwayat
            // 
            this.dataRiwayat.AllowUserToOrderColumns = true;
            this.dataRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRiwayat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dataRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRiwayat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRiwayat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRiwayat.GridColor = System.Drawing.Color.White;
            this.dataRiwayat.Location = new System.Drawing.Point(19, 57);
            this.dataRiwayat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRiwayat.Name = "dataRiwayat";
            this.dataRiwayat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRiwayat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataRiwayat.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataRiwayat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataRiwayat.RowTemplate.Height = 24;
            this.dataRiwayat.Size = new System.Drawing.Size(763, 670);
            this.dataRiwayat.TabIndex = 5;
            // 
            // FormLogAdmin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataRiwayat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogAdmin1";
            this.Text = "FormLogAdmin1";
            this.panel1.ResumeLayout(false);
            this.panelFilterText.ResumeLayout(false);
            this.panelFilterText.PerformLayout();
            this.panelFilterTanggal.ResumeLayout(false);
            this.panelFilterTanggal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFilterText;
        private System.Windows.Forms.Button btCariTextRwt;
        private System.Windows.Forms.TextBox txtFilterRiwayat;
        private System.Windows.Forms.Panel panelFilterTanggal;
        private System.Windows.Forms.Button btCariTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbFilterRiwayat;
        private System.Windows.Forms.DataGridView dataRiwayat;
    }
}