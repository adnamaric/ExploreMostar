using exploreMostar.Mobile.Views;
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
    public partial class OpeningPage : ContentPage
    {
        public OpeningPage()
        {
            InitializeComponent();
          //  var assemly = typeof(OpeningPage);
            opImage.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Explore Mostar (6).png");
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //try
            //{
            //    Application.Current.MainPage = new RegistationPage();
            //}
            //catch(Exception ex)
            //{
            //    Application.Current.MainPage.DisplayAlert("A mistake has happend!",ex.Message,"OK");
            //}

        }
    }
}