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

    public class DrzaveController : BaseCRUDController<Model.Drzave, ByNameSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveController(ICRUDService<Drzave, ByNameSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest> service) : base(service)
        {
        }
    }
}
