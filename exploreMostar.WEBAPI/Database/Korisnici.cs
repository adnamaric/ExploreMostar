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
            Objava = new HashSet<Objava>();
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
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<KorisnikKategorija> KorisnikKategorija { get; set; }
        public ICollection<Objava> Objava { get; set; }
    }
}
