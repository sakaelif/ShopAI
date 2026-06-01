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
    public partial class SiparisOnayForm : Form
    {
        private SepetServis sepetservis = new SepetServis();
        private SiparisServis siparisServis = new SiparisServis();
        public SiparisOnayForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SiparisOnayForm_Load(object sender, EventArgs e)
        {
         
            //burda sepeti doldurmama lasım 
            //ayırca alttaki kodda gerkdizlikleri temziledm
            dgvSepet.Rows.Clear();

            List<SepetUrun> sepetekiUrunler = sepetservis.SepetGetir();

            for (int i = 0; i < sepetekiUrunler.Count; i++)
            {
                //buryaı tek satırda yazdım çünkü her ürün tek bir satrıda görünecek
                dgvSepet.Rows.Add(
                    sepetekiUrunler[i].KategoriAdi,
                    sepetekiUrunler[i].UrunAdi,
                sepetekiUrunler[i].Fiyat.ToString("0.00" + "TL"),
                sepetekiUrunler[i].Adet,
                sepetekiUrunler[i].ToplamTutar
                );
              
            }

            lbltoplamTutarOnay.Text = sepetservis.SepetToplamTutar().ToString("0.00" + "TL");

            SepetYukle();

            maskedTextBox1.Text = "1234123412341234";
            maskedTextBox2.Text = "1228";
            maskedTextBox3.Text = "123";

          

        }

        //ürün silndikten snra atagirvrewsa üürnler listelenmeli 


        public void SepetYukle()
        {
            dgvSepet.Rows.Clear();

            List<SepetUrun> sepetttekiUrunlar = sepetservis.SepetGetir();

            for (int i = 0; i < sepetttekiUrunlar.Count; i++)
            {
                dgvSepet.Rows.Add(
                    sepetttekiUrunlar[i].UrunID,
                    sepetttekiUrunlar[i].KategoriAdi,
                    sepetttekiUrunlar[i].UrunAdi,
                    sepetttekiUrunlar[i].Fiyat.ToString("0.00") + "TL",
                    sepetttekiUrunlar[i].Adet,
                    sepetttekiUrunlar[i].ToplamTutar.ToString("0.00") + "TL"

                );

            }


            lbltoplamTutarOnay.Text = sepetservis.SepetToplamTutar().ToString("0.00" + "TL");

        }

        private void dgvSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSepet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // burda siparişin oluşturduğu bilgisini ve sipariş verdikten sonra verileri temizle işelmi yapıyor
            if(sepetservis.SepetGetir().Count == 0)
            {
                MessageBox.Show("Sepetizin boş. Lütfen ürün ekleyiniz!!!!");
                return;
            }

            int kullaniciID = GirişYapKayitOl.OTURUM_MUSTERI.KullaniciID;

            //oturm açan kullanıcı demek bu 

            bool siparisBasariliMi = siparisServis.SiparisKaydet(sepetservis.SepetGetir(), kullaniciID);

            if (siparisBasariliMi)
            {
                MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //kredi kartı bilgilerini silme 
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();

                sepetservis.SepetiTemizle();

                dgvSepet.Rows.Clear();
                lbltoplamTutarOnay.Text = "0.00 TL";

            }
            else
            {
                MessageBox.Show("Siparis oluşturulamadı.");
            }


        }

        private void dgvSepet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvSepet.Columns[e.ColumnIndex].Name != "colSil")
            {
                return;
            }

            //Soru sorma için kullanılyor DialogResult

            DialogResult cevap = MessageBox.Show("Bu ürünü sepetten silmek istiyor musun?", "Sepetten Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                int urunID = Convert.ToInt32(dgvSepet.Rows[e.RowIndex].Cells["colUrunID"].Value);

                string kategoriAdi = dgvSepet.Rows[e.RowIndex].Cells["colKategori"].Value.ToString();

                sepetservis.SepettenSil(urunID, kategoriAdi);

                SepetYukle();

            }
        }

        private void btnAnaMenuDon_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaMenuForm frm = new AnaMenuForm();
            frm.ShowDialog();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            SiparislerimFormu frm = new SiparislerimFormu();
            frm.ShowDialog();

        }
    }
}
