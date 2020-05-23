using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviokompanija.Models
{
    public class Putnik
    {
        //Atributi
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public int BrojKreditneKartice { get; set; }
        public string Email { get; set; }

        //Veze sa drugim klasama
    }
}
