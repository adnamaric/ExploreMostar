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
    public class VrstaAtrakcijaController : ControllerBase
    {
        private readonly IVrstaAtrakcijaService _service;

        public VrstaAtrakcijaController(IVrstaAtrakcijaService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IList<Model.VrstaAtrakcija>> Get()
        {
            return _service.Get().ToList();

        }
    }
}
