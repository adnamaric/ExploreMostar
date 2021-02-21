using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class KategorijaJela
    {
        public KategorijaJela()
        {
            Jela = new HashSet<Jela>();
        }

        public int KategorijaJelaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Jela> Jela { get; set; }
    }
}
