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
    public partial class AIAsistanForm : Form
    {
        private GeminiAiServis geminiAiServis = new GeminiAiServis();

        public AIAsistanForm()
        {
            InitializeComponent();
        }
        
        private void AIAsistanForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtMesajlar.Text))
            {
                MessageBox.Show("Lütefen bir mesaj yazınız !!!");
                return;
            }

            if (GirişYapKayitOl.OTURUM_MUSTERI == null)
            {
                MessageBox.Show("Önce müşteri girişi yapılmalıdır.");
                return;
            }

            string kullaniciMesaji = rtxtMesajlar.Text.Trim();


            btnGonder.Enabled = false;



            try
            {
                rtxtAiCevaplar.AppendText("Sen:" + kullaniciMesaji + Environment.NewLine + Environment.NewLine);

                int kullaniciID = GirişYapKayitOl.OTURUM_MUSTERI.KullaniciID;
                string aiCevabi = await geminiAiServis.MesajGonderAsync(kullaniciMesaji, kullaniciID);

                rtxtAiCevaplar.AppendText("ShopAı Asistan:" + aiCevabi + Environment.NewLine + Environment.NewLine);

                rtxtMesajlar.Clear();
                rtxtMesajlar.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                btnGonder.Enabled = true;
            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rtxtAiCevaplar.Clear();
            rtxtMesajlar.Clear();
            rtxtMesajlar.Focus();
        }

      
    }
}
