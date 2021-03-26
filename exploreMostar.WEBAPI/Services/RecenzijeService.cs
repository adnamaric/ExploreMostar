using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class RecenzijeService : BaseCRUDService<Model.Recenzije, ByNameSearchRequest, Database.Recenzije, RecenzijeUpsertRequest, RecenzijeUpsertRequest>
    {
        public RecenzijeService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
