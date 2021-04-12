using exploreMostar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
    public class MyFavouritesModel : BaseViewModel
    {
        private readonly APIService _favoriti = new APIService("MojiFavoriti");
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _nk = new APIService("Nightclubs");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _ua = new APIService("UserActivity");
        private readonly APIService _recenzije = new APIService("Recenzije");

        public ObservableCollection<Model.MojiFavoriti> favoriti { get; set; } = new ObservableCollection<Model.MojiFavoriti>();
        public MyFavouritesModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Model.Korisnici korisnik = null;
            var listaK = await _korisnici.Get<List<Model.Korisnici>>(null);
            var list = await _favoriti.Get<IList<Model.MojiFavoriti>>(null);
            foreach (var item in listaK)
            {
                if (item.KorisnickoIme == APIService.Username)
                    korisnik = item;
            }
            favoriti.Clear();
            var temp = 0;
            foreach (var item in list)
            {
                if (item.KorisnikId == korisnik.KorisnikId)
                {
                    item.Rbr = ++temp;
                    favoriti.Add(item);
                }
            }
        }

        public async void GetFavorite(object e)
        {
            var favorit = e as Model.MojiFavoriti;
            if (favorit.Vrsta == "Apartman")
            {
                var listaApartmana = await _apartmani.Get<List<Model.Apartmani>>(null);
                foreach (var item in listaApartmana)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }

            }
            if (favorit.Vrsta == "Atrakcija")
            {
                var listaAtrakcija = await _atrakcije.Get<List<Model.Atrakcije>>(null);
                foreach (var item in listaAtrakcija)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Restoran")
            {
                var listaRestorana = await _restorani.Get<List<Model.Restorani>>(null);
                foreach (var item in listaRestorana)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Hotel")
            {
                var listaHotela = await _hoteli.Get<List<Model.Hoteli>>(null);
                foreach (var item in listaHotela)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Nocni klub")
            {
                var listaNk = await _nk.Get<List<Model.Nightclubs>>(null);
                foreach (var item in listaNk)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
            if (favorit.Vrsta == "Kafic")
            {
                var listaKafica = await _kafici.Get<List<Model.Kafici>>(null);
                foreach (var item in listaKafica)
                {
                    if (item.Naziv == favorit.Naziv)
                    {
                        APIService.modelTemp = item;
                        Application.Current.MainPage = new MapPage(APIService.modelTemp);
                    }
                }
            }
        }
        //public async void GetRecommended()
        //{
        //    var listaKorisnika = await _korisnici.Get<List<Model.Korisnici>>(null);
        //    var listaRecenzija = await _recenzije.Get<List<Model.Recenzije>>(null);
        //    var listaApartmana = await _apartmani.Get<List<Model.Apartmani>>(null);
        //    var listaAtrakcija = await _atrakcije.Get<List<Model.Atrakcije>>(null);
        //    var listaHotela = await _hoteli.Get<List<Model.Hoteli>>(null);
        //    var listaKafica = await _kafici.Get<List<Model.Kafici>>(null);
        //    var listaRestorana = await _kafici.Get<List<Model.Restorani>>(null);
        //    var listaNk = await _nk.Get<List<Model.Nightclubs>>(null);

        //    List<Model.Recenzije> mojeRecenzije = new List<Model.Recenzije>();
        //    Model.Korisnici korisnik = null;
        //    foreach (var item in listaKorisnika)
        //    {
        //        if (item.KorisnickoIme == APIService.Username)
        //        {
        //            korisnik = item;
        //            break;
        //        }
        //    }
        //    if (korisnik != null)
        //    {
        //        foreach (var item in listaRecenzija)
        //        {
        //            if (korisnik.KorisnikId == item.KorisnikId)
        //            {
        //                if (item.Ocjena > 4)
        //                {
        //                    mojeRecenzije.Add(item);
        //                }
        //            }
        //        }
        //    }
        //    bool Apartmani = false;
        //    List<string> apartmaniSu = new List<string>();
        //    bool Atrakcije = false;
        //    List<string> atrakcijeSu = new List<string>();

        //    bool Kafici = false;
        //    bool Nightclubs = false;
        //    bool Hoteli = false;
        //    List<string> restoraniSu = new List<string>();
        //    List<string> kaficiSu = new List<string>();
        //    List<string> hoteliSu = new List<string>();
        //    List<string> nocniSu = new List<string>();


        //    bool Restorani = false;

        //    foreach (var item in mojeRecenzije)
        //    {
        //        if (item.Vrsta == "Apartman")
        //        {
        //            Apartmani = true;
        //            apartmaniSu.Add(item.Objekat);
        //        }
        //        if (item.Vrsta == "Atrakcija")
        //        {
        //            Atrakcije = true;
        //            atrakcijeSu.Add(item.Objekat);
        //        }
        //        if (item.Vrsta == "Restoran")
        //        {
        //            Restorani = true;
        //            restoraniSu.Add(item.Objekat);
        //        }
        //        if (item.Vrsta == "Kafic")
        //        {
        //            Kafici = true;
        //            kaficiSu.Add(item.Objekat);
        //        }
        //        if (item.Vrsta == "Hotel")
        //        {
        //            Hoteli = true;
        //            hoteliSu.Add(item.Objekat);
        //        }
        //        if(item.Vrsta=="Nocni klub")
        //        {
        //            Nightclubs = true;
        //            nocniSu.Add(item.Objekat);
        //        }
        //    }
        //    if (Apartmani)
        //    {
        //        int brojac = 0;
        //        foreach(var item in listaApartmana)
        //        {
        //            if (item.Ocjena >= 4)
        //            {
        //                foreach(var item2 in apartmaniSu)
        //                {
        //                    if (item2 != item.Naziv)
        //                    {

        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //    public async void GetRecommend()
        //    {
        //        var listaKorisnika = await _korisnici.Get<List<Model.Korisnici>>(null);
        //        var listaUA = await _ua.Get<List<Model.UserActivity>>(null);
        //        var listaFavorita = await _favoriti.Get<List<Model.MojiFavoriti>>(null);
        //        var listaRecenzija = await _recenzije.Get<List<Model.Recenzije>>(null);
        //        List<Model.Recenzije> mojeRecenzije = new List<Model.Recenzije>();
        //        Model.Korisnici korisnik = null;
        //        Model.UserActivity user = null;

        //        foreach(var item in listaKorisnika)
        //        {
        //            if(item.KorisnickoIme==APIService.Username)
        //            {
        //                korisnik = item;
        //                break;
        //            }
        //        }
        //        if (korisnik != null)
        //        {
        //            foreach(var item in listaRecenzija)
        //            {
        //                if (korisnik.KorisnikId == item.KorisnikId)
        //                {
        //                    if (item.Ocjena > 4)
        //                    {
        //                        mojeRecenzije.Add(item);
        //                    }
        //                }
        //            }
        //        }

        //        if (mojeRecenzije.Count > 0)
        //        {
        //            foreach(var item in mojeRecenzije)
        //            {
        //                if (item.Ocjena >= 4.5)
        //                {

        //                }
        //            }
        //        }
        //        if (korisnik != null)
        //        {
        //            foreach(var item in listaUA)
        //            {
        //                if (item.KorisnikId == korisnik.KorisnikId)
        //                {
        //                    user = item;
        //                    break;
        //                }
        //            }
        //            if (user != null)
        //            {
        //                user.BrojAtrakcijaFavoriti = 0;
        //                user.BrojApartmanaFavoriti = 0;
        //                user.BrojHotelaFavoriti = 0;
        //                user.BrojKaficaFavoriti = 0;
        //                user.BrojRestoranaFavoriti = 0;
        //                user.BrojNocnihKlubovaFavoriti = 0;
        //                foreach (var item in listaFavorita)
        //                {
        //                    if (item.KorisnikId == user.KorisnikId)
        //                    {
        //                        if (item.Vrsta == "Atrakcija")
        //                        {

        //                            user.BrojAtrakcijaFavoriti += 1;
        //                        }
        //                        else if (item.Vrsta == "Apartman")
        //                        {
        //                            user.BrojApartmanaFavoriti += 1;
        //                        }
        //                        else if (item.Vrsta == "Kafic")
        //                        {
        //                            user.BrojKaficaFavoriti += 1;
        //                        }
        //                        else if (item.Vrsta == "Hotel")
        //                        {
        //                            user.BrojHotelaFavoriti += 1;
        //                        }
        //                        else if (item.Vrsta == "Restoran")
        //                        {
        //                            user.BrojRestoranaFavoriti += 1;
        //                        }
        //                        else if (item.Vrsta == "Nocni klub")
        //                        {
        //                            user.BrojNocnihKlubovaFavoriti += 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        int najveci = 0;
        //        int drugiNajveci = 0;
        //        int pozicijaDrugog = 0;
        //        int pozicija = 0;
        //        string kat;
        //        int[] array = { (int)user.BrojApartmanaFavoriti, (int)user.BrojHotelaFavoriti, (int)user.BrojKaficaFavoriti, (int)user.BrojNocnihKlubovaFavoriti, (int)user.BrojAtrakcijaFavoriti, (int)user.BrojRestoranaFavoriti };
        //       for(int i = 0; i< 5; i++)
        //        {
        //            if (array[i] > array[i + 1])
        //            {
        //                najveci = array[i];
        //                pozicija = i;
        //            }
        //            else if (array[i] == array[i + 1])
        //            {
        //                drugiNajveci = array[i];
        //                if (najveci == drugiNajveci)
        //                {
        //                    pozicijaDrugog = i;
        //                }
        //            }
        //            else 
        //            {
        //                najveci = array[i+1];
        //                pozicija = i+1;
        //            }
        //        }
        //        if (pozicija == 0)
        //        {
        //            kat = "Apartman";

        //        }
        //        if (pozicija == 1)
        //        {
        //            //hoteli
        //        }
        //        if (pozicija == 2)
        //        {
        //            //kafici
        //        }
        //        if (pozicija == 3)
        //        {
        //            //nocni klubovi
        //        }
        //        if (pozicija == 4)
        //        {
        //            //atrakcije 
        //        }
        //        if (pozicija == 5)
        //        {
        //            //restorani
        //        }
        //    }
        //}
    }
}
