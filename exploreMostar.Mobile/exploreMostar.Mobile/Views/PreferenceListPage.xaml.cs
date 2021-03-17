using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exploreMostar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreferenceListPage : ContentPage
    {
        private APIService korisnici = new APIService("Korisnici");

        public PreferenceListPage()
        {
            InitializeComponent();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await korisnici.Get<dynamic>(null);
        }
    }
}