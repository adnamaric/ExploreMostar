using exploreMostar.Model;
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
    public class KorisnickaUlogaController : BaseController<Model.KorisnickaUloga, object>
    {
        //private readonly IKorisnickaUlogaService _service;

        //public KorisnickaUlogaController(IKorisnickaUlogaService service)
        //{
        //    _service = service;
        //}
        //[HttpGet]
        //public ActionResult<IList<Model.KorisnickaUloga>> Get()
        //{
        //    return _service.Get().ToList();

        //}
        public KorisnickaUlogaController(IService<KorisnickaUloga, object> service) : base(service)
        {
        }
    }
}
