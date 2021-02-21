using System;
using System.Collections.Generic;

namespace exploreMostar.WebAPI.Database
{
    public partial class Objava
    {
        public int ObjavaId { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public string PutanjaSlike { get; set; }
    }
}
