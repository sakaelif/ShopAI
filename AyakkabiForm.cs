using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShopAI.Modeller;
using ShopAI.Servisler;

namespace ShopAI
{
    public partial class AyakkabiForm : Form
    {
        private UrunServis urunServis = new UrunServis();
        private SepetServis sepetServis = new SepetServis();
        private List<Urunler> ayakkabiUrunler;

        public AyakkabiForm()
        {
            InitializeComponent();
        }

        private void AyakkabiForm_Load(object sender, EventArgs e)
        {
            AyakkabiUrunleriniYukle();
            lblAyakkabiSepetAdet.Text = sepetServis.SepetToplamCesit().ToString();
        }

        private void AyakkabiForm_Activated(object sender, EventArgs e)
        {
            AyakkabiUrunleriniYukle();
            lblAyakkabiSepetAdet.Text = sepetServis.SepetToplamCesit().ToString();
        }

        private void AyakkabiUrunleriniYukle()
        {
            flpAyakkabiUrunler.Controls.Clear();

            ayakkabiUrunler = urunServis.AyakkabiUrunleriListele();

            for (int i = 0; i < ayakkabiUrunler.Count; i++)
            {
                Panel urunKarti = AyakkabiUrunKartiOlustur(ayakkabiUrunler[i]);
                flpAyakkabiUrunler.Controls.Add(urunKarti);
            }
        }

        private Panel AyakkabiUrunKartiOlustur(Urunler urun)
        {
            Panel panel = new Panel();
            panel.Width = 230;
            panel.Height = 250;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(10);
            panel.BackColor = Color.White;

            Label lblUrunAdi = new Label();
            lblUrunAdi.Text = urun.UrunAdi;
            lblUrunAdi.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblUrunAdi.Location = new Point(10, 10);
            lblUrunAdi.Width = 200;
            lblUrunAdi.Height = 25;

            Label lblFiyat = new Label();
            lblFiyat.Text = "Fiyat: " + urun.Fiyat.ToString("0.00") + " TL";
            lblFiyat.Location = new Point(10, 40);
            lblFiyat.Width = 200;
            lblFiyat.Height = 20;

            Label lblAciklama = new Label();
            lblAciklama.Text = "Açıklama: " + urun.Aciklama;
            lblAciklama.Location = new Point(10, 65);
            lblAciklama.Width = 200;
            lblAciklama.Height = 60;

            Label lblStok = new Label();
            lblStok.Text = "Stok: " + urun.Adet.ToString();
            lblStok.Location = new Point(10, 130);
            lblStok.Width = 200;
            lblStok.Height = 20;

            Label lblAdet = new Label();
            lblAdet.Text = "Adet:";
            lblAdet.Location = new Point(10, 160);
            lblAdet.Width = 40;
            lblAdet.Height = 20;

            NumericUpDown nudAdet = new NumericUpDown();
            nudAdet.Location = new Point(60, 158);
            nudAdet.Width = 60;
            nudAdet.Minimum = 1;
            nudAdet.Value = 1;
            nudAdet.Maximum = urun.Adet > 0 ? urun.Adet : 1;

            Button btnSepeteEkle = new Button();
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.Width = 120;
            btnSepeteEkle.Height = 30;
            btnSepeteEkle.Location = new Point(10, 195);

            if (urun.Adet <= 0)
            {
                btnSepeteEkle.Enabled = false;
                btnSepeteEkle.Text = "Stok Yok";
            }

            btnSepeteEkle.Click += (sender, e) =>
            {
                SepeteEkle(urun, (int)nudAdet.Value);
            };

            panel.Controls.Add(lblUrunAdi);
            panel.Controls.Add(lblFiyat);
            panel.Controls.Add(lblAciklama);
            panel.Controls.Add(lblStok);
            panel.Controls.Add(lblAdet);
            panel.Controls.Add(nudAdet);
            panel.Controls.Add(btnSepeteEkle);

            return panel;
        }

        private void SepeteEkle(Urunler urun, int secilenAdet)
        {
            if (secilenAdet <= 0)
            {
                MessageBox.Show("Lütfen en az 1 adet seçin.");
                return;
            }

            if (secilenAdet > urun.Adet)
            {
                MessageBox.Show("Seçilen adet stoktan fazla olamaz.");
                return;
            }

            SepetUrun yeniSepetUrun = new SepetUrun();
            yeniSepetUrun.UrunID = urun.UrunID;
            yeniSepetUrun.KategoriAdi = "Ayakkabı";
            yeniSepetUrun.UrunAdi = urun.UrunAdi;
            yeniSepetUrun.Fiyat = urun.Fiyat;
            yeniSepetUrun.Adet = secilenAdet;
            yeniSepetUrun.ToplamTutar = urun.Fiyat * secilenAdet;

            sepetServis.SepetEkle(yeniSepetUrun);

            lblAyakkabiSepetAdet.Text = sepetServis.SepetToplamCesit().ToString();

            MessageBox.Show("Ürün sepete eklendi.");
        }

        private void btnSepeteGit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisOnayForm frm = new SiparisOnayForm();
            frm.ShowDialog();
            this.Show();
        }

        private void btnKategoriSecenegi_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenuForm frm = new AnaMenuForm();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAsistanaBaglan_Click(object sender, EventArgs e)
        {
            this.Hide();
            AIAsistanForm frm = new AIAsistanForm();
            frm.ShowDialog();
            this.Show();
        }
    }
}