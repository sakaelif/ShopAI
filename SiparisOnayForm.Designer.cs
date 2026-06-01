namespace ShopAI
{
    partial class SiparisOnayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltoplamTutarOnay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.colUrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnAnaMenuDon = new System.Windows.Forms.Button();
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(449, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞ ONAYI";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lbltoplamTutarOnay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(824, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 419);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(245, 211);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(126, 22);
            this.maskedTextBox3.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(48, 211);
            this.maskedTextBox2.Mask = "00/00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(126, 22);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(48, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siparişi Onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltoplamTutarOnay
            // 
            this.lbltoplamTutarOnay.AutoSize = true;
            this.lbltoplamTutarOnay.Location = new System.Drawing.Point(228, 267);
            this.lbltoplamTutarOnay.Name = "lbltoplamTutarOnay";
            this.lbltoplamTutarOnay.Size = new System.Drawing.Size(88, 16);
            this.lbltoplamTutarOnay.TabIndex = 8;
            this.lbltoplamTutarOnay.Text = "Toplam Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Toplam Tutar :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Son Kullanma Tarihi ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(48, 126);
            this.maskedTextBox1.Mask = "0000-0000-0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(313, 22);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kart Numarası";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShopAI.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(44, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ShopAI.Properties.Resources.indir__2_;
            this.pictureBox2.Location = new System.Drawing.Point(164, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopAI.Properties.Resources.indir__3_;
            this.pictureBox1.Location = new System.Drawing.Point(270, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSepet
            // 
            this.dgvSepet.AllowUserToAddRows = false;
            this.dgvSepet.AllowUserToDeleteRows = false;
            this.dgvSepet.AllowUserToResizeColumns = false;
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUrunID,
            this.colKategori,
            this.colUrunAdi,
            this.colFiyat,
            this.colAdet,
            this.colToplamTutar,
            this.colSil});
            this.dgvSepet.Location = new System.Drawing.Point(12, 108);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.ReadOnly = true;
            this.dgvSepet.RowHeadersWidth = 51;
            this.dgvSepet.RowTemplate.Height = 24;
            this.dgvSepet.Size = new System.Drawing.Size(796, 408);
            this.dgvSepet.TabIndex = 11;
            this.dgvSepet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellClick);
            this.dgvSepet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellContentClick);
            this.dgvSepet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellDoubleClick);
            // 
            // colUrunID
            // 
            this.colUrunID.HeaderText = "UrunID";
            this.colUrunID.MinimumWidth = 6;
            this.colUrunID.Name = "colUrunID";
            this.colUrunID.ReadOnly = true;
            this.colUrunID.Visible = false;
            this.colUrunID.Width = 125;
            // 
            // colKategori
            // 
            this.colKategori.HeaderText = "Kategori";
            this.colKategori.MinimumWidth = 6;
            this.colKategori.Name = "colKategori";
            this.colKategori.ReadOnly = true;
            this.colKategori.Width = 125;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.MinimumWidth = 6;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 125;
            // 
            // colFiyat
            // 
            this.colFiyat.HeaderText = "Fiyat";
            this.colFiyat.MinimumWidth = 6;
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.ReadOnly = true;
            this.colFiyat.Width = 125;
            // 
            // colAdet
            // 
            this.colAdet.HeaderText = "Adet";
            this.colAdet.MinimumWidth = 6;
            this.colAdet.Name = "colAdet";
            this.colAdet.ReadOnly = true;
            this.colAdet.Width = 125;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.HeaderText = "Toplam Tutar";
            this.colToplamTutar.MinimumWidth = 6;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.ReadOnly = true;
            this.colToplamTutar.Width = 125;
            // 
            // colSil
            // 
            this.colSil.HeaderText = "Sil";
            this.colSil.MinimumWidth = 6;
            this.colSil.Name = "colSil";
            this.colSil.ReadOnly = true;
            this.colSil.Width = 125;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCikisYap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCikisYap.Location = new System.Drawing.Point(1069, 537);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(207, 57);
            this.btnCikisYap.TabIndex = 3;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnAnaMenuDon
            // 
            this.btnAnaMenuDon.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAnaMenuDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAnaMenuDon.Location = new System.Drawing.Point(822, 537);
            this.btnAnaMenuDon.Name = "btnAnaMenuDon";
            this.btnAnaMenuDon.Size = new System.Drawing.Size(210, 57);
            this.btnAnaMenuDon.TabIndex = 2;
            this.btnAnaMenuDon.Text = "Ana Menüye Dön";
            this.btnAnaMenuDon.UseVisualStyleBackColor = false;
            this.btnAnaMenuDon.Click += new System.EventHandler(this.btnAnaMenuDon_Click);
            // 
            // btnSiparislerim
            // 
            this.btnSiparislerim.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSiparislerim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSiparislerim.Location = new System.Drawing.Point(1200, 21);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(129, 43);
            this.btnSiparislerim.TabIndex = 12;
            this.btnSiparislerim.Text = "Siparişlerim";
            this.btnSiparislerim.UseVisualStyleBackColor = false;
            this.btnSiparislerim.Click += new System.EventHandler(this.btnSiparislerim_Click);
            // 
            // SiparisOnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopAI.Properties.Resources.SiparisOnayForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 642);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.btnAnaMenuDon);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "SiparisOnayForm";
            this.Text = "Siparişini Tamamla ";
            this.Load += new System.EventHandler(this.SiparisOnayForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltoplamTutarOnay;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnAnaMenuDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSil;
        private System.Windows.Forms.Button btnSiparislerim;
    }
}