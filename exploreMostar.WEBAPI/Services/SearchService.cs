using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class SearchService : BaseCRUDService<Model.Search, ByNameSearchRequest, Database.SearchTrack, SearchUpsertRequest, SearchUpsertRequest>
    {
        public SearchService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
