using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Kategorije
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int Rbr { get; set; }
        public int Ukupno { get; set; }
        public string Sadrzaj { get; set; }
    }
}
