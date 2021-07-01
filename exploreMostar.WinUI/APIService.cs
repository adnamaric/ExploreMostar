using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

using exploreMostar.Model;
using System.Windows.Forms;

namespace exploreMostar.WinUI
{
    //za centraliziranje pozivanja APIa
    public class APIService
    {
        private string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static bool isUpdate { get; set; }
        public static bool isDelete { get; set; }

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
            var url =  $"{Properties.Settings.Default.APIUrl}/{_route}";
           try  {
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
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }


        }
        public async Task<T> GetById<T>(object id)
        {
           
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
          
             return await url.WithBasicAuth(APIService.Username, APIService.Password).GetJsonAsync<T>();
            
        }
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithBasicAuth(APIService.Username, APIService.Password).PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(object id,object request)
        {
            var nesto = Username;
            //var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            //return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

       
        public async Task<bool> Delete(int id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

          

            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();
        }




    }
}

