using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class RecenzijeUpsertRequest
    {

        public int? Ocjena { get; set; }
        public string Sadrzaj { get; set; }
        public string Objekat { get; set; }
        public string Vrsta { get; set; }
        public int? KorisnikId { get; set; }
        public string ImePrezime { get; set; }
        public DateTime? Datum { get; set; }
    }
}
