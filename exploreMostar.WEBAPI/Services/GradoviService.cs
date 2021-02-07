using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class GradoviService:IGradoviService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public GradoviService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Gradovi> Get()
        {
            var lista = _context.Gradovi.ToList();

            return _mapper.Map<List<Model.Gradovi>>(lista);
        }
    }
}
