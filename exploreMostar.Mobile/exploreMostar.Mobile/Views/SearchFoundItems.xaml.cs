using exploreMostar.Mobile.Models;
using exploreMostar.Mobile.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace exploreMostar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchFoundItems : ContentPage
    {
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _nocniklubovi = new APIService("Nightclubs");
        private readonly APIService _searchS = new APIService("Search");
        private readonly APIService korisnici = new APIService("Korisnici");
        private SearchResultModel model = null;
        public ObservableCollection<Model.ReportClass> temp { get; set; } = new ObservableCollection<Model.ReportClass>();
        public string some=string.Empty;
        
        public SearchFoundItems(string _search)
        {
            InitializeComponent();
            BindingContext = model = new SearchResultModel();
          model.SearchResult(_search);
            spanSearch.Text = _search;
            some = _search;
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
            APIService.SearchCon = _search;

            //foreach (var item in APIService.searchListaObjekata)
            //{
            //    Pin pin = new Pin
            //    {
            //        Label = item.Naziv,
            //        Address = item.Adresa,
            //        Type = PinType.Place,
            //        Position = new Position((double)item.Latitude, (double)item.Longitude)
            //    };
            //    Mapa.Pins.Add(pin);
            AddPins();
            }


        //public async void  GetPins()
        //{
        //    var list = await _service.Get<IList<Model.Korisnici>>(null);
        //    var trazeni = APIService.SearchCon;
        //    var lista = model.searchItems;
        //    var lista1 = APIService.searchListaObjekata;


        //}
        CancellationTokenSource cts;
        TaskCompletionSource<PermissionStatus> tcs;
        public async void AddPins()
        {
            var listApartmana = await _apartmani.Get<IList<Model.Apartmani>>(null);
            var listaAtrakcija = await _atrakcije.Get<IList<Model.Atrakcije>>(null);
            var listaKafica = await _kafici.Get<IList<Model.Kafici>>(null);
            var listaHotela = await _hoteli.Get<IList<Model.Hoteli>>(null);
            var listaRestorana = await _restorani.Get<IList<Model.Restorani>>(null);
            var listaNk = await _nocniklubovi.Get<IList<Model.Nightclubs>>(null);
            object trazeniModel = null;
            foreach (var item in listApartmana)
            {
                string lowerSearch = APIService.SearchCon.ToLower();
                string lowerLetters = item.Naziv.ToLower();
                if (lowerLetters.Contains(lowerSearch))
                {
                    trazeniModel = item;

                    temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = item.Vrsta, Latitude = item.Latitude, Longitude = item.Longitude, Adresa = item.Lokacija });
                }
            }

            foreach (var item in listaAtrakcija)
            {
                string lowerSearch = APIService.SearchCon.ToLower();
                string lowerLetters = item.Naziv.ToLower();
                if (lowerLetters.Contains(lowerSearch))
                {
                    trazeniModel = item;
                    temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = item.Vrsta, Latitude = item.Latitude, Longitude = item.Longitude, Adresa = item.Lokacija });
                }
            }



            foreach (var item in listaHotela)
            {
                string lowerSearch = APIService.SearchCon.ToLower();
                string lowerLetters = item.Naziv.ToLower();
                if (lowerLetters.Contains(lowerSearch))
                {
                    trazeniModel = item;
                    temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Hotel", Latitude = item.Latitude, Longitude = item.Longitude, Adresa = item.Lokacija });
                }
            }



            foreach (var item in listaKafica)
            {
                string lowerSearch = APIService.SearchCon.ToLower();
                string lowerLetters = item.Naziv.ToLower();
                if (lowerLetters.Contains(lowerSearch))
                {
                    trazeniModel = item;
                    temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Kafic", Latitude = item.Latitude, Longitude = item.Longitude, Adresa = item.Lokacija });
                }
            }


            foreach (var item in listaRestorana)
            {
                string lowerSearch = APIService.SearchCon.ToLower();
                string lowerLetters = item.Naziv.ToLower();
                if (lowerLetters.Contains(lowerSearch))
                {
                    trazeniModel = item;
                    temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Restoran", Latitude = item.Latitude, Longitude = item.Longitude, Adresa = item.Lokacija });
                }
            }


            foreach (var item in listaNk)
            {
                string lowerSearch = APIService.SearchCon.ToLower();
                string lowerLetters = item.Naziv.ToLower();
                if (lowerLetters.Contains(lowerSearch))
                {
                    trazeniModel = item;
                    temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Nightclub", Latitude = item.Latitude, Longitude = item.Longitude, Adresa = item.Lokacija });
                }
            }
            var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10));
            cts = new CancellationTokenSource();
            tcs = new TaskCompletionSource<PermissionStatus>();
            var location = await Geolocation.GetLocationAsync(request, cts.Token);

            var client = new System.Net.Http.HttpClient();
            foreach (var item in temp)
            {
                Pin pin = new Pin
                {
                    Label = item.Naziv,
                    Address = item.Adresa,
                    Type = PinType.Place,
                    Position = new Position((double)item.Latitude, (double)item.Longitude)
                };
                Mapa.Pins.Add(pin);
              
                
                var lat1 = item.Latitude;
                var lon1 = item.Longitude;
                var lat2 = location.Latitude;
                var lon2 = location.Longitude;
                string trazeniUrl = @"https://maps.googleapis.com/maps/api/directions/json?origin=" + lat2 + "," + lon2 + "&destination=" + lat1 + "," + lon1 + "&key=AIzaSyDP-0g1tNQWjpbUKC0uLv3tJ7GGm6a3t8Q";
                var response = await client.GetAsync(trazeniUrl);
                string contactsJson = await response.Content.ReadAsStringAsync(); //Getting response  

                GoogleDirection ObjContactList = new GoogleDirection();
                if (response != null)
                {
                    ObjContactList = JsonConvert.DeserializeObject<GoogleDirection>(contactsJson);
                }
                Xamarin.Forms.Maps.Polyline polyline = new Xamarin.Forms.Maps.Polyline
                {
                    StrokeColor = Color.Blue,
                    StrokeWidth = 12,
                };
                var brojRouta = ObjContactList.Routes[0].Legs[0].Steps.Count();


                for (int i = 0; i < brojRouta; i++)
                {
                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lng));
                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lng));

                }
                Mapa.MapElements.Add(polyline);

            }
        }
        protected  override void OnAppearing()
        {
            base.OnAppearing();
            // await model.Init();
          
        }

        private void goBack_Clicked(object sender, EventArgs e)
        {
            APIService.SearchLista = false;
            APIService.Pretraga = string.Empty;
            Application.Current.MainPage = new PreferenceListPage();
        }

        private void MyRecenzijeView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            APIService.SearchLista = true;
            APIService.Pretraga = some;
            APIService.PreferenceListPage = false;
            
            model.GetResult(e.SelectedItem);
        }
    }
}