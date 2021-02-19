using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class ApartmaniUpsertRequest
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? Bazen { get; set; }
        public bool? Parking { get; set; }
        public bool? Tv { get; set; }
        public bool? Wifi { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? AparatZaKafu { get; set; }
        public string KategorijaApartmana { get; set; }
        public bool? Klima { get; set; }
        public double? Ocjena { get; set; }
    }
}
