using exploreMostar.Mobile.Views;
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
            
            var result = await _service.Get<List<Model.Korisnici>>(null);
            Model.Korisnici korisnik = new Model.Korisnici();
            bool pronadjen = false;
            bool pronadjen2 = false;


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

            if (pronadjen2 == true && pronadjen == true)
            {
                try
                {
                    APIService.Username = Username;
                    APIService.Password = Password;

                    await _service.Get<dynamic>(null);
                    Application.Current.MainPage = new UserPreferenceContentPage();


                }
                catch (Exception ex)
                {
                    //  MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");

                }

            }
            else
            {
                //  MessageBox.Show("Molimo vas unesite ispravno korisničko ime i/ili lozinku", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Application.Current.MainPage.DisplayAlert("Try again", "Please enter correct username and/or password !", "OK");

            }
           
        }
    }
}
