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
            CreateMap<Database.Apartmani, ApartmaniUpsertRequest>().ReverseMap();
            CreateMap<Database.Hoteli, HoteliUpsertRequest>().ReverseMap();
            CreateMap<Database.Hoteli, Model.Hoteli>();
            CreateMap<Database.Atrakcije, AtrakcijeUpsertRequest>().ReverseMap();
            CreateMap<Database.Nightclubs, Model.Nightclubs>();
            CreateMap<Database.Nightclubs, NightClubsUpsertRequest>().ReverseMap();
            CreateMap<Database.Jela, JelaUpsertRequest>().ReverseMap();
            CreateMap<Database.Jela, Model.Jela>();
            CreateMap<Database.Gradovi, GradoviUpsertRequest>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Gradovi>().ReverseMap();
            CreateMap<Database.Drzave, DrzaveUpsertRequest>().ReverseMap();
            CreateMap<Database.Drzave, Model.Drzave>().ReverseMap();
            CreateMap<Database.Prevoz, Model.Prevoz>();
            CreateMap<Database.Prevoz, PrevozUpsertRequest>().ReverseMap();
            CreateMap<Database.Kafici, KaficiUpsertRequest>().ReverseMap();
            CreateMap<Database.Kafici, Model.Kafici>().ReverseMap();
            CreateMap<Database.Restorani, RestoraniUpsertRequest>().ReverseMap();
            CreateMap<Database.Restorani, Model.Restorani>();
            CreateMap<Database.Jelovnik, Model.Jelovnik>();
            CreateMap<Database.Jelovnik, JelovnikUpsertRequest>().ReverseMap();


        }
    }
}
