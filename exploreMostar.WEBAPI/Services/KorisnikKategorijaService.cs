using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KorisnikKategorijaService : BaseCRUDService<Model.KorisnikKategorija, ByNameSearchRequest, Database.KorisnikKategorija, KorisnikKategorijaUpsertRequest, KorisnikKategorijaUpsertRequest>
    {
        public KorisnikKategorijaService(exploreMostarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
