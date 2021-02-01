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
    // ruta podrazumijeva localhost.. + api + sve ostalo
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private readonly IKorisniciServis _proizvodiServis;
        public ProizvodController(IKorisniciServis proizvodiServis)
        {
            _proizvodiServis = proizvodiServis;
        }
        [HttpGet]
        public ActionResult<IList<Proizvod>> Get()
        {
            return Ok(_proizvodiServis.Get());
           
        }
        [HttpGet("{id}")]
        public ActionResult<Proizvod> GetById(int id)
        {
            if (id == 1)
            {
                var item = new Proizvod()
                {
                    Naziv = "novi",
                    ProizvodID = 1
                };
                return item;
            }
            else 
            {
                var item = new Proizvod()
                {
                    Naziv = "drugi Proizvod",
                    ProizvodID = 2
                };
                return item;
            }
        }

        //zasto je tipa proizvod
        [HttpPost]
        public Proizvod Insert( Proizvod proizvod)
        {
            return new Proizvod()
            {
                Naziv = proizvod.Naziv,
                ProizvodID =-1
            };
        }

        [HttpPut("{id}")]
        public Proizvod Update(Proizvod proizvod)
        {
            return new Proizvod()
            {
                Naziv = proizvod.Naziv,
                ProizvodID = -1
            };
        }

    }
}
