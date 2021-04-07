using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Kategorije
    {
        public Kategorije()
        {
            Apartmani = new HashSet<Apartmani>();
            Atrakcije = new HashSet<Atrakcije>();
            Hoteli = new HashSet<Hoteli>();
            Kafici = new HashSet<Kafici>();
            KorisnikKategorija = new HashSet<KorisnikKategorija>();
            Nightclubs = new HashSet<Nightclubs>();
            Prevoz = new HashSet<Prevoz>();
            Restorani = new HashSet<Restorani>();
        }

        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int KategorijaId { get; set; }
        public string Sadrzaj { get; set; }
        public int? Ukupno { get; set; }

        public ICollection<Apartmani> Apartmani { get; set; }
        public ICollection<Atrakcije> Atrakcije { get; set; }
        public ICollection<Hoteli> Hoteli { get; set; }
        public ICollection<Kafici> Kafici { get; set; }
        public ICollection<KorisnikKategorija> KorisnikKategorija { get; set; }
        public ICollection<Nightclubs> Nightclubs { get; set; }
        public ICollection<Prevoz> Prevoz { get; set; }
        public ICollection<Restorani> Restorani { get; set; }
    }
}
