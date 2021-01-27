using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class MeniKategorija
    {
        public int? KategorijaId { get; set; }
        public int? MeniId { get; set; }
        public int MeniKategorijaId { get; set; }

        public Kategorije Kategorija { get; set; }
        public Menu Meni { get; set; }
    }
}
