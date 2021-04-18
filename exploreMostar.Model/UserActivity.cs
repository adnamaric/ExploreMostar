using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
   public class UserActivity
    {
        public int KorisnikId { get; set; }
        public int? BrojPrijavljivanja { get; set; }
        public int? BrojNeuspjesnihPrijavljivanja { get; set; }
        public bool? Onemogucen { get; set; }
        public string Razlog { get; set; }
        public DateTime? Datum { get; set; }
        public int? AdminId { get; set; }
        public string ListaOdabranihStavki { get; set; }
        public bool? IsApartman { get; set; }
        public bool? IsAtrakcija { get; set; }
        public bool? IsRestoran { get; set; }
        public bool? IsHotel { get; set; }
        public bool? IsKafic { get; set; }
        public bool? IsNightClub { get; set; }
        public int? BrojApartmanaFavoriti { get; set; }
        public int? BrojAtrakcijaFavoriti { get; set; }
        public int? BrojRestoranaFavoriti { get; set; }
        public int? BrojHotelaFavoriti { get; set; }
        public int? BrojKaficaFavoriti { get; set; }
        public int? BrojNocnihKlubovaFavoriti { get; set; }
        
    }
}
