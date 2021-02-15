using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class VrstaRestoranaService : BaseService<Model.VrstaRestorana, ByNameSearchRequest, Database.VrstaRestorana>
    {
        public VrstaRestoranaService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
