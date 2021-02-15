using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class NightClubsService : BaseCRUDService<Model.Nightclubs, ByNameSearchRequest, Database.Nightclubs, NightClubsUpsertRequest, NightClubsUpsertRequest>
    {
        public NightClubsService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
