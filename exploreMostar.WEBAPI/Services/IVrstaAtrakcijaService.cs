﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
  public  interface IVrstaAtrakcijaService
    {
        IList<Model.VrstaAtrakcija> Get();
    }
}