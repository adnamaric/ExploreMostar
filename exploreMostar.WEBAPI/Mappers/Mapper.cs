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
            CreateMap<Database.Gradovi, Model.Gradovi>();
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
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();
            CreateMap<Database.Objava, Model.Objava>();
            CreateMap<Database.Objava, ObjavaUpsertRequest>().ReverseMap();
            CreateMap<Database.Poruke, Model.Poruke>();
            CreateMap<Database.Poruke, PorukeUpsertRequest>().ReverseMap();
            CreateMap<Database.Recenzije, Model.Recenzije>();
            CreateMap<Database.Recenzije, RecenzijeUpsertRequest>().ReverseMap();
            CreateMap<Database.Kategorije, Model.Kategorije>().ReverseMap();
            CreateMap<Database.UserActivity, Model.UserActivity>().ReverseMap();
            CreateMap<Database.UserActivity, UserActivityUpsertRequest>().ReverseMap();
            CreateMap<Database.SearchTrack, SearchUpsertRequest>().ReverseMap();
            CreateMap<Database.SearchTrack, Model.Search>().ReverseMap();

            CreateMap<Database.Kategorije, KategorijeUpsertRequest>().ReverseMap();
            CreateMap<Database.MojiFavoriti, Model.MojiFavoriti>().ReverseMap();
            CreateMap<Database.MojiFavoriti, MojiFavoritiUpsertRequest>().ReverseMap();

        }
    }
}
