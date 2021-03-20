using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exploreMostar.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exploreMostar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPreferenceContentPage : ContentPage
    {
        private APIService korisnici = new APIService("Korisnici");

        public UserPreferenceContentPage()
        {
            InitializeComponent();
            
        }
        public UserPreferenceModel m = new UserPreferenceModel();
    private void Button_Clicked(object sender, EventArgs e)
        {
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            m._food = true;
            m.Hrana = true;
        }

        private void Button2_Cliked(object sender, EventArgs e)
        {
            btn2.BackgroundColor = Color.DarkRed;
            btn2.TextColor = Color.White;
            m._atraction = true;
            m.Atrakcija = true;
        }

        private void Button3_Cliked(object sender, EventArgs e)
        {
            btn3.BackgroundColor = Color.DarkRed;
            btn3.TextColor = Color.White;
            m._hotel = true;
            m.Hotel = true;
           
        }

        private void Button4_Cliked(object sender, EventArgs e)
        {
            btn4.BackgroundColor = Color.DarkRed;
            btn4.TextColor = Color.White;
            m.Apartman = true;
            m._apartment = true;
           
        }

        private void Button5_Cliked(object sender, EventArgs e)
        {
            //btn5.BackgroundColor = Color.DarkRed;
            //btn5.TextColor = Color.White;
            m._transport = true;
            m.Prevoz = true;
           
        }

        private void Button6_Cliked(object sender, EventArgs e)
        {
            btn6.BackgroundColor = Color.DarkRed;
            btn6.TextColor = Color.White;
            m._coffeeshops = true;
            m.Kafic = true;
         
        }

        private void Button7_Cliked(object sender, EventArgs e)
        {
            btn7.BackgroundColor = Color.DarkRed;
            btn7.TextColor = Color.White;
            m._nightclubs = true;
            m.NK = true;
        }

        private void Button8_Cliked(object sender, EventArgs e)
        {
            //btn8.BackgroundColor = Color.DarkRed;
            //btn8.TextColor = Color.White;
            m._other = true;
            m.Other = true;
        }

        private  void Button_Clicked_1(object sender, EventArgs e)
        {
            
            if (m.Submit.CanExecute(null))
                m.Submit.Execute(null);

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await korisnici.Get<dynamic>(null);


            if (m.Submit.CanExecute(null))
                m.Submit.Execute(null);

        }
    }
}
