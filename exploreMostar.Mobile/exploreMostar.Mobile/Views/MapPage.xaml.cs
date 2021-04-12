using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;
using exploreMostar.Mobile.ViewModels;
using exploreMostar.Mobile.Models;
using System.Diagnostics;
using Xamarin.Forms.PlatformConfiguration;
using System.IO;

namespace exploreMostar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private readonly APIService _favoriti = new APIService("MojiFavoriti");
        private readonly APIService _service = new APIService("Korisnici");

        public Model.Restorani selected=new Model.Restorani();
        public Model.Atrakcije selecteda = new Model.Atrakcije();
        public Model.Apartmani selectedap = new Model.Apartmani();
        public Model.Nightclubs selectedn = new Model.Nightclubs();
        public Model.Kafici selectedk = new Model.Kafici();
        public Model.Hoteli selectedh = new Model.Hoteli();
        public bool isRestoran;
        public bool isApartman;
        public bool isAtrakcija;
        public bool isNightClub;
        public bool isKafic;
        public bool isHotel;
        private readonly APIService korisnici = new APIService("Korisnici");
        private PreferenceListModel model = null;
        public object trenutniObj = null;
        public MapPage(object model1)
        {
            InitializeComponent();
            var backSelected = model1;
            var item = model1 as Model.Restorani;
            var item1 = model1 as Model.Atrakcije;
            var item2 = model1 as Model.Apartmani;
            var item3 = model1 as Model.Hoteli;
            var item4 = model1 as Model.Kafici;
            var item5 = model1 as Model.Nightclubs;
             isRestoran = (item == null) ? false : true;
             isAtrakcija = (item1 == null) ? false : true;
             isApartman = (item2 == null) ? false : true;
             isNightClub = (item5 == null) ? false : true;
             isKafic = (item4 == null) ? false : true;
             isHotel = (item3 == null) ? false : true;
            //selected =  model1;
            if (isRestoran == true)
            {
                if (APIService.modelTemp == null)
                {
                    selected = item;
                    btn1Stack.IsVisible = true;
                    btn1.IsVisible = true;
                    APIService.Vrsta = "Restoran";
                    APIService.modelTemp = selected;
                    APIService.ObjekatID = selected.RestoranId;
                }
                else
                {
                    selected = backSelected as Model.Restorani;
                    btn1Stack.IsVisible = true;
                    btn1.IsVisible = true;
                    APIService.Vrsta = "Restoran";
                    APIService.ObjekatID = selected.RestoranId;
                }
    }
            else if (isApartman == true)
            {
                if (APIService.modelTemp == null)
                {
                    selectedap = item2;
                    btn1Stack.IsVisible = false;
                    btn1Stack.HeightRequest = 0;
                    btn1Stack.WidthRequest = 0;
                    btn1.IsVisible = false;
                    APIService.Vrsta = "Apartman";
                    APIService.modelTemp = selectedap;
                    APIService.ObjekatID = selectedap.ApartmanId;
                }
                else
                {
                    selectedap = backSelected as Model.Apartmani;
                    APIService.Vrsta = "Apartman";
                 
                    APIService.ObjekatID = selectedap.ApartmanId;
                }
            }
            else if (isAtrakcija == true)
            {
                if (APIService.modelTemp == null)
                {
                    selecteda = item1;
                    btn1Stack.IsVisible = false;
                    btn1Stack.HeightRequest = 0;
                    btn1Stack.WidthRequest = 0;
                    btn1.IsVisible = false;
                    APIService.Vrsta = "Atrakcija";
                    APIService.modelTemp = selecteda;
                    APIService.ObjekatID = selecteda.AtrakcijaId;
                }
                else
                {
                    selecteda = backSelected as Model.Atrakcije;
                    APIService.Vrsta = "Atrakcija";
                    APIService.ObjekatID = selecteda.AtrakcijaId;
                }
            }
            else if (isNightClub == true)
            {
                if (APIService.modelTemp == null)
                {
                    selectedn = item5;
                    btn1Stack.IsVisible = false;
                    btn1Stack.HeightRequest = 0;
                    btn1Stack.WidthRequest = 0;
                    btn1.IsVisible = false;
                    APIService.Vrsta = "Nocni klub";
                    APIService.modelTemp = selectedn;
                    APIService.ObjekatID = selectedn.NightClubId;
                }
                else
                {
                    selectedn = backSelected as Model.Nightclubs;
                    APIService.Vrsta = "Nocni klub";
                    APIService.ObjekatID = selectedn.NightClubId;
                }
            }
            else if(isKafic== true)
            {
                if (APIService.modelTemp == null)
                {
                    selectedk = item4;
                    btn1Stack.IsVisible = false;
                    btn1Stack.HeightRequest = 0;
                    btn1Stack.WidthRequest = 0;
                    btn1.IsVisible = false;
                    APIService.Vrsta = "Kafic";
                    APIService.modelTemp = selectedk;
                    APIService.ObjekatID = selectedk.KaficId;
                }
                else
                {
                    selectedk = backSelected as Model.Kafici;
                    APIService.Vrsta = "Kafic";
                    APIService.ObjekatID = selectedk.KaficId;
                }
            }
            else if(isHotel == true)
            {
                if (APIService.modelTemp == null)
                {
                    selectedh = item3;
                    btn1Stack.IsVisible = false;
                    btn1Stack.HeightRequest = 0;
                    btn1Stack.WidthRequest = 0;
                    btn1.IsVisible = false;
                    APIService.Vrsta = "Hotel";
                    APIService.modelTemp = selectedh;
                    APIService.ObjekatID = selectedh.HotelId;
                }
                else
                {
                    selectedh = backSelected as Model.Hoteli;
                    APIService.Vrsta = "Hotel";
                    APIService.ObjekatID = selectedh.HotelId;
                }
            }
           
            BindingContext = model = new PreferenceListModel();
         
            Get();
            navmenu.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Row-52.png");
            navmenu.WidthRequest = 20;
            navmenu.HeightRequest = 20;
            messageBox.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Chat-88.png");
         
           

            logout.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Logout-82.png");
            newsBox.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Newspaper-80.png");
            // reviews.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Rating-52.png");
            reviews.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.showfavourites.png");
            favs.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.heart.png");
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
            //label.Text = "Name: "+selected.Naziv;
            //ocjena.Text ="Rate: "+ selected.Ocjena.ToString();
            APIService.InboxLista = false;
            APIService.UPContentPage = false;
            APIService.PreferenceListPage = false;
            APIService.MapPage = true;
            APIService.modelTemp = model1;
            model.CheckIfFavourite();
        }
        CancellationTokenSource cts;
        TaskCompletionSource<PermissionStatus> tcs;
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            await model.GetT(selected);
            
        }
        async Task GetCurrentLocation()
        {


                //Position position = new Position((double)selected.Longitude, (double)selected.Longitude);
         //   Location restoran = new Location((double)selected.Longitude, (double)selected.Longitude);

            try
            {
                
                //var lat = 47.673988;
                //var lon = -122.121513;

                //var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                //var placemark = placemarks?.FirstOrDefault();
                //if (placemark != null)
                //{
                //    var geocodeAddress =
                //        $"AdminArea:       {placemark.AdminArea}\n" +
                //        $"CountryCode:     {placemark.CountryCode}\n" +
                //        $"CountryName:     {placemark.CountryName}\n" +
                //        $"FeatureName:     {placemark.FeatureName}\n" +
                //        $"Locality:        {placemark.Locality}\n" +
                //        $"PostalCode:      {placemark.PostalCode}\n" +
                //        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                //        $"SubLocality:     {placemark.SubLocality}\n" +
                //        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                //        $"Thoroughfare:    {placemark.Thoroughfare}\n";

                //    Console.WriteLine(geocodeAddress);
                //}
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            Location location1=null;
            if (status.ToString() == "Denied")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "In order to use this, you need to enable your current location!", "OK");

            }
            try
            {
                btn2.BackgroundColor = Color.White;
                btn2.TextColor = Color.DarkRed;
                var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                tcs = new TaskCompletionSource<PermissionStatus>();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);
                location1 = location;
                if (location != null)
                {
                    Map.IsShowingUser = true;
                  //  await Application.Current.MainPage.DisplayAlert("Your location", $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}", "OK");
                    //Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
               

            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                await Application.Current.MainPage.DisplayAlert("Error", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            if (isRestoran == true)
            {
                Location resto = new Location((double)selected.Longitude, (double)selected.Latitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(resto, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selected.Naziv,
                    Address = selected.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selected.Latitude, (double)selected.Longitude)
                };
                Map.Pins.Add(pin);
            }
            if (isApartman == true)
            {
                Location aparto = new Location((double)selectedap.Longitude, (double)selectedap.Latitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(aparto, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selectedap.Naziv,
                    Address = selectedap.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedap.Latitude, (double)selectedap.Longitude)
                };
                Map.Pins.Add(pin);
            }
            if (isAtrakcija == true)
            {
                Location atraction = new Location((double)selecteda.Longitude, (double)selecteda.Latitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(atraction, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selecteda.Naziv,
                    Address = selecteda.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selecteda.Latitude, (double)selecteda.Longitude)
                };
                Map.Pins.Add(pin);
            }
            if (isHotel == true)
            {
                Location hotel = new Location((double)selectedh.Longitude, (double)selectedh.Latitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(hotel, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selectedh.Naziv,
                    Address = selectedh.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedh.Latitude, (double)selectedh.Longitude)
                };
                Map.Pins.Add(pin);
            }
            if (isKafic == true)
            {
                Location kafic = new Location((double)selectedk.Longitude, (double)selectedk.Latitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(kafic, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selectedk.Naziv,
                    Address = selectedk.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedk.Latitude, (double)selectedk.Longitude)
                };
                Map.Pins.Add(pin);
            }
            if (isHotel == true)
            {
                Location hotel = new Location((double)selectedh.Longitude, (double)selectedh.Latitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(hotel, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selectedh.Naziv,
                    Address = selectedh.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedh.Latitude, (double)selectedh.Longitude)
                };
                Map.Pins.Add(pin);
                
            }
        }
        Task<Xamarin.Essentials.Location> GetLocationFromPhone()
        {

            var locationTaskCompletionSource = new TaskCompletionSource<Xamarin.Essentials.Location>();

            Device.BeginInvokeOnMainThread(async () =>
            {
                locationTaskCompletionSource.SetResult(await Geolocation.GetLastKnownLocationAsync());
            });

            return locationTaskCompletionSource.Task;
        }
        async Task ExecuteGetGeoLocationCommand()
        {
            try
            {
                var locationFromPhone = await GetLocationFromPhone().ConfigureAwait(false);

                if (locationFromPhone is null)
                    return;

                //_location = locationFromPhone;

                //if (_location != null)
                //{
                //    Console.WriteLine($"Latitude: {_location.Latitude}, Longitude {_location.Longitude}, Altitude: {_location.Altitude}");
                //}
                //else
                //{
                //    Console.WriteLine($"Exiting geolocation");
                //}
            }
            catch (FeatureNotSupportedException fnsEx)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public async void Get()
        {
            await GetCurrentLocation();
        }
        private async void GetPermission()
        {
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status.ToString() != "granted")
            {
                var results = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
                
            }
        }

        private  void btn2_Clicked(object sender, EventArgs e)
        {
            Stack2.IsVisible = true;
            
            
            Stack2.HeightRequest = 500;
            Map.IsVisible = true;
            Map.HasZoomEnabled = true;
            
            Stacky1.IsVisible = false;
            btn2.TextColor = Color.DarkRed;
            btn2.FontAttributes = FontAttributes.Bold;
            btn2.BackgroundColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            info.IsVisible = false;
            Recenzije.IsVisible = false;
            Recenzije.HeightRequest = 0;
            btnRecenzije.TextColor = Color.White;
            btnRecenzije.BackgroundColor = Color.DarkRed;
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            info.IsVisible = true;
            Model.Korisnici korisnik = new Model.Korisnici();
            var list = await _service.Get<IList<Model.Korisnici>>(null);

            foreach (var item in list)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    korisnik = item;

                    break;
                }
            }
            var listaFavorita = await _favoriti.Get<IList<Model.MojiFavoriti>>(null);

            foreach (var item in listaFavorita)
            {
                if (item.Naziv == APIService.Naziv && item.KorisnikId == korisnik.KorisnikId)
                {
                    APIService.postojiFavorit = true;


                }
            }
            if (!APIService.postojiFavorit)
            {
                MyFavs.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.heart.png");
                MyFavs.Text = "Add to my favourites";
            }
            else
            {
                MyFavs.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.addedheart.png");
                MyFavs.Text = "";
            }
            if (APIService.postojiFavorit)
            {
                model.CheckIfFavourite();
                Recommend.IsVisible = true;
                lista.IsVisible = true;
                lista.HeightRequest = 100;
            }

            info.HeightRequest = 650;
            Map.IsVisible = false;
            Stacky1.IsVisible = false;
            Stack2.IsVisible = false;
            Stack2.HeightRequest = 0;
            
            btn3.TextColor = Color.DarkRed;
            btn3.BackgroundColor = Color.White;
            btn3.FontAttributes = FontAttributes.Bold;
            //   Stack2.IsVisible = false;
          
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            if (isRestoran == true)
            {
                if (selected.Naziv == "Megamarkt")
                    respicture.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.restoran1.png");
                if (selected.Naziv == "restoran 1")
                    respicture.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.restoran1.jpg");

                Naziv.Text = selected.Naziv;
                Lokacija.Text = selected.Lokacija;
                Godina.Text = selected.GodinaIzgradnje.ToString();
                Rating.Text = selected.Ocjena.ToString();
                if (selected.VrstaId == 1)
                    Type.Text = "Restaurant";
                if (selected.VrstaId == 2)
                    Type.Text = "Fast Food";
                if (selected.VrstaId == 3)
                    Type.Text = "N/A";
                



            }
            if(isApartman== true)
            {
                Naziv.Text = selectedap.Naziv;
                Lokacija.Text = selectedap.Lokacija;
                Godina.Text = selectedap.GodinaIzgradnje.ToString();
                Rating.Text = selectedap.Ocjena.ToString();
            }
            if (isAtrakcija == true)
            {
                Naziv.Text = selecteda.Naziv;
                Lokacija.Text = selecteda.Lokacija;
                Rating.Text = selecteda.Ocjena.ToString();
                if (selected.VrstaId == 1)
                    Type.Text = "Natural atraction";
                if (selected.VrstaId == 2)
                    Type.Text = "Historical atraction";
                if (selected.VrstaId == 3)
                    Type.Text = "Religion atraction";
                if (selected.VrstaId == 4)
                {
                    Type.Text = "N/A";
                }
            }
            //if (model.GetRecenzije.CanExecute(null))
            // model.GetRecenzije.Execute(null);
            Recenzije.IsVisible = false;
            Recenzije.HeightRequest = 0;
            btnRecenzije.TextColor = Color.White;
            btnRecenzije.BackgroundColor = Color.DarkRed;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
          
             Map.IsVisible = false;
            Stack2.IsVisible = false;
            Stack2.HeightRequest = 0;
            info.IsVisible = false;
            info.HeightRequest = 0;
          
            // Stack2.IsVisible = true;
            Stacky1.IsVisible = true;
            btn1.TextColor = Color.DarkRed;
            btn1.BackgroundColor = Color.White;
            btn1.FontAttributes = FontAttributes.Bold;
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            Recenzije.IsVisible = false;
            Recenzije.HeightRequest = 0;

            btnRecenzije.TextColor = Color.White;
            btnRecenzije.BackgroundColor = Color.DarkRed;
        }

        private async void btn4_Clicked(object sender, EventArgs e)
        {
          //  await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-calendar"));

            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status.ToString() == "Denied")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "In order to use this, you need to enable your current location! {Search -> LocationPrivacy -> Turn on ", "OK");

                
            }
         
           try
            {
                //GetLocationPermission()

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void btnRecenzije_Clicked(object sender, EventArgs e)
        {
          
            model.GetReviews();
            Recenzije.IsVisible = true;
            Recenzije.HeightRequest = 500;
            Map.IsVisible = false;
            Stack2.IsVisible = false;
            Stack2.HeightRequest = 0;
            info.IsVisible = false;
            info.HeightRequest = 0;
            // Stack2.IsVisible = true;
            Stacky1.IsVisible = false;
         
            btnRecenzije.TextColor = Color.DarkRed;
            btnRecenzije.BackgroundColor = Color.White;
            btnRecenzije.FontAttributes = FontAttributes.Bold;
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
        }

        private void postButton_Clicked(object sender, EventArgs e)
        {
           
            model.AddReview();
         


        }
        private void ShowReviews()
        {
          
            Recenzije.IsVisible = true;
            Recenzije.HeightRequest = 500;
            Map.IsVisible = false;
            Stack2.IsVisible = false;
            Stack2.HeightRequest = 0;
            info.IsVisible = false;
            info.HeightRequest = 0;
            // Stack2.IsVisible = true;
            Stacky1.IsVisible = false;

            btnRecenzije.TextColor = Color.DarkRed;
            btnRecenzije.BackgroundColor = Color.White;
            btnRecenzije.FontAttributes = FontAttributes.Bold;
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            model.GetReviews();
            APIService.PreferenceListPage = false;
            APIService.UPContentPage = false;
            APIService.InboxLista = false;
            APIService.MapPage = true;
        }

        private void goBack_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PreferenceListPage();
        }

        private async void navmenu_Clicked(object sender, EventArgs e)
        {
            if (NavigationPane.IsVisible == true)
            {
                NavigationPane.IsVisible = false;
                await navmenu.RotateTo(180, 200);


            }
            else
            {
                NavigationPane.IsVisible = true;
                await navmenu.RotateTo(90, 200);
                var lista = await korisnici.Get<IList<Model.Korisnici>>(null);
                Model.Korisnici korisnik = new Model.Korisnici();
                foreach (var item in lista)
                {
                    if (item.KorisnickoIme == APIService.Username)
                    {
                        korisnik = item;
                    }
                }
                spanUser.Text = korisnik.Ime + " " + korisnik.Prezime;
            }
        }

        private void messageBox_Clicked(object sender, EventArgs e)
        {
        
            Application.Current.MainPage = new InboxPage();
        }

        private void newsBox_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CheckPosts();
        }

        private void logout_Clicked(object sender, EventArgs e)
        {
            model.DeleteUnsuccessfulLogins();
            Application.Current.MainPage = new OpeningPage();
        }

        private void reviews_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MyReviewsPage();
        }

        private void MyFavs_Clicked(object sender, EventArgs e)
        {
           
                MyFavs.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.addedheart.png");
                MyFavs.Text = "";
                
                model.AddFavourite();
            
        }

        private void favs_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MyFavouritesPage();
        }

        private void Recomend_SizeChanged(object sender, EventArgs e)
        {

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
   
}
