using exploreMostar.Mobile.Views;
using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace exploreMostar.Mobile.ViewModels
{
   public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _uaservice = new APIService("UserActivity");

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }
        public ICommand RegistrationCommand { get; set; }

        
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegistrationCommand = new Command(async () =>
            {
                try
                {
                    Application.Current.MainPage = new RegistationPage();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                }
            });
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray);
        }
        protected string hash;
        async Task Login()
        {
            
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            var resultUA = await _uaservice.Get<List<Model.UserActivity>>(null);
            var result = await _service.Get<List<Model.Korisnici>>(null);
            Model.Korisnici korisnik = new Model.Korisnici();
            bool pronadjen = false;
            bool pronadjen2 = false;
            Model.UserActivity userActivity = null;
            bool udaljen = false;
           
            bool takeThis = false;
            if (udaljen == true)
            {
                await Application.Current.MainPage.DisplayAlert("You don't have permissions to access the application", "No access", "OK");
            }
            foreach (var temp in result)
            {
                if (temp.KorisnickoIme == Username)
                {
                    korisnik = temp;
                    pronadjen = true;

                    hash = GenerateHash(korisnik.LozinkaSalt, Password);
                    if (temp.LozinkaHash == hash)
                    {
                        pronadjen2 = true;
                    }
                }


            }
            foreach (var item in resultUA)
            {
                if (item.KorisnikId == korisnik.KorisnikId)
                {
                    userActivity = item;
                    if (item.BrojNeuspjesnihPrijavljivanja >= 3)
                    {
                        item.Onemogucen = true;
                        udaljen = true;
                    }
                }
            }
            if (pronadjen2 == true && pronadjen == true && udaljen == false)
            {
                try
                {
                    APIService.Username = Username;
                    APIService.Password = Password;
                    if (userActivity != null)
                        userActivity.BrojPrijavljivanja += 1;
                    await _service.Get<dynamic>(null);
                    Application.Current.MainPage = new UserPreferenceContentPage();
                    takeThis = true;

                }
                catch (Exception ex)
                {
                    //  MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                   
                }

            }
            else if (pronadjen == true && udaljen == false)
            {
                if (userActivity != null)
                    userActivity.BrojNeuspjesnihPrijavljivanja += 1;
                takeThis = false;
                await Application.Current.MainPage.DisplayAlert("Try again", "Please enter correct username and/or password !", "OK");

            }
            else
            {
                //  MessageBox.Show("Molimo vas unesite ispravno korisničko ime i/ili lozinku", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Application.Current.MainPage.DisplayAlert("Try again", "Please enter correct username and/or password !", "OK");

            }
            try
            {
                if (userActivity != null)
                {

                    var request = new UserActivityUpsertRequest
                    {
                        KorisnikId = userActivity.KorisnikId,
                        BrojPrijavljivanja = userActivity.BrojPrijavljivanja,
                        BrojNeuspjesnihPrijavljivanja = userActivity.BrojNeuspjesnihPrijavljivanja,
                        Datum = DateTime.Now,
                        Razlog = "",
                        Onemogucen = false,
                        IsApartman=userActivity.IsApartman,
                        IsAtrakcija=userActivity.IsAtrakcija,
                        IsHotel=userActivity.IsHotel,
                        IsKafic=userActivity.IsKafic,
                        IsNightClub=userActivity.IsNightClub,
                        IsRestoran=userActivity.IsRestoran,
                        

                    };
                    await _uaservice.Update<Model.UserActivity>(userActivity.KorisnikId, request);
                }
                else
                {
                    if (takeThis)
                    {
                        var request = new UserActivityUpsertRequest
                        {
                            KorisnikId = korisnik.KorisnikId,
                            BrojPrijavljivanja = 1,
                            BrojNeuspjesnihPrijavljivanja = 0,
                            Datum = DateTime.Now,
                            Razlog = "",
                            Onemogucen = false

                        };
                        await _uaservice.Insert<Model.UserActivity>(request);
                    }
                    else
                    {
                        var request = new UserActivityUpsertRequest
                        {
                            KorisnikId = korisnik.KorisnikId,
                            BrojPrijavljivanja = 0,
                            BrojNeuspjesnihPrijavljivanja = 1,
                            Datum = DateTime.Now,
                            Razlog = "",
                            Onemogucen = false

                        };
                        await _uaservice.Insert<Model.UserActivity>(request);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
