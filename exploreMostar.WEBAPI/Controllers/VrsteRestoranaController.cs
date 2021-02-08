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
    public class VrsteRestoranaController : ControllerBase
    {
        private readonly IVrstaRestoranaService _service;

        public VrsteRestoranaController(IVrstaRestoranaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IList<Model.VrstaRestorana>> Get()
        {
            return _service.Get().ToList();

        }
    }
}
