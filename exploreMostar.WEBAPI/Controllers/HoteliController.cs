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
    public class HoteliController : ControllerBase
    {
        private readonly IHoteliService _service;

        public HoteliController(IHoteliService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Hoteli> Get()
        {
            return _service.Get();
        }
    }
}
