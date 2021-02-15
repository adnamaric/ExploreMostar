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
        public IList<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();
           
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(y => y.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(y => y.Prezime.StartsWith(request.Prezime));
            }
            var list = query.ToList();

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
        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            _mapper.Map(request, entity);
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne preklapaju!");
                }
                //hasing..
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);

        }
        public bool  Delete(int id)
        {
            if (id != 0)
            {
               var kor= _context.Korisnici.Find(id);
                if (kor != null)
                {
                    _context.Korisnici.Remove(kor);
                    _context.SaveChanges();
                    return true;
                }
            }
            return false;



        }
    }
}
