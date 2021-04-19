using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
   public partial class ReportClassByCountries
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

      
        public int ukupnoPoDrzaviAktivnih { get; set; }
        public int ukupnoPoDrzavi { get; set; }
        public int ukupnoPoDrzaviUdaljenih { get; set; }


    }
}
