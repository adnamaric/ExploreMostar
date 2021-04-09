using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
  public  class MojiFavoritiUpsertRequest
    {
      
        public int? ObjekatId { get; set; }
        public string Vrsta { get; set; }
        public int? KorisnikId { get; set; }
        public string Naziv { get; set; }
    }
}
