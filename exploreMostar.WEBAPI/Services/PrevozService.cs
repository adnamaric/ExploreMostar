using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class PrevozService:IPrevozService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public PrevozService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Prevoz> Get()
        {
            var list = _context.Prevoz.ToList();

            return _mapper.Map<List<Model.Prevoz>>(list);
        }
    }
}
