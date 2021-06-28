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
using Newtonsoft.Json;

namespace exploreMostar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private readonly APIService _favoriti = new APIService("MojiFavoriti");
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _recenzije = new APIService("Recenzije");

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
        public double udaljenost;
       static bool preference = APIService.PreferenceListPage;
        static bool search = APIService.SearchLista;
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
                because.IsVisible = false;
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
                location1 = await Geolocation.GetLocationAsync(request);
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
            List<string> rute = new List<string>();
            //List<string> distanca = new List<string>();
            //List<string> duration = new List<string>();

            if (isRestoran == true)
            {
                
                Location resto = new Location((double)selected.Latitude, (double)selected.Longitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(resto, location1, DistanceUnits.Kilometers);
                    udaljenost = kilometers;
                    double meters = kilometers * 1000;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{kilometers} kilometara", "OK");
                    kilometers = Math.Round((double)kilometers,2);
                    spanUdaljenost.Text = kilometers.ToString();
                }
                Pin pin = new Pin
                {
                    Label = selected.Naziv,
                    Address = selected.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selected.Latitude, (double)selected.Longitude)
                };
               
                
                Map.Pins.Add(pin);
                var client = new System.Net.Http.HttpClient();
                var lat1 = selected.Latitude;
                var lon1 = selected.Longitude;
                var lat2 = location1.Latitude;
                var lon2 = location1.Longitude;
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
                    rute.Add(ObjContactList.Routes[0].Legs[0].Steps[i].HtmlInstructions);
                  
                }
         
                trajanjeP.Text = ObjContactList.Routes[0].Legs[0].Duration.Text;
                start.Text = ObjContactList.Routes[0].Legs[0].StartAddress;
                end.Text= ObjContactList.Routes[0].Legs[0].EndAddress;
                
                    Map.MapElements.Add(polyline);
            }
            if (isApartman == true)
            {
                Location aparto = new Location((double)selectedap.Latitude, (double)selectedap.Longitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(aparto, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    udaljenost = kilometers;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{kilometers} kilometara", "OK");
                    kilometers = Math.Round(kilometers,2);
                    spanUdaljenost.Text = kilometers.ToString();
                }
                Pin pin = new Pin
                {
                    Label = selectedap.Naziv,
                    Address = selectedap.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedap.Latitude, (double)selectedap.Longitude),
                    
                };

                //Circle polygon = new Circle
                //{
                //    StrokeColor = Color.Red,
                //    StrokeWidth = 12,
                //    Center = new Position((double)selectedap.Latitude, (double)selectedap.Longitude),
                //    Radius = new Distance(250),
                //    //             Geopath =
                //    //             {
                //    //new Position(location1.Latitude, location1.Longitude),
                //    // new Position((double)selectedap.Latitude, (double)selectedap.Longitude)
                //    //             }
                //};
                
                //Map.MapElements.Add(polygon);
                Map.Pins.Add(pin);
                
                var client = new System.Net.Http.HttpClient();
                var lat1 = selectedap.Latitude;
                var lon1 = selectedap.Longitude;
                var lat2 = location1.Latitude;
                var lon2 = location1.Longitude;
              
                string trazeniUrl= @"https://maps.googleapis.com/maps/api/directions/json?origin=" + lat2 + "," + lon2 + "&destination=" + lat1 + "," + lon1 + "&key=AIzaSyDP-0g1tNQWjpbUKC0uLv3tJ7GGm6a3t8Q";
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
                Map.MapElements.Add(polyline);

                trajanjeP.Text = ObjContactList.Routes[0].Legs[0].Duration.Text;
                start.Text = ObjContactList.Routes[0].Legs[0].StartAddress;
                end.Text = ObjContactList.Routes[0].Legs[0].EndAddress;




            }
            if (isAtrakcija == true)
            {
                Location atraction = new Location((double)selecteda.Latitude, (double)selecteda.Longitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(atraction, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    udaljenost = kilometers;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{kilometers}kilometara", "OK");
                    kilometers = Math.Round(kilometers,2);
                    spanUdaljenost.Text = kilometers.ToString();
                }
                Pin pin = new Pin
                {
                    Label = selecteda.Naziv,
                    Address = selecteda.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selecteda.Latitude, (double)selecteda.Longitude)
                };
                Map.Pins.Add(pin);
                var client = new System.Net.Http.HttpClient();
                var lat1 = selecteda.Latitude;
                var lon1 = selecteda.Longitude;
                var lat2 = location1.Latitude;
                var lon2 = location1.Longitude;

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
                trajanjeP.Text = ObjContactList.Routes[0].Legs[0].Duration.Text;
                start.Text = ObjContactList.Routes[0].Legs[0].StartAddress;
                end.Text = ObjContactList.Routes[0].Legs[0].EndAddress;
                Map.MapElements.Add(polyline);
            }
            if (isHotel == true)
            {
                Location hotel = new Location((double)selectedh.Latitude, (double)selectedh.Longitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(hotel, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    udaljenost = kilometers;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{kilometers} kilometara", "OK");
                    kilometers = Math.Round(kilometers,2);
                    spanUdaljenost.Text = kilometers.ToString();
                }
                Pin pin = new Pin
                {
                    Label = selectedh.Naziv,
                    Address = selectedh.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedh.Latitude, (double)selectedh.Longitude)
                };
                Map.Pins.Add(pin);
                var client = new System.Net.Http.HttpClient();
                var lat1 = selectedh.Latitude;
                var lon1 = selectedh.Longitude;
                var lat2 = location1.Latitude;
                var lon2 = location1.Longitude;
                //fit-lokacija
                var lat3 = 43.355280;
                var lng3 = 17.809992;
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
                //polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].StartLocation.Lng));
                //polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].EndLocation.Lng));

                for (int i = 0; i < brojRouta; i++)
                {


                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lng));
                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lng));


                }
                trajanjeP.Text = ObjContactList.Routes[0].Legs[0].Duration.Text;
                start.Text = ObjContactList.Routes[0].Legs[0].StartAddress;
                end.Text = ObjContactList.Routes[0].Legs[0].EndAddress;
                Map.MapElements.Add(polyline);
            }
            if (isKafic == true)
            {
                Location kafic = new Location((double)selectedk.Latitude, (double)selectedk.Longitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(kafic, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    udaljenost = kilometers;
                    meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{kilometers} kilometara", "OK");
                    kilometers = Math.Round(kilometers,2);
                    spanUdaljenost.Text = kilometers.ToString();
                }
                Pin pin = new Pin
                {
                    Label = selectedk.Naziv,
                    Address = selectedk.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedk.Latitude, (double)selectedk.Longitude)
                };
                Map.Pins.Add(pin);
                var client = new System.Net.Http.HttpClient();
                var lat1 = selectedk.Latitude;
                var lon1 = selectedk.Longitude;
                var lat2 = location1.Latitude;
                var lon2 = location1.Longitude;

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
                //polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].StartLocation.Lng));
                //polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].EndLocation.Lng));

                for (int i = 0; i < brojRouta; i++)
                {


                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lng));
                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lng));


                }
                trajanjeP.Text = ObjContactList.Routes[0].Legs[0].Duration.Text;
                start.Text = ObjContactList.Routes[0].Legs[0].StartAddress;
                end.Text = ObjContactList.Routes[0].Legs[0].EndAddress;
                Map.MapElements.Add(polyline);
            }
            if (isNightClub == true)
            {
                Location hotel = new Location((double)selectedn.Latitude, (double)selectedn.Longitude);
                if (location1 != null)
                {
                    double kilometers = Location.CalculateDistance(hotel, location1, DistanceUnits.Kilometers);
                    double meters = kilometers * 1000;
                    udaljenost = kilometers;
                    kilometers = Math.Round(kilometers,2);
                    spanUdaljenost.Text = kilometers.ToString();
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{kilometers}  kilometara", "OK");
                }
                Pin pin = new Pin
                {
                    Label = selectedn.Naziv,
                    Address = selectedn.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selectedn.Latitude, (double)selectedn.Longitude)
                };
                Map.Pins.Add(pin);
                var client = new System.Net.Http.HttpClient();
                var lat1 = selectedn.Latitude;
                var lon1 = selectedn.Longitude;
                var lat2 = location1.Latitude;
                var lon2 = location1.Longitude;
              
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
                //polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].StartLocation.Lng));
                //polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].EndLocation.Lng));
                
                for (int i = 0; i < brojRouta; i++)
                {


                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].StartLocation.Lng));
                    polyline.Geopath.Add(new Position(ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lat, ObjContactList.Routes[0].Legs[0].Steps[i].EndLocation.Lng));
                    

                }
                trajanjeP.Text = ObjContactList.Routes[0].Legs[0].Duration.Text;
                start.Text = ObjContactList.Routes[0].Legs[0].StartAddress;
                end.Text = ObjContactList.Routes[0].Legs[0].EndAddress;
                Map.MapElements.Add(polyline);
            }
            if (udaljenost >= 3)
            {
                model.CheckDistance(udaljenost);
              
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
            if (udaljenost >= 3)
            {
                model.CheckDistance(udaljenost);
                transport.IsVisible = true;
                
            }
            
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
            var listaRecenzija = await _recenzije.Get<IList<Model.Recenzije>>(null);
       

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
                because.IsVisible = true;
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
            double ukupna = 0.0;
            int brojac = 0;
            if (isRestoran == true)
            {
                if (selected.Naziv == "Megamarkt")
                    respicture.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.restoran1.png");
                if (selected.Naziv == "restoran 1")
                    respicture.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.restoran1.jpg");
                foreach(var item in listaRecenzija)
                {
                    if (item.Objekat == selected.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                ukupna +=(double) selected.Ocjena;
                brojac++;
                ukupna /= brojac;
               
                Rating.Text = ukupna.ToString();
                Naziv.Text = selected.Naziv;
                Lokacija.Text = selected.Lokacija;
                Godina.Text = selected.GodinaIzgradnje.ToString();

               
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
                foreach (var item in listaRecenzija)
                {
                    if (item.Objekat == selectedap.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                ukupna += (double)selectedap.Ocjena;
                brojac++;
                ukupna /= brojac;
                Rating.Text = ukupna.ToString();
                
            }
            if (isAtrakcija == true)
            {
                Naziv.Text = selecteda.Naziv;
                Lokacija.Text = selecteda.Lokacija;
                foreach (var item in listaRecenzija)
                {
                    if (item.Objekat == selecteda.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                ukupna += (double)selecteda.Ocjena;
                brojac++;
                ukupna /= brojac;
                Rating.Text = ukupna.ToString();
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
            if (isHotel == true)
            {
                Naziv.Text = selectedh.Naziv;
                Lokacija.Text = selectedh.Lokacija;
                foreach (var item in listaRecenzija)
                {
                    if (item.Objekat == selectedh.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                ukupna += (double)selectedh.Ocjena;
                brojac++;
                ukupna /= brojac;
                Rating.Text = ukupna.ToString();
            }
            if (isKafic == true)
            {
                Naziv.Text = selectedk.Naziv;
                Lokacija.Text = selectedk.Lokacija;
                foreach (var item in listaRecenzija)
                {
                    if (item.Objekat == selectedk.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                ukupna += (double)selectedk.Ocjena;
                brojac++;
                ukupna /= brojac;
                Rating.Text = ukupna.ToString();
            }
            if (isNightClub == true)
            {
                Naziv.Text = selectedn.Naziv;
                Lokacija.Text = selectedn.Lokacija;
                foreach (var item in listaRecenzija)
                {
                    if (item.Objekat == selectedn.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                ukupna += (double)selectedn.Ocjena;
                brojac++;
                ukupna /= brojac;
                Rating.Text = ukupna.ToString();
            }
            //if (model.GetRecenzije.CanExecute(null))
            // model.GetRecenzije.Execute(null);
            Recenzije.IsVisible = false;
            Recenzije.HeightRequest = 0;
            btnRecenzije.TextColor = Color.White;
            btnRecenzije.BackgroundColor = Color.DarkRed;
        }
        //internal async Task<System.Collections.Generic.List<Xamarin.Forms.Maps.Position>> LoadRoute()
        //{
        //    var client = new System.Net.Http.HttpClient();
        //    string googleDirection = @"https://maps.googleapis.com/maps/api/directions/json?origin=43.370205,17.853197&destination=43.3403544,17.8167406&key=AIzaSyAcTROi9rcud66EEqgDjPB7w8zXrdfL1yY";
        //    var response = await client.GetAsync(googleDirection);
        //    string contactsJson = await response.Content.ReadAsStringAsync(); //Getting response  
       
        //    if (contactsJson.Length>0)
        //    {
        //        var positions = (Enumerable.ToList(PolylineHelper.Decode(googleDirection)));
        //        return positions;
        //    }
         

        //}
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
        //List<Android.Locations.Location> FnDecodePolylinePoints(string encodedPoints)
        //{
        //    if (string.IsNullOrEmpty(encodedPoints))
        //        return null;
        //    var poly = new List<Android.Locations.Location>();
        //    char[] polylinechars = encodedPoints.ToCharArray();
        //    int index = 0;

        //    int currentLat = 0;
        //    int currentLng = 0;
        //    int next5bits;
        //    int sum;
        //    int shifter;

        //    try
        //    {
        //        while (index < polylinechars.Length)
        //        {
        //            // calculate next latitude
        //            sum = 0;
        //            shifter = 0;
        //            do
        //            {
        //                next5bits = (int)polylinechars[index++] - 63;
        //                sum |= (next5bits & 31) << shifter;
        //                shifter += 5;
        //            } while (next5bits >= 32 && index < polylinechars.Length);

        //            if (index >= polylinechars.Length)
        //                break;

        //            currentLat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

        //            //calculate next longitude
        //            sum = 0;
        //            shifter = 0;
        //            do
        //            {
        //                next5bits = (int)polylinechars[index++] - 63;
        //                sum |= (next5bits & 31) << shifter;
        //                shifter += 5;
        //            } while (next5bits >= 32 && index < polylinechars.Length);

        //            if (index >= polylinechars.Length && next5bits >= 32)
        //                break;

        //            currentLng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);
        //            Android.Locations.Location p = new Android.Locations.Location("");
        //            p.Latitude = Convert.ToDouble(currentLat) / 100000.0;
        //            p.Longitude = Convert.ToDouble(currentLng) / 100000.0;
        //            poly.Add(p);
        //        }
        //    }
        //    catch
        //    {


        //    }
        //    return poly;
        //}
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
            
            model.SelectedItem(e.SelectedItem);
           
        }
    }
   
}
