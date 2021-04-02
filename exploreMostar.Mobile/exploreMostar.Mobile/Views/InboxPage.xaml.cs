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
            goBack.Source = ImageSource.FromResource("exploreMostar.Mobile.Resources.Left-Arrow-84.png");
            goBack.WidthRequest = 20;
            goBack.HeightRequest = 20;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            APIService.VelicinaListe = ListaStack.Height;
           
        }
        public async void Set()
        {
            InboxStack.Children.Remove(entry);

            //ListaStack.IsVisible = false;
            //ListaStack.HeightRequest = 0;
            //InboxStack.IsVisible = true;


            StackLayout n = new StackLayout();


                n.BackgroundColor = Color.LightBlue;
                Label texty2 = new Label();

                if (zadnjaPoruka.PosiljalacId == thisone.KorisnikId)
                {
                    n.BackgroundColor = Color.LightBlue;
                    n.HorizontalOptions = LayoutOptions.End;
                    n.WidthRequest = 200;
                }
                else
                {
                    n.BackgroundColor = Color.LightBlue;
                    n.HorizontalOptions = LayoutOptions.Start;
                    n.WidthRequest = 200;

                }


                Label texty1 = new Label();
                texty1.Text = zadnjaPoruka.Datum.ToString();

                texty2.Text = zadnjaPoruka.Posiljalac;

                Label texty = new Label();
                texty.Text = zadnjaPoruka.Sadrzaj;

               
                n.Children.Add(texty1);
                n.Children.Add(texty2);

                n.Children.Add(texty);

                InboxStack.Children.Add(n);
            entry.Placeholder = "Type new message";
            entry.PlaceholderColor = Color.LightBlue;
            entry.BackgroundColor = Color.Transparent;
            entry.TextColor = Color.White;
            //entry.TextChanged += OnEntryTextChanged;
            InboxStack.Children.Add(entry);

        }
          public Model.Korisnici thisone = new Model.Korisnici();
        public Model.Korisnici primalac = new Model.Korisnici();
        public Model.Poruke zadnjaPoruka = new Model.Poruke();
       public Entry entry = new Entry();
        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            APIService.InboxLista = true;
            ListaStack.IsVisible = false;
            ListaStack.HeightRequest = 0;
            InboxStack.IsVisible = true;
            





          
       
            primalac = e.SelectedItem as Model.Korisnici;
            var listKorisnika = await _service.Get<IList<Model.Korisnici>>(null);

            var list = await _poruke.Get<IList<Model.Poruke>>(null);
            poruke.Clear();
            foreach (var item in listKorisnika)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    thisone = item;

                }
            }
            foreach (var item in list)
            {
                if ((item.PosiljalacId == thisone.KorisnikId && item.PrimalacId == primalac.KorisnikId) || (item.PosiljalacId == primalac.KorisnikId && item.PrimalacId == thisone.KorisnikId))
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
                    n.HorizontalOptions = LayoutOptions.End;
                    n.WidthRequest = 200;
                }
                else
                {
                    n.BackgroundColor = Color.LightBlue;
                    n.HorizontalOptions = LayoutOptions.Start;
                    n.WidthRequest = 200;

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
            
            entry.Placeholder = "Type new message";
            entry.PlaceholderColor = Color.LightBlue;
            entry.BackgroundColor = Color.Transparent;
            entry.TextColor = Color.White;
            //entry.TextChanged += OnEntryTextChanged;
            entry.Completed += OnEnterPressed;
            InboxStack.Children.Add(entry);
            
            //Called on enter key press
        }
        public void OnEnterPressed(object sender, EventArgs e)
        {
            // ObjectCommandIsOn.LoginCommand.Invoke();
            // OR
            // Login Command Logic Can go here, but use a ViewModel like a normal Person at least.
          
            Model.Poruke n = new Model.Poruke();
           // string sadrzaj = entry.Text ;
            n.Sadrzaj = entry.Text;
            n.PosiljalacId = thisone.KorisnikId;
            n.Posiljalac = thisone.Ime + " " + thisone.Prezime;
            n.Primalac = primalac.Ime+" "+primalac.Prezime;
            n.PrimalacId = primalac.KorisnikId;
            n.Datum = DateTime.Now;

            model.AddNewMessage(n);
            zadnjaPoruka = n;
            Set();
           

        }

        private  void goBack_Clicked(object sender, EventArgs e)
        {
            if(APIService.PreferenceListPage && APIService.InboxLista!=true)
            Application.Current.MainPage = new PreferenceListPage();
            else if(APIService.InboxLista)
            {
                //ListaStack.HeightRequest = APIService.VelicinaListe;
                //ListaStack.IsVisible = true;
                //APIService.VelicinaInboxa = InboxStack.HeightRequest;
                //InboxStack.IsVisible = false;
                //InboxStack.HeightRequest = 0;
                APIService.InboxLista = false;
                Application.Current.MainPage = new InboxPage();
               
            }
            else if (APIService.UPContentPage)
            {
                Application.Current.MainPage = new UserPreferenceContentPage();
            }
        }
    }
   

}
