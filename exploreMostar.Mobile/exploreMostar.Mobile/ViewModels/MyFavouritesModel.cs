using exploreMostar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
   public class MyFavouritesModel:BaseViewModel
    {
        private readonly APIService _favoriti = new APIService("MojiFavoriti");
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _nk = new APIService("Nightclubs");
        private readonly APIService _kafici = new APIService("Kafici");

        public ObservableCollection<Model.MojiFavoriti> favoriti { get; set; } = new ObservableCollection<Model.MojiFavoriti>();
        public MyFavouritesModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Model.Korisnici korisnik = null;
            var listaK = await _korisnici.Get<List<Model.Korisnici>>(null);
            var list = await _favoriti.Get<IList<Model.MojiFavoriti>>(null);
            foreach (var item in listaK)
            {
                if (item.KorisnickoIme == APIService.Username)
                    korisnik = item;
            }
            favoriti.Clear();
            var temp = 0;
            foreach (var item in list)
            {
                if (item.KorisnikId == korisnik.KorisnikId)
                {
                    item.Rbr = ++temp;
                    favoriti.Add(item);
                }
            }
        }

        public async void GetFavorite(object e)
        {
            var favorit = e as Model.MojiFavoriti;
            if (favorit.Vrsta == "Apartman")
            {
                var listaApartmana = await _apartmani.Get<List<Model.Apartmani>>(null);
                foreach(var item in listaApartmana)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }

            }
            if (favorit.Vrsta == "Atrakcija")
            {
                var listaAtrakcija = await _atrakcije.Get<List<Model.Atrakcije>>(null);
                foreach (var item in listaAtrakcija)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Restoran")
            {
                var listaRestorana = await _restorani.Get<List<Model.Restorani>>(null);
                foreach (var item in listaRestorana)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Hotel")
            {
                var listaHotela = await _hoteli.Get<List<Model.Hoteli>>(null);
                foreach (var item in listaHotela)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Nocni klub")
            {
                var listaNk = await _nk.Get<List<Model.Nightclubs>>(null);
                foreach (var item in listaNk)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Kafic")
            {
                var listaKafica = await _kafici.Get<List<Model.Kafici>>(null);
                foreach (var item in listaKafica)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
        }
    }
}
