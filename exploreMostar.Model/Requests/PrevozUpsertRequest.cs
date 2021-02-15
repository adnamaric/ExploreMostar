using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public class PrevozUpsertRequest
    {
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Telefon { get; set; }
        public int? KategorijaId { get; set; }
    }
}
