using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class MenuService:IMenuService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public MenuService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Menu> Get()
        {
            var list = _context.Menu.ToList();

            return _mapper.Map<List<Model.Menu>>(list);
        }
    }
}
