﻿using System;
using System.Collections.Generic;
using System.Text;


namespace exploreMostar.Model
{
    public partial class Jela
    {
        public string Naziv { get; set; }
        public int JeloId { get; set; }
        public int? KategorijaJelaId { get; set; }
        public byte[] Slika { get; set; }
        public string Sastojci { get; set; }
        public double? Ocjena { get; set; }
        public string PutanjaSlike { get; set; }
       
        public int Rbr { get; set; }
        public string Vrsta { get; set; }

        //public Xamarin.Forms.ImageSource imgSrc;

        //public Xamarin.Forms.ImageSource GetImgSrc()
        //{
        //    return imgSrc;
        //}

        //public void SetImgSrc(Xamarin.Forms.ImageSource value)
        //{
        //    imgSrc = value;
        //}
    }
}
