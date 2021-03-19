﻿using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public interface IKorisniciService
    {
        IList<Model.Korisnici> Get(KorisniciSearchRequest request);
        Model.Korisnici GetById(int id);

        Model.Korisnici Insert(KorisniciInsertRequest request);

        Model.Korisnici Update(int id,KorisniciInsertRequest request);
        Model.Korisnici Authenticiraj(string username, string pass);
        bool Delete(int id);

    }
}
