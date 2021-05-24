using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Database
{
    public class Data
    {
        public static void Seed(exploreMostarContext context)
        {
            context.Database.Migrate();
        }
    }
}
