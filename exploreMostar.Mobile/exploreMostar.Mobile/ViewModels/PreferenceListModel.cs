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
        private readonly APIService _jelovnik = new APIService("Jelovnik");
        private readonly APIService _jela = new APIService("Jela");
        private readonly APIService _recenzije = new APIService("Recenzije");


        public ObservableCollection<Model.Restorani> restoranis { get; set; } = new ObservableCollection<Model.Restorani>();
        public ObservableCollection<Model.Atrakcije> atrakcije { get; set; } = new ObservableCollection<Model.Atrakcije>();
        public ObservableCollection<Model.ReportClass> temp { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp1 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp2 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp3 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.ReportClass> temp4 { get; set; } = new ObservableCollection<Model.ReportClass>();
        public ObservableCollection<Model.Kafici> kafici { get; set; } = new ObservableCollection<Model.Kafici>();
        public ObservableCollection<Model.Jela> jelas { get; set; } = new ObservableCollection<Model.Jela>();
        public ObservableCollection<Model.Apartmani> apartmanis { get; set; } = new ObservableCollection<Model.Apartmani>();
        public ObservableCollection<Model.Hoteli> hotelis { get; set; } = new ObservableCollection<Model.Hoteli>();
        public ObservableCollection<Model.Nightclubs> nightclubs { get; set; } = new ObservableCollection<Model.Nightclubs>();
        public ObservableCollection<Model.Recenzije> recenzijes { get; set; } = new ObservableCollection<Model.Recenzije>();

        public ICommand InitCommand { get; set; }
        public ICommand GetSelectedOne { get; set; }
        public string parametar;
        public Model.Restorani model = new Model.Restorani();

        public PreferenceListModel()
        {
            //Setuj();
            InitCommand = new Command(async () => await Init());
            //GetSelectedOne = new Command(async () => await GetT());
           // GetRecenzije = new Command(async () => await GetRecenzijeFunction());
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
            Recenzije = APIService.Recenzije;
            if (Food == true)
            {

                var list = await _restorani.Get<IList<Model.Restorani>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                restoranis.Clear();
                temp.Clear();
                jelas.Clear();
                foreach (var item in list)
                {
                    if(item.PutanjaSlike!=null)
                        APIService.PutanjaSlike = item.PutanjaSlike;

                    restoranis.Add(item);
                    temp.Add(new Model.ReportClass {Naziv=item.Naziv, Ocjena=item.Ocjena });
                    
                }

                var list1 = await _jela.Get<IList<Model.Jela>>(null);
                list1 = list1.OrderByDescending(y => y.Ocjena).ToList();
                foreach(var item in list1)
                {
                    jelas.Add(item);
                    
                }
              
                var broj = 0;
                foreach(var item in jelas)
                {
                    item.Rbr = ++broj;
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
                   // temp1.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

                }

            }
            if (Apartmani == true)
            {
                var list = await _apartmani.Get<IEnumerable<Model.Apartmani>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                apartmanis.Clear();
                temp2.Clear();
                foreach (var item in list)
                {
                    apartmanis.Add(item);
                   // temp2.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

                }
            }
            if (Hoteli == true)
            {
                var list = await _hoteli.Get<IEnumerable<Model.Hoteli>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                hotelis.Clear();
                temp3.Clear();
                foreach (var item in list)
                {
                    hotelis.Add(item);
                    //temp3.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena });

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
            if (NocniKlubovi == true)
            {
                var list = await _nocniklubovi.Get<IEnumerable<Model.Nightclubs>>(null);
                list = list.OrderByDescending(y => y.Ocjena).ToList();
                temp4.Clear();
                nightclubs.Clear();
                foreach (var item in list)
                {

                    //temp4.Add(new Model.ReportClass { Naziv = item.Naziv,Ocjena=item.Ocjena });
                    nightclubs.Add(item);
                }
            }
            if (APIService.Naziv != null)
            {
                recenzijes.Clear();
                var list = await _recenzije.Get<IList<Model.Recenzije>>(null);
                if (list.Count() != 0)
                {
                    list = list.Where(y => y.Objekat == APIService.Naziv).ToList();
                    foreach (var item in list)
                    {
                        recenzijes.Add(item);
                    }

                }
                var broj = 0;
                foreach (var item in recenzijes)
                {
                    item.Rbr = ++broj;
                }
            }
            if (recenzijes.Count() != 0)
                Recenzije = true;

        }
        //public ICommand GetRecenzije { get; set; }
        //public async Task GetRecenzijeFunction()
        //{
        //    await _service.Get<dynamic>(null);
          
        //}
        public async Task GetT(Model.Restorani model)
        {
            this.model = model;
            _naziv = model.Naziv;
        }
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
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
        public bool Recenzije = false;
        public async void Setuj()
        {
         
         
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
      

   

    }
}
