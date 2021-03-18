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
            Application.Current.MainPage = new ListViewPage1();

        }
    }
}
