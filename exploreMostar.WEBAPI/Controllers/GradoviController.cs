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
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _service;

        public GradoviController(IGradoviService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Gradovi> Get()
        {
            return _service.Get();
        }
    }
}
