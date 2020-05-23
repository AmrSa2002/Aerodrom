using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviokompanija.Models
{
    public class Karta
    {
        //Atributi
        public int ID { get; set; }
        public int BrojSjedista { get; set; }
        public string Klasa { get; set; }
        public double Cijena { get; set; }

        //Veze sa drugim klasama
        public int LetId { get; set; }
    }
}
