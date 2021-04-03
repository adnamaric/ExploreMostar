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
    public partial class CheckPosts : ContentPage
    {
        private CheckNewPostsModel model;
        public CheckPosts()
        {
            InitializeComponent();
            BindingContext = model = new CheckNewPostsModel();
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();


        }

        private void goBack_Clicked(object sender, EventArgs e)
        {
            if (APIService.PreferenceListPage )
                Application.Current.MainPage = new PreferenceListPage();
            
            else if (APIService.UPContentPage)
            {
                Application.Current.MainPage = new UserPreferenceContentPage();
            }
            else if(APIService.MapPage)
                Application.Current.MainPage = new MapPage(APIService.modelTemp);

        }
    }
}