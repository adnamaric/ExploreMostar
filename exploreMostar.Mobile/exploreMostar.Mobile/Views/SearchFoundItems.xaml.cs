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
    public partial class SearchFoundItems : ContentPage
    {
        private SearchResultModel model = null;
        public string some=string.Empty;
        public SearchFoundItems(string _search)
        {
            InitializeComponent();
            BindingContext = model = new SearchResultModel();
            model.SearchResult(_search);
            spanSearch.Text = _search;
            some = _search;
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
        }
        protected  override void OnAppearing()
        {
            base.OnAppearing();
            // await model.Init();
          
        }

        private void goBack_Clicked(object sender, EventArgs e)
        {
            APIService.SearchLista = false;
            APIService.Pretraga = string.Empty;
            Application.Current.MainPage = new PreferenceListPage();
        }

        private void MyRecenzijeView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            APIService.SearchLista = true;
            APIService.Pretraga = some;
            APIService.PreferenceListPage = false;
            
            model.GetResult(e.SelectedItem);
        }
    }
}