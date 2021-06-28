using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class ReportClass
    {
        public int Rbr { get; set; }
        public string Naziv { get; set; }
        public double? Ocjena { get; set; }
        public string Vrsta { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Adresa { get; set; }
       
    }
}
