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
    public class AtrakcijeController : ControllerBase
    {
        private readonly IAtrakcijeService _service;

        public AtrakcijeController(IAtrakcijeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Atrakcije> Get()
        {
            return _service.Get();
        }
    }
}
