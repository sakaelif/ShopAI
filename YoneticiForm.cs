using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAI.Modeller;
using ShopAI.Servisler;

namespace ShopAI
{
    public partial class YoneticiForm : Form
    {

        private SiparisServis siparisServis = new SiparisServis();
        private UrunServis urunServis = new UrunServis();
        public string MusteriAdiSoyadi { get; set; }

        private int secilenUrunID = 0;
        public YoneticiForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboxYeniUrunKategori.Text == "")
            {
                MessageBox.Show("Lütfen kategori seçiniz.");
                return;
            }

            if (txtYeniUrunAdi.Text == "")
            {
                MessageBox.Show("Ürün adı boş bırakılamaz.");
                return;
            }

            if (txtYeniUrunFiyati.Text == "")
            {
                MessageBox.Show("Ürün fiyatı boş bırakılamaz.");
                return;
            }

            if (rtxtYeniUrunAciklama.Text == "")
            {
                MessageBox.Show("Açıklama boş bırakılamaz.");
                return;
            }

            decimal fiyat;
            if (!decimal.TryParse(txtYeniUrunFiyati.Text, out fiyat))
            {
                MessageBox.Show("Ürün fiyatı sayısal olmalıdır.");
                return;
            }

            Urunler urun = new Urunler();
            urun.UrunAdi = txtYeniUrunAdi.Text;
            urun.Fiyat = fiyat;
            urun.Aciklama = rtxtYeniUrunAciklama.Text;
            urun.Adet = (int)nupStok.Value;

            bool eklendiMi = urunServis.UrunEkle(urun, cboxYeniUrunKategori.Text);

