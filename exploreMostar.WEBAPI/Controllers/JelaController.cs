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
    public class JelaController : ControllerBase
    {
        private readonly IJelaService _service;

        public JelaController(IJelaService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Jela> Get()
        {
            return _service.Get();
        }
    }
}
