using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class UlogeService : BaseService<Model.Uloge, ByNameSearchRequest, Database.Uloge>
    {
        public UlogeService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
