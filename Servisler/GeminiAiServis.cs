using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopAI.Modeller;

namespace ShopAI.Servisler
{
    public class GeminiAiServis
    {
        private readonly string apiKey;
        private readonly string model;
        private UrunServis urunServis = new UrunServis();
        private SiparisServis siparisServis = new SiparisServis();
        public GeminiAiServis()
        {
            apiKey = ConfigurationManager.AppSettings["GeminiApiKey"];
            model = ConfigurationManager.AppSettings["GeminiModel"];
        }

        private string UrunBaglaminiHazirla()
        {
            List<Urunler> tumUrunler = urunServis.TumUrunleriGetir();

            if (tumUrunler.Count == 0)
            {
                return "Sistemde kayıtlı ürün bulunmamaktadır.";
            }

            StringBuilder urunMetni = new StringBuilder();

            for (int i = 0; i < tumUrunler.Count; i++)
            {
                urunMetni.AppendLine(
                    "Kategori: " + tumUrunler[i].KategoriAdi +
                    " | Ürün Adı: " + tumUrunler[i].UrunAdi +
                    " | Fiyat: " + tumUrunler[i].Fiyat.ToString("0.00") + " TL" +
                    " | Açıklama: " + tumUrunler[i].Aciklama +
                    " | Stok: " + tumUrunler[i].Adet
                );
            }

            return urunMetni.ToString();
        }

        private string SiparisBaglaminiHazirla(int kullaniciID)
        {
            List<Siparisler> siparisler = siparisServis.KullaniciGecmisSiparisleriniGetir(kullaniciID);

            if (siparisler.Count == 0)
            {
                return "Kullanıcının daha önce verdiği sipariş bulunmamaktadır.";
            }

            StringBuilder siparisMetni = new StringBuilder();

            for (int i = 0; i < siparisler.Count; i++)
            {
                siparisMetni.AppendLine(
                    "Kategori: " + siparisler[i].KategoriAdi +
                    " | Ürün Adı: " + siparisler[i].UrunAdi +
                    " | Adet: " + siparisler[i].Adet +
                    " | Toplam Tutar: " + siparisler[i].ToplamTutar.ToString("0.00") + " TL" +
                    " | Sipariş Durumu: " + siparisler[i].SiparisDurumu +
                    " | Sipariş Tarihi: " + siparisler[i].SiparisTarihi.ToShortDateString()
                );
            }

            return siparisMetni.ToString();
        }




        public async Task<string> MesajGonderAsync(string kullaniciMesaji, int kullaniciID)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new Exception("Gemini API anahtarı App.config içinde bulunamadı.");
            }



            string urunBaglami = UrunBaglaminiHazirla();
            string siparisBaglami = SiparisBaglaminiHazirla(kullaniciID);


            using (HttpClient istemci = new HttpClient())
            {
                string istekAdresi =
                    "https://generativelanguage.googleapis.com/v1beta/models/"
                    + model
                    + ":generateContent";

                istemci.DefaultRequestHeaders.Add("x-goog-api-key", apiKey);

                var istekNesnesi = new
                {
                    contents = new object[]
                    {
                        new
                        {
                            parts = new object[]
                            {
                                new
                               {text =
                                    "Sen ShopAI alışveriş asistanısın. " +
                                    "Sadece aşağıda verilen gerçek ürün bilgilerine ve kullanıcının önceki sipariş bilgilerine göre cevap ver. " +
                                    "Sistemde olmayan ürünleri veya siparişleri varmış gibi söyleme. " +
                                    "Kısa, net ve yardımcı cevaplar ver. " +
                                    "Gerekirse kullanıcının sipariş geçmişine göre kısa öneri yapabilirsin. " +
                                    "Ama asla ürün ya da sipariş uydurma." +
                                    "MEVCUT ÜRÜNLER:" +
                                    urunBaglami +
                                    "KULLANICININ ÖNCEKİ SİPARİŞLERİ:" +
                                    siparisBaglami +
                                    "KULLANICI MESAJI:" +
                                    kullaniciMesaji
                                }
                            }
                        }
                    }
                };

                string jsonIstek = JsonConvert.SerializeObject(istekNesnesi);
                StringContent icerik = new StringContent(jsonIstek, Encoding.UTF8, "application/json");

                HttpResponseMessage yanit = await istemci.PostAsync(istekAdresi, icerik);
                string jsonYanit = await yanit.Content.ReadAsStringAsync();

                if (!yanit.IsSuccessStatusCode)
                {
                    throw new Exception("Gemini hatası: " + jsonYanit);
                }

                JObject cevapNesnesi = JObject.Parse(jsonYanit);

                JToken adaylar = cevapNesnesi["candidates"];
                if (adaylar != null && adaylar.HasValues)
                {
                    JToken ilkAday = adaylar[0];
                    JToken parcalar = ilkAday["content"]?["parts"];

                    if (parcalar != null && parcalar.HasValues)
                    {
                        JToken ilkParca = parcalar[0];
                        if (ilkParca["text"] != null)
                        {
                            return ilkParca["text"].ToString();
                        }
                    }
                }

                return "AI cevabı alınamadı.";
            }
        }



    }
}