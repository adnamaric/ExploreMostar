using AutoMapper;
using exploreMostar.Model.Requests;
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
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Apartmani, Model.Apartmani>();
            CreateMap<Database.Atrakcije, Model.Atrakcije>();

        }
    }
}
