
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféToepassing_Domain.Business
{
    public class ProductenInBestelling
    {
        //velden
        private int _idProducten;
        private int _idBestelling;
        private double _aantal;

        //eigenschappen
        public int IdProducten
        {
            get { return _idProducten; }
        }
        public int IdBestelling
        {
            get { return _idBestelling; }
            set { _idBestelling = value; }
        }
        public double Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        //constructor
        public ProductenInBestelling(int idBestelling, int idProduct, double aantal)
        {
            _idBestelling = idBestelling;
            _idProducten = idProduct;
            _aantal = aantal;
        }
        public ProductenInBestelling(double aantal)
        { 
            _idBestelling = 0;
            _idProducten = 0;
            _aantal = aantal;
        }
        public override string ToString()
        {
            return "Product id: "+ _idProducten + " in bestelling: " + _idBestelling + " en " + _aantal + " keer"; 
        }
    }
}
