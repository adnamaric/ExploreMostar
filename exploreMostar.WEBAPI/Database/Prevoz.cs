using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Prevoz
    {
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Telefon { get; set; }
        public int PrevozId { get; set; }
        public int? KategorijaId { get; set; }

        public Kategorije Kategorija { get; set; }
    }
}
