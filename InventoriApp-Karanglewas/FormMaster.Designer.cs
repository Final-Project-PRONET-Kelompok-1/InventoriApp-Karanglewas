namespace InventoriApp_Karanglewas
{
    partial class FormMaster
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKeluar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnLaporan = new FontAwesome.Sharp.IconButton();
            this.btnStockOpname = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRiwayat = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBarangKeluar = new FontAwesome.Sharp.IconButton();
            this.btnBarangMasuk = new FontAwesome.Sharp.IconButton();
            this.btDataBarang = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 107);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "KECAMATAN \r\nKARANGLEWAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Image = global::InventoriApp_Karanglewas.Gambar.logo_Banyumas;
            this.logo.Location = new System.Drawing.Point(0, 9);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(81, 87);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.panelSidebar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(183, 609);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.panelSidebar.Controls.Add(this.label5);
            this.panelSidebar.Controls.Add(this.btnKeluar);
            this.panelSidebar.Controls.Add(this.label4);
            this.panelSidebar.Controls.Add(this.btnAdmin);
            this.panelSidebar.Controls.Add(this.btnLaporan);
            this.panelSidebar.Controls.Add(this.btnStockOpname);
            this.panelSidebar.Controls.Add(this.label3);
            this.panelSidebar.Controls.Add(this.btnRiwayat);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnBarangKeluar);
            this.panelSidebar.Controls.Add(this.btnBarangMasuk);
            this.panelSidebar.Controls.Add(this.btDataBarang);
            this.panelSidebar.Location = new System.Drawing.Point(0, 112);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(183, 497);
            this.panelSidebar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(68, 473);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Purwokerto";
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKeluar.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnKeluar.IconColor = System.Drawing.Color.LightGray;
            this.btnKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKeluar.IconSize = 52;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(0, 322);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnKeluar.Size = new System.Drawing.Size(183, 46);
            this.btnKeluar.TabIndex = 7;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(30, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Universitas Amikom";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdmin.IconColor = System.Drawing.Color.LightGray;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 52;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 276);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnAdmin.Size = new System.Drawing.Size(183, 46);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLaporan.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnLaporan.IconColor = System.Drawing.Color.LightGray;
            this.btnLaporan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLaporan.IconSize = 52;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(0, 230);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnLaporan.Size = new System.Drawing.Size(183, 46);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnStockOpname
            // 
            this.btnStockOpname.BackColor = System.Drawing.Color.Transparent;
            this.btnStockOpname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockOpname.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockOpname.FlatAppearance.BorderSize = 0;
            this.btnStockOpname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockOpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOpname.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStockOpname.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnStockOpname.IconColor = System.Drawing.Color.LightGray;
            this.btnStockOpname.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStockOpname.IconSize = 52;
            this.btnStockOpname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockOpname.Location = new System.Drawing.Point(0, 184);
            this.btnStockOpname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStockOpname.Name = "btnStockOpname";
            this.btnStockOpname.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnStockOpname.Size = new System.Drawing.Size(183, 46);
            this.btnStockOpname.TabIndex = 4;
            this.btnStockOpname.Text = "Stock Opname";
            this.btnStockOpname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockOpname.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockOpname.UseVisualStyleBackColor = false;
            this.btnStockOpname.Click += new System.EventHandler(this.btnStockOpname_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(64, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supported by";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.Transparent;
            this.btnRiwayat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRiwayat.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnRiwayat.IconColor = System.Drawing.Color.LightGray;
            this.btnRiwayat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRiwayat.IconSize = 52;
            this.btnRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.Location = new System.Drawing.Point(0, 138);
            this.btnRiwayat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnRiwayat.Size = new System.Drawing.Size(183, 46);
            this.btnRiwayat.TabIndex = 3;
            this.btnRiwayat.Text = "Riwayat";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::InventoriApp_Karanglewas.Gambar.Logo_Amikom__2_;
            this.pictureBox1.Location = new System.Drawing.Point(129, 448);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarangKeluar
            // 
            this.btnBarangKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnBarangKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBarangKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarangKeluar.FlatAppearance.BorderSize = 0;
            this.btnBarangKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarangKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarangKeluar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBarangKeluar.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btnBarangKeluar.IconColor = System.Drawing.Color.LightGray;
            this.btnBarangKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBarangKeluar.IconSize = 52;
            this.btnBarangKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarangKeluar.Location = new System.Drawing.Point(0, 92);
            this.btnBarangKeluar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBarangKeluar.Name = "btnBarangKeluar";
            this.btnBarangKeluar.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnBarangKeluar.Size = new System.Drawing.Size(183, 46);
            this.btnBarangKeluar.TabIndex = 2;
            this.btnBarangKeluar.Text = "Barang Keluar";
            this.btnBarangKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarangKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarangKeluar.UseVisualStyleBackColor = false;
            this.btnBarangKeluar.Click += new System.EventHandler(this.btnBarangKeluar_Click);
            // 
            // btnBarangMasuk
            // 
            this.btnBarangMasuk.BackColor = System.Drawing.Color.Transparent;
            this.btnBarangMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBarangMasuk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarangMasuk.FlatAppearance.BorderSize = 0;
            this.btnBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarangMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarangMasuk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBarangMasuk.IconChar = FontAwesome.Sharp.IconChar.Indent;
            this.btnBarangMasuk.IconColor = System.Drawing.Color.LightGray;
            this.btnBarangMasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBarangMasuk.IconSize = 52;
            this.btnBarangMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarangMasuk.Location = new System.Drawing.Point(0, 46);
            this.btnBarangMasuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBarangMasuk.Name = "btnBarangMasuk";
            this.btnBarangMasuk.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnBarangMasuk.Size = new System.Drawing.Size(183, 46);
            this.btnBarangMasuk.TabIndex = 1;
            this.btnBarangMasuk.Text = "Barang Masuk";
            this.btnBarangMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarangMasuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarangMasuk.UseVisualStyleBackColor = false;
            this.btnBarangMasuk.Click += new System.EventHandler(this.btnBarangMasuk_Click);
            // 
            // btDataBarang
            // 
            this.btDataBarang.BackColor = System.Drawing.Color.Transparent;
            this.btDataBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDataBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDataBarang.FlatAppearance.BorderSize = 0;
            this.btDataBarang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btDataBarang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDataBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataBarang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDataBarang.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btDataBarang.IconColor = System.Drawing.Color.LightGray;
            this.btDataBarang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDataBarang.IconSize = 52;
            this.btDataBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDataBarang.Location = new System.Drawing.Point(0, 0);
            this.btDataBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDataBarang.Name = "btDataBarang";
            this.btDataBarang.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btDataBarang.Size = new System.Drawing.Size(183, 46);
            this.btDataBarang.TabIndex = 0;
            this.btDataBarang.Text = "Data Barang";
            this.btDataBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDataBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDataBarang.UseVisualStyleBackColor = false;
            this.btDataBarang.Click += new System.EventHandler(this.btDataBarang_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblChildForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 37);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 379);
            this.panel3.TabIndex = 3;
            // 
            // lblChildForm
            // 
            this.lblChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.ForeColor = System.Drawing.Color.White;
            this.lblChildForm.Location = new System.Drawing.Point(147, 7);
            this.lblChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(340, 23);
            this.lblChildForm.TabIndex = 0;
            this.lblChildForm.Text = "INVENTARIS KECAMATAN KARANGLEWAS";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(183, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(627, 609);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 609);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(814, 597);
            this.Name = "FormMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaster";
            this.Load += new System.EventHandler(this.FormMaster_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btDataBarang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelSidebar;
        private FontAwesome.Sharp.IconButton btnKeluar;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnLaporan;
        private FontAwesome.Sharp.IconButton btnStockOpname;
        private FontAwesome.Sharp.IconButton btnRiwayat;
        private FontAwesome.Sharp.IconButton btnBarangKeluar;
        private FontAwesome.Sharp.IconButton btnBarangMasuk;
    }
}