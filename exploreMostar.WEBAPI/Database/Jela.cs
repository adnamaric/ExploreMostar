using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Jela
    {
        public Jela()
        {
            Jelovnik = new HashSet<Jelovnik>();
        }

        public string Naziv { get; set; }
        public int JeloId { get; set; }
        public byte[] Slika { get; set; }
        public string Sastojci { get; set; }
        public double? Ocjena { get; set; }
        public int? KategorijaJelaId { get; set; }
        public string PutanjaSlike { get; set; }

        public KategorijaJela KategorijaJela { get; set; }
        public ICollection<Jelovnik> Jelovnik { get; set; }
    }
}
