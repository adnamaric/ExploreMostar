using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
   public partial class ReportClassUA
    {
        public int Rbr { get; set; }
        public int KorisnikID { get; set; }

        public string ImePrezime { get; set; }
        public string Username { get; set; }
        public int brojPrijavljivanja{ get; set; }
        public int brojFavorita{ get; set; }
        public int brojRecenzija{ get; set; }
    }
}
