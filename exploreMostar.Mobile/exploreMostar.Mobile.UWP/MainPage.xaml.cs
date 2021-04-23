using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Essentials;

namespace exploreMostar.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();


            //// if you want not to have any window smaller than this size...
            //ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(480, 800));
            //Xamarin.FormsMaps.Init("AuRdBkvQJxfJOPvHr03c8Ne058fyLkaf74i3odVWKA3QdaBk-uAJLP2oOussl89E");
            LoadApplication(new exploreMostar.Mobile.App());
            GetLocationPermission();
        }
        public async void GetLocationPermission()
        {
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status.ToString() == "Denied")
            {
                var messageDialog = new MessageDialog("Please enable your location!");

                await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-location"));


            }


        }
       



    }
}
