using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KategorijeService:IKategorijeService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public KategorijeService(exploreMostarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Kategorije> Get()
        {
            var lista = _context.Kategorije.ToList();

            return _mapper.Map<List<Model.Kategorije>>(lista);
        }
    }
}
