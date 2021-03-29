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
    public partial class InboxPage : ContentPage
    {
        private InboxModel model = null;
        List<Button> listaPoruka = new List<Button>();
        List<Model.Poruke> poruke = new List<Model.Poruke>();
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _poruke = new APIService("Poruke");
        public InboxPage()
        {
            InitializeComponent();

            BindingContext = model = new InboxModel();
            ListaStack.IsVisible = true;
           // Set();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
           

        }
        public async void Set()
        {
            var list = await _poruke.Get<IList<Model.Poruke>>(null);
            var listKorisnika = await _service.Get<IList<Model.Korisnici>>(null);
            Model.Korisnici korisnik = new Model.Korisnici();
            foreach (var item in listKorisnika)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    korisnik = item;
                    
                }
            }
            poruke.Clear();
            foreach (var item in list)
            {
                if (item.PosiljalacId == korisnik.KorisnikId || item.PrimalacId == korisnik.KorisnikId)
                {
                    poruke.Add(item);
                }
            }
            
            foreach (var item in poruke)
            {
                StackLayout n = new StackLayout();
               
                
                n.BackgroundColor = Color.LightBlue;
                Label texty2 = new Label();



              
                
                Label texty1 = new Label();
                texty1.Text = item.Datum.ToString();
              
                texty2.Text = item.Posiljalac;
            
                Label texty = new Label();
                texty.Text = item.Sadrzaj;
               
                
                n.Children.Add(texty1);
                n.Children.Add(texty2);

                n.Children.Add(texty);

               
                

                //n.Text = item.Sadrzaj;
                //listaPoruka.Add(n);
              //  MyStackLayout.Children.Add(n);


            }
            Entry entry = new Entry();
            entry.Placeholder = "Type new message";
            
            //ImageButton n = new ImageButton();
            
            //MyStackLayout.Children.Add(entry);
        }

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListaStack.IsVisible = false;
            ListaStack.HeightRequest = 0;
            InboxStack.IsVisible = true;
            var korisnik = e.SelectedItem as Model.Korisnici;
            var listKorisnika = await _service.Get<IList<Model.Korisnici>>(null);

            var list = await _poruke.Get<IList<Model.Poruke>>(null);
            poruke.Clear();
            Model.Korisnici thisone = new Model.Korisnici();
            foreach (var item in listKorisnika)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    thisone = item;

                }
            }
            foreach (var item in list)
            {
                if ((item.PosiljalacId == thisone.KorisnikId && item.PrimalacId==korisnik.KorisnikId) ||( item.PosiljalacId==korisnik.KorisnikId &&  item.PrimalacId == thisone.KorisnikId))
                {
                    poruke.Add(item);
                }
            }
            foreach (var item in poruke)
            {
                StackLayout n = new StackLayout();


                n.BackgroundColor = Color.LightBlue;
                Label texty2 = new Label();

                if (item.PosiljalacId == thisone.KorisnikId)
                {
                    n.BackgroundColor = Color.LightBlue;
                }
                else
                {
                    n.BackgroundColor = Color.DarkBlue;
                    
                }


                Label texty1 = new Label();
                texty1.Text = item.Datum.ToString();

                texty2.Text = item.Posiljalac;

                Label texty = new Label();
                texty.Text = item.Sadrzaj;


                n.Children.Add(texty1);
                n.Children.Add(texty2);

                n.Children.Add(texty);




                //n.Text = item.Sadrzaj;
                //listaPoruka.Add(n);
                //  MyStackLayout.Children.Add(n);
                InboxStack.Children.Add(n);

            }
            Entry entry = new Entry();
            entry.Placeholder = "Type new message";
            InboxStack.Children.Add(entry);
        }
    }
}