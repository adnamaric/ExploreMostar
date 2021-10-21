using exploreMostar.Model;
using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace exploreMostar.Mobile.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private APIService korisnici = new APIService("Korisnici");
        private readonly APIService _aPIService = new APIService("Gradovi");

        public  RegistrationViewModel()
        {
            Submit = new Command(async () => await Registracija());
            UcitajGradove();
        }
        public List<Model.Gradovi> GradList { get; set; } = new List<Model.Gradovi>();
        public void UcitajGradove()
        {
            Task<List<Model.Gradovi>> task = Task.Run<List<Model.Gradovi>>(async () => await _aPIService.Get<List<Model.Gradovi>>(null));
            GradList.Clear();
            GradList.AddRange(task.Result);
        }
        Gradovi _selectedGrad = null;
        public Gradovi SelectedGrad
        {
            get { return _selectedGrad; }
            set
            {
                SetProperty(ref _selectedGrad, value);
                if (value != null)
                {
                    
                }
            }
        }
        string _username = string.Empty;
        public string KorisnickoIme
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }


        string _firstname = string.Empty;
        public string Ime
        {
            get { return _firstname; }
            set { SetProperty(ref _firstname, value); }
        }

        string _lastname = string.Empty;
        public string Prezime
        {
            get { return _lastname; }
            set { SetProperty(ref _lastname, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _confirmPassword = string.Empty;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }

        DateTime _birthdate = DateTime.UtcNow;
        public DateTime DatumRodjenja
        {
            get { return _birthdate; }
            set { SetProperty(ref _birthdate, value); }
        }

        string _mobile = string.Empty;
        public string Telefon
        {
            get { return _mobile; }
            set { SetProperty(ref _mobile, value); }
        }

        int _gradId = 0;
        public int Grad
        {
            get { return _gradId; }
            set { SetProperty(ref _gradId, value); }
        }

        //List<Model.Gradovi> lista = new List<Model.Gradovi>(async => await Function());

        //public async Task Function()
        //{
        //    lista = await _aPIService.Get<List<Model.Gradovi>>(null);

        //}
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
        public ICommand Submit { get; set; }
        async Task Registracija()
        {
            if (Ime == string.Empty && Prezime == string.Empty && _username == string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", "You can not save an empty user", "OK");
            else if(_username==string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", " Username is mandatory field", "OK");
            else if (_email == string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", " Email is mandatory field", "OK");
            else if (Ime == string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", " First name is mandatory field", "OK");
            else if (Prezime == string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", " Last name is mandatory field", "OK");
            else if(Password== string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", " Password is mandatory field", "OK");
            else if (ConfirmPassword == string.Empty)
                await Application.Current.MainPage.DisplayAlert("Error", " Confirmation of password is mandatory field", "OK");
            else if (_selectedGrad == null)
                await Application.Current.MainPage.DisplayAlert("Error", " City is mandatory field", "OK");
            else
            {
                var temp = _selectedGrad;
                try
                {
                    if (ConfirmPassword != Password)
                    {
                        throw new Exception("Passwords do not match.");
                    }
                

                    List<KorisniciUloge> n = new List<KorisniciUloge>();

                    List<int> novaLista = new List<int>();
                    novaLista.Add(2);
                    IsBusy = true;
                    var incase = 1;
                    if (temp != null)
                    {
                        await korisnici.Insert<Korisnici>(new KorisniciInsertRequest()
                        {
                            Ime = _firstname,
                            Prezime = _lastname,
                            Telefon = _mobile,
                            KorisnickoIme = _username,
                            Password = Password,
                            PasswordConfirmation = _confirmPassword,
                            Email = _email,
                            GradId = temp.GradId,
                            DatumRodjenja = _birthdate,
                            Uloge = novaLista
                        });
                    }
                    else
                    {
                        await korisnici.Insert<Korisnici>(new KorisniciInsertRequest()
                        {
                            Ime = _firstname,
                            Prezime = _lastname,
                            Telefon = _mobile,
                            KorisnickoIme = _username,
                            Password = Password,
                            PasswordConfirmation = _confirmPassword,
                            Email = _email,
                            GradId = incase,
                            DatumRodjenja = _birthdate,
                            Uloge = novaLista
                        });
                    }

                    Application.Current.MainPage = new OpeningPage();
                }
                catch
                {
                    if (_selectedGrad == null && _firstname != "" && _lastname != "")
                        await Application.Current.MainPage.DisplayAlert("Error", "You haven't selected a city!", "OK");
                    else if (ConfirmPassword != Password)
                        await Application.Current.MainPage.DisplayAlert("Error", "Passwords do not match!", "OK");
                    else
                        await Application.Current.MainPage.DisplayAlert("Error", "Invalid information passed", "OK");
                }
            }
        }

        //private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        //{
        //    if (!Equals(field, newValue))
        //    {
        //        field = newValue;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //        return true;
        //    }

        //    return false;
        //}

        //private string naziv;

        //public string Naziv { get => naziv; set => SetProperty(ref naziv, value); }
    }
}

