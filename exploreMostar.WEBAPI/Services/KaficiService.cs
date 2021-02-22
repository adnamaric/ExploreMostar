using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KaficiService : BaseCRUDService<Model.Kafici, ByNameSearchRequest, Database.Kafici, KaficiUpsertRequest, KaficiUpsertRequest>
    {
        public KaficiService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
