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
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciUlogeController : BaseController<Model.KorisniciUloge, ByNameSearchRequest>
    {
        public KorisniciUlogeController(IService<KorisniciUloge, ByNameSearchRequest> service) : base(service)
        {
        }
    }
}
