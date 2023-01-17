namespace InventoriApp_Karanglewas
{
    partial class FormPassword
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
            this.txtPassBaru = new System.Windows.Forms.TextBox();
            this.txtPassLama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSimpanPassword = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassBaru
            // 
            this.txtPassBaru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPassBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassBaru.Location = new System.Drawing.Point(146, 84);
            this.txtPassBaru.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassBaru.Name = "txtPassBaru";
            this.txtPassBaru.Size = new System.Drawing.Size(132, 20);
            this.txtPassBaru.TabIndex = 19;
            this.txtPassBaru.UseSystemPasswordChar = true;
            // 
            // txtPassLama
            // 
            this.txtPassLama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPassLama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassLama.Location = new System.Drawing.Point(146, 50);
            this.txtPassLama.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassLama.Name = "txtPassLama";
            this.txtPassLama.Size = new System.Drawing.Size(132, 20);
            this.txtPassLama.TabIndex = 18;
            this.txtPassLama.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(48, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password Baru";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(47, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password Lama";
            // 
            // btSimpanPassword
            // 
            this.btSimpanPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSimpanPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSimpanPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSimpanPassword.FlatAppearance.BorderSize = 0;
            this.btSimpanPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimpanPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btSimpanPassword.Location = new System.Drawing.Point(203, 130);
            this.btSimpanPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btSimpanPassword.Name = "btSimpanPassword";
            this.btSimpanPassword.Size = new System.Drawing.Size(74, 28);
            this.btSimpanPassword.TabIndex = 20;
            this.btSimpanPassword.Text = "Simpan";
            this.btSimpanPassword.UseVisualStyleBackColor = false;
            this.btSimpanPassword.Click += new System.EventHandler(this.btSimpanPassword_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 19);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username: ";
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(326, 198);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btSimpanPassword);
            this.Controls.Add(this.txtPassBaru);
            this.Controls.Add(this.txtPassLama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassBaru;
        private System.Windows.Forms.TextBox txtPassLama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSimpanPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}