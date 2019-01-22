﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class Dane
    {
        public int id { get; set; }
        public string temat { get; set; }
        public string czynnosc { get; set; }
        public string opis { get; set; }

        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0}")]
        public int status { get; set; }
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0}")]
        public int priorytet { get; set; }
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0}")]
        public int procent_zakonczenia { get; set; }

        //uzywam system.component, aby moc uzywac date w input type="date", w przeciwnym wypadku, kazde wywolanie musialbym rzutowac na toStringa
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime data_rozpoczecia { get; set;}
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime data_zakonczenia { get; set; }
    }
}