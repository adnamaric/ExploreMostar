using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Atrakcije
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int AtrakcijaId { get; set; }
        public int? VrstaAtrakcijeId { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumn { get; set; }
        public double? Ocjena { get; set; }

        public Kategorije Kategorija { get; set; }
        public VrstaAtrakcija VrstaAtrakcije { get; set; }
    }
}
