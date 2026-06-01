using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAI.Modeller;

namespace ShopAI.Servisler
{
    public class SepetServis
    {
        //başak forma geçtiğnde sepet boş görümesin diye static tabımladım
         public static List<SepetUrun> sepet = new List<SepetUrun>();

        //sepete ekle de üürn var yok kontrol yapar sonra varsa yeni adeti attırır yoksa yeni üürn olarka sepete ekler
        //daha sonr alisteyi yani sepetei döndürü
        public void SepetEkle(SepetUrun eklenecekUrun)
        {
            for (int i = 0; i < sepet.Count; i++)
            {
                if (sepet[i].UrunID == eklenecekUrun.UrunID && sepet[i].KategoriAdi == eklenecekUrun.KategoriAdi)
                {
                    sepet[i].Adet = sepet[i].Adet + eklenecekUrun.Adet;
                    sepet[i].ToplamTutar = sepet[i].Fiyat * sepet[i].Adet;
                    return;

                }
            }


            sepet.Add(eklenecekUrun);
        }

        public int SepetToplamAdet()
        {
            int toplamAdet = 0;

            for (int i = 0;i < sepet.Count; i++)
            {
                toplamAdet += sepet[i].Adet;
            }

            return toplamAdet;
        }

        public int SepetToplamCesit()
        {
            return sepet.Count;
        }

        public List<SepetUrun> SepetGetir()
        {
            return sepet;
        }

        public decimal SepetToplamTutar()
        {
            decimal toplamTutar = 0;

            for(int i = 0; i < sepet.Count; i++)
            {
                toplamTutar += sepet[i].ToplamTutar;

            }
            return toplamTutar;
        }

        public void SepettenSil(int urunID, string kategoriAdi)
        {
            for(int i = 0; i < sepet.Count; i++)
            {
                //bu şekilde daha doğru silme işlemi yapılırrrr
                if (sepet[i].UrunID == urunID && sepet[i].KategoriAdi == kategoriAdi)
                {
                    sepet.RemoveAt(i);
                    return;
                }
            }
        }

        public void SepetiTemizle()
        {
            sepet.Clear();
        }


    }
}
