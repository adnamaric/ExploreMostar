﻿using System;
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
        private readonly APIService _ua = new APIService("UserActivity");
       
        public UserPreferenceContentPage()
        {
            InitializeComponent();
            opImage.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Row-52.png");
            opImage.WidthRequest = 20;
            opImage.HeightRequest = 20;
            messageBox.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Chat-88.png");

            logout.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.Logout-82.png");
            newsBox.ImageSource= ImageSource.FromResource("exploreMostar.Mobile.Resources.Newspaper-80.png");
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            reviews.ImageSource = ImageSource.FromResource("exploreMostar.Mobile.Resources.showfavourites.png");
            favs.ImageSource= ImageSource.FromResource("exploreMostar.Mobile.Resources.heart.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
            APIService.UPContentPage = true;
            APIService.PreferenceListPage = false;
            
            SetExisting();
            
        }
        public UserPreferenceModel m = new UserPreferenceModel();
    private void Button_Clicked(object sender, EventArgs e)
        {
            btn1.BackgroundColor = Color.DarkRed;
            btn1.TextColor = Color.White;
            m._food = true;
            m.Hrana = true;
        }
        public async void SetExisting()
        {
          
            var result = await korisnici.Get<List<Model.Korisnici>>(null);
            var resultUA = await _ua.Get<List<Model.UserActivity>>(null);

            Model.Korisnici korisnik = null;
            Model.UserActivity user = null;
            foreach (var item in result)
            {
                if (APIService.Username == item.KorisnickoIme)
                {
                    korisnik = item;
                }
            }
            if (korisnik != null)
            {
                foreach (var item in resultUA)
                {
                    if (korisnik.KorisnikId == item.KorisnikId)
                    {
                        user = item;
                    }
                }
                if (user != null)
                {
                    if (user.BrojPrijavljivanja >= 1)
                    {
                        if (user.IsApartman != null)
                            APIService.Apartments = (bool)user.IsApartman;
                        if (user.IsAtrakcija != null)
                            APIService.Atraction = (bool)user.IsAtrakcija;
                        if (user.IsHotel != null)
                            APIService.Hotels = (bool)user.IsHotel;
                        if (user.IsKafic != null)
                            APIService.Coffeeshops = (bool)user.IsKafic;
                        if (user.IsNightClub != null)
                            APIService.Nightclubs = (bool)user.IsNightClub;
                        if (user.IsRestoran != null)
                            APIService.Food = (bool)user.IsRestoran;

                    }
                }
            }
            Set();
        }
        public void Set()
        {
            if (APIService.Apartments)
            {
                btn4.BackgroundColor = Color.DarkRed;
                btn4.TextColor = Color.White;
                m.Apartman = true;
                m._apartment = true;
            }
            if (APIService.Atraction)
            {
                btn2.BackgroundColor = Color.DarkRed;
                btn2.TextColor = Color.White;
                m._atraction = true;
                m.Atrakcija = true;
            }
            if (APIService.Coffeeshops)
            {
                btn6.BackgroundColor = Color.DarkRed;
                btn6.TextColor = Color.White;
                m._coffeeshops = true;
                m.Kafic = true;
            }
            if (APIService.Hotels)
            {
                btn3.BackgroundColor = Color.DarkRed;
                btn3.TextColor = Color.White;
                m._hotel = true;
                m.Hotel = true;
            }
            if (APIService.Food)
            {
                btn1.BackgroundColor = Color.DarkRed;
                btn1.TextColor = Color.White;
                m._food = true;
                m.Hrana = true;
            }
            if (APIService.Nightclubs)
            {
                btn7.BackgroundColor = Color.DarkRed;
                btn7.TextColor = Color.White;
                m._nightclubs = true;
                m.NK = true;
            }
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
            m.SetPreferences();
        }

        private async void opImage_Clicked(object sender, EventArgs e)
        {
            if (NavigationPane.IsVisible == true)
            {
                NavigationPane.IsVisible = false;
                await opImage.RotateTo(180, 200);
                

            }
            else
            {
                NavigationPane.IsVisible = true;
                await opImage.RotateTo(90, 200);
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

        }

    

        private void recenzije_Clicked_1(object sender, EventArgs e)
        {

        }

        private void logout_Clicked(object sender, EventArgs e)
        {
            m.DeleteUnsuccessfulLogins();
           
            Application.Current.MainPage = new OpeningPage();
        }

        private void newsBox_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CheckPosts();
        }

        private void messageBox_Clicked_1(object sender, EventArgs e)
        {
            APIService.UPContentPage = true;
            APIService.PreferenceListPage = false;
          
            Application.Current.MainPage = new InboxPage();
        }

        private void goBack_Clicked(object sender, EventArgs e)
        {

            APIService.Username = null;
            APIService.Password = null;
           
            Application.Current.MainPage = new OpeningPage();
        }

        private void reviews_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MyReviewsPage();
        }

        private void reviews_Clicked_1(object sender, EventArgs e)
        {

        }

        private void favs_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MyFavouritesPage();
        }
      
    }
}
