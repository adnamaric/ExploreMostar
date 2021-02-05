using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class AtrakcijeService:IAtrakcijeService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public AtrakcijeService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Atrakcije> Get()
        {
            var lista = _context.Atrakcije.ToList();

            return _mapper.Map<List<Model.Atrakcije>>(lista);
        }
    }
}
