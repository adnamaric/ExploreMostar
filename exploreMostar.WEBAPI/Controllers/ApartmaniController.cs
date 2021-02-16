using exploreMostar.Model;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]

    public class ApartmaniController : BaseCRUDController<Model.Apartmani, ByNameSearchRequest, ApartmaniUpsertRequest, ApartmaniUpsertRequest>
    {

        public ApartmaniController(ICRUDService<Apartmani, ByNameSearchRequest, ApartmaniUpsertRequest, ApartmaniUpsertRequest> service) : base(service)
        {
        }

      
    }


}
