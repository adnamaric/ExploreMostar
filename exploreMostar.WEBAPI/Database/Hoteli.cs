using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Hoteli
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int HotelId { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? Bazen { get; set; }
        public bool? Parking { get; set; }
        public bool? Tv { get; set; }
        public bool? Wifi { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumn { get; set; }
        public bool? Klima { get; set; }
        public bool? AparatZaKafu { get; set; }
        public string Kategorija { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }

        public Kategorije KategorijaNavigation { get; set; }
    }
}
