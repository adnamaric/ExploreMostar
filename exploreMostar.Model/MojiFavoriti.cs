using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
   public partial class MojiFavoriti
    {
        public int FavoritiId { get; set; }
        public int? ObjekatId { get; set; }
        public string Vrsta { get; set; }
        public string Naziv { get; set; }
        public int? KorisnikId { get; set; }
    }
}
