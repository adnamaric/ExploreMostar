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

    public class KategorijeController : BaseCRUDController<Model.Kategorije, ByNameSearchRequest, KategorijeUpsertRequest, KategorijeUpsertRequest>
    {
        public KategorijeController(ICRUDService<Kategorije, ByNameSearchRequest, KategorijeUpsertRequest, KategorijeUpsertRequest> service) : base(service)
        {
        }
    }
}
