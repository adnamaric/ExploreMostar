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
    public class MarkeriController : ControllerBase
    {
        private readonly IMarkeriService _service;

        public MarkeriController(IMarkeriService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IList<Model.Markeri>> Get()
        {
            return _service.Get().ToList();

        }
    }
}
