﻿namespace InventoriApp_Karanglewas
{
    partial class FormAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btUbah = new System.Windows.Forms.Button();
            this.btEditAdmin = new System.Windows.Forms.Button();
            this.btHapusAdmin = new System.Windows.Forms.Button();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.txtNamaAdmin = new System.Windows.Forms.TextBox();
            this.txtUsernameAdmin = new System.Windows.Forms.TextBox();
            this.btSimpanAdmin = new System.Windows.Forms.Button();
            this.btResetAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.btUbah);
            this.panel2.Controls.Add(this.btEditAdmin);
            this.panel2.Controls.Add(this.btHapusAdmin);
            this.panel2.Controls.Add(this.txtPasswordAdmin);
            this.panel2.Controls.Add(this.txtNamaAdmin);
            this.panel2.Controls.Add(this.txtUsernameAdmin);
            this.panel2.Controls.Add(this.btSimpanAdmin);
            this.panel2.Controls.Add(this.btResetAdmin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 207);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btUbah
            // 
            this.btUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btUbah.BackColor = System.Drawing.Color.Magenta;
            this.btUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUbah.FlatAppearance.BorderSize = 0;
            this.btUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btUbah.Location = new System.Drawing.Point(556, 98);
            this.btUbah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(175, 34);
            this.btUbah.TabIndex = 19;
            this.btUbah.Text = "Ubah Password";
            this.btUbah.UseVisualStyleBackColor = false;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btEditAdmin
            // 
            this.btEditAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEditAdmin.BackColor = System.Drawing.Color.Khaki;
            this.btEditAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditAdmin.FlatAppearance.BorderSize = 0;
            this.btEditAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btEditAdmin.Location = new System.Drawing.Point(408, 150);
            this.btEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditAdmin.Name = "btEditAdmin";
            this.btEditAdmin.Size = new System.Drawing.Size(75, 34);
            this.btEditAdmin.TabIndex = 18;
            this.btEditAdmin.Text = "Edit";
            this.btEditAdmin.UseVisualStyleBackColor = false;
            this.btEditAdmin.Click += new System.EventHandler(this.btEditAdmin_Click);
            // 
            // btHapusAdmin
            // 
            this.btHapusAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btHapusAdmin.BackColor = System.Drawing.Color.Tomato;
            this.btHapusAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHapusAdmin.FlatAppearance.BorderSize = 0;
            this.btHapusAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHapusAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btHapusAdmin.Location = new System.Drawing.Point(488, 150);
            this.btHapusAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHapusAdmin.Name = "btHapusAdmin";
            this.btHapusAdmin.Size = new System.Drawing.Size(75, 34);
            this.btHapusAdmin.TabIndex = 17;
            this.btHapusAdmin.Text = "Hapus";
            this.btHapusAdmin.UseVisualStyleBackColor = false;
            this.btHapusAdmin.Click += new System.EventHandler(this.btHapusAdmin_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAdmin.Location = new System.Drawing.Point(556, 66);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.Size = new System.Drawing.Size(175, 22);
            this.txtPasswordAdmin.TabIndex = 16;
            // 
            // txtNamaAdmin
            // 
            this.txtNamaAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNamaAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaAdmin.Location = new System.Drawing.Point(133, 110);
            this.txtNamaAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaAdmin.Name = "txtNamaAdmin";
            this.txtNamaAdmin.Size = new System.Drawing.Size(175, 22);
            this.txtNamaAdmin.TabIndex = 15;
            this.txtNamaAdmin.TextChanged += new System.EventHandler(this.txtNamaAdmin_TextChanged);
            // 
            // txtUsernameAdmin
            // 
            this.txtUsernameAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameAdmin.Location = new System.Drawing.Point(133, 66);
            this.txtUsernameAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernameAdmin.Name = "txtUsernameAdmin";
            this.txtUsernameAdmin.Size = new System.Drawing.Size(175, 22);
            this.txtUsernameAdmin.TabIndex = 14;
            this.txtUsernameAdmin.TextChanged += new System.EventHandler(this.txtUsernameAdmin_TextChanged);
            // 
            // btSimpanAdmin
            // 
            this.btSimpanAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSimpanAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSimpanAdmin.FlatAppearance.BorderSize = 0;
            this.btSimpanAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimpanAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btSimpanAdmin.Location = new System.Drawing.Point(649, 150);
            this.btSimpanAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanAdmin.Name = "btSimpanAdmin";
            this.btSimpanAdmin.Size = new System.Drawing.Size(83, 34);
            this.btSimpanAdmin.TabIndex = 12;
            this.btSimpanAdmin.Text = "Simpan";
            this.btSimpanAdmin.UseVisualStyleBackColor = false;
            this.btSimpanAdmin.Click += new System.EventHandler(this.btSimpanAdmin_Click);
            // 
            // btResetAdmin
            // 
            this.btResetAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btResetAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.btResetAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResetAdmin.FlatAppearance.BorderSize = 0;
            this.btResetAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btResetAdmin.Location = new System.Drawing.Point(569, 150);
            this.btResetAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetAdmin.Name = "btResetAdmin";
            this.btResetAdmin.Size = new System.Drawing.Size(75, 34);
            this.btResetAdmin.TabIndex = 11;
            this.btResetAdmin.Text = "Reset";
            this.btResetAdmin.UseVisualStyleBackColor = false;
            this.btResetAdmin.Click += new System.EventHandler(this.btResetAdmin_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(443, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmin.GridColor = System.Drawing.Color.White;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 214);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(787, 562);
            this.dgvAdmin.TabIndex = 6;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSimpanAdmin;
        private System.Windows.Forms.Button btResetAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameAdmin;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.TextBox txtNamaAdmin;
        private System.Windows.Forms.Button btHapusAdmin;
        private System.Windows.Forms.Button btEditAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btUbah;
    }
}