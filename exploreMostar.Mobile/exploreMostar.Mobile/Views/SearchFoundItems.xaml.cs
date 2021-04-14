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
        }
        protected  override void OnAppearing()
        {
            base.OnAppearing();
            // await model.Init();
          
        }
    }
}