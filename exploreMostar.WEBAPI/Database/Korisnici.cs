using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisnikKategorija = new HashSet<KorisnikKategorija>();
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int KorisnikId { get; set; }
        public int? GradId { get; set; }
        public int? KorisnickaUlogaId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public Gradovi Grad { get; set; }
        public KorisnickaUloga KorisnickaUloga { get; set; }
        public ICollection<KorisnikKategorija> KorisnikKategorija { get; set; }
    }
}
