namespace ShopAI
{
    partial class YoneticiForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSiparisler = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSiparisDurumuGuncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxSiparisDurumu = new System.Windows.Forms.ComboBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.tabUrunEkle = new System.Windows.Forms.TabPage();
            this.rtxtYeniUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvYeniUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.nupStok = new System.Windows.Forms.NumericUpDown();
            this.txtYeniUrunFiyati = new System.Windows.Forms.TextBox();
            this.cboxYeniUrunKategori = new System.Windows.Forms.ComboBox();
            this.tabUrunYonetimi = new System.Windows.Forms.TabPage();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.rtxtGuncelleUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.txtGuncelleUrunAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.nupGuncelleUrunStok = new System.Windows.Forms.NumericUpDown();
            this.txtGuncelleUrunFiyat = new System.Windows.Forms.TextBox();
            this.cboxUurnYonetimKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.tabUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeniUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).BeginInit();
            this.tabUrunYonetimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupGuncelleUrunStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSiparisler);
            this.tabControl1.Controls.Add(this.tabUrunEkle);
            this.tabControl1.Controls.Add(this.tabUrunYonetimi);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1462, 715);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSiparisler
            // 
            this.tabSiparisler.Controls.Add(this.label14);
            this.tabSiparisler.Controls.Add(this.btnSiparisDurumuGuncelle);
            this.tabSiparisler.Controls.Add(this.label13);
            this.tabSiparisler.Controls.Add(this.cboxSiparisDurumu);
            this.tabSiparisler.Controls.Add(this.dgvSiparisler);
            this.tabSiparisler.Location = new System.Drawing.Point(4, 25);
            this.tabSiparisler.Name = "tabSiparisler";
            this.tabSiparisler.Padding = new System.Windows.Forms.Padding(3);
            this.tabSiparisler.Size = new System.Drawing.Size(1454, 686);
            this.tabSiparisler.TabIndex = 0;
            this.tabSiparisler.Text = "Siparişler";
            this.tabSiparisler.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DarkViolet;
            this.label14.Location = new System.Drawing.Point(607, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 29);
            this.label14.TabIndex = 4;
            this.label14.Text = "SİPARİŞLER";
            // 
            // btnSiparisDurumuGuncelle
            // 
            this.btnSiparisDurumuGuncelle.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSiparisDurumuGuncelle.Location = new System.Drawing.Point(573, 615);
            this.btnSiparisDurumuGuncelle.Name = "btnSiparisDurumuGuncelle";
            this.btnSiparisDurumuGuncelle.Size = new System.Drawing.Size(295, 46);
            this.btnSiparisDurumuGuncelle.TabIndex = 3;
            this.btnSiparisDurumuGuncelle.Text = "Güncelle";
            this.btnSiparisDurumuGuncelle.UseVisualStyleBackColor = false;
            this.btnSiparisDurumuGuncelle.Click += new System.EventHandler(this.btnSiparisDurumuGuncelle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(36, 622);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sipariş Durumu :";
            // 
            // cboxSiparisDurumu
            // 
            this.cboxSiparisDurumu.FormattingEnabled = true;
            this.cboxSiparisDurumu.Location = new System.Drawing.Point(185, 622);
            this.cboxSiparisDurumu.Name = "cboxSiparisDurumu";
            this.cboxSiparisDurumu.Size = new System.Drawing.Size(313, 24);
            this.cboxSiparisDurumu.TabIndex = 1;
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(6, 49);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 51;
            this.dgvSiparisler.RowTemplate.Height = 24;
            this.dgvSiparisler.Size = new System.Drawing.Size(1442, 525);
            this.dgvSiparisler.TabIndex = 0;
            // 
            // tabUrunEkle
            // 
            this.tabUrunEkle.Controls.Add(this.rtxtYeniUrunAciklama);
            this.tabUrunEkle.Controls.Add(this.txtYeniUrunAdi);
            this.tabUrunEkle.Controls.Add(this.label6);
            this.tabUrunEkle.Controls.Add(this.label5);
            this.tabUrunEkle.Controls.Add(this.label4);
            this.tabUrunEkle.Controls.Add(this.label2);
            this.tabUrunEkle.Controls.Add(this.label3);
            this.tabUrunEkle.Controls.Add(this.dgvYeniUrunler);
            this.tabUrunEkle.Controls.Add(this.label1);
            this.tabUrunEkle.Controls.Add(this.btnYeniUrunEkle);
            this.tabUrunEkle.Controls.Add(this.nupStok);
            this.tabUrunEkle.Controls.Add(this.txtYeniUrunFiyati);
            this.tabUrunEkle.Controls.Add(this.cboxYeniUrunKategori);
            this.tabUrunEkle.Location = new System.Drawing.Point(4, 25);
            this.tabUrunEkle.Name = "tabUrunEkle";
            this.tabUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunEkle.Size = new System.Drawing.Size(1454, 686);
            this.tabUrunEkle.TabIndex = 1;
            this.tabUrunEkle.Text = "Ürün Ekle";
            this.tabUrunEkle.UseVisualStyleBackColor = true;
            // 
            // rtxtYeniUrunAciklama
            // 
            this.rtxtYeniUrunAciklama.Location = new System.Drawing.Point(1130, 277);
            this.rtxtYeniUrunAciklama.Name = "rtxtYeniUrunAciklama";
            this.rtxtYeniUrunAciklama.Size = new System.Drawing.Size(290, 84);
            this.rtxtYeniUrunAciklama.TabIndex = 3;
            this.rtxtYeniUrunAciklama.Text = "";
            // 
            // txtYeniUrunAdi
            // 
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(1130, 143);
            this.txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(292, 22);
            this.txtYeniUrunAdi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1048, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1072, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1036, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1043, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1023, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori Adı : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvYeniUrunler
            // 
            this.dgvYeniUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeniUrunler.Location = new System.Drawing.Point(8, 50);
            this.dgvYeniUrunler.Name = "dgvYeniUrunler";
            this.dgvYeniUrunler.RowHeadersWidth = 51;
            this.dgvYeniUrunler.RowTemplate.Height = 24;
            this.dgvYeniUrunler.Size = new System.Drawing.Size(979, 587);
            this.dgvYeniUrunler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(509, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜRÜN EKLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnYeniUrunEkle.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btnYeniUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(1132, 478);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(290, 66);
            this.btnYeniUrunEkle.TabIndex = 5;
            this.btnYeniUrunEkle.Text = "Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = false;
            this.btnYeniUrunEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // nupStok
            // 
            this.nupStok.Location = new System.Drawing.Point(1132, 414);
            this.nupStok.Name = "nupStok";
            this.nupStok.Size = new System.Drawing.Size(288, 22);
            this.nupStok.TabIndex = 4;
            // 
            // txtYeniUrunFiyati
            // 
            this.txtYeniUrunFiyati.Location = new System.Drawing.Point(1130, 203);
            this.txtYeniUrunFiyati.Name = "txtYeniUrunFiyati";
            this.txtYeniUrunFiyati.Size = new System.Drawing.Size(292, 22);
            this.txtYeniUrunFiyati.TabIndex = 2;
            // 
            // cboxYeniUrunKategori
            // 
            this.cboxYeniUrunKategori.FormattingEnabled = true;
            this.cboxYeniUrunKategori.Location = new System.Drawing.Point(1132, 80);
            this.cboxYeniUrunKategori.Name = "cboxYeniUrunKategori";
            this.cboxYeniUrunKategori.Size = new System.Drawing.Size(290, 24);
            this.cboxYeniUrunKategori.TabIndex = 0;
            // 
            // tabUrunYonetimi
            // 
            this.tabUrunYonetimi.Controls.Add(this.btnUrunSil);
            this.tabUrunYonetimi.Controls.Add(this.rtxtGuncelleUrunAciklama);
            this.tabUrunYonetimi.Controls.Add(this.txtGuncelleUrunAdi);
            this.tabUrunYonetimi.Controls.Add(this.label7);
            this.tabUrunYonetimi.Controls.Add(this.label9);
            this.tabUrunYonetimi.Controls.Add(this.label10);
            this.tabUrunYonetimi.Controls.Add(this.label11);
            this.tabUrunYonetimi.Controls.Add(this.label12);
            this.tabUrunYonetimi.Controls.Add(this.btnUrunGuncelle);
            this.tabUrunYonetimi.Controls.Add(this.nupGuncelleUrunStok);
            this.tabUrunYonetimi.Controls.Add(this.txtGuncelleUrunFiyat);
            this.tabUrunYonetimi.Controls.Add(this.cboxUurnYonetimKategoriAdi);
            this.tabUrunYonetimi.Controls.Add(this.label8);
            this.tabUrunYonetimi.Controls.Add(this.dgvUrunler);
            this.tabUrunYonetimi.Location = new System.Drawing.Point(4, 25);
            this.tabUrunYonetimi.Name = "tabUrunYonetimi";
            this.tabUrunYonetimi.Size = new System.Drawing.Size(1454, 686);
            this.tabUrunYonetimi.TabIndex = 2;
            this.tabUrunYonetimi.Text = "Ürün Yönetimi";
            this.tabUrunYonetimi.UseVisualStyleBackColor = true;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.LightGreen;
            this.btnUrunSil.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(1145, 549);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(290, 48);
            this.btnUrunSil.TabIndex = 7;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // rtxtGuncelleUrunAciklama
            // 
            this.rtxtGuncelleUrunAciklama.Location = new System.Drawing.Point(1145, 276);
            this.rtxtGuncelleUrunAciklama.Name = "rtxtGuncelleUrunAciklama";
            this.rtxtGuncelleUrunAciklama.Size = new System.Drawing.Size(290, 84);
            this.rtxtGuncelleUrunAciklama.TabIndex = 4;
            this.rtxtGuncelleUrunAciklama.Text = "";
            // 
            // txtGuncelleUrunAdi
            // 
            this.txtGuncelleUrunAdi.Location = new System.Drawing.Point(1145, 142);
            this.txtGuncelleUrunAdi.Name = "txtGuncelleUrunAdi";
            this.txtGuncelleUrunAdi.Size = new System.Drawing.Size(292, 22);
            this.txtGuncelleUrunAdi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1063, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ürün Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1087, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Stok :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1051, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ürün Fiyatı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1058, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Açıklama :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1038, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Kategori Adı : ";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btnUrunGuncelle.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(1148, 477);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(290, 48);
            this.btnUrunGuncelle.TabIndex = 6;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // nupGuncelleUrunStok
            // 
            this.nupGuncelleUrunStok.Location = new System.Drawing.Point(1147, 413);
            this.nupGuncelleUrunStok.Name = "nupGuncelleUrunStok";
            this.nupGuncelleUrunStok.Size = new System.Drawing.Size(288, 22);
            this.nupGuncelleUrunStok.TabIndex = 5;
            // 
            // txtGuncelleUrunFiyat
            // 
            this.txtGuncelleUrunFiyat.Location = new System.Drawing.Point(1145, 202);
            this.txtGuncelleUrunFiyat.Name = "txtGuncelleUrunFiyat";
            this.txtGuncelleUrunFiyat.Size = new System.Drawing.Size(292, 22);
            this.txtGuncelleUrunFiyat.TabIndex = 3;
            // 
            // cboxUurnYonetimKategoriAdi
            // 
            this.cboxUurnYonetimKategoriAdi.FormattingEnabled = true;
            this.cboxUurnYonetimKategoriAdi.Location = new System.Drawing.Point(1147, 79);
            this.cboxUurnYonetimKategoriAdi.Name = "cboxUurnYonetimKategoriAdi";
            this.cboxUurnYonetimKategoriAdi.Size = new System.Drawing.Size(290, 24);
            this.cboxUurnYonetimKategoriAdi.TabIndex = 1;
            this.cboxUurnYonetimKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cboxUurnYonetimKategoriAdi_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(602, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "ÜRÜN YÖNETİMİ";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(3, 61);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(1028, 578);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 715);
            this.Controls.Add(this.tabControl1);
            this.Name = "YoneticiForm";
            this.Text = "YoneticiForm";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSiparisler.ResumeLayout(false);
            this.tabSiparisler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.tabUrunEkle.ResumeLayout(false);
            this.tabUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeniUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).EndInit();
            this.tabUrunYonetimi.ResumeLayout(false);
            this.tabUrunYonetimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupGuncelleUrunStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSiparisler;
        private System.Windows.Forms.TabPage tabUrunEkle;
        private System.Windows.Forms.TabPage tabUrunYonetimi;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.DataGridView dgvYeniUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.RichTextBox rtxtYeniUrunAciklama;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.NumericUpDown nupStok;
        private System.Windows.Forms.TextBox txtYeniUrunFiyati;
        private System.Windows.Forms.ComboBox cboxYeniUrunKategori;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.RichTextBox rtxtGuncelleUrunAciklama;
        private System.Windows.Forms.TextBox txtGuncelleUrunAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.NumericUpDown nupGuncelleUrunStok;
        private System.Windows.Forms.TextBox txtGuncelleUrunFiyat;
        private System.Windows.Forms.ComboBox cboxUurnYonetimKategoriAdi;
        private System.Windows.Forms.Button btnSiparisDurumuGuncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboxSiparisDurumu;
    }
}