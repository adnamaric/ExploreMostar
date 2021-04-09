using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class MojiFavoriti
    {
        public int FavoritiId { get; set; }
        public int? ObjekatId { get; set; }
        public string Vrsta { get; set; }
        public int? KorisnikId { get; set; }
        public string Naziv { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
