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
    public partial class GirişYapKayitOl : Form
    {
        MusteriServis musteriservis = new MusteriServis();
        public static Musteriler OTURUM_MUSTERI;
        public static Yonetici OTURUM_YONETICI;
        private YoneticiServis yoneticiServis = new YoneticiServis();


        public GirişYapKayitOl()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGirisYap.Visible = true;
            panelKayitOl.Visible = false;
        }

        private void GirişYapKayitOl_Load(object sender, EventArgs e)
        {
            panelKayitOl.Visible = false;

        }

        private void linklblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGirisYap.Visible = false;
            panelKayitOl.Visible = true;

        }

        private void panelKayitOl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string eposta = txtGirisEposta.Text;
            string sifre = txtGirisSifre.Text;


            if (eposta== "")
            {
                MessageBox.Show("E-Posta alanı boş bırakılamaz.");
                return;
            }
            if (sifre == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz.");
                return;
            }

            /// oturum açma işlemi yazılacak
            Musteriler musteri = musteriservis.OturumAc(eposta, sifre);
            
            if(musteri != null)
            {
                GirişYapKayitOl.OTURUM_MUSTERI = musteri;
                AnaMenuForm frm = new AnaMenuForm();
                frm.Show();
                this.Hide();
            }


        }

        private void btnGirisKayitOl_Click(object sender, EventArgs e)
        {
            //Kayit Kontolleri 
            if(txtKayitAd.Text == "")
            {
                MessageBox.Show("Ad alanı boş bırakılamaz!!!");
                return;
            }

            if (txtKayitSoyad.Text == "")
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz!!!");
                return;
            }
            if (txtKayitEposta.Text == "")
            {
                MessageBox.Show("Eposta alanı boş bırakılamaz!!!");
                return;
            }
            if (!mskKayitTel.MaskCompleted)
            {
                MessageBox.Show("Telefon numarası alanı boş bırakılamaz!!!");
                return;
            }
            if (txtKayitAdres.Text == "")
            {
                MessageBox.Show("Adres alanı boş bırakılamaz!!!");
                return;
            }
            if (txtKayitSifre.Text == "")
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz!!!");
                return;
            }
            if (txtKayitSifreTekrar.Text =="")
            {
                MessageBox.Show("Şifre Tekrarı alanı boş bırakılamaz!!!");
                return;
            }


            // Şifre ve şifre tekrarı eşleşmesini kontrol ederiz. Ayrıca büyük küçük harf kontrolü ve 6 bas olup olması,
            // rakam içerip içermemeside kontrol edilir

            if (txtKayitSifre.Text == txtKayitSifreTekrar.Text)
            {
                //En az 1 tane büyük harf içermelidir.
                //En az 1 tane rakam içermelidir.
                //En az 6 basamak içermelidir. 

                string sifre = txtKayitSifre.Text;
                if (sifre.Length < 6)
                {
                    MessageBox.Show("Şifre en az 6 basamaklı olmalıdır.");
                    return;
                }
                string buyukHarfKontrolu = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZXWQ";
                string rakamlar = "1234567890";

                bool buyukHarfİceriyor = false;
                bool rakamIceriyor = false;

                for (int i = 0; i < sifre.Length; i++)
                {
                    //sifre: Ab13Cd
                    //       012345

                    if (buyukHarfKontrolu.Contains(sifre[i]))
                    {
                        buyukHarfİceriyor = true;
                    }
                    if (rakamlar.Contains(sifre[i]))
                    {
                        rakamIceriyor = true;
                    }

                }

                if (rakamIceriyor == false)
                {
                    MessageBox.Show("Şifren ez 1 rakam içermelidir.");
                    return;
                }
                if (buyukHarfİceriyor == false)
                {
                    MessageBox.Show("Şifren en az bir büyük harf içermelidir.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Şifreler birbirine eşit değildir.");
                return;
            }

            Musteriler musteri = new Musteriler();

            musteri.Ad = txtKayitAd.Text;
            musteri.Soyad = txtKayitSoyad.Text;
            musteri.EPosta=txtKayitEposta.Text;
            musteri.TelNo = mskKayitTel.Text;
            musteri.Adres = txtKayitAdres.Text;
            musteri.Sifre = txtKayitSifre.Text;

            bool kaydedildiMi = musteriservis.Kaydet(musteri);

            if (kaydedildiMi)
            {
                MessageBox.Show("Kaydınız başarıyla oluşturlmuştur. Lütfen giriş yapınız!!");

            }

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtGirisEposta.Text;
            string sifre = txtGirisSifre.Text;

            if (eposta == "")
            {
                MessageBox.Show("E-Posta alanı boş bırakılamaz.");
                return;
            }

            if (sifre == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz.");
                return;
            }

            Yonetici yonetici = yoneticiServis.OturumAc(eposta, sifre);

            if (yonetici != null)
            {
                GirişYapKayitOl.OTURUM_YONETICI = yonetici;

                MessageBox.Show("Yönetici girişi başarılı.");

                YoneticiForm frm = new YoneticiForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yönetici bilgileri hatalı.");
            }


        }

        private void txtGirisEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGirisSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
