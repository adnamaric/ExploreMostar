using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Restorani
    {
        public Restorani()
        {
            Jelovnik = new HashSet<Jelovnik>();
        }

        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int RestoranId { get; set; }
        public int KategorijaId { get; set; }
        public int VrstaId { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public byte[] Slika { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }

        public Kategorije Kategorija { get; set; }
        public VrstaRestorana Vrsta { get; set; }
        public ICollection<Jelovnik> Jelovnik { get; set; }
    }
}
