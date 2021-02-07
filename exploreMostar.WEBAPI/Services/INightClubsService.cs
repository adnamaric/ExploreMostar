using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Services
{
    public interface INightClubsService
    {
        IList<Model.Nightclubs> Get();
        
    }
}
