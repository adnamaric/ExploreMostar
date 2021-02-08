using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class VrstaAtrakcijaService :IVrstaAtrakcijaService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public VrstaAtrakcijaService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.VrstaAtrakcija> Get()
        {
            var list = _context.VrstaRestorana.ToList();

            return _mapper.Map<List<Model.VrstaAtrakcija>>(list);
        }
    }
}
