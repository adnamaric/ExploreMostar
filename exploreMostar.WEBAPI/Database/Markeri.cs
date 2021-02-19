using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Markeri
    {
        public int MarkerId { get; set; }
        public string Ime { get; set; }
        public string Adresa { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int? GradId { get; set; }
        public string Opis { get; set; }

        public Gradovi Grad { get; set; }
    }
}
