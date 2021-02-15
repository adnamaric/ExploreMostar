using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public class JeloMeniUpsertRequest
    {
        public int? JeloId { get; set; }
        public int? MeniId { get; set; }
        public int JeloMeliId { get; set; }
    }
}
