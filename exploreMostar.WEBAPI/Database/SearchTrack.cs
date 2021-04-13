using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class SearchTrack
    {
        public int SearchId { get; set; }
        public int? KorisnikId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumPretrage { get; set; }
        public string ImePrezime { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
