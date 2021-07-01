using exploreMostar.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exploreMostar.Mobile
{
    public class APIService
    {
        private readonly string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static bool Food { get; set; }
        public static bool Atraction { get; set; }
        public static bool Apartments { get; set; }
        public static bool Hotels { get; set; }
        public static bool Transport { get; set; }
        public static bool Coffeeshops { get; set; }
        public static bool Other { get; set; }
        public static bool Nightclubs { get; set; }
        public static bool Recenzije { get; set; }
        public static string PutanjaSlike { get; set; }
        public static string Naziv { get; set; }
        public static string Vrsta { get; set; }
        public static bool NearOn{ get; set; }
        public static bool UPContentPage { get; set; }
        public static bool PreferenceListPage { get; set; }
        public static bool InboxLista { get; set; }
        public static bool SearchLista { get; set; }
        public static string Pretraga { get; set; }
        public static double VelicinaListe { get; set; }
        public static double VelicinaInboxa { get; set; }
        public static bool MapPage { get; set; }
        public static object modelTemp { get; set; }
        public static string SearchCon { get; set; }
        public static bool postojiFavorit { get; set; }
        public static ObservableCollection<Model.ReportClass> searchListaObjekata { get; set; } = new ObservableCollection<ReportClass>();
        public static int ObjekatID { get; set; }

#if DEBUG
        string _apiUrl = "http://localhost:6060/api";
       // string _apiUrl = "http://localhost:64741/api/";
#endif
#if RELEASE
 
#endif

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
        {
            //asynch - čeka na api
            //  var result = $"{Properties.Settings.Default.APIUrl}/{_route}".GetJsonAsync<T>();
            //return result.Result;

            //var result = await $"{Properties.Settings.Default.APIUrl}/{_route}".GetJsonAsync<T>();
            var url = $"{_apiUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(APIService.Username,APIService.Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    //MessageBox.Show("Niste authentificirani");
                 await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                
                    throw new Exception( "Niste authentificirani");
            }


        }
        public async Task<T> GetById<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(APIService.Username, APIService.Password).GetJsonAsync<T>();

        }
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";

            //return await url.PostJsonAsync(request).ReceiveJson<T>();
            try
            {
                return await url.WithBasicAuth(APIService.Username, APIService.Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Update<T>(object id, object request)
        {

            //var url = $"{_apiUrl}/{_route}/{id}";
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(APIService.Username, APIService.Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
            //return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }

        //public async Task<T> Delete<T>(object id)
        //{
        //    var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

        //    var result = await url.GetJsonAsync<T>();
        //    return await url.PutJsonAsync(request).ReceiveJson<T>();;
        //}
        public async Task<T> Delete<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            var result = await url.GetJsonAsync<T>();
            return await url.WithBasicAuth(APIService.Username, APIService.Password).DeleteAsync().ReceiveJson<T>();
        }
      
    }
}
