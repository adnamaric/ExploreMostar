using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class KorisnikKategorija
    {
        public int? KorisnikId { get; set; }
        public int? KategorijaId { get; set; }
        public int KorisnikKategorija1 { get; set; }

        public Kategorije Kategorija { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
