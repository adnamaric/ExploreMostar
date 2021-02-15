using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class KorisnikKategorijaUpsertRequest
    {
        public int? KorisnikId { get; set; }
        public int? KategorijaId { get; set; }
        public int KorisnikKategorijaId { get; set; }
    }
}
