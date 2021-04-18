using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class ReportClass
    {
        public int Rbr { get; set; }
        public string Naziv { get; set; }
        public double? Ocjena { get; set; }
        public string Vrsta { get; set; }
        public string ImePrezime { get; set; }
        public string Username { get; set; }
        public int brojPrijavljivanja { get; set; }
        public int brojFavorita { get; set; }
        public int brojRecenzija { get; set; }

    }
}
