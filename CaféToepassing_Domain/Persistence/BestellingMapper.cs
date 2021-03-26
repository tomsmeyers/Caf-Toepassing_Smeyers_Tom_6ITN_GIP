using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaféToepassing_Domain.Business;
using MySql.Data.MySqlClient;

namespace CaféToepassing_Domain.Persistence
{
    class BestellingMapper
    {
		//methods
		public List<Bestelling> getBestellingFromDB(string connectionstring)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("select * from cafétoepassing_smeyers_tom_gip.bestelling", conn);

			List<Bestelling> BestellingLijst = new List<Bestelling>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				Bestelling bestelling = new Bestelling(
				Convert.ToInt32(dataReader[0]),
				Convert.ToDateTime(dataReader[1]),
				Convert.ToString(dataReader[2]),
				Convert.ToInt32(dataReader[3]),
				Convert.ToString(dataReader[4])
				);
				BestellingLijst.Add(bestelling);
			}
			conn.Close();
			return BestellingLijst;
		}
		public void addBestellingToDB(string connectionstring, Bestelling item)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO cafétoepassing_smeyers_tom_gip.bestelling(Datum, Betaald,tafel_tafelNummer ,Emailadres) VALUES(@Datum, @Betaald, @tafel_tafelNummer ,@Emailadres)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("Datum", item.Datum);
			cmd.Parameters.AddWithValue("Betaald", item.Betaald);
			cmd.Parameters.AddWithValue("tafel_tafelNummer", item.TafelNummer);
			cmd.Parameters.AddWithValue("Emailadres", item.Emailadres);
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}
	}
}
