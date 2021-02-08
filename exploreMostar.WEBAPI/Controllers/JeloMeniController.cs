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
    public class JeloMeniController : ControllerBase
    {
        private readonly IJeloMeniService _service;

        public JeloMeniController(IJeloMeniService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.JeloMeni> Get()
        {
            return _service.Get();
        }
    }
}
