using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Drzave
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public string PutanjaSlike { get; set; }
        public byte[] Slika { get; set; }
        public int Rbr { get; set; }
    }
}
