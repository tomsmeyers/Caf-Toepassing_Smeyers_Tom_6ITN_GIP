using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaféToepassing_Domain.Business;
using MySql.Data.MySqlClient;

namespace CaféToepassing_Domain.Persistence
{
    class TafelMapper
    {
		//methods
		public List<Tafel> getTafelsFromDB(string connectionstring)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("select * from cafétoepassing_smeyers_tom_gip.tafel", conn);

			List<Tafel> productenInBestellingLijst = new List<Tafel>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				Tafel tafel = new Tafel(
				Convert.ToInt16(dataReader[0]),
				dataReader[1].ToString()
				);
				productenInBestellingLijst.Add(tafel);
			}
			conn.Close();
			return productenInBestellingLijst;
		}
		public void addTafelsToDB(string connectionstring, Tafel item)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO cafétoepassing_smeyers_tom_gip.tafel(TafelNummer, Positie) VALUES(@TafelNummer, @Positie)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("TafelNummer", item.TafelNummer);
			cmd.Parameters.AddWithValue("Positie", item.Positie);
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}
	}
}
