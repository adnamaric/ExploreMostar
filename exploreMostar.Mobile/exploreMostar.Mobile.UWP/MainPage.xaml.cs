using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace exploreMostar.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();


            //// if you want not to have any window smaller than this size...
            //ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(480, 800));
            Xamarin.FormsMaps.Init("AIzaSyAcTROi9rcud66EEqgDjPB7w8zXrdfL1yY");

            LoadApplication(new exploreMostar.Mobile.App());
        }
       

    }
}
