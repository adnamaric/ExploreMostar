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
    public class DodatneOpcijeController : ControllerBase
    {
        private readonly IDodatneOpcijeService _service;
        // malorazmisliti o ovoj vezi, da li je many to many i zasto nije!?
        public DodatneOpcijeController(IDodatneOpcijeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.DodatneOpcije> Get()
        {
            return _service.Get();
        }
    }
}
