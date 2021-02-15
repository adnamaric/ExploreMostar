using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class ApartmaniService : BaseCRUDService<Model.Apartmani, ByNameSearchRequest, Database.Apartmani, ApartmaniUpsertRequest, ApartmaniUpsertRequest>
    {
        public ApartmaniService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
