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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSimpanAdmin = new System.Windows.Forms.Button();
            this.btResetAdmin = new System.Windows.Forms.Button();
            this.txtIdAdmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.txtUsernameAdmin = new System.Windows.Forms.TextBox();
            this.txtNamaAdmin = new System.Windows.Forms.TextBox();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPasswordAdmin);
            this.panel2.Controls.Add(this.txtNamaAdmin);
            this.panel2.Controls.Add(this.txtUsernameAdmin);
            this.panel2.Controls.Add(this.btSimpanAdmin);
            this.panel2.Controls.Add(this.btResetAdmin);
            this.panel2.Controls.Add(this.txtIdAdmin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 207);
            this.panel2.TabIndex = 5;
            // 
            // btSimpanAdmin
            // 
            this.btSimpanAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanAdmin.Location = new System.Drawing.Point(656, 124);
            this.btSimpanAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSimpanAdmin.Name = "btSimpanAdmin";
            this.btSimpanAdmin.Size = new System.Drawing.Size(75, 34);
            this.btSimpanAdmin.TabIndex = 12;
            this.btSimpanAdmin.Text = "Simpan";
            this.btSimpanAdmin.UseVisualStyleBackColor = true;
            // 
            // btResetAdmin
            // 
            this.btResetAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btResetAdmin.Location = new System.Drawing.Point(563, 124);
            this.btResetAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetAdmin.Name = "btResetAdmin";
            this.btResetAdmin.Size = new System.Drawing.Size(75, 34);
            this.btResetAdmin.TabIndex = 11;
            this.btResetAdmin.Text = "Reset";
            this.btResetAdmin.UseVisualStyleBackColor = true;
            // 
            // txtIdAdmin
            // 
            this.txtIdAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIdAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdAdmin.Location = new System.Drawing.Point(132, 30);
            this.txtIdAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdAdmin.Name = "txtIdAdmin";
            this.txtIdAdmin.Size = new System.Drawing.Size(175, 22);
            this.txtIdAdmin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. ID";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToOrderColumns = true;
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(11, 219);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(787, 611);
            this.dgvAdmin.TabIndex = 4;
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
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAdmin.Location = new System.Drawing.Point(556, 66);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(175, 22);
            this.txtPasswordAdmin.TabIndex = 16;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSimpanAdmin;
        private System.Windows.Forms.Button btResetAdmin;
        private System.Windows.Forms.TextBox txtIdAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.TextBox txtUsernameAdmin;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.TextBox txtNamaAdmin;
    }
}