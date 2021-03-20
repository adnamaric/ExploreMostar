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
    public partial class MapPage2 : ContentPage
    {
        public Model.Restorani selected = new Model.Restorani();
        private TempModel model = null;
        public MapPage2(Model.Restorani restorani)
        {
            InitializeComponent();
            selected = restorani;
            BindingContext = model = new TempModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}