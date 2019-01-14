using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class Dane
    {
        public decimal id { get; set; }
        public string temat { get; set; }
        public string czynnosc { get; set; }
        public string opis { get; set; }

        public decimal status { get; set; }
        public decimal priorytet { get; set; }
        public decimal procent_zakonczenia { get; set; }

        public DateTime data_rozpoczecia { get; set;}
        public DateTime data_zakonczenia { get; set; }
    }
}