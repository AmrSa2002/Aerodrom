using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviokompanija.Models
{
    public class Rezervacija
    {
        //Atributi
        public int ID { get; set; }
        public DateTime DatumRezervacije { get; set; }

        //Veze sa drugim klasama
        public int PutnikId { get; set; }
        public int KartaId { get; set; }
    }
}
