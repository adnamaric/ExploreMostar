using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KorisnikKategorijaService:IKorisnikKategorijaService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public KorisnikKategorijaService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.KorisnikKategorija> Get()
        {
            var list = _context.KorisnikKategorija.ToList();

            return _mapper.Map<List<Model.KorisnikKategorija>>(list);
        }
    }
}
