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
    public partial class CarouselView : ContentPage
    {
        private PreferenceListModel model = null;
        public CarouselView()
        {
            InitializeComponent();
            BindingContext = model = new PreferenceListModel();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            SetterI();

        }
        public void SetterI()
        {
          
            foreach (var item in model.jelas)
            {
             
                if ((item.PutanjaSlike != null) && (item.PutanjaSlike != "openFileDialog1"))
                {
                //    item.SetImgSrc(ImageSource.FromUri(new Uri(item.PutanjaSlike)));
                }

            }
        }
    }
}