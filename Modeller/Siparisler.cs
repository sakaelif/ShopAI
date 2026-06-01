using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAI.Modeller
{
    public class Siparisler
    {
        public int SiparisID { get; set; }
        public int KullaniciID { get; set; }

        public string KategoriAdi { get; set; }

        public int UrunID { get; set; }

        public string UrunAdi { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public int Adet { get; set; }

        public decimal Fiyat { get; set; }

        public decimal ToplamTutar { get; set; }

        public DateTime SiparisTarihi { get; set; }

        public string SiparisDurumu { get; set; }


    }
}
