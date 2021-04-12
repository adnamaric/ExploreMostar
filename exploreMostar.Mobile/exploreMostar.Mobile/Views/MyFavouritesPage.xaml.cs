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
    public partial class MyFavouritesPage : ContentPage
    {
        private MyFavouritesModel model = null;
      
        public MyFavouritesPage()
        {
            InitializeComponent();
            BindingContext = model = new MyFavouritesModel();
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
            //model.GetRecommend();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
         
        }
        private void goBack_Clicked(object sender, EventArgs e)
        {
            if (APIService.PreferenceListPage)
                Application.Current.MainPage = new PreferenceListPage();
            else if (APIService.InboxLista)
            {
                //ListaStack.HeightRequest = APIService.VelicinaListe;
                //ListaStack.IsVisible = true;
                //APIService.VelicinaInboxa = InboxStack.HeightRequest;
                //InboxStack.IsVisible = false;
                //InboxStack.HeightRequest = 0;

                Application.Current.MainPage = new InboxPage();

            }
            else if (APIService.UPContentPage)
            {
                Application.Current.MainPage = new UserPreferenceContentPage();
            }
            else if (APIService.MapPage)
            {
                Application.Current.MainPage = new MapPage(APIService.modelTemp);

            }
        }



        private void MyFavouritesView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            model.GetFavorite(e.SelectedItem);
        }
    }
}