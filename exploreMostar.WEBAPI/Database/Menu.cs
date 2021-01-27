using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Menu
    {
        public Menu()
        {
            JeloMeni = new HashSet<JeloMeni>();
            MeniKategorija = new HashSet<MeniKategorija>();
        }

        public string Naziv { get; set; }
        public int MeniId { get; set; }

        public ICollection<JeloMeni> JeloMeni { get; set; }
        public ICollection<MeniKategorija> MeniKategorija { get; set; }
    }
}
