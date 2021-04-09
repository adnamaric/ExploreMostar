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

    public class MojiFavoritiController : BaseCRUDController<Model.MojiFavoriti, ByNameSearchRequest, MojiFavoritiUpsertRequest, MojiFavoritiUpsertRequest>
    {
        public MojiFavoritiController(ICRUDService<MojiFavoriti, ByNameSearchRequest, MojiFavoritiUpsertRequest, MojiFavoritiUpsertRequest> service) : base(service)
        {
        }
    }
}
