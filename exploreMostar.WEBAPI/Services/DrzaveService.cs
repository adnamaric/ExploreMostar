using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class DrzaveService : BaseCRUDService<Model.Drzave, ByNameSearchRequest, Database.Drzave, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
