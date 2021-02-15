using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class RestoraniService : BaseCRUDService<Model.Restorani, ByNameSearchRequest, Database.Restorani, RestoraniUpsertRequest, RestoraniUpsertRequest>
    {
        public RestoraniService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
