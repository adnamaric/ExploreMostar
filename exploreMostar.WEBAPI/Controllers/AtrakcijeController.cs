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
  
    public class AtrakcijeController : BaseCRUDController<Model.Atrakcije, ByNameSearchRequest, AtrakcijeUpsertRequest, AtrakcijeUpsertRequest>
    {
        public AtrakcijeController(ICRUDService<Model.Atrakcije, ByNameSearchRequest, AtrakcijeUpsertRequest, AtrakcijeUpsertRequest> service) : base(service)
        {
        }
    }
}
