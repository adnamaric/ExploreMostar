using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public  class SearchUpsertRequest
    {
        
        public int? KorisnikId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumPretrage { get; set; }
        public string ImePrezime { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
