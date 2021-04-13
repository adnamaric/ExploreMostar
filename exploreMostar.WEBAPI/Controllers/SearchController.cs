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
    
    public class SearchController : BaseCRUDController<Model.Search, ByNameSearchRequest, SearchUpsertRequest, SearchUpsertRequest>
    {
        public SearchController(ICRUDService<Search, ByNameSearchRequest, SearchUpsertRequest, SearchUpsertRequest> service) : base(service)
        {
        }
    }
}
