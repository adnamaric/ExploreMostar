using AutoMapper;
using exploreMostar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly exploreMostarContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(exploreMostarContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Korisnici> Get()
        {
            var list= _context.Korisnici.ToList();
            //List<Model.Korisnici> result = new List<Model.Korisnici>();
            //foreach(var item in list)
            //{
            //    result.Add(new Model.Korisnici()
            //    {
            //        Ime = item.Ime,
            //        KorisnickoIme = item.KorisnickoIme,
            //        Email = item.Email,
            //        Prezime = item.Prezime,


            //    });
            //}
            //return result;
            return _mapper.Map<List<Model.Korisnici>>(list);
        }
    }
}
