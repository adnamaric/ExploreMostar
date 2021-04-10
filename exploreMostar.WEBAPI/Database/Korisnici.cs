using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
            KorisnikKategorija = new HashSet<KorisnikKategorija>();
            MojiFavoriti = new HashSet<MojiFavoriti>();
            Objava = new HashSet<Objava>();
            PorukePosiljalacNavigation = new HashSet<Poruke>();
            PorukePrimalacNavigation = new HashSet<Poruke>();
            Recenzije = new HashSet<Recenzije>();
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int KorisnikId { get; set; }
        public int? GradId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string PutanjaSlike { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public int? BrojPrijavljivanja { get; set; }

        public Gradovi Grad { get; set; }
        public UserActivity UserActivity { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<KorisnikKategorija> KorisnikKategorija { get; set; }
        public ICollection<MojiFavoriti> MojiFavoriti { get; set; }
        public ICollection<Objava> Objava { get; set; }
        public ICollection<Poruke> PorukePosiljalacNavigation { get; set; }
        public ICollection<Poruke> PorukePrimalacNavigation { get; set; }
        public ICollection<Recenzije> Recenzije { get; set; }
    }
}
