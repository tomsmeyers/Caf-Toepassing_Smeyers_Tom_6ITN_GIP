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

            MySqlCommand cmd = new MySqlCommand(" Select * from  cafétoepassing_smeyers_tom_gip.bestelling_has_producten" + 
            " where bestelling_idbestelling = @idbestelling ", conn);
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

        public void updateProductenInBestellingToDB(string connectionstring, ProductenInBestelling item)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            string opdracht = "UPDATE cafétoepassing_smeyers_tom_gip.bestelling_has_producten" +
                " SET Aantal = aantal + @aantal" +
                " WHERE bestelling_idbestelling = @bestelling_idbestelling" +
                " AND  Producten_idProducten= @Producten_idProducten";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("aantal", item.Aantal);
            cmd.Parameters.AddWithValue("bestelling_idbestelling", item.IdBestelling);
            cmd.Parameters.AddWithValue("Producten_idProducten", item.IdProducten);
           
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
        public List<ProductenInBestellenVoorEigenaar> getPersonalProductenInBestelling(string connectionstring, int idBestelling)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand(" Select " +
                "bestelling_has_producten.bestelling_idbestelling, " +
                "producten.ProductNaam, " +
                "bestelling_has_producten.aantal " +
                "from cafétoepassing_smeyers_tom_gip.bestelling_has_producten " +
                "inner join cafétoepassing_smeyers_tom_gip.producten " +
                "on producten.idProducten = bestelling_has_producten.Producten_idProducten " +
            " where bestelling_idbestelling = @idbestelling ", conn);
            cmd.Parameters.AddWithValue("idbestelling", idBestelling);

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
        public bool DeleteProductenInBestelling(string connectionstring, int idProduct, int idBestelling)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            string opdracht = "DELETE FROM cafétoepassing_smeyers_tom_gip.bestelling_has_producten WHERE (Producten_idProducten = @productId and bestelling_idbestelling = @bestellingId)";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("productId", idProduct);
            cmd.Parameters.AddWithValue("bestellingId", idBestelling);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }
        public double GetTussenTotaal(string connectionstring, int idBestelling)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand("SELECT "+
                "bestelling_has_producten.bestelling_idbestelling, Sum(producten.Prijs * bestelling_has_producten.aantal ) as Prijs from cafétoepassing_smeyers_tom_gip.bestelling_has_producten " +
                "inner join cafétoepassing_smeyers_tom_gip.producten "+
                "on producten.idProducten = bestelling_has_producten.Producten_idProducten "+
                "where bestelling_idbestelling = @idbestelling ", conn);
            cmd.Parameters.AddWithValue("idbestelling", idBestelling);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if(dataReader[0] is DBNull)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(dataReader[1]);
                }
            }
            conn.Close();
            return 0;
        }
    }
}

