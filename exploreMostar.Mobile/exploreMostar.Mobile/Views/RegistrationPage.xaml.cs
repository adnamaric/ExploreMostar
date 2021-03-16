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
    public partial class RegistationPage : ContentPage
    {
        private readonly APIService _aPIService = new APIService("Gradovi");

        public RegistationPage()
        {
            InitializeComponent();
          
        }

        private void btnRegi_Focused(object sender, FocusEventArgs e)
        {
          

        }
        //protected async override void OnAppearing()
        //{
        //    //var lista = await _aPIService.Get<List<Model.Gradovi>>(null);
        //    //List<string> gradovi = new List<string>();
        //    //foreach (var item in lista)
        //    //{
        //    //    gradovi.Add(item.Naziv);
        //    //}
        //    //ListView.ItemsSource = gradovi;
            
        //}
    }
}