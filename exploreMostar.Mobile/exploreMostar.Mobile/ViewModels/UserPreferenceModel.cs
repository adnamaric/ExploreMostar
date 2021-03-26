using exploreMostar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
   public  class UserPreferenceModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");

        public UserPreferenceModel()
        {
            Submit = new Command(async () => await UISet());
            
        }
        public bool _food = false;
        public bool Hrana
        {
            get { return _food; }
            set { SetProperty(ref _food, value); }
        }
      public bool _apartment= false;
        public bool Apartman
        {
            get { return _apartment; }
            set { SetProperty(ref _apartment, value); }
        }
       public bool _hotel = false;
        public bool Hotel
        {
            get { return _hotel; }
            set { SetProperty(ref _hotel, value); }
        }
       public bool _atraction = false;
        public bool Atrakcija
        {
            get { return _atraction; }
            set { SetProperty(ref _atraction, value); }
        }
      public  bool _transport = false;
        public bool Prevoz
        {
            get { return _transport; }
            set { SetProperty(ref _transport, value); }
        }
     public  bool _other = false;
        public bool Other
        {
            get { return _other; }
            set { SetProperty(ref _other, value); }
        }
        public bool _coffeeshops = false;
        public bool Kafic
        {
            get { return _coffeeshops; }
            set { SetProperty(ref _coffeeshops, value); }
        }
        public bool _nightclubs = false;
        public bool NK
        {
            get { return _nightclubs; }
            set { SetProperty(ref _nightclubs, value); }
        }
        public ICommand Submit { get; set; }
        public ICommand B1 { get; set; }
      
        async Task UISet()
        {
            APIService.Apartments = _apartment;
            APIService.Atraction = _atraction;
            APIService.Coffeeshops = _coffeeshops;
            APIService.Food = _food;
            APIService.Hotels = _hotel;
            APIService.Other = _other;
            APIService.Nightclubs = _nightclubs;
            APIService.Transport = _transport;

            if ( _atraction==false && _food == false && _apartment == false &&  _coffeeshops == false && _hotel == false && _transport == false && _nightclubs == false)
                await Application.Current.MainPage.DisplayAlert("Error", "Please select at least one item", "OK");
            else
            {
                Application.Current.MainPage = new PreferenceListPage();
            }

        }
    }
}
