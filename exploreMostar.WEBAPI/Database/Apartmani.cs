using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Apartmani
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int ApartmanId { get; set; }
        public int? DodatnaOpcijaId { get; set; }
        public int? MarkerId { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int KategorijaId { get; set; }
        public int? Ocjena { get; set; }

        public DodatneOpcije DodatnaOpcija { get; set; }
        public Kategorije Kategorija { get; set; }
        public Markeri Marker { get; set; }
    }
}
