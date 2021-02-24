using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Prevoz
    {
        public int PrevozId { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Telefon { get; set; }
        public byte[] Slika { get; set; }
        public string PutanjaSlike { get; set; }
        public int Rbr { get; set; }
    }
}
