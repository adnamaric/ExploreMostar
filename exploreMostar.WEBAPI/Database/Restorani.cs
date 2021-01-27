using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Restorani
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int RestoranId { get; set; }
        public int? PonudaId { get; set; }
        public int? MarkerId { get; set; }
        public int KategorijaId { get; set; }
        public int VrstaId { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int? Ocjena { get; set; }

        public Kategorije Kategorija { get; set; }
        public Markeri Marker { get; set; }
        public JeloMeni Ponuda { get; set; }
        public VrstaRestorana Vrsta { get; set; }
    }
}
