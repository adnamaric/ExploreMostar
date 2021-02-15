using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class GradoviService : BaseCRUDService<Model.Gradovi, ByNameSearchRequest, Database.Gradovi, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
