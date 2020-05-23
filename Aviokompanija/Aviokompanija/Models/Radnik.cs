using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviokompanija.Models
{
    public class Radnik
    {
        //Atributi
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public double Plata { get; set; }
        public DateTime DatumZaposlenja { get; set; }

    }
}
