using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class VrstaAtrakcija
    {
        public VrstaAtrakcija()
        {
            Atrakcije = new HashSet<Atrakcije>();
        }

        public int VrstaAtrakcijeId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Atrakcije> Atrakcije { get; set; }
    }
}
