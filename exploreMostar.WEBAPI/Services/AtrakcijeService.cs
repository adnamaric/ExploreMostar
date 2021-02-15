using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class AtrakcijeService : BaseCRUDService<Model.Atrakcije, ByNameSearchRequest, Database.Atrakcije, AtrakcijeUpsertRequest, AtrakcijeUpsertRequest>
    {
        public AtrakcijeService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
