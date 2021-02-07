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
    public class NightClubsController : ControllerBase
    {
        private readonly INightClubsService _service;

        public NightClubsController(INightClubsService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IList<Model.Nightclubs>> Get()
        {
            return _service.Get().ToList();

        }
    }
}
