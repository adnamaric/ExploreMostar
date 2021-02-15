using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public  class RestoraniUpsertRequest
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int? MarkerId { get; set; }
        public int KategorijaId { get; set; }
        public int VrstaId { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int? Ocjena { get; set; }
    }
}
