using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exploreMostar.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //APIService _service = new APIService("Korisnici");
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    var result = await _service.Get<List<Model.Korisnici>>(null);
        //    Model.Korisnici korisnik = new Model.Korisnici();
        //    bool pronadjen = false;
        //    bool pronadjen2 = false;
        //    string nesto = Username.Text;
        //    string nesto2 = Password.Text;
        //    Command command = (Command)Komanda.BindingContext;

          
        //}
    }
}