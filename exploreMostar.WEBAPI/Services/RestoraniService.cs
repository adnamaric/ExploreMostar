using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class RestoraniService:IRestoraniService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public RestoraniService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Restorani> Get()
        {
            var list = _context.Restorani.ToList();

            return _mapper.Map<List<Model.Restorani>>(list);
        }
    }
}
