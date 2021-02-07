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
    public class KorisnickaUlogaController : ControllerBase
    {
        private readonly IKorisnickaUlogaService _service;

        public KorisnickaUlogaController(IKorisnickaUlogaService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IList<Model.KorisnickaUloga>> Get()
        {
            return _service.Get().ToList();

        }
    }
}
