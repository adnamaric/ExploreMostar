using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int? GradId { get; set; }
        public string Grad { get; set; }
        public int Rbr { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string ImePrezime { get; set; }
        public string PutanjaSlike { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public List<KorisniciUloge> KorisniciUloge { get; set; }

    }
}
