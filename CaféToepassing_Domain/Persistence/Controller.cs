using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_Domain.Persistence
{
    class Controller
    {
        //velden
        private string _connectionString;

        //constructors
        public Controller()
        {
            _connectionString = "server = localhost; user id= root; password = 1234; database=cafétoepassing_smeyers_tom_gip";
        }
        public Controller(string connstring)
        {
            _connectionString = connstring;
        }
        //Producten
        public List<Producten> GetProducten()
        {
            ProductenMapper mapper = new ProductenMapper();
            return mapper.getProductenFromDB(_connectionString);
        }
        public void addProducten(Producten item)
        {
            ProductenMapper mapper = new ProductenMapper();
            mapper.addProductToDB(_connectionString, item);
        }
        //Tafels
        public List<Tafel> GetTafel()
        {
            TafelMapper mapper = new TafelMapper();
            return mapper.getTafelsFromDB(_connectionString);
        }
        public void addTafel(Tafel item)
        {
            TafelMapper mapper = new TafelMapper();
            mapper.addTafelsToDB(_connectionString, item);
        }
        //Bestellingen
        public List<Bestelling> GetBestelling()
        {
            BestellingMapper mapper = new BestellingMapper();
            return mapper.getBestellingFromDB(_connectionString);
        }
        public int addBestelling(Bestelling item)
        {
            BestellingMapper mapper = new BestellingMapper();
            return mapper.addBestellingToDB(_connectionString, item);
        }
        //Producten in de bestelling
        public List<ProductenInBestelling> GetProductenInBestelling(int idBestelling)
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            return mapper.getProductenInBestellingFromDB(_connectionString, idBestelling);
        }
        public List<ProductenInBestellenVoorEigenaar> GetAllProductenInBestelling()
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            return mapper.getAllProductenInBestelling(_connectionString);
        }
        public void addProductenInBestelling(ProductenInBestelling item)
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            mapper.addProductenInBestellingToDB(_connectionString, item);
        }
    }
}
