using exploreMostar.Model;
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
        [HttpGet]
        public ActionResult<List<Proizvod>> Get()
        {
            var list = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Naziv="novi",
                    ProizvodID=1
                },
                new Proizvod()
                {
                    Naziv="novi2",
                    ProizvodID=2
                }
            };
            return list;
           
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
    }
}
