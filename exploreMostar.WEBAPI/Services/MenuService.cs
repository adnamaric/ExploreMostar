using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class MenuService : BaseCRUDService<Model.Menu, ByNameSearchRequest, Database.Menu, MenuUpsertRequest, MenuUpsertRequest>
    {
        public MenuService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
