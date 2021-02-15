using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KategorijeService : BaseCRUDService<Model.Kategorije, ByNameSearchRequest, Database.Kategorije, KategorijeUpsertRequest, KategorijeUpsertRequest>
    {
        public KategorijeService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
