using exploreMostar.Mobile.Views;
using System;
using System.Collections.Generic;
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
        async Task Login()
        {
            
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            try
            {
                await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
