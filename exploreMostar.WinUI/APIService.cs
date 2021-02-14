using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using exploreMostar.Model;

namespace exploreMostar.WinUI
{
    //za centraliziranje pozivanja APIa
    public class APIService
    {
        private string _route = null;
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
            if (search != null)
            {
                url += "?";
                url += search.ToQueryString();
            }
            var result = await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
           
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
          
            var result = await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(object id,object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.PutJsonAsync(request).ReceiveJson<T>();
        }

        //public async Task<T> Delete<T>(object id)
        //{
        //    var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

        //    var result = await url.GetJsonAsync<T>();
        //    return await url.PutJsonAsync(request).ReceiveJson<T>();;
        //}
    }
}
