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
    
    public class JeloMeniController : BaseCRUDController<Model.JeloMeni, ByNameSearchRequest, JeloMeniUpsertRequest, JeloMeniUpsertRequest>
    {
        public JeloMeniController(ICRUDService<JeloMeni, ByNameSearchRequest, JeloMeniUpsertRequest, JeloMeniUpsertRequest> service) : base(service)
        {
        }
    }
}
