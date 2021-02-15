using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public partial class AtrakcijeUpsertRequest
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int? MarkerId { get; set; }
        public int? VrstaAtrakcijeId { get; set; }
        public int KategorijaId { get; set; }
        public byte[] Slika { get; set; }

      
    }
}
