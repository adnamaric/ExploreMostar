using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class MarkeriService:IMarkeriService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public MarkeriService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Markeri> Get()
        {
            var list = _context.Markeri.ToList();

            return _mapper.Map<List<Model.Markeri>>(list);
        }
    }
}
