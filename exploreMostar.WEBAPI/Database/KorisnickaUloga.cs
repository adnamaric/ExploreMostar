using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class KorisnickaUloga
    {
        public KorisnickaUloga()
        {
            Korisnici = new HashSet<Korisnici>();
        }

        public int KorisnickaUlogaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Korisnici> Korisnici { get; set; }
    }
}
