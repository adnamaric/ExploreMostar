﻿using exploreMostar.Model;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Controllers
{

    public class ObjavaController : BaseCRUDController<Model.Objava, ByNameSearchRequest, ObjavaUpsertRequest, ObjavaUpsertRequest>
    {
        public ObjavaController(ICRUDService<Objava, ByNameSearchRequest, ObjavaUpsertRequest, ObjavaUpsertRequest> service) : base(service)
        {
        }
    }
}