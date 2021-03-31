using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Nightclubs
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int NightClubId { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public byte[] Slika { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }
        public double? Udaljenost { get; set; }

        public Kategorije Kategorija { get; set; }
    }
}
