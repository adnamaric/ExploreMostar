using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model.Requests
{
    public class GradoviUpsertRequest
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? DrzavaId { get; set; }
    }
}
