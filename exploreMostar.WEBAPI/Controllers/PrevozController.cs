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

    public class PrevozController : BaseCRUDController<Model.Prevoz, ByNameSearchRequest, PrevozUpsertRequest, PrevozUpsertRequest>
    {
        public PrevozController(ICRUDService<Prevoz, ByNameSearchRequest, PrevozUpsertRequest, PrevozUpsertRequest> service) : base(service)
        {
        }
    }
}
