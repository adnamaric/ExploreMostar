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
   
    public class KorisnickaUlogaController : BaseController<Model.KorisnickaUloga, object>
    {
        public KorisnickaUlogaController(IService<KorisnickaUloga, object> service) : base(service)
        {
        }
    }
}
