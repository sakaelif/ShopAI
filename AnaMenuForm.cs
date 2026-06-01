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
    public partial class AnaMenuForm : Form
    {
        MusteriServis musteriservis = new MusteriServis();
        public AnaMenuForm()

        {
            InitializeComponent();
        }

        private void btnElektronik_Click(object sender, EventArgs e)
        {
            this.Hide();

            ElektronikForm frm = new ElektronikForm();
            frm.ShowDialog();

            this.Show();

        }

        private void btnGiyim_Click(object sender, EventArgs e)
        {
            this.Hide();

            GiyimForm frm = new GiyimForm();
            frm.ShowDialog();

            this.Show();

        }

        private void btnAyakkabi_Click(object sender, EventArgs e)
        {
            this.Hide();

            AyakkabiForm frm = new AyakkabiForm();
            frm.ShowDialog();

            this.Show();

        }

        private void btnEvYasam_Click(object sender, EventArgs e)
        {
            this.Hide();

            EvYasamForm frm = new EvYasamForm();
            frm.ShowDialog();
            this.Show();

        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            //from yükelndiği anda kullnaıcının bilgilerini buraya çekicez gerekli olanları
            //globel static bir değişkele birden falan sorgu ile sürekli bilgileri çağırmadan bu şekilde kısaca hellettim ayrıca verileri doğru şekilde doğru yerler yazıyo 
            lblAd.Text = GirişYapKayitOl.OTURUM_MUSTERI.Ad;
            lblSoyad.Text = GirişYapKayitOl.OTURUM_MUSTERI.Soyad;
            txtAnaMenuEposta.Text = GirişYapKayitOl.OTURUM_MUSTERI.EPosta;
            txtAnaMenuTelNo.Text = GirişYapKayitOl.OTURUM_MUSTERI.TelNo;
            txtAnaMenuAdres.Text = GirişYapKayitOl.OTURUM_MUSTERI.Adres;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAnaMenuEposta.Text== "")
            {
                MessageBox.Show("Eposta alanı boş bırakılamaz");
                return;
            }
            if (txtAnaMenuTelNo.Text == "")
            {
                MessageBox.Show("Telefon numarası  boş bırakılamaz");
                return;
            }
            if (txtAnaMenuAdres.Text== "")
            {
                MessageBox.Show("Adres alanı  boş bırakılamaz");
                return;
            }
            Musteriler musteri = new Musteriler();
            musteri.KullaniciID = GirişYapKayitOl.OTURUM_MUSTERI.KullaniciID;
            musteri.EPosta =txtAnaMenuEposta.Text;
            musteri.TelNo =txtAnaMenuTelNo.Text;
            musteri.Adres=txtAnaMenuAdres.Text;

            bool guncelleme = musteriservis.Guncelle(musteri);

            if (guncelleme)
            {    
                MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellenmiştir.");
            }
            else 
            { 
                MessageBox.Show("Güncellme İşlemi başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAsistanaBaglan_Click(object sender, EventArgs e)
        {
            AIAsistanForm frm = new AIAsistanForm();
            frm.ShowDialog();

        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparislerimFormu frm = new SiparislerimFormu();
            frm.ShowDialog();
        }
    }
}
