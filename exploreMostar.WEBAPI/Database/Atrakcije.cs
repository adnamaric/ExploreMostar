using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Atrakcije
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int AtrakcijaId { get; set; }
        public int? MarkerId { get; set; }
        public int? VrstaAtrakcijeId { get; set; }
        public int KategorijaId { get; set; }
        public byte[] Slika { get; set; }

        public Kategorije Kategorija { get; set; }
        public Markeri Marker { get; set; }
        public VrstaAtrakcija VrstaAtrakcije { get; set; }
    }
}
