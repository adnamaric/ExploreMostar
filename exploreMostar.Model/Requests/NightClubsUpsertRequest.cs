using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public class NightClubsUpsertRequest
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public byte[] Slika { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }
    }
}
