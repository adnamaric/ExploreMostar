using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class JelaService:IJelaService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public JelaService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Jela> Get()
        {
            var lista = _context.Jela.ToList();

            return _mapper.Map<List<Model.Jela>>(lista);
        }
    }
}
