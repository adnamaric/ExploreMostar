using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Jelovnik
    {
        public int JelovnikId { get; set; }
        public string Opis { get; set; }
        public int? JeloId { get; set; }
        public int? RestoranId { get; set; }
        public DateTime? Datum { get; set; }
        public int? BrojJela { get; set; }
        public List<Jela> listaOdabranihJela { get; set; }
        public Jela Jelo { get; set; }
        public Restorani Restoran { get; set; }
    }
}
