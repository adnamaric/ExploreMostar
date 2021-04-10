using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class UserActivityService : BaseCRUDService<Model.UserActivity, ByNameSearchRequest, Database.UserActivity, UserActivityUpsertRequest, UserActivityUpsertRequest>
    {
        public UserActivityService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
