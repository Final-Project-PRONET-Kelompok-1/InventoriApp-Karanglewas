namespace InventoriApp_Karanglewas
{
    partial class Form_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new FontAwesome.Sharp.IconButton();
            this.btMasuk = new System.Windows.Forms.Button();
            this.icon2 = new FontAwesome.Sharp.IconButton();
            this.icon1 = new FontAwesome.Sharp.IconButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btMasuk);
            this.panel1.Controls.Add(this.icon2);
            this.panel1.Controls.Add(this.icon1);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(492, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 398);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(130, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASUK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(144, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lupa password?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btClose.IconColor = System.Drawing.Color.White;
            this.btClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClose.IconSize = 25;
            this.btClose.Location = new System.Drawing.Point(277, 2);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(28, 23);
            this.btClose.TabIndex = 6;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMasuk
            // 
            this.btMasuk.BackColor = System.Drawing.Color.Crimson;
            this.btMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMasuk.FlatAppearance.BorderSize = 0;
            this.btMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasuk.ForeColor = System.Drawing.Color.White;
            this.btMasuk.Location = new System.Drawing.Point(160, 222);
            this.btMasuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMasuk.Name = "btMasuk";
            this.btMasuk.Size = new System.Drawing.Size(91, 27);
            this.btMasuk.TabIndex = 5;
            this.btMasuk.Text = "Masuk";
            this.btMasuk.UseVisualStyleBackColor = false;
            this.btMasuk.Click += new System.EventHandler(this.btMasuk_Click);
            // 
            // icon2
            // 
            this.icon2.FlatAppearance.BorderSize = 0;
            this.icon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icon2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.icon2.IconColor = System.Drawing.Color.White;
            this.icon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon2.IconSize = 25;
            this.icon2.Location = new System.Drawing.Point(75, 185);
            this.icon2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(28, 23);
            this.icon2.TabIndex = 4;
            this.icon2.UseVisualStyleBackColor = true;
            // 
            // icon1
            // 
            this.icon1.FlatAppearance.BorderSize = 0;
            this.icon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icon1.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            this.icon1.IconColor = System.Drawing.Color.White;
            this.icon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon1.IconSize = 25;
            this.icon1.Location = new System.Drawing.Point(75, 142);
            this.icon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(28, 23);
            this.icon1.TabIndex = 3;
            this.icon1.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Location = new System.Drawing.Point(117, 185);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(133, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(117, 142);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(133, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 398);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 260);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(493, 118);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "INOVASI, INTEGRITAS, TRANSPARAN";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 180);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Schadow BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(197, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "KARANGLEWAS";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Schadow BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(197, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "KECAMATAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::InventoriApp_Karanglewas.Gambar.logo_Banyumas;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 80);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btMasuk;
        private FontAwesome.Sharp.IconButton icon2;
        private FontAwesome.Sharp.IconButton icon1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btClose;
        private System.Windows.Forms.Label label5;
    }
}

