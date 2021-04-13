using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace exploreMostar.Mobile.ViewModels
{
    public class SearchResultModel : BaseViewModel
    {
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _nocniklubovi = new APIService("Nightclubs");
        private readonly APIService _searchS = new APIService("Search");
        private readonly APIService korisnici = new APIService("Korisnici");

        public ObservableCollection<Model.ReportClass> temp { get; set; } = new ObservableCollection<Model.ReportClass>();
        public string _search = string.Empty;

        public string Search
        {
            get { return _search; }
            set { SetProperty(ref _search, value); }
        }
        public SearchResultModel()
        {

        }
        public async void SearchResult(string search)
        {
            _search = search;
            var listApartmana = await _apartmani.Get<IList<Model.Apartmani>>(null);
            var listaAtrakcija = await _atrakcije.Get<IList<Model.Atrakcije>>(null);
            var listaKafica = await _kafici.Get<IList<Model.Kafici>>(null);
            var listaHotela = await _hoteli.Get<IList<Model.Hoteli>>(null);
            var listaRestorana = await _restorani.Get<IList<Model.Restorani>>(null);
            var listaNk = await _nocniklubovi.Get<IList<Model.Nightclubs>>(null);
            var listaK = await korisnici.Get<IList<Model.Korisnici>>(null);
            Model.Korisnici korisnik = null;
            List<Model.ReportClass> sviObjektiNadjeni = new List<Model.ReportClass>();
            object trazeniModel = null;
            foreach(var item in listaK)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    korisnik = item;
                }
            }
            if (_search != string.Empty)
            {
                if (korisnik != null)
                {
                    await _searchS.Insert<Model.Search>(new SearchUpsertRequest()
                    {
                        KorisnikId=korisnik.KorisnikId,
                        Sadrzaj=_search,
                        DatumPretrage=DateTime.Now,
                        ImePrezime=korisnik.Ime+" "+korisnik.Prezime
                    });
                }
                if (_search == "apartman" || _search == "apartment")
                {
                    // vraca listu apartmana
                }
                temp.Clear();
                foreach (var item in listApartmana)
                {
                    string lowerSearch = _search.ToLower();
                    string lowerLetters = item.Naziv.ToLower();
                    if (lowerLetters.Contains(lowerSearch))
                    {
                        trazeniModel = item;

                        temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = item.Vrsta });
                    }
                }

                foreach (var item in listaAtrakcija)
                {
                    string lowerSearch = _search.ToLower();
                    string lowerLetters = item.Naziv.ToLower();
                    if (lowerLetters.Contains(lowerSearch))
                    {
                        trazeniModel = item;
                        temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = item.Vrsta });
                    }
                }



                foreach (var item in listaHotela)
                {
                    string lowerSearch = _search.ToLower();
                    string lowerLetters = item.Naziv.ToLower();
                    if (lowerLetters.Contains(lowerSearch))
                    {
                        trazeniModel = item;
                        temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Hotel" });
                    }
                }



                foreach (var item in listaKafica)
                {
                    string lowerSearch = _search.ToLower();
                    string lowerLetters = item.Naziv.ToLower();
                    if (lowerLetters.Contains(lowerSearch))
                    {
                        trazeniModel = item;
                        temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Kafic" });
                    }
                }


                foreach (var item in listaRestorana)
                {
                    string lowerSearch = _search.ToLower();
                    string lowerLetters = item.Naziv.ToLower();
                    if (lowerLetters.Contains(lowerSearch))
                    {
                        trazeniModel = item;
                        temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Restoran" });
                    }
                }


                foreach (var item in listaNk)
                {
                    string lowerSearch = _search.ToLower();
                    string lowerLetters = item.Naziv.ToLower();
                    if (lowerLetters.Contains(lowerSearch))
                    {
                        trazeniModel = item;
                        temp.Add(new Model.ReportClass { Naziv = item.Naziv, Ocjena = item.Ocjena, Vrsta = "Nightclub" });
                    }
                }

            }
        }
    }
}
