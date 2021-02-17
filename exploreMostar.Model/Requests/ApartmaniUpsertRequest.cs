using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class ApartmaniUpsertRequest
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int? Ocjena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int? DodatnaOpcijaId { get; set; }
        public int? MarkerId { get; set; }
  
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
