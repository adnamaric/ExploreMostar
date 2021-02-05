using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using exploreMostar.WebAPI.Exceptions;
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

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne poklapaju!");
            }
            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test";
            _context.Korisnici.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
