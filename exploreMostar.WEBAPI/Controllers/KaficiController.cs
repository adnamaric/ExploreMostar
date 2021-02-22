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

    public class KaficiController : BaseCRUDController<Model.Kafici, ByNameSearchRequest, KaficiUpsertRequest, KaficiUpsertRequest>
    {
        public KaficiController(ICRUDService<Kafici, ByNameSearchRequest, KaficiUpsertRequest, KaficiUpsertRequest> service) : base(service)
        {
        }
    }
}
