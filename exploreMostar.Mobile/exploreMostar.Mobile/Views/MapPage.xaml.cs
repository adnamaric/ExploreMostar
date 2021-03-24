using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Windows.Devices.Geolocation;
using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;
using exploreMostar.Mobile.ViewModels;

namespace exploreMostar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public Model.Restorani selected=new Model.Restorani();
        private PreferenceListModel model = null;
        public MapPage(Model.Restorani model1)
        {
            InitializeComponent();
            selected = model1;
            BindingContext = model = new PreferenceListModel ();
            //Get();
            //label.Text = "Name: "+selected.Naziv;
            //ocjena.Text ="Rate: "+ selected.Ocjena.ToString();
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
            if (status.ToString() == "Denied")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "In order to use this, you need to enable your current location!", "OK");

            }
            try
            {
                btn2.BackgroundColor = Color.White;
                btn2.TextColor = Color.DarkRed;
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                tcs = new TaskCompletionSource<PermissionStatus>();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);
                
                if (location != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Your location", $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}", "OK");
                    //Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }

                Location boston = new Location((double)selected.Longitude,(double)selected.Latitude);
               
                double kilometers = Location.CalculateDistance(boston, location, DistanceUnits.Kilometers);
                double meters = kilometers * 1000;
                meters = Math.Round(meters);
                    await Application.Current.MainPage.DisplayAlert("Alert", $"Udaljenost vas i traženog objekta iznosi:{meters}metara", "OK");
                Pin pin = new Pin
                {
                    Label = selected.Naziv,
                    Address =selected.Lokacija,
                    Type = PinType.Place,
                    Position = new Position((double)selected.Latitude, (double)selected.Longitude)
                };
                //Map.Pins.Add(pin);
              

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
            Stacky1.IsVisible = false;
            btn2.TextColor = Color.DarkRed;
            btn2.FontAttributes = FontAttributes.Bold;
            btn2.BackgroundColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            info.IsVisible = false;
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            
            Map.IsVisible = false;
            Stacky1.IsVisible = false;
            Stack2.IsVisible = false;
            Stack2.HeightRequest = 0;
            info.IsVisible = true;
            btn3.TextColor = Color.DarkRed;
            btn3.BackgroundColor = Color.White;
            btn3.FontAttributes = FontAttributes.Bold;
            //   Stack2.IsVisible = false;
            info.IsVisible = true;
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            if (selected.Naziv== "Megamarkt")
                respicture.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.restoran1.png");
            if(selected.Naziv == "restoran 1")
                respicture.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.restoran1.jpg");
         
            Naziv.Text = selected.Naziv;
            Lokacija.Text = selected.Lokacija;
            Godina.Text = selected.GodinaIzgradnje.ToString();
            Rating.Text = selected.Ocjena.ToString();
            if (selected.VrstaId == 1)
                Type.Text = "Restaurant";
            if (selected.VrstaId ==2)
                Type.Text = "Fast Food";
            if (selected.VrstaId == 3)
                Type.Text = "N/A";
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
             Map.IsVisible = false;
            Stack2.IsVisible = false;
            Stack2.HeightRequest = 0;
            info.IsVisible = false;
            // Stack2.IsVisible = true;
            Stacky1.IsVisible = true;
            btn1.TextColor = Color.DarkRed;
            btn1.BackgroundColor = Color.White;
            btn1.FontAttributes = FontAttributes.Bold;
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            
        }
    }
   
}
