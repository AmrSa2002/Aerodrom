using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviokompanija.Models
{
    public class Recenzija
    {
        //Atributi
        public int ID { get; set; }
        public string ImeIPrezime { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int PutnikId { get; set; }

        //Veze sa drugim klasama
        public virtual Putnik Putnik { get; set; }
    }
}
