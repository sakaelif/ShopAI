using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAI.Modeller
{
    public class SepetUrun
    {
        //Sepete eklenen ürün bilgilerini tutacak
        public int UrunID { get; set; }
        
        public string KategoriAdi { get; set; }

        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar {get;set; }

    }
}
