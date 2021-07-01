using exploreMostar.Mobile.Models;
using exploreMostar.Mobile.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public partial class PreferenceListPage : ContentPage
    {
        private APIService korisnici = new APIService("Korisnici");
        private PreferenceListModel model = null;
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _nocniklubovi = new APIService("Nightclubs");
        public PreferenceListPage()
        {
            InitializeComponent();
            //Set();
            BindingContext = model = new PreferenceListModel();
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
            navmenu.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Row-52.png");
            navmenu.WidthRequest = 20;
            navmenu.HeightRequest = 20;
            messageBox.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Chat-88.png");
            reviews.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.showfavourites.png");
            favs.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.heart.png");
            logout.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Logout-82.png");
            newsBox.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Newspaper-80.png");
            APIService.PreferenceListPage = true;
            APIService.UPContentPage = false;
            
        }
        public void Set()
        {
            //CarouselView carouselView = new CarouselView();
            //carouselView.SetBinding(ItemsView.ItemsSourceProperty, "Monkeys");

            //carouselView.ItemTemplate = new DataTemplate(() =>
            //{
            //    Label nameLabel = new Label { };
            //    nameLabel.SetBinding(Label.TextProperty, "Name");

            //    Image image = new Image { };
            //    image.SetBinding(Image.SourceProperty, "ImageUrl");

            //    Label locationLabel = new Label {  };
            //    locationLabel.SetBinding(Label.TextProperty, "Location");

            //    Label detailsLabel = new Label { };
            //    detailsLabel.SetBinding(Label.TextProperty, "Details");

            //    StackLayout stackLayout = new StackLayout
            //    {
            //        Children = { nameLabel, image, locationLabel, detailsLabel }
            //    };

            //    Frame frame = new Frame {  };
            //    StackLayout rootStackLayout = new StackLayout
            //    {
            //        Children = { frame }
            //    };

            //    return rootStackLayout;
            //});
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await korisnici.Get<dynamic>(null);
            if (model.GetSelectedOne.CanExecute(null))
                model.GetSelectedOne.Execute(null);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            Location location1 = null;
            if (status.ToString() == "Denied")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "In order to use this, you need to enable your current location!", "OK");
               

            }
            if (status.ToString() == "Granted")
            {
                await model.Init();
            }
        }

        private void StackLayout_SizeChanged(object sender, EventArgs e)
        {
            if (APIService.Food == false)
            {
                MyStackLayout.IsVisible = false;
                MyStackLayout.HeightRequest = 0; //
            }
        }

        private void MyStackLayout1_SizeChanged(object sender, EventArgs e)
        {
            if (APIService.Atraction == false)
            {
                MyStackLayout1.IsVisible = false;
                MyStackLayout1.HeightRequest = 0; //
            }
        }

        private void MyStackLayout2_SizeChanged(object sender, EventArgs e)
        {
            if (APIService.Apartments == false)
            {
                MyStackLayout2.IsVisible = false;
                MyStackLayout2.HeightRequest = 0; //
            }
        }

        private void MyStackLayout3_SizeChanged(object sender, EventArgs e)
        {
            if (APIService.Coffeeshops == false)
            {
                MyStackLayout3.IsVisible = false;
                MyStackLayout3.HeightRequest = 0; //
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Restorani;
           

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var nesto = 123;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            
        }

        private void MyStackLayout4_SizeChanged(object sender, EventArgs e)
        {
            if (APIService.Hotels == false)
            {
                MyStackLayout4.IsVisible = false;
                MyStackLayout4.HeightRequest = 0; //
            }
        }

        private void MyStackLayout5_SizeChanged(object sender, EventArgs e)
        {
            if (APIService.Nightclubs == false)
            {
                MyStackLayout5.IsVisible = false;
                MyStackLayout5.HeightRequest = 0; //
            }
        }

        private void ListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem;
            var restoran = e.SelectedItem as Model.Restorani;
            var apartman = e.SelectedItem as Model.Apartmani;
            var atrakcija= e.SelectedItem as Model.Atrakcije;
            var nocniklub = e.SelectedItem as Model.Nightclubs;
            var kafic = e.SelectedItem as Model.Kafici;
            var hotel = e.SelectedItem as Model.Hoteli;

            bool isRestoran =( restoran == null)? false:true;
            bool isApartman = (apartman == null) ? false : true;
            bool isAtrakcija = (atrakcija == null) ? false : true;
            bool isNightClub = (nocniklub == null) ? false : true;
            bool isKafic = (kafic == null) ? false : true;
            bool isHotel = (hotel == null) ? false : true;
            APIService.PreferenceListPage = true; 
            if (isRestoran==true)
            {
               
                APIService.Naziv = restoran.Naziv;
                try
                {
                    
                    Application.Current.MainPage = new MapPage(restoran);

                }
                catch (Exception ex)
                {

                }
            }
            else if (isApartman == true)
            {
                APIService.Naziv = apartman.Naziv;
                try
                {
                    Application.Current.MainPage = new MapPage(apartman);

                }
                catch (Exception ex)
                {

                }
            }
            else  if (isAtrakcija == true)
            {
                APIService.Naziv = atrakcija.Naziv;
                try
                {
                    // Application.Current.MainPage = new MapPage(restoran);
                    Application.Current.MainPage = new MapPage(atrakcija);

                }
                catch (Exception ex)
                {

                }
            }
            else if (isNightClub == true)
            {
                APIService.Naziv = nocniklub.Naziv;
                try
                {
                    // Application.Current.MainPage = new MapPage(restoran);
                    Application.Current.MainPage = new MapPage(nocniklub);

                }
                catch (Exception ex)
                {

                }
            }
            else if (isKafic == true) {
                APIService.Naziv = kafic.Naziv;
                try
                {
                    // Application.Current.MainPage = new MapPage(restoran);
                    Application.Current.MainPage = new MapPage(kafic);

                }
                catch (Exception ex)
                {

                }

            }
            else if (isHotel == true)
            {
                APIService.Naziv = hotel.Naziv;
                try
                {
                    // Application.Current.MainPage = new MapPage(restoran);
                    Application.Current.MainPage = new MapPage(hotel);

                }
                catch (Exception ex)
                {

                }
            }
           
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Application.Current.MainPage = new InboxPage();
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            MyStackLayout.IsVisible = true;
            MyStackLayout1.IsVisible = true;
            MyStackLayout2.IsVisible = true;
            MyStackLayout3.IsVisible = true;
            MyStackLayout4.IsVisible = true;
            MyStackLayout5.IsVisible = true;
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status.ToString() == "Denied")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "In order to use this, you need to enable your current location!", "OK");


            }
            if (status.ToString() == "Granted")
            {
                
                APIService.NearOn = true;

                await model.Init();
            }
            
            btn2.TextColor = Color.DarkRed;
            btn2.BackgroundColor = Color.White;
            btn2.FontAttributes = FontAttributes.Bold;
            //   Stack2.IsVisible = false;

            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            StackMapa.IsVisible = false;
            btn32.BackgroundColor = Color.DarkRed;
            btn32.TextColor = Color.White;

        }

        private  async void btn3_Clicked(object sender, EventArgs e)
        {
            MyStackLayout.IsVisible = true;
            MyStackLayout1.IsVisible = true;
            MyStackLayout2.IsVisible = true;
            MyStackLayout3.IsVisible = true;
            MyStackLayout4.IsVisible = true;
            MyStackLayout5.IsVisible = true;
            APIService.NearOn = false;
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status.ToString() == "Denied")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "In order to use this, you need to enable your current location!", "OK");


            }
            else if (status.ToString() == "Granted")
            {
                await model.Init();

            }
            btn3.TextColor = Color.DarkRed;
            btn3.BackgroundColor = Color.White;
            btn3.FontAttributes = FontAttributes.Bold;
            //   Stack2.IsVisible = false;

            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            btn32.BackgroundColor = Color.DarkRed;
            btn32.TextColor = Color.White;
            StackMapa.IsVisible = false;
          
        }

      

        private void goBack_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UserPreferenceContentPage();
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
            APIService.PreferenceListPage = true;
            APIService.UPContentPage = false;
            APIService.InboxLista = false;
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

        private void favs_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MyFavouritesPage();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            
            model.CheckSearchRequest();
        }
        CancellationTokenSource cts;
        TaskCompletionSource<PermissionStatus> tcs;
        private async void btn32_Clicked(object sender, EventArgs e)
        {
            Mapa1.IsShowingUser = true;
            MyStackLayout.IsVisible = false;
            MyStackLayout1.IsVisible = false;
            MyStackLayout2.IsVisible = false;
            MyStackLayout3.IsVisible = false;
            MyStackLayout4.IsVisible = false;
            MyStackLayout5.IsVisible = false;
           
            btn32.TextColor = Color.DarkRed;
            btn32.BackgroundColor = Color.White;
            btn32.FontAttributes = FontAttributes.Bold;
            //   Stack2.IsVisible = false;

            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            var listApartmana = await _apartmani.Get<IList<Model.Apartmani>>(null);
            var listaAtrakcija = await _atrakcije.Get<IList<Model.Atrakcije>>(null);
            var listaKafica = await _kafici.Get<IList<Model.Kafici>>(null);
            var listaHotela = await _hoteli.Get<IList<Model.Hoteli>>(null);
            var listaRestorana = await _restorani.Get<IList<Model.Restorani>>(null);
            var listaNk = await _nocniklubovi.Get<IList<Model.Nightclubs>>(null);
            StackMapa.IsVisible = true;
            var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10));
            cts = new CancellationTokenSource();
            tcs = new TaskCompletionSource<PermissionStatus>();
            var location = await Geolocation.GetLocationAsync(request, cts.Token);
            var client = new System.Net.Http.HttpClient();
            Position position = new Position(location.Latitude, location.Longitude);

            MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.444));
            Mapa1.MoveToRegion(mapSpan);
            if (APIService.Atraction)
            {
                foreach(var item in listaAtrakcija)
                {
                    Pin pin = new Pin
                    {
                        Label = item.Naziv,
                        Address = item.Lokacija,
                        Type = PinType.Place,
                        Position = new Position((double)item.Latitude, (double)item.Longitude)
                    };
                    Mapa1.Pins.Add(pin);
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
                    Mapa1.MapElements.Add(polyline);
                }
            }
            if (APIService.Apartments)
            {
                foreach (var item in listApartmana)
                {
                    Pin pin = new Pin
                    {
                        Label = item.Naziv,
                        Address = item.Lokacija,
                        Type = PinType.Place,
                        Position = new Position((double)item.Latitude, (double)item.Longitude)
                    };
                    Mapa1.Pins.Add(pin);
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
                    Mapa1.MapElements.Add(polyline);
                }
            }
            if (APIService.Food)
            {
                foreach (var item in listaRestorana)
                {
                    Pin pin = new Pin
                    {
                        Label = item.Naziv,
                        Address = item.Lokacija,
                        Type = PinType.Place,
                        Position = new Position((double)item.Latitude, (double)item.Longitude)
                    };
                    Mapa1.Pins.Add(pin);
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
                    Mapa1.MapElements.Add(polyline);
                }
            }
            if (APIService.Nightclubs)
            {
                foreach (var item in listaNk)
                {
                    Pin pin = new Pin
                    {
                        Label = item.Naziv,
                        Address = item.Lokacija,
                        Type = PinType.Place,
                        Position = new Position((double)item.Latitude, (double)item.Longitude)
                    };
                    Mapa1.Pins.Add(pin);
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
                    Mapa1.MapElements.Add(polyline);
                }
            }
            if (APIService.Coffeeshops)
            {
                foreach (var item in listaKafica)
                {
                    Pin pin = new Pin
                    {
                        Label = item.Naziv,
                        Address = item.Lokacija,
                        Type = PinType.Place,
                        Position = new Position((double)item.Latitude, (double)item.Longitude)
                    };
                    Mapa1.Pins.Add(pin);
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
                    Mapa1.MapElements.Add(polyline);
                }
               
            }
        }
    }
}
