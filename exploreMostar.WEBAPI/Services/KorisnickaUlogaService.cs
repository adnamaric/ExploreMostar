using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KorisnickaUlogaService:IKorisnickaUlogaService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public KorisnickaUlogaService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.KorisnickaUloga> Get()
        {
            var list = _context.KorisnickaUloga.ToList();

            return _mapper.Map<List<Model.KorisnickaUloga>>(list);
        }
    }
}