            if (eklendiMi)
            {
                MessageBox.Show("Ürün başarıyla eklendi.");

                txtYeniUrunAdi.Clear();
                txtYeniUrunFiyati.Clear();
                rtxtYeniUrunAciklama.Clear();
                nupStok.Value = 0;

                YeniUrunleriYukle();
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi.");
            }
        }

        private void YeniUrunleriYukle()
        {
            string seciliKategori = cboxYeniUrunKategori.Text;

            dgvYeniUrunler.AutoGenerateColumns = true;
            dgvYeniUrunler.DataSource = null;
            dgvYeniUrunler.DataSource = urunServis.KategoriyeGoreUrunleriGetir(seciliKategori);
        }


        private void YoneticiForm_Load(object sender, EventArgs e)
        {
           
            cboxSiparisDurumu.Items.Clear();
            cboxSiparisDurumu.Items.Add("Hazırlanıyor");
            cboxSiparisDurumu.Items.Add("Kargoya Verildi");
            cboxSiparisDurumu.Items.Add("Teslim Edildi");
            cboxSiparisDurumu.Items.Add("İptal Edildi");
            cboxSiparisDurumu.SelectedIndex = 0;

            SiparisleriYukle();


            cboxYeniUrunKategori.Items.Clear();
            cboxYeniUrunKategori.Items.Add("Elektronik");
            cboxYeniUrunKategori.Items.Add("Giyim");
            cboxYeniUrunKategori.Items.Add("Ayakkabı");
            cboxYeniUrunKategori.Items.Add("Ev Yaşam");
            cboxYeniUrunKategori.SelectedIndex = 0;

            YeniUrunleriYukle();


            cboxUurnYonetimKategoriAdi.Items.Clear();
            cboxUurnYonetimKategoriAdi.Items.Add("Elektronik");
            cboxUurnYonetimKategoriAdi.Items.Add("Giyim");
            cboxUurnYonetimKategoriAdi.Items.Add("Ayakkabı");
            cboxUurnYonetimKategoriAdi.Items.Add("Ev Yaşam");
            cboxUurnYonetimKategoriAdi.SelectedIndex = 0;

            YonetimUrunleriniYukle();

        }


        private void SiparisleriYukle()
        {
            dgvSiparisler.AutoGenerateColumns = true;
            dgvSiparisler.DataSource = null;
            dgvSiparisler.DataSource = siparisServis.SiparisleriGetir();

            if (dgvSiparisler.Columns["KullaniciID"] != null)
            {
                dgvSiparisler.Columns["KullaniciID"].Visible = false;
            }

            if (dgvSiparisler.Columns["UrunID"] != null)
            {
                dgvSiparisler.Columns["UrunID"].Visible = false;
            }

            if (dgvSiparisler.Columns["SiparisID"] != null)
            {
                dgvSiparisler.Columns["SiparisID"].HeaderText = "Sipariş No";
            }

            if (dgvSiparisler.Columns["MusteriAdiSoyadi"] != null)
            {
                dgvSiparisler.Columns["MusteriAdiSoyadi"].HeaderText = "Müşteri";
            }

            if (dgvSiparisler.Columns["KategoriAdi"] != null)
            {
                dgvSiparisler.Columns["KategoriAdi"].HeaderText = "Kategori";
            }

            if (dgvSiparisler.Columns["UrunAdi"] != null)
            {
                dgvSiparisler.Columns["UrunAdi"].HeaderText = "Ürün Adı";
            }

            if (dgvSiparisler.Columns["ToplamTutar"] != null)
            {
                dgvSiparisler.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";
                dgvSiparisler.Columns["ToplamTutar"].DefaultCellStyle.Format = "0.00";
            }

            if (dgvSiparisler.Columns["Fiyat"] != null)
            {
                dgvSiparisler.Columns["Fiyat"].HeaderText = "Fiyat";
                dgvSiparisler.Columns["Fiyat"].DefaultCellStyle.Format = "0.00";
            }

            if (dgvSiparisler.Columns["SiparisTarihi"] != null)
            {
                dgvSiparisler.Columns["SiparisTarihi"].HeaderText = "Sipariş Tarihi";
            }

            if (dgvSiparisler.Columns["SiparisDurumu"] != null)
            {
                dgvSiparisler.Columns["SiparisDurumu"].HeaderText = "Sipariş Durumu";
            }

            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void YonetimUrunleriniYukle()
        {
            string seciliKategori = cboxUurnYonetimKategoriAdi.Text;

            dgvUrunler.AutoGenerateColumns = true;
            dgvUrunler.DataSource = null;
            dgvUrunler.DataSource = urunServis.KategoriyeGoreUrunleriGetir(seciliKategori);
        }

        private void YonetimAlanlariniTemizle()
        {
            secilenUrunID = 0;
            txtGuncelleUrunAdi.Clear();
            txtGuncelleUrunFiyat.Clear();
            rtxtGuncelleUrunAciklama.Clear();
            nupGuncelleUrunStok.Value = 0;
        }

        private void btnSiparisDurumuGuncelle_Click(object sender, EventArgs e)
        {

            if (dgvSiparisler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir sipariş seçiniz.");
                return;
            }

            int siparisID = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells["SiparisID"].Value);
            string yeniDurum = cboxSiparisDurumu.Text;

            bool guncellendiMi = siparisServis.SiparisDurumuGuncelle(siparisID, yeniDurum);

            if (guncellendiMi)
            {
                MessageBox.Show("Sipariş durumu güncellendi.");
                SiparisleriYukle();
            }
            else
            {
                MessageBox.Show("Sipariş durumu güncellenemedi.");
            }


        }

        private void cboxYeniUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            YeniUrunleriYukle();
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            secilenUrunID = Convert.ToInt32(dgvUrunler.Rows[e.RowIndex].Cells["UrunID"].Value);
            txtGuncelleUrunAdi.Text = dgvUrunler.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();
            txtGuncelleUrunFiyat.Text = dgvUrunler.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString();
            rtxtGuncelleUrunAciklama.Text = dgvUrunler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
            nupGuncelleUrunStok.Value = Convert.ToInt32(dgvUrunler.Rows[e.RowIndex].Cells["Adet"].Value);
        
         }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenUrunID == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçiniz.");
                return;
            }

            if (cboxUurnYonetimKategoriAdi.Text == "")
            {
                MessageBox.Show("Lütfen kategori seçiniz.");
                return;
            }

            if (txtGuncelleUrunAdi.Text == "")
            {
                MessageBox.Show("Ürün adı boş bırakılamaz.");
                return;
            }

            if (txtGuncelleUrunFiyat.Text == "")
            {
                MessageBox.Show("Ürün fiyatı boş bırakılamaz.");
                return;
            }

            if (rtxtGuncelleUrunAciklama.Text == "")
            {
                MessageBox.Show("Açıklama boş bırakılamaz.");
                return;
            }

            decimal fiyat;
            if (!decimal.TryParse(txtGuncelleUrunFiyat.Text, out fiyat))
            {
                MessageBox.Show("Ürün fiyatı sayısal olmalıdır.");
                return;
            }

            Urunler urun = new Urunler();
            urun.UrunID = secilenUrunID;
            urun.UrunAdi = txtGuncelleUrunAdi.Text;
            urun.Fiyat = fiyat;
            urun.Aciklama = rtxtGuncelleUrunAciklama.Text;
            urun.Adet = (int)nupGuncelleUrunStok.Value;

            bool guncellendiMi = urunServis.UrunGuncelle(urun, cboxUurnYonetimKategoriAdi.Text);

            if (guncellendiMi)
            {
                MessageBox.Show("Ürün başarıyla güncellendi.");
                YonetimUrunleriniYukle();
                YonetimAlanlariniTemizle();
            }
            else
            {
                MessageBox.Show("Ürün güncellenemedi.");
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (secilenUrunID == 0)
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Bu ürünü silmek istiyor musunuz?",
                "Ürün Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                bool silindiMi = urunServis.UrunSil(secilenUrunID, cboxUurnYonetimKategoriAdi.Text);

                if (silindiMi)
                {
                    MessageBox.Show("Ürün başarıyla silindi.");
                    YonetimUrunleriniYukle();
                    YonetimAlanlariniTemizle();
                }
                else
                {
                    MessageBox.Show("Ürün silinemedi.");
                }
            }
        }

        private void cboxUurnYonetimKategoriAdi_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            YonetimUrunleriniYukle();
            YonetimAlanlariniTemizle();
        }
    }
}
