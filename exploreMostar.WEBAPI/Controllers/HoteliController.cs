using exploreMostar.Model;
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

    public class HoteliController : BaseCRUDController<Model.Hoteli, ByNameSearchRequest, HoteliUpsertRequest, HoteliUpsertRequest>
    {
        public HoteliController(ICRUDService<Hoteli, ByNameSearchRequest, HoteliUpsertRequest, HoteliUpsertRequest> service) : base(service)
        {
        }
    }
}
