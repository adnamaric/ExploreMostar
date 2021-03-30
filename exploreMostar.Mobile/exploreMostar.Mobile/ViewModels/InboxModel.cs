using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
    public class InboxModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _poruke = new APIService("Poruke");
        private readonly APIService _gradovi = new APIService("Gradovi");

        public ObservableCollection<Model.Poruke> poruke { get; set; } = new ObservableCollection<Model.Poruke>();
        public ObservableCollection<Model.Korisnici> korisnici { get; set; } = new ObservableCollection<Model.Korisnici>();
        public ICommand InitCommand { get; set; }
        public InboxModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public async Task Init()
        {
            var list = await _poruke.Get<IList<Model.Poruke>>(null);
            var listKorisnika = await _service.Get<IList<Model.Korisnici>>(null);
            var listaGradova = await _gradovi.Get<IList<Model.Gradovi>>(null);

            Model.Korisnici korisnik = new Model.Korisnici();
            korisnici.Clear();
            var temp = 0;

            foreach (var item in listKorisnika)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    korisnik = item;

                }
                item.ImePrezime = item.Ime + " " + item.Prezime;
                item.Rbr = ++temp;
                if (item.GradId != null)
                {
                    foreach (var item1 in listaGradova)
                    {
                        if (item1.GradId == item.GradId)
                        {
                            item.Grad = item1.Naziv;


                        }
                    }
                }
                korisnici.Add(item);
            }
            //poruke.Clear();
            //foreach (var item in list)
            //{
            //    if (item.PosiljalacId == korisnik.KorisnikId || item.PrimalacId == korisnik.KorisnikId)
            //    {
            //        poruke.Add(item);
            //    }
            //}

        }
        public async void AddNewMessage(object n)
        {
            if (n is Model.Poruke temp)
            {
                await _poruke.Insert<Model.Poruke>(new PorukeUpsertRequest()
                {
                    Sadrzaj = temp.Sadrzaj,
                    Posiljalac = temp.Posiljalac,
                    PosiljalacId = temp.PosiljalacId,
                    PrimalacId = temp.PrimalacId,
                    Primalac = temp.Primalac,
                    Datum = DateTime.Now

                });
            }
        }

    }
 }

