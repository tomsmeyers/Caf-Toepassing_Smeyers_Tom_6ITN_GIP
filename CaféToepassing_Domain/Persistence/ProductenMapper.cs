using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_Domain.Persistence
{
    class ProductenMapper
    {
        //methods
        public List<Producten> getProductenFromDB(string connectionstring)
        {
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("select * from cafétoepassing_smeyers_tom_gip.producten", conn);

			List<Producten> productenLijst = new List<Producten>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				Producten item = new Producten(
				Convert.ToInt16(dataReader[0]),
				 dataReader[1].ToString(),
				Convert.ToDouble(dataReader[2])
				);
				productenLijst.Add(item);
			}
			conn.Close();
			return productenLijst ;
		}
        public void addProductToDB(string connectionstring, Producten item)
        {
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO cafétoepassing_smeyers_tom_gip.producten(Productnaam, Prijs) VALUES(@productnaam, @prijsperproduct)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("productnaam", item.ProductNaam);
			cmd.Parameters.AddWithValue("prijsperproduct", item.PrijsProduct);

			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}
	}
}
