using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class JeloMeniService :IJeloMeniService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public JeloMeniService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.JeloMeni> Get()
        {
            var lista = _context.JeloMeni.ToList();

            return _mapper.Map<List<Model.JeloMeni>>(lista);
        }
    }
}
