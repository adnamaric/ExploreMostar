using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
    public class MyReviewsModel : BaseViewModel
    {
        private readonly APIService _recenzije = new APIService("Recenzije");
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _nocniklubovi = new APIService("Nightclubs");

        public ObservableCollection<Model.Recenzije> recenzije { get; set; } = new ObservableCollection<Model.Recenzije>();
        public MyReviewsModel()
        {
            InitCommand = new Command(async () => await Init());
           
        }
        public ICommand InitCommand { get; set; }
       
        public async Task Init()
        {
            Model.Korisnici korisnik = null;
            var listaK = await _korisnici.Get<List<Model.Korisnici>>(null);
            var list = await _recenzije.Get<List<Model.Recenzije>>(null);

            foreach (var item in listaK)
            {
                if (item.KorisnickoIme == APIService.Username)
                    korisnik = item;
            }
            recenzije.Clear();
            var temp = 0;
         
           
            foreach (var item in list)
            {
                if (item.KorisnikId == korisnik.KorisnikId)
                {
                    item.Rbr = ++temp;
                    recenzije.Add(item); 
                }
            }
        }
    }
}
