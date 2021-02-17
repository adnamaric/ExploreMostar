using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Markeri
    {
        public Markeri()
        {
            Atrakcije = new HashSet<Atrakcije>();
            Hoteli = new HashSet<Hoteli>();
            Kafici = new HashSet<Kafici>();
            Nightclubs = new HashSet<Nightclubs>();
            Restorani = new HashSet<Restorani>();
        }

        public int MarkerId { get; set; }
        public string Ime { get; set; }
        public string Adresa { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int? GradId { get; set; }
        public string Opis { get; set; }

        public Gradovi Grad { get; set; }
        public ICollection<Atrakcije> Atrakcije { get; set; }
        public ICollection<Hoteli> Hoteli { get; set; }
        public ICollection<Kafici> Kafici { get; set; }
        public ICollection<Nightclubs> Nightclubs { get; set; }
        public ICollection<Restorani> Restorani { get; set; }
    }
}
