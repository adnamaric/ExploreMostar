using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KorisnickaUlogaService : BaseService<Model.KorisnickaUloga, ByNameSearchRequest, Database.KorisnickaUloga>
    {
        public KorisnickaUlogaService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
