﻿using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class ObjavaService : BaseCRUDService<Model.Objava, ByNameSearchRequest, Database.Objava, ObjavaUpsertRequest, ObjavaUpsertRequest>
    {
        public ObjavaService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
