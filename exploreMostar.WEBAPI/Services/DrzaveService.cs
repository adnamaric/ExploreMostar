using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class DrzaveService:IDrzaveService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public DrzaveService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Drzave> Get()
        {
            var lista = _context.Drzave.ToList();

            return _mapper.Map<List<Model.Drzave>>(lista);
        }
    }
}
