using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviokompanija.Models
{
    public class Let
    {
        //Atributi
        public int ID { get; set; }
        public int BrojSlobodnihMjesta { get; set; }
        public string VrstaLeta { get; set; }
        public double Cijena { get; set; }
        public int MjestoPolaskaIDDestinacije { get; set; }
        public DateTime VrijemePolijetanja { get; set; }
        public DateTime VrijemeSlijetanja { get; set; }
        public int AvionId { get; set; }
        public int DestinacijaId { get; set; }

        //Veze sa drugim klasama
        public virtual Avion Avion { get; set; }
        public virtual Destinacija Destinacija { get; set; }

        public virtual ICollection<Karta> Karte { get; set; }
    }
}
