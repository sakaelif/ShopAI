using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAI.Modeller
{
    public class Urunler
    {
        public int UrunID { get; set; }
        public string UrunAdi {  get; set; }

        public decimal Fiyat{ get; set; }

        public string Aciklama { get; set; }

        public int Adet { get; set; }

        public string KategoriAdi { get; set; }

    }
}
