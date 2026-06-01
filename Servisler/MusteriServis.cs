using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAI.Modeller;

namespace ShopAI.Servisler
{
    public class MusteriServis
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public bool Kaydet(Musteriler musteri)
        {
            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true");

            command = new SqlCommand("insert into Musteriler (Ad,Soyad,EPosta,TelNo,Adres,Sifre) values (@Ad,@Soyad,@EPosta,@TelNo,@Adres,@Sifre)", connection);

            command.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = musteri.Ad;

            command.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = musteri.Soyad;


            command.Parameters.Add("@EPosta", SqlDbType.NVarChar).Value = musteri.EPosta;


            command.Parameters.Add("@TelNo", SqlDbType.Char).Value = musteri.TelNo;

            command.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = musteri.Adres;

            command.Parameters.Add("@Sifre", SqlDbType.Char).Value = musteri.Sifre;

            int ekelnesatirsayisi = 0;

            try
            {
                connection.Open();
                ekelnesatirsayisi = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return ekelnesatirsayisi > 0;

        }


        public Musteriler OturumAc(string eposta, string sifre)
        {
            //gerksiz doluluğu silerim burada 
            Musteriler musteri = null;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand("select * from Musteriler where Eposta = @EPosta and Sifre= @Sifre", connection);

            command.Parameters.Add("@EPosta", SqlDbType.NVarChar).Value = eposta;
            command.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = sifre;

            try
            {
                connection.Open();
                //select sorgusunu çalıştırır.Dönen sonuçları okur.
                //Bir sorguda veri okumak için kullanılır reader ın görevi

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    musteri = new Musteriler();

                    musteri.KullaniciID = Convert.ToInt32(reader["KullaniciID"]);
                    musteri.Ad = reader["Ad"].ToString();
                    musteri.Soyad = reader["Soyad"].ToString();
                    musteri.EPosta = reader["Eposta"].ToString();
                    musteri.TelNo = reader["TelNo"].ToString();
                    musteri.Adres = reader["Adres"].ToString();
                    musteri.Sifre = reader["Sifre"].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return musteri;

        }

        public bool Guncelle(Musteriler musteri)
        {
            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand("update Musteriler set Eposta = @Eposta, TelNo = @TelNo, Adres = @Adres where KullaniciID = @KullaniciID", connection);

            command.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = musteri.KullaniciID;
            command.Parameters.Add("@EPosta", SqlDbType.NVarChar).Value = musteri.EPosta;
            command.Parameters.Add("@TelNo", SqlDbType.Char).Value = musteri.TelNo;
            command.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = musteri.Adres;
            

            //bunu beiim koyma nedneim gerçekten değişim oluyr mu olmuyor mu ona bakmak 
            int etkilenenSatirSayisi = 0;

            try
            {
                connection.Open();
                etkilenenSatirSayisi = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return etkilenenSatirSayisi > 0;
            //değişim var deömek 
        }


    }
    
}
