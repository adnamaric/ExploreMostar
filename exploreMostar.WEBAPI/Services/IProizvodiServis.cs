using exploreMostar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public interface IKorisniciServis
    {
        IList<Proizvod> Get();
    }
}
