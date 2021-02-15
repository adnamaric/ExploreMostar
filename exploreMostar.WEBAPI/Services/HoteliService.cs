using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class HoteliService : BaseCRUDService<Model.Hoteli, ByNameSearchRequest, Database.Hoteli, HoteliUpsertRequest, HoteliUpsertRequest>
    {
        public HoteliService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
