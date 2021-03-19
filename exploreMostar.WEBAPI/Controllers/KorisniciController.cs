using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
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
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
             _service = service;
        }
        [HttpGet]
        public IList<Model.Korisnici> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _service.Get(request);

        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id}")]
        public Model.Korisnici Update(int id,KorisniciInsertRequest request)
        {
            return _service.Update(id,request);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
            
        }
    }
}
