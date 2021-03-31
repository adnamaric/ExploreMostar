﻿using System;
using System.Collections.Generic;
using System.Text;

namespace exploreMostar.Model
{
    public partial class Kafici
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public int KaficId { get; set; }
        public int KategorijaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public byte[] Slika { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }
        public int Rbr { get; set; }
        public double? Udaljenost { get; set; }
    }
}
