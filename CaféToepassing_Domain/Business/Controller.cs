using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaféToepassing_Domain.Persistence;

namespace CaféToepassing_Domain.Business
{
    public class Controller
    {
        //velden
        private Persistence.Controller _controller;
        private Bestelling _actieveBestelling;

        //constructor
        public Controller()
        {
            _controller = new Persistence.Controller();
        }
        public Controller(string connstring)
        {
            _controller = new Persistence.Controller(connstring);
        }
        //producten
        public List<Producten> getProducten()
        {
            return _controller.GetProducten();
        }
        public void addProducten(Producten item)
        {
            _controller.addProducten(item);
        }
        //tafels
        public List<Tafel> GetTafels()
        {
            return _controller.GetTafel();
        }
        public void addTafel(Tafel item)
        {
            _controller.addTafel(item);
        }
        //bestellingen
        public List<Bestelling> GetBestellingen()
        {
            return _controller.GetBestelling();
        }
        public bool addBestelling(Bestelling item)
        {
            try
            {
                item.IdBestelling = _controller.addBestelling(item);
                _actieveBestelling = item;
            }
            catch { return false; }
            return true;
        }
        //producten in bestelling
        public List<ProductenInBestelling> GetProductenInBestelling()
        {
            return _controller.GetProductenInBestelling(_actieveBestelling.IdBestelling);
        }
        public void addProductenInBestelling(int indexProduct, int aantal)
        {
            ProductenInBestelling item = new ProductenInBestelling(_actieveBestelling.IdBestelling, _controller.GetProducten()[indexProduct].IdProduct, aantal);
            _controller.addProductenInBestelling(item);
        }
        public bool DeleteProductFromBestelling(int index)
        {
            ProductenInBestelling productInBestelling = _controller.GetProductenInBestelling(_actieveBestelling.IdBestelling)[index];
            return _controller.DeleteProductenInBestelling(productInBestelling.IdProducten, productInBestelling.IdBestelling);
        }
        //Producten in Bestelling voor eigenaar
        public List<ProductenInBestellenVoorEigenaar> GetAllProductenInBestelling()
        {
            return _controller.GetAllProductenInBestelling();
        }
        public List<ProductenInBestellenVoorEigenaar> GetPersonalProductenInBestelling()
        {
            return _controller.GetPersonalProductenInBestelling(_actieveBestelling.IdBestelling);
        }
        public List<ProductenInBestellenVoorEigenaar> GetProductenInBestelling(int bestellingid)
        {
            return _controller.GetPersonalProductenInBestelling(bestellingid);
        }
        //prijs van de producten in de bestelling
        public double GetPrijsProductenInBestelling()
        {
            return _controller.GetPrijsProductenInBestelling(_actieveBestelling.IdBestelling);
        }

        public void UpdateBetaalstatusBestelling(int bestellingid, string betaald)
        {
            _controller.UpdateBetaalstatusBestelling(bestellingid, betaald);
        }
    }
}
