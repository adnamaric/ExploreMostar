using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Menu
    {
        public Menu()
        {
            JeloMeni = new HashSet<JeloMeni>();
        }

        public string Naziv { get; set; }
        public int MeniId { get; set; }

        public ICollection<JeloMeni> JeloMeni { get; set; }
    }
}
