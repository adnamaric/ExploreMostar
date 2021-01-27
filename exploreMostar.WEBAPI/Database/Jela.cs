using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Jela
    {
        public Jela()
        {
            JeloMeni = new HashSet<JeloMeni>();
        }

        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Ocjena { get; set; }
        public int JeloId { get; set; }

        public ICollection<JeloMeni> JeloMeni { get; set; }
    }
}
