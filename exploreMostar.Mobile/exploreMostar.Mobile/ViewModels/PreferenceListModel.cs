using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

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
        public ObservableCollection<Model.Restorani> restoranis { get; set; } = new ObservableCollection<Model.Restorani>();
        public ObservableCollection<Model.Atrakcije> atrakcije { get; set; } = new ObservableCollection<Model.Atrakcije>();
        public ObservableCollection<Model.ReportClass> temp { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp1 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp2 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp3 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp4 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.Kafici> kafici { get; set; } = new ObservableCollection<Model.Kafici>();

        public ICommand InitCommand { get; set; }
        public PreferenceListModel()
        {
            //Setuj();
            InitCommand = new Command(async () => await Init());
        }
      public async Task Init()
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
            if (Food == true)
            {

                var list = await _restorani.Get<IList<Model.Restorani>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                restoranis.Clear();
                temp.Clear();
                foreach (var item in list)
                {
                    if(item.PutanjaSlike!=null)
                        APIService.PutanjaSlike = item.PutanjaSlike;

                    restoranis.Add(item);
                    temp.Add(new Model.ReportClass {Naziv=item.Naziv, Ocjena=item.Ocjena });
                    
                }
                
            }
            if (Atrakcije == true)
            {
                var list = await _atrakcije.Get<IEnumerable<Model.Atrakcije>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                atrakcije.Clear();
                temp1.Clear();
                foreach (var item in list)
                {
                    atrakcije.Add(item);
                    temp1.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

                }
            }
            if (Apartmani == true)
            {
                var list = await _apartmani.Get<IEnumerable<Model.Apartmani>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();

                temp2.Clear();
                foreach (var item in list)
                {
                    
                    temp2.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

                }
            }
            if (Hoteli == true)
            {
                var list = await _hoteli.Get<IEnumerable<Model.Hoteli>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();

                temp3.Clear();
                foreach (var item in list)
                {
                   
                    temp3.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

                }
            }
            if (Kafici == true)
            {
                var list = await _kafici.Get<IEnumerable<Model.Kafici>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                kafici.Clear();
                temp3.Clear();
                foreach (var item in list)
                {
                    kafici.Add(item);
                    temp3.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

                }
            }
            if (Prevoz == true)
            {
                var list = await _prevoz.Get<IEnumerable<Model.Prevoz>>(null);
                

                temp4.Clear();
                foreach (var item in list)
                {

                    temp4.Add(new Model.ReportClass { Naziv = item.Naziv });

                }
            }
            if (Prevoz == true)
            {
                var list = await _nocniklubovi.Get<IEnumerable<Model.Nightclubs>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                temp4.Clear();
                foreach (var item in list)
                {

                    temp4.Add(new Model.ReportClass { Naziv = item.Naziv,Ocjena=item.Ocjena });

                }
            }
        }
        public string OcjenaGlobal { get; set; }

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
         
         
            //    UcitajAtrakcije();
            //if (Apartmani == true)
            //    UcitajApartmane();
            //if (Hoteli == true)
            //    UcitajHotele();
          
            //  //  UcitajRestorane();
            //if (Prevoz == true)
            //    UcitajPrevoz();
            //if (NocniKlubovi == true)
            //    UcitajNocneKlubove();
            //if (Kafici == true)
            //    UcitajKafice();
           // HoteliLista = IEnumerable<Model.Hoteli>();
        }
        private IEnumerable<Model.Hoteli> _hotelis;

        public IEnumerable<Model.Hoteli> Hotelis
        {
            get { return _hotelis; }
            set
            {
                _hotelis = value;
               
            }
        }
        //  public PreferenceListModel(INavigationService navigationService, IMonkeyService monkeyService)
        //: base(navigationService)
        //  {
        //      Title = "Monkeys Horizontal List";

        //      _monkeyService = monkeyService;
        //  }
        //public MainPageViewModel(INavigationService navigationService, IMonkeyService monkeyService)
        //     : base(navigationService)
        //{
        //    Title = "Monkeys Horizontal List";

        //    _monkeyService = monkeyService;
        //}

        //public async override void OnNavigatingTo(NavigationParameters parameters)
        //{
        //    base.OnNavigatingTo(parameters);
        //    Monkeys = await _monkeyService.GetMonkey();
        //}

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
