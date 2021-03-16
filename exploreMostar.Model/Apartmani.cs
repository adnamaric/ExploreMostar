using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
   
    public partial class Apartmani
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int ApartmanId { get; set; }
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
        public int Rbr { get; set; }
        public bool? AparatZaKafu { get; set; }
        public string KategorijaApartmana { get; set; }
        public bool? Klima { get; set; }
        public double? Ocjena { get; set; }
        public string DodatneOpcije { get; set; }
        public string PutanjaSlike { get; set; }
        public string Vrsta { get; set; }

    }
}
