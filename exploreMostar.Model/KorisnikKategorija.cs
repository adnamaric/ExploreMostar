using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class KorisnikKategorija
    {
        public int KorisnikKategorijaId { get; set; }

        public int? KorisnikId { get; set; }
        public int? KategorijaId { get; set; }
        public Kategorije Kategorija { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
