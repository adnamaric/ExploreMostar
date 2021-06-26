using exploreMostar.Model;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Controllers
{
   
    public class PorukeController : BaseCRUDController<Model.Poruke, ByNameSearchRequest, PorukeUpsertRequest, PorukeUpsertRequest>
    {
        public PorukeController(ICRUDService<Poruke, ByNameSearchRequest, PorukeUpsertRequest, PorukeUpsertRequest> service) : base(service)
        {
        }
    }
}
