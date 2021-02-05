using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Hoteli
    {
        public int HotelId { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int Rating { get; set; }
        public int? GodinaIzgradnje { get; set; }
    }
}
