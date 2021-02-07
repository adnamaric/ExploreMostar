using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class HoteliService:IHoteliService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public HoteliService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Hoteli> Get()
        {
            var lista = _context.Hoteli.ToList();

            return _mapper.Map<List<Model.Hoteli>>(lista);
        }
    }
}
