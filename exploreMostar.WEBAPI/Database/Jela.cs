using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Jela
    {
        public Jela()
        {
            JeloMeni = new HashSet<JeloMeni>();
        }

        public string Naziv { get; set; }
        public int JeloId { get; set; }
        public byte[] Slika { get; set; }
        public string Sastojci { get; set; }
        public double? Ocjena { get; set; }
        public int? KategorijaJelaId { get; set; }

        public KategorijaJela KategorijaJela { get; set; }
        public ICollection<JeloMeni> JeloMeni { get; set; }
    }
}
