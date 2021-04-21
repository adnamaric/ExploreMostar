using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public class KategorijeUpsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int? Ukupno { get; set; }
        public string Sadrzaj { get; set; }
        public string VrstaKategorije { get; set; }
    }
}
