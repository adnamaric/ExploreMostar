using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class JeloMeniService : BaseCRUDService<Model.JeloMeni, ByNameSearchRequest, Database.JeloMeni, JeloMeniUpsertRequest, JeloMeniUpsertRequest>
    {
        public JeloMeniService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
