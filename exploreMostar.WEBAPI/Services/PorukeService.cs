using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class PorukeService : BaseCRUDService<Model.Poruke, ByNameSearchRequest, Database.Poruke, PorukeUpsertRequest, PorukeUpsertRequest>
    {
        public PorukeService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
