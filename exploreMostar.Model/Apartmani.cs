using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    //zasto je partial?
    public partial class Apartmani
    {
        public int ApartmanId { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public int? Ocjena { get; set; }

    }
}
