using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Korisnici = new HashSet<Korisnici>();
            Markeri = new HashSet<Markeri>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? DrzavaId { get; set; }

        public Drzave Drzava { get; set; }
        public ICollection<Korisnici> Korisnici { get; set; }
        public ICollection<Markeri> Markeri { get; set; }
    }
}
