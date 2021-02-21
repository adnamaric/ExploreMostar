using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Kafici
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int KaficId { get; set; }
        public int? PonudaId { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public byte[] Slika { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }

        public Kategorije Kategorija { get; set; }
        public JeloMeni Ponuda { get; set; }
    }
}
