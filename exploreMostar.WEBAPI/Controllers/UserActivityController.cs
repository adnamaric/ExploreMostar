using exploreMostar.Model;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Controllers
{

    public class UserActivityController : BaseCRUDController<Model.UserActivity, ByNameSearchRequest, UserActivityUpsertRequest, UserActivityUpsertRequest>
    {
        public UserActivityController(ICRUDService<UserActivity, ByNameSearchRequest, UserActivityUpsertRequest, UserActivityUpsertRequest> service) : base(service)
        {
        }
    }
}
