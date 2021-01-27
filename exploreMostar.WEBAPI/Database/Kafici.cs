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
        public int? MarkerId { get; set; }
        public int KategorijaId { get; set; }

        public Kategorije Kategorija { get; set; }
        public Markeri Marker { get; set; }
        public JeloMeni Ponuda { get; set; }
    }
}
