using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class HoteliUpsertRequest
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int Rating { get; set; }
        public int? DodatnaOpcijaId { get; set; }
        public int? MarkerId { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int KategorijaId { get; set; }
    }
}
