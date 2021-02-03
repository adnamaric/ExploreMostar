using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Mappers
{

    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
        }
    }
}
