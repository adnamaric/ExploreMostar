using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class ApartmaniService:IApartmaniService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public ApartmaniService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Apartmani> Get()
        {
            var lista = _context.Apartmani.ToList();

            return _mapper.Map<List<Model.Apartmani>>(lista);
        }
    }
}
