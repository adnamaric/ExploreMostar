using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Gradovi
    {

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public int Rbr { get; set; }
        public string Drzava { get; set; }
    }
}
