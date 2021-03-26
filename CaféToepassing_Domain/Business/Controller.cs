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
        private Persistence.Controller _persistController;

        //constructor
        public Controller()
        {
            _persistController = new Persistence.Controller();
        }
        public Controller(string connstring)
        {
            _persistController = new Persistence.Controller(connstring);
        }
        //producten
        public List<Producten> getProducten()
        {
            return _persistController.GetProducten();
        }
        public void addProducten(Producten item)
        {
            _persistController.addProducten(item);
        }
        //tafels
        public List<Tafel> GetTafels()
        {
            return _persistController.GetTafel();
        }
        public void addTafel(Tafel item)
        {
            _persistController.addTafel(item);
        }
        //bestellingen
        public List<Bestelling> GetBestellingen()
        {
            return _persistController.GetBestelling();
        }
        public void addBestelling(Bestelling item)
        {
            _persistController.addBestelling(item);
        }
        //producten in bestelling
        public List<ProductenInBestelling> GetProductenInBestelling()
        {
            return _persistController.GetProductenInBestelling();
        }
        public void addProductenInBestelling(ProductenInBestelling item)
        {
            _persistController.addProductenInBestelling(item);
        }
    }
}
