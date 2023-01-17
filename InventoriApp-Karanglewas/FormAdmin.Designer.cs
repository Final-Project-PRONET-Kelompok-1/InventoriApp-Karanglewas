namespace InventoriApp_Karanglewas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 168);
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
            this.btUbah.Location = new System.Drawing.Point(474, 80);
            this.btUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(74, 28);
            this.btUbah.TabIndex = 19;
            this.btUbah.Text = "Ubah";
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
            this.btEditAdmin.Location = new System.Drawing.Point(306, 122);
            this.btEditAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btEditAdmin.Name = "btEditAdmin";
            this.btEditAdmin.Size = new System.Drawing.Size(56, 28);
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
            this.btHapusAdmin.Location = new System.Drawing.Point(366, 122);
            this.btHapusAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btHapusAdmin.Name = "btHapusAdmin";
            this.btHapusAdmin.Size = new System.Drawing.Size(56, 28);
            this.btHapusAdmin.TabIndex = 17;
            this.btHapusAdmin.Text = "Hapus";
            this.btHapusAdmin.UseVisualStyleBackColor = false;
            this.btHapusAdmin.Click += new System.EventHandler(this.btHapusAdmin_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAdmin.Location = new System.Drawing.Point(417, 54);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtPasswordAdmin.TabIndex = 16;
            // 
            // txtNamaAdmin
            // 
            this.txtNamaAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNamaAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaAdmin.Location = new System.Drawing.Point(100, 89);
            this.txtNamaAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaAdmin.Name = "txtNamaAdmin";
            this.txtNamaAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtNamaAdmin.TabIndex = 15;
            this.txtNamaAdmin.TextChanged += new System.EventHandler(this.txtNamaAdmin_TextChanged);
            // 
            // txtUsernameAdmin
            // 
            this.txtUsernameAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameAdmin.Location = new System.Drawing.Point(100, 54);
            this.txtUsernameAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsernameAdmin.Name = "txtUsernameAdmin";
            this.txtUsernameAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtUsernameAdmin.TabIndex = 14;
            // 
            // btSimpanAdmin
            // 
            this.btSimpanAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSimpanAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSimpanAdmin.FlatAppearance.BorderSize = 0;
            this.btSimpanAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimpanAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btSimpanAdmin.Location = new System.Drawing.Point(487, 122);
            this.btSimpanAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btSimpanAdmin.Name = "btSimpanAdmin";
            this.btSimpanAdmin.Size = new System.Drawing.Size(62, 28);
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
            this.btResetAdmin.Location = new System.Drawing.Point(427, 122);
            this.btResetAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btResetAdmin.Name = "btResetAdmin";
            this.btResetAdmin.Size = new System.Drawing.Size(56, 28);
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
            this.label4.Location = new System.Drawing.Point(332, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdmin.GridColor = System.Drawing.Color.White;
            this.dgvAdmin.Location = new System.Drawing.Point(9, 174);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(590, 457);
            this.dgvAdmin.TabIndex = 6;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(608, 640);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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