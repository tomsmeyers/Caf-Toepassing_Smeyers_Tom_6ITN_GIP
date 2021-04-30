using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféToepassing_Domain.Business
{
    public class Bestelling
    {
        //velden
        private int _idBestelling;
        private DateTime _datum;
        private int _tafelNummer;
        private string _betaald;
        private string _emailadres;

        //eigenschappen
        public int IdBestelling
        {
            set { _idBestelling = value; }
            get { return _idBestelling; }
        }
        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public string Betaald
        {
            get { return _betaald; }
            set { _betaald = value; }
        }
        public int TafelNummer
        {
            get { return _tafelNummer; }
            set { _tafelNummer = value; }
        }
        public string Emailadres
        {
            get { return _emailadres; }
            set { _emailadres = value; }
        }

        //constructor
        public Bestelling(int idBestelling, DateTime datum, string betaald,int tafelnummer, string emailadres)
        {
            _idBestelling = idBestelling;
            _datum = datum;
            _betaald = betaald;
            _tafelNummer = tafelnummer;
            _emailadres = emailadres;
        }
        public Bestelling(DateTime datum, string betaald, int tafelnummer, string emailadres)
        {
            _idBestelling = 0;
            _datum = datum;
            _betaald = betaald;
            _tafelNummer = tafelnummer;
            _emailadres = emailadres;
        }
        public override string ToString()
        {
            return _idBestelling + " aan tafel"+ _tafelNummer + " (" + _datum.ToShortDateString() +") betaald(Ja/Nee): "+ _betaald +" het emailadres is: "+ _emailadres;
        }
    }
}
