using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Jelovnik
    {
        public int JelovnikId { get; set; }
        public string Opis { get; set; }
        public int? JeloId { get; set; }
        public int? RestoranId { get; set; }
        public DateTime? Datum { get; set; }
        public int? BrojJela { get; set; }

        public Jela Jelo { get; set; }
        public Restorani Restoran { get; set; }
    }
}
