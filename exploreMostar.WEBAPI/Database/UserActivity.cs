using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class UserActivity
    {
        public int KorisnikId { get; set; }
        public int? BrojPrijavljivanja { get; set; }
        public int? BrojNeuspjesnihPrijavljivanja { get; set; }
        public bool? Onemogucen { get; set; }
        public string Razlog { get; set; }
        public DateTime? Datum { get; set; }
        public int? AdminId { get; set; }
        public string ListaOdabranihStavki { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
