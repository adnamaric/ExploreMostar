using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Recenzije
    {
        public int RecenzijaId { get; set; }
        public int? Ocjena { get; set; }
        public string Sadrzaj { get; set; }
        public string Objekat { get; set; }
        public int? KorisnikId { get; set; }
        public string ImePrezime { get; set; }
        public DateTime? Datum { get; set; }
        public string Vrsta { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
