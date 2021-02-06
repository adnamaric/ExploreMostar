using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class DodatneOpcijeService:IDodatneOpcijeService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public DodatneOpcijeService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.DodatneOpcije> Get()
        {
            var lista = _context.DodatneOpcije.ToList();

            return _mapper.Map<List<Model.DodatneOpcije>>(lista);
        }
    }
}
