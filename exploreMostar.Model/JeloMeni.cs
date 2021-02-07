using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class JeloMeni
    {

        public int JeloMeliId { get; set; }
        public int? JeloId { get; set; }
        public int? MeniId { get; set; }

        public Jela Jelo { get; set; }
        public Menu Meni { get; set; }
    
    }
}
