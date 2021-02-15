using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class JelaService : BaseCRUDService<Model.Jela, ByNameSearchRequest, Database.Jela, JelaUpsertRequest, JelaUpsertRequest>
    {
        public JelaService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
