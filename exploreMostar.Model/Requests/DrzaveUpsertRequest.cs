using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class DrzaveUpsertRequest
    {
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public string PutanjaSlike { get; set; }
        public byte[] Slika { get; set; }
    }
}
