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
        public KorisniciService(exploreMostarContext context){
            _context = context;

        }
        public IList<Korisnici> Get()
        {
            return _context.Korisnici.ToList();
        }
    }
}
