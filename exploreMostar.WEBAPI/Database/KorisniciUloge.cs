using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class KorisniciUloge
    {
        public int KorisnickaUlogaId { get; set; }
        public int? KorisnikId { get; set; }
        public int? UlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public Korisnici Korisnik { get; set; }
        public Uloge Uloga { get; set; }
    }
}
