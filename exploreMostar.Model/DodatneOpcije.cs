using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class DodatneOpcije
    {
        public int DodatnaOpcijaId { get; set; }
        public bool? Bazen { get; set; }
        public bool? Tv { get; set; }
        public bool? Parking { get; set; }
        
    }
}
