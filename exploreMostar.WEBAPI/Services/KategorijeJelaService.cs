using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KategorijeJelaService : BaseService<Model.KategorijeJela, ByNameSearchRequest, Database.KategorijaJela>
    {
        public KategorijeJelaService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
