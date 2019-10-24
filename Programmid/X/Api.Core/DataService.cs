using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Core
{
    public class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            dynamic data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<WeatherID.ConsolidatedWeather>(response.ToString());
            }
            return data;
        }
    }
}
