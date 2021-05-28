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
        public bool DeleteProductenInBestelling(int idProduct, int idBestelling)
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            return mapper.DeleteProductenInBestelling(_connectionString, idProduct, idBestelling);
        }

        public List<ProductenInBestellenVoorEigenaar> GetPersonalProductenInBestelling(int idBestelling)
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            return mapper.getPersonalProductenInBestelling(_connectionString, idBestelling);
        }
        public void addProductenInBestelling(ProductenInBestelling item)
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            try
            {
                mapper.addProductenInBestellingToDB(_connectionString, item);
            }
            catch(Exception ex)
            {
                mapper.updateProductenInBestellingToDB(_connectionString, item);
            }
        }
        public double GetPrijsProductenInBestelling(int idBestelling)
        {
            ProductenInBestellingMapper mapper = new ProductenInBestellingMapper();
            return mapper.GetTussenTotaal(_connectionString, idBestelling);
        }

        public void UpdateBetaalstatusBestelling(int IdBestelling, string betaald)
        {
            BestellingMapper mapper = new BestellingMapper();
            mapper.updateBestellingToDB(_connectionString, IdBestelling, betaald);
        }


    }
}
