using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public partial class JelovnikUpsertRequest
    {
        public string Naziv { get; set; }
        public int? JeloId { get; set; }
        public int? RestoranId { get; set; }
        public DateTime? Datum { get; set; }
        public int? BrojJela { get; set; }
        public object ListaOdabranihJela { get; set; }
        public Jela Jelo { get; set; }
        public Restorani Restoran { get; set; }
    }
}
