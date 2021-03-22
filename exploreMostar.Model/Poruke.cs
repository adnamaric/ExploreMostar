using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Poruke
    {
        public int PorukaId { get; set; }
        public string Sadrzaj { get; set; }
        public string Posiljalac { get; set; }
        public int? PosiljalacId { get; set; }
        public string Primalac { get; set; }
        public int? PrimalacId { get; set; }
        public DateTime? Datum { get; set; }

     
    }
}
