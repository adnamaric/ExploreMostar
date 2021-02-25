using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{

    public class JelovnikService : BaseCRUDService<Model.Jelovnik, ByNameSearchRequest, Database.Jelovnik, JelovnikUpsertRequest, JelovnikUpsertRequest>
    {
        public JelovnikService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
