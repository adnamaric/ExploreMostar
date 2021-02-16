using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
   
    public partial class Apartmani
    {
        public int ApartmanId { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int? Ocjena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int Rbr { get; set; }
    }
}
