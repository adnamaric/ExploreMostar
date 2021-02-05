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

    public class ApartmaniController : ControllerBase
    {
        private readonly IApartmaniService _service;

        public ApartmaniController(IApartmaniService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Apartmani> Get()
        {
            return _service.Get();

        }
    }
}
