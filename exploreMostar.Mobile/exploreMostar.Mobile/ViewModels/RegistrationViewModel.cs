using exploreMostar.Model;
using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
  public  class RegistrationViewModel :BaseViewModel
    {
        private APIService korisnici = new APIService("Korisnici");

        public RegistrationViewModel()
        {
           Submit = new Command(async () => await Registracija());
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

      
        public ICommand Submit { get; set; }
        async Task Registracija()
        {
            try
            {
                if (ConfirmPassword != Password)
                {
                    throw new Exception("Passwords do not match.");
                }

                IsBusy = true;
                await korisnici.Insert<Korisnici>(new KorisniciInsertRequest()
                {
                   Ime= _firstname,
                   Prezime=_lastname,
                   Telefon=_mobile,
                   KorisnickoIme=_username,
                   Password=Password,
                   PasswordConfirmation= _confirmPassword,
                   Email=_email
                });
               

                Application.Current.MainPage = new LoginPage();
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid information passed", "OK");
            }
        }
    }
}

