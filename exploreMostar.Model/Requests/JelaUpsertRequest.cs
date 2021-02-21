using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class JelaUpsertRequest
    {
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        public string Sastojci { get; set; }
        public double? Ocjena { get; set; }
        public int? KategorijaJelaId { get; set; }
        public string PutanjaSlike { get; set; }
    }
}
