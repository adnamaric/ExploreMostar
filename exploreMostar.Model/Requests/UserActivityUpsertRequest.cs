using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
  public  class UserActivityUpsertRequest
    {
      
            public int KorisnikId { get; set; }
            public int? BrojPrijavljivanja { get; set; }
            public int? BrojNeuspjesnihPrijavljivanja { get; set; }
            public bool? Onemogucen { get; set; }
            public string Razlog { get; set; }
            public DateTime? Datum { get; set; }
            public int? AdminId { get; set; }
            public string ListaOdabranihStavki { get; set; }
        
    }
}
