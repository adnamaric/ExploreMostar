using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class VrstaRestorana
    {
        public VrstaRestorana()
        {
            Restorani = new HashSet<Restorani>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Restorani> Restorani { get; set; }
    }
}
