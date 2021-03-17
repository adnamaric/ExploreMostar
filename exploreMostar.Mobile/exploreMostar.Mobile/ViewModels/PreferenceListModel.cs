using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace exploreMostar.Mobile.ViewModels
{
    public class PreferenceListModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _nocniklubovi = new APIService("Nightclubs");
        private readonly APIService _prevoz = new APIService("Prevoz");

        public PreferenceListModel()
        {
            Setuj();
          
        }
        public bool Atrakcije = false;
        public bool Apartmani = false;
        public bool Hoteli = false;
        public bool Other = false;
        public bool Prevoz = false;
        public bool NocniKlubovi = false;
        public bool Kafici = false;
        public bool Food = false;
        public async void Setuj()
        {
            await _service.Get<dynamic>(null);
            Atrakcije = APIService.Atraction;
            Apartmani = APIService.Apartments;
            Hoteli = APIService.Hotels;
            Food = APIService.Food;
            Other = APIService.Other;
            Prevoz = APIService.Transport;
            NocniKlubovi = APIService.Nightclubs;
            Kafici = APIService.Coffeeshops;
            if (Atrakcije == true)
                UcitajAtrakcije();
            if (Apartmani == true)
                UcitajApartmane();
            if (Hoteli == true)
                UcitajHotele();
            if (Food == true)
                UcitajRestorane();
            if (Prevoz == true)
                UcitajPrevoz();
            if (NocniKlubovi == true)
                UcitajNocneKlubove();
            if (Kafici == true)
                UcitajKafice();

        }
        public List<Model.Apartmani> ApartmaniLista { get; set; } = new List<Model.Apartmani>();
        public void UcitajApartmane()
        {
            Task<List<Model.Apartmani>> task = Task.Run<List<Model.Apartmani>>(async () => await _apartmani.Get<List<Model.Apartmani>>(null));
            ApartmaniLista.Clear();
            ApartmaniLista.AddRange(task.Result);
        }
        public List<Model.Atrakcije> AtrakcijeLista { get; set; } = new List<Model.Atrakcije>();
        public void UcitajAtrakcije()
        {
            Task<List<Model.Atrakcije>> task = Task.Run<List<Model.Atrakcije>>(async () => await _atrakcije.Get<List<Model.Atrakcije>>(null));
            AtrakcijeLista.Clear();
            AtrakcijeLista.AddRange(task.Result);
        }
        public List<Model.Hoteli> HoteliLista { get; set; } = new List<Model.Hoteli>();
        public void UcitajHotele()
        {
            Task<List<Model.Hoteli>> task = Task.Run<List<Model.Hoteli>>(async () => await _hoteli.Get<List<Model.Hoteli>>(null));
            HoteliLista.Clear();
            HoteliLista.AddRange(task.Result);
        }
        public List<Model.Restorani> RestoraniLista { get; set; } = new List<Model.Restorani>();
        public void UcitajRestorane()
        {
            Task<List<Model.Restorani>> task = Task.Run<List<Model.Restorani>>(async () => await _restorani.Get<List<Model.Restorani>>(null));
            RestoraniLista.Clear();
            RestoraniLista.AddRange(task.Result);
        }
        public List<Model.Kafici> KaficiLista { get; set; } = new List<Model.Kafici>();
        public void UcitajKafice()
        {
            Task<List<Model.Kafici>> task = Task.Run<List<Model.Kafici>>(async () => await _kafici.Get<List<Model.Kafici>>(null));
            KaficiLista.Clear();
            KaficiLista.AddRange(task.Result);
        }
        public List<Model.Nightclubs> NightclubsLista { get; set; } = new List<Model.Nightclubs>();
        public void UcitajNocneKlubove()
        {
            Task<List<Model.Nightclubs>> task = Task.Run<List<Model.Nightclubs>>(async () => await _nocniklubovi.Get<List<Model.Nightclubs>>(null));
            NightclubsLista.Clear();
            NightclubsLista.AddRange(task.Result);
        }
        public List<Model.Prevoz> PrevozLista { get; set; } = new List<Model.Prevoz>();
        public void UcitajPrevoz()
        {
            Task<List<Model.Prevoz>> task = Task.Run<List<Model.Prevoz>>(async () => await _prevoz.Get<List<Model.Prevoz>>(null));
            PrevozLista.Clear();
            PrevozLista.AddRange(task.Result);
        }
    }
}
