using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public partial class ObjavaUpsertRequest
    {
      
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public string PutanjaSlike { get; set; }
        public int? KorisnikId { get; set; }
        public string Autor { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? DatumModificiranja { get; set; }
        public string AutorModifikacije { get; set; }

    }
}
