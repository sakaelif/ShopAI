using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using ShopAI.Modeller;
using System.Windows.Forms;

namespace ShopAI.Servisler
{
    public  class SiparisServis
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;


        private SepetServis sepetservis = new SepetServis();

        public bool SiparisKaydet(List<SepetUrun> sepettekiUurnler, int kullaniciID)
        {
            int kaydedilenSatirSayisi = 0;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            try
            {
                connection.Open();

                for (int i = 0; i < sepettekiUurnler.Count; i++)
                {
                    command = new SqlCommand(
                        "insert into Siparisler (KullaniciID, KategoriAdi, UrunID, UrunAdi, Adet, Fiyat, ToplamTutar, SiparisTarihi, SiparisDurumu) " +
                        "values (@KullaniciID, @KategoriAdi, @UrunID, @UrunAdi, @Adet, @Fiyat, @ToplamTutar, @SiparisTarihi, @SiparisDurumu)",
                        connection);

                    command.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kullaniciID;
                    command.Parameters.Add("@KategoriAdi", SqlDbType.NVarChar).Value = sepettekiUurnler[i].KategoriAdi;
                    command.Parameters.Add("@UrunID", SqlDbType.Int).Value = sepettekiUurnler[i].UrunID;
                    command.Parameters.Add("@UrunAdi", SqlDbType.NVarChar).Value = sepettekiUurnler[i].UrunAdi;
                    command.Parameters.Add("@Adet", SqlDbType.Int).Value = sepettekiUurnler[i].Adet;
                    command.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = sepettekiUurnler[i].Fiyat;
                    command.Parameters.Add("@ToplamTutar", SqlDbType.Decimal).Value = sepettekiUurnler[i].ToplamTutar;
                    command.Parameters.Add("@SiparisTarihi", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@SiparisDurumu", SqlDbType.NVarChar).Value = "Hazırlanıyor";

                    kaydedilenSatirSayisi += command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                connection.Close();
            }

            return kaydedilenSatirSayisi > 0;



        }

        public List<Siparisler> SiparisleriGetir()
        {
            List<Siparisler> siparisler = new List<Siparisler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand(
                "select s.SiparisID, s.KullaniciID, " +
                "m.Ad + ' ' + m.Soyad as MusteriAdiSoyadi, " +
                "s.KategoriAdi, s.UrunID, s.UrunAdi, s.Adet, s.Fiyat, s.ToplamTutar, s.SiparisTarihi, s.SiparisDurumu " +
                "from Siparisler s " +
                "inner join Musteriler m on s.KullaniciID = m.KullaniciID " +
                "order by s.SiparisTarihi desc",
                connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Siparisler siparis = new Siparisler();

                    siparis.SiparisID = Convert.ToInt32(reader["SiparisID"]);
                    siparis.KullaniciID = Convert.ToInt32(reader["KullaniciID"]);
                    siparis.MusteriAdiSoyadi = reader["MusteriAdiSoyadi"].ToString();
                    siparis.KategoriAdi = reader["KategoriAdi"].ToString();
                    siparis.UrunID = Convert.ToInt32(reader["UrunID"]);
                    siparis.UrunAdi = reader["UrunAdi"].ToString();
                    siparis.Adet = Convert.ToInt32(reader["Adet"]);
                    siparis.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    siparis.ToplamTutar = Convert.ToDecimal(reader["ToplamTutar"]);
                    siparis.SiparisTarihi = Convert.ToDateTime(reader["SiparisTarihi"]);
                    siparis.SiparisDurumu = reader["SiparisDurumu"].ToString();

                    siparisler.Add(siparis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                connection.Close();
            }

            return siparisler;
        }

        public bool SiparisDurumuGuncelle(int siparisID, string yeniDurum)
        {
            int etkilenenSatirSayisi = 0;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand(
                "update Siparisler set SiparisDurumu = @SiparisDurumu where SiparisID = @SiparisID",
                connection);

            command.Parameters.Add("@SiparisDurumu", SqlDbType.NVarChar).Value = yeniDurum;
            command.Parameters.Add("@SiparisID", SqlDbType.Int).Value = siparisID;

            try
            {
                connection.Open();
                etkilenenSatirSayisi = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                connection.Close();
            }

            return etkilenenSatirSayisi > 0;
        }


        public List<Siparisler> KullaniciSiparisleriniGetir(int kullaniciId)
        {
            List<Siparisler> siparisler = new List<Siparisler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand(
                "select SiparisID, KullaniciID, KategoriAdi, UrunID, UrunAdi, Adet, Fiyat, ToplamTutar, SiparisTarihi, SiparisDurumu " +
                "from Siparisler " +
                "where KullaniciID = @KullaniciID " +
                "order by SiparisTarihi desc",
                connection);

            command.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kullaniciId;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Siparisler siparis = new Siparisler();

                    siparis.SiparisID = Convert.ToInt32(reader["SiparisID"]);
                    siparis.KullaniciID = Convert.ToInt32(reader["KullaniciID"]);
                    siparis.KategoriAdi = reader["KategoriAdi"].ToString();
                    siparis.UrunID = Convert.ToInt32(reader["UrunID"]);
                    siparis.UrunAdi = reader["UrunAdi"].ToString();
                    siparis.Adet = Convert.ToInt32(reader["Adet"]);
                    siparis.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    siparis.ToplamTutar = Convert.ToDecimal(reader["ToplamTutar"]);
                    siparis.SiparisTarihi = Convert.ToDateTime(reader["SiparisTarihi"]);
                    siparis.SiparisDurumu = reader["SiparisDurumu"].ToString();

                    siparisler.Add(siparis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                connection.Close();
            }

            return siparisler;
        }

        public List<Siparisler> KullaniciGecmisSiparisleriniGetir(int kullaniciID)
        {
            List<Siparisler> siparisler = new List<Siparisler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand(
                "select top 10 SiparisID, KullaniciID, KategoriAdi, UrunID, UrunAdi, Adet, Fiyat, ToplamTutar, SiparisTarihi, SiparisDurumu " +
                "from Siparisler " +
                "where KullaniciID = @KullaniciID " +
                "order by SiparisTarihi desc, SiparisID desc",
                connection);

            command.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kullaniciID;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Siparisler siparis = new Siparisler();

                    siparis.SiparisID = Convert.ToInt32(reader["SiparisID"]);
                    siparis.KullaniciID = Convert.ToInt32(reader["KullaniciID"]);
                    siparis.KategoriAdi = reader["KategoriAdi"].ToString();
                    siparis.UrunID = Convert.ToInt32(reader["UrunID"]);
                    siparis.UrunAdi = reader["UrunAdi"].ToString();
                    siparis.Adet = Convert.ToInt32(reader["Adet"]);
                    siparis.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    siparis.ToplamTutar = Convert.ToDecimal(reader["ToplamTutar"]);
                    siparis.SiparisTarihi = Convert.ToDateTime(reader["SiparisTarihi"]);
                    siparis.SiparisDurumu = reader["SiparisDurumu"].ToString();

                    siparisler.Add(siparis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                connection.Close();
            }

            return siparisler;
        }


    }
}
