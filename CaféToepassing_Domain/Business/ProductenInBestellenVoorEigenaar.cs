using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféToepassing_Domain.Business
{
    public class ProductenInBestellenVoorEigenaar
    {
        //velden
        private string _naamProduct;
        private int _idBestelling;
        private double _aantal;

        //eigenschappen
        public string NaamProduct
        {
            get { return _naamProduct; }
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
        public ProductenInBestellenVoorEigenaar(int idBestelling, string naamProduct, double aantal)
        {
            _idBestelling = idBestelling;
            _naamProduct = naamProduct;
            _aantal = aantal;
        }
        public ProductenInBestellenVoorEigenaar(double aantal)
        {
            _idBestelling = 0;
            _naamProduct = "";
            _aantal = aantal;
        }
        public override string ToString()
        {
            return "Productnaam: " + _naamProduct + " in bestelling: " + _idBestelling + " en " + _aantal + " keer";
        }
    }
}
