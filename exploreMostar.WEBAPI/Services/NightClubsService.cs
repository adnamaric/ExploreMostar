using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class NightClubsService:INightClubsService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public NightClubsService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Nightclubs> Get()
        {
            var list = _context.Nightclubs.ToList();

            return _mapper.Map<List<Model.Nightclubs>>(list);
        }
    }
}
