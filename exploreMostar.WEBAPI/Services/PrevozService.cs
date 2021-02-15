using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class PrevozService : BaseCRUDService<Model.Prevoz, ByNameSearchRequest, Database.Prevoz, PrevozUpsertRequest, PrevozUpsertRequest>
    {
        public PrevozService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
