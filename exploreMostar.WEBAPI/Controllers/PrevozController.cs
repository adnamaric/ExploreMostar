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
    public class PrevozController : ControllerBase
    {
        private readonly IPrevozService _service;

        public PrevozController(IPrevozService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IList<Model.Prevoz>> Get()
        {
            return _service.Get().ToList();

        }
    }
}
