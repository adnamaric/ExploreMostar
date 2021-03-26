using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms.PlatformConfiguration;

namespace exploreMostar.Mobile.Models
{
    public class OpenSettings_UWP : IOpenSettings
    {
        public  void OpenCalendarSettings()
        {

            //await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-calendar"));
          
        }
    }
}
