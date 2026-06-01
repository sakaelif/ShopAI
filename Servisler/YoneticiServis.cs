using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAI.Modeller;

namespace ShopAI.Servisler
{
    public class YoneticiServis
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public Yonetici OturumAc(string eposta, string sifre)
        {
            Yonetici yonetici = null;

            connection = new SqlConnection("Data Source=Elif_SAKA; Initial Catalog=SHOPAIDB; Integrated Security=true;");

            command = new SqlCommand(
                "select * from Yoneticiler where Eposta = @Eposta and Sifre = @Sifre",
                connection);

            command.Parameters.Add("@Eposta", SqlDbType.NVarChar).Value = eposta;
            command.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = sifre;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    yonetici = new Yonetici();

                    yonetici.YoneticiID = Convert.ToInt32(reader["YoneticiID"]);
                    yonetici.Ad = reader["Ad"].ToString();
                    yonetici.Soyad = reader["Soyad"].ToString();
                    yonetici.EPosta = reader["Eposta"].ToString();
                    yonetici.Sifre = reader["Sifre"].ToString();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return yonetici;
        }




    }
}
