using exploreMostar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public class ProizvodServis : IKorisniciServis
    {
        public IList<Proizvod> Get()
        {
            var list = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Naziv="novi",
                    ProizvodID=1
                },
                new Proizvod()
                {
                    Naziv="novi2",
                    ProizvodID=2
                }
            };
            return list;
        }
    }
}
