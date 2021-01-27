using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class DodatneOpcije
    {
        public DodatneOpcije()
        {
            Apartmani = new HashSet<Apartmani>();
            Hoteli = new HashSet<Hoteli>();
        }

        public bool? Bazen { get; set; }
        public bool? Tv { get; set; }
        public bool? Parking { get; set; }
        public int DodatnaOpcijaId { get; set; }

        public ICollection<Apartmani> Apartmani { get; set; }
        public ICollection<Hoteli> Hoteli { get; set; }
    }
}
