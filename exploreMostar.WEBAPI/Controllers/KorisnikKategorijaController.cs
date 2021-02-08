﻿using exploreMostar.WebAPI.Services;
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
    public class KorisnikKategorijaController : ControllerBase
    {
        private readonly IKorisnikKategorijaService _service;

        public KorisnikKategorijaController(IKorisnikKategorijaService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IList<Model.KorisnikKategorija>> Get()
        {
            return _service.Get().ToList();

        }
    }
}