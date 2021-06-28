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
    public partial class ViewAllObjectsOnMapPage : ContentPage
    {
        private PreferenceListModel model = null;
        public ViewAllObjectsOnMapPage()
        {
            InitializeComponent();
            BindingContext = model = new PreferenceListModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
          

        }
    }
}