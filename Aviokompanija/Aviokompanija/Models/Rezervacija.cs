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
        public int PutnikId { get; set; }
        public int KartaId { get; set; }
        
        //Veze sa drugim klasama
        public virtual Putnik Putnik { get; set; }
        public virtual Karta Karta { get; set; }
    }
}
