using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class JeloMeni
    {
        public JeloMeni()
        {
            Restorani = new HashSet<Restorani>();
        }

        public int? JeloId { get; set; }
        public int? MeniId { get; set; }
        public int JeloMeliId { get; set; }

        public Jela Jelo { get; set; }
        public Menu Meni { get; set; }
        public ICollection<Restorani> Restorani { get; set; }
    }
}
