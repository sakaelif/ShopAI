using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAI.Servisler;

namespace ShopAI
{
    public partial class SiparislerimFormu : Form
    {
        private SiparisServis siparisServis = new SiparisServis();

        public SiparislerimFormu()
        {
            InitializeComponent();
        }

        private void SiparislerimFormu_Load(object sender, EventArgs e)
        {
            SiparisleriYukle();
        }

        private void SiparisleriYukle()
        {
            if (GirişYapKayitOl.OTURUM_MUSTERI == null)
            {
                MessageBox.Show("Oturum bilgisi bulunamadı.");
                return;
            }

            int kullaniciId = GirişYapKayitOl.OTURUM_MUSTERI.KullaniciID;

            dgvSiparislerim.AutoGenerateColumns = true;
            dgvSiparislerim.DataSource = null;
            dgvSiparislerim.DataSource = siparisServis.KullaniciSiparisleriniGetir(kullaniciId);

            if (dgvSiparislerim.Columns["SiparisID"] != null)
            {
                dgvSiparislerim.Columns["SiparisID"].HeaderText = "Sipariş No";
            }

            if (dgvSiparislerim.Columns["KullaniciID"] != null)
            {
                dgvSiparislerim.Columns["KullaniciID"].Visible = false;
            }

            if (dgvSiparislerim.Columns["UrunID"] != null)
            {
                dgvSiparislerim.Columns["UrunID"].Visible = false;
            }

            if (dgvSiparislerim.Columns["KategoriAdi"] != null)
            {
                dgvSiparislerim.Columns["KategoriAdi"].HeaderText = "Kategori";
            }

            if (dgvSiparislerim.Columns["UrunAdi"] != null)
            {
                dgvSiparislerim.Columns["UrunAdi"].HeaderText = "Ürün Adı";
            }

            if (dgvSiparislerim.Columns["Adet"] != null)
            {
                dgvSiparislerim.Columns["Adet"].HeaderText = "Adet";
            }

            if (dgvSiparislerim.Columns["Fiyat"] != null)
            {
                dgvSiparislerim.Columns["Fiyat"].HeaderText = "Fiyat";
                dgvSiparislerim.Columns["Fiyat"].DefaultCellStyle.Format = "0.00";
            }

            if (dgvSiparislerim.Columns["ToplamTutar"] != null)
            {
                dgvSiparislerim.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";
                dgvSiparislerim.Columns["ToplamTutar"].DefaultCellStyle.Format = "0.00";
            }

            if (dgvSiparislerim.Columns["SiparisTarihi"] != null)
            {
                dgvSiparislerim.Columns["SiparisTarihi"].HeaderText = "Sipariş Tarihi";
            }

            if (dgvSiparislerim.Columns["SiparisDurumu"] != null)
            {
                dgvSiparislerim.Columns["SiparisDurumu"].HeaderText = "Sipariş Durumu";
            }

            dgvSiparislerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




    }
}
