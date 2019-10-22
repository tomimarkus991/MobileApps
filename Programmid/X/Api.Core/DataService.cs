using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks; 

namespace Api.Core
{
    public class DataService
    {
        public static async Task<dynamic> GetDataService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<WeatherID.ConsolidatedWeather>(response.ToString());
            }
            return data;
        }
    }
}
