using exploreMostar.Mobile.ViewModels;
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
        private PreferenceListModel model = null;
        public PreferenceListPage()
        {
            InitializeComponent();
            //Set();
            BindingContext = model = new PreferenceListModel();
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
            await model.Init();
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
    }
}
