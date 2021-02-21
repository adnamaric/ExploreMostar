using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Drzave
    {
        public Drzave()
        {
            Gradovi = new HashSet<Gradovi>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public string PutanjaSlike { get; set; }
        public byte[] Slika { get; set; }

        public ICollection<Gradovi> Gradovi { get; set; }
    }
}
