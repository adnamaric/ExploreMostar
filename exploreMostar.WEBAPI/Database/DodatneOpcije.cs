using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class DodatneOpcije
    {
        public bool? Bazen { get; set; }
        public bool? Tv { get; set; }
        public bool? Parking { get; set; }
        public int DodatnaOpcijaId { get; set; }
    }
}
