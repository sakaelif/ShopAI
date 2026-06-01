using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAI.Modeller;

namespace ShopAI.Servisler
{
    public class UrunServis
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public List<Urunler> ElektronikUrunleriListele()
        {
            List<Urunler> urunler = new List<Urunler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand("select ElektronikID, UrunAdi, Fiyat, Aciklama, Adet from ElektronikUrunler order by ElektronikID", connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Urunler urun = new Urunler();

                    urun.UrunID = Convert.ToInt32(reader["ElektronikID"]);
                    urun.UrunAdi = reader["UrunAdi"].ToString();
                    urun.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    urun.Aciklama = reader["Aciklama"].ToString();
                    urun.Adet = Convert.ToInt32(reader["Adet"]);
                    urun.KategoriAdi = "Elektronik";

                    urunler.Add(urun);
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

            return urunler;
        }

        public List<Urunler> GiyimUrunleriListele()
        {
            List<Urunler> urunler = new List<Urunler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand("select GiyimID, UrunAdi, Fiyat, Aciklama, Adet from GiyimUrunleri order by GiyimID", connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Urunler urun = new Urunler();

                    urun.UrunID = Convert.ToInt32(reader["GiyimID"]);
                    urun.UrunAdi = reader["UrunAdi"].ToString();
                    urun.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    urun.Aciklama = reader["Aciklama"].ToString();
                    urun.Adet = Convert.ToInt32(reader["Adet"]);
                    urun.KategoriAdi = "Giyim";

                    urunler.Add(urun);
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

            return urunler;
        }


        public List<Urunler> EvVeYasamUrunleriListele()
        {
            List<Urunler> urunler = new List<Urunler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand("select EvID, UrunAdi, Fiyat, Aciklama, Adet from EvVeYasamUrunleri order by EvID", connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Urunler urun = new Urunler();

                    urun.UrunID = Convert.ToInt32(reader["EvID"]);
                    urun.UrunAdi = reader["UrunAdi"].ToString();
                    urun.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    urun.Aciklama = reader["Aciklama"].ToString();
                    urun.Adet = Convert.ToInt32(reader["Adet"]);
                    urun.KategoriAdi = "Ev Yaşam";

                    urunler.Add(urun);
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

            return urunler;
        }
        public List<Urunler> AyakkabiUrunleriListele()
        {
            List<Urunler> urunler = new List<Urunler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand("select AyakkabiID, UrunAdi, Fiyat, Aciklama, Adet from AyakkabiUrunleri order by AyakkabiID", connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Urunler urun = new Urunler();

                    urun.UrunID = Convert.ToInt32(reader["AyakkabiID"]);
                    urun.UrunAdi = reader["UrunAdi"].ToString();
                    urun.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    urun.Aciklama = reader["Aciklama"].ToString();
                    urun.Adet = Convert.ToInt32(reader["Adet"]);
                    urun.KategoriAdi = "Ayakkabı";

                    urunler.Add(urun);
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

            return urunler;
        }


        public bool UrunEkle(Urunler urun, string kategoriAdi)
        {
            int etkilenenSatirSayisi = 0;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            string sorgu = "";

            if (kategoriAdi == "Elektronik")
            {
                sorgu = "insert into ElektronikUrunler (UrunAdi, Fiyat, Aciklama, Adet) values (@UrunAdi, @Fiyat, @Aciklama, @Adet)";
            }
            else if (kategoriAdi == "Giyim")
            {
                sorgu = "insert into GiyimUrunleri (UrunAdi, Fiyat, Aciklama, Adet) values (@UrunAdi, @Fiyat, @Aciklama, @Adet)";
            }
            else if (kategoriAdi == "Ayakkabı")
            {
                sorgu = "insert into AyakkabiUrunleri (UrunAdi, Fiyat, Aciklama, Adet) values (@UrunAdi, @Fiyat, @Aciklama, @Adet)";
            }
            else if (kategoriAdi == "Ev Yaşam")
            {
                sorgu = "insert into EvVeYasamUrunleri (UrunAdi, Fiyat, Aciklama, Adet) values (@UrunAdi, @Fiyat, @Aciklama, @Adet)";
            }
            command = new SqlCommand(sorgu, connection);

            command.Parameters.Add("@UrunAdi", SqlDbType.NVarChar).Value = urun.UrunAdi;
            command.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = urun.Fiyat;
            command.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = urun.Aciklama;
            command.Parameters.Add("@Adet", SqlDbType.Int).Value = urun.Adet;

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

        public List<Urunler> KategoriyeGoreUrunleriGetir(string kategoriAdi)
        {
            List<Urunler> urunler = new List<Urunler>();

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            string sorgu = "";

            if (kategoriAdi == "Elektronik")
            {
                sorgu = "select ElektronikID as UrunID, UrunAdi, Fiyat, Aciklama, Adet from ElektronikUrunler";
            }
            else if (kategoriAdi == "Giyim")
            {
                sorgu = "select GiyimID as UrunID, UrunAdi, Fiyat, Aciklama, Adet from GiyimUrunleri";
            }
            else if (kategoriAdi == "Ayakkabı")
            {
                sorgu = "select AyakkabiID as UrunID, UrunAdi, Fiyat, Aciklama, Adet from AyakkabiUrunleri";
            }
            else if (kategoriAdi == "Ev Yaşam")
            {
                sorgu = "select EvID as UrunID, UrunAdi, Fiyat, Aciklama, Adet from EvVeYasamUrunleri";
            }

            command = new SqlCommand(sorgu, connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Urunler urun = new Urunler();

                    urun.UrunID = Convert.ToInt32(reader["UrunID"]);
                    urun.UrunAdi = reader["UrunAdi"].ToString();
                    urun.Fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    urun.Aciklama = reader["Aciklama"].ToString();
                    urun.Adet = Convert.ToInt32(reader["Adet"]);

                    urunler.Add(urun);
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

            return urunler;
        }


        public bool UrunGuncelle(Urunler urun, string kategoriAdi)
        {
            int etkilenenSatirSayisi = 0;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            string sorgu = "";

            if (kategoriAdi == "Elektronik")
            {
                sorgu = "update ElektronikUrunler set UrunAdi = @UrunAdi, Fiyat = @Fiyat, Aciklama = @Aciklama, Adet = @Adet where ElektronikID = @UrunID";
            }
            else if (kategoriAdi == "Giyim")
            {
                sorgu = "update GiyimUrunleri set UrunAdi = @UrunAdi, Fiyat = @Fiyat, Aciklama = @Aciklama, Adet = @Adet where GiyimID = @UrunID";
            }
            else if (kategoriAdi == "Ayakkabı")
            {
                sorgu = "update AyakkabiUrunleri set UrunAdi = @UrunAdi, Fiyat = @Fiyat, Aciklama = @Aciklama, Adet = @Adet where AyakkabiID = @UrunID";
            }
            else if (kategoriAdi == "Ev Yaşam")
            {
                sorgu = "update EvVeYasamUrunleri set UrunAdi = @UrunAdi, Fiyat = @Fiyat, Aciklama = @Aciklama, Adet = @Adet where EvID = @UrunID";
            }

            command = new SqlCommand(sorgu, connection);

            command.Parameters.Add("@UrunID", SqlDbType.Int).Value = urun.UrunID;
            command.Parameters.Add("@UrunAdi", SqlDbType.NVarChar).Value = urun.UrunAdi;
            command.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = urun.Fiyat;
            command.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = urun.Aciklama;
            command.Parameters.Add("@Adet", SqlDbType.Int).Value = urun.Adet;

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

        public bool UrunSil(int urunID, string kategoriAdi)
        {
            int etkilenenSatirSayisi = 0;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            string sorgu = "";

            if (kategoriAdi == "Elektronik")
            {
                sorgu = "delete from ElektronikUrunler where ElektronikID = @UrunID";
            }
            else if (kategoriAdi == "Giyim")
            {
                sorgu = "delete from GiyimUrunleri where GiyimID = @UrunID";
            }
            else if (kategoriAdi == "Ayakkabı")
            {
                sorgu = "delete from AyakkabiUrunleri where AyakkabiID = @UrunID";
            }
            else if (kategoriAdi == "Ev Yaşam")
            {
                sorgu = "delete from EvVeYasamUrunleri where EvID = @UrunID";
            }

            command = new SqlCommand(sorgu, connection);
            command.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;

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

        public List<Urunler> TumUrunleriGetir()
        {
            List<Urunler> tumUrunler = new List<Urunler>();

            List<Urunler> elektronikUrunler = ElektronikUrunleriListele();
            for (int i = 0; i < elektronikUrunler.Count; i++)
            {
                elektronikUrunler[i].KategoriAdi = "Elektronik";
                tumUrunler.Add(elektronikUrunler[i]);
            }

            List<Urunler> giyimUrunler = GiyimUrunleriListele();
            for (int i = 0; i < giyimUrunler.Count; i++)
            {
                giyimUrunler[i].KategoriAdi = "Giyim";
                tumUrunler.Add(giyimUrunler[i]);
            }

            List<Urunler> ayakkabiUrunler = AyakkabiUrunleriListele();
            for (int i = 0; i < ayakkabiUrunler.Count; i++)
            {
                ayakkabiUrunler[i].KategoriAdi = "Ayakkabı";
                tumUrunler.Add(ayakkabiUrunler[i]);
            }

            List<Urunler> evVeYasamUrunler = EvVeYasamUrunleriListele();
            for (int i = 0; i < evVeYasamUrunler.Count; i++)
            {
                evVeYasamUrunler[i].KategoriAdi = "Ev Yaşam";
                tumUrunler.Add(evVeYasamUrunler[i]);
            }

            return tumUrunler;
        }

    }
}
