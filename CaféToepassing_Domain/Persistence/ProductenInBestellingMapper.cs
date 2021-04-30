using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaféToepassing_Domain.Business;
using MySql.Data.MySqlClient;

namespace CaféToepassing_Domain.Persistence
{
    class ProductenInBestellingMapper
    {
        //methods
        public List<ProductenInBestelling> getProductenInBestellingFromDB(string connectionstring, int idBestelling)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren

            MySqlCommand cmd = new MySqlCommand("select * from cafétoepassing_smeyers_tom_gip.bestelling_has_producten " +
            "where bestelling_idbestelling = @idbestelling " +
            "order by bestelling_idbestelling asc", conn);
            cmd.Parameters.AddWithValue("idbestelling", idBestelling);

            List<ProductenInBestelling> productenInBestellingLijst = new List<ProductenInBestelling>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ProductenInBestelling item = new ProductenInBestelling(
                Convert.ToInt16(dataReader[0]),
                Convert.ToInt16(dataReader[1]),
                Convert.ToDouble(dataReader[2])
                );
                productenInBestellingLijst.Add(item);
            }
            conn.Close();
            return productenInBestellingLijst;
        }
        public void addProductenInBestellingToDB(string connectionstring, ProductenInBestelling item)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            string opdracht = "INSERT INTO cafétoepassing_smeyers_tom_gip.bestelling_has_producten(bestelling_idbestelling, Producten_idProducten, Aantal) VALUES(@bestelling_idbestelling, @Producten_idProducten, @aantal)";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("bestelling_idbestelling", item.IdBestelling);
            cmd.Parameters.AddWithValue("Producten_idProducten", item.IdProducten);
            cmd.Parameters.AddWithValue("aantal", item.Aantal);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<ProductenInBestellenVoorEigenaar> getAllProductenInBestelling(string connectionstring)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand(" Select " + 
                "bestelling_has_producten.bestelling_idbestelling, " +
                "producten.ProductNaam, "+
                "bestelling_has_producten.aantal " +
                "from cafétoepassing_smeyers_tom_gip.bestelling_has_producten " +
                "inner join cafétoepassing_smeyers_tom_gip.producten " +
                "on producten.idProducten = bestelling_has_producten.Producten_idProducten " +
                "order by bestelling_idbestelling asc;", conn);

            List<ProductenInBestellenVoorEigenaar> productenInBestellingLijst = new List<ProductenInBestellenVoorEigenaar>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ProductenInBestellenVoorEigenaar item = new ProductenInBestellenVoorEigenaar(
                Convert.ToInt16(dataReader[0]),
                Convert.ToString(dataReader[1]),
                Convert.ToDouble(dataReader[2])
                );
                productenInBestellingLijst.Add(item);
            }
            conn.Close();
            return productenInBestellingLijst;
        }
    }
}

