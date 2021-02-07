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
    public class DrzaveController : ControllerBase
    {
        private readonly IDrzaveService _service;

        public DrzaveController(IDrzaveService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Drzave> Get()
        {
            return _service.Get();
        }
    }
}
