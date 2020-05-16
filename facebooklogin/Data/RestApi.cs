using facebooklogin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace facebooklogin.Data
{
    public class RestApi
    {
        HttpClient client;
        public RestApi()
        {
            client = new HttpClient();
        }
        public async Task<facebook_login> GetDetails(string accessToken)
        {
            var url = string.Format(constants.RequestUri, accessToken);
            try
            {
                var json = await client.GetStringAsync(url);
                if (string.IsNullOrWhiteSpace(json))
                    return null;
                var result = JsonConvert.DeserializeObject<facebook_login>(json);
                return result;
            }
            catch
            {
                return null;
            }
        }

       
    }
}
