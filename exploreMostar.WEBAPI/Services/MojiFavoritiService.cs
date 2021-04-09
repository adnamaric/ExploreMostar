using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class MojiFavoritiService : BaseCRUDService<Model.MojiFavoriti, ByNameSearchRequest, Database.MojiFavoriti, MojiFavoritiUpsertRequest, MojiFavoritiUpsertRequest>
    {
        public MojiFavoritiService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
