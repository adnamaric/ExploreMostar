using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Restorani
    {
        public int RestoranId { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
      
        public int? GodinaIzgradnje { get; set; }
        public int? Ocjena { get; set; }

    }
}
