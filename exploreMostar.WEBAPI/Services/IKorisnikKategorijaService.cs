using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public interface IKorisnikKategorijaService
    {
        IList<Model.KorisnikKategorija> Get();

    }
}
