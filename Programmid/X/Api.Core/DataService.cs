using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApi.Core
{
    public class DataService
    {
        public static async Task<MainWeather> GetDataFromService(string queryString)
        {
            HttpClient httpClient = new HttpClient();
            HttpClient client = httpClient;
            var response = await client.GetStringAsync(queryString);

            MainWeather data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<MainWeather>(response.ToString());
            }
            return data;
        }

        public static async Task<LocationId[]> GetDataFromLocation(string queryString)
        {
            HttpClient httpClient = new HttpClient();
            HttpClient client = httpClient;
            var response = await client.GetStringAsync(queryString);

            LocationId[] data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<LocationId[]>(response.ToString());
            }
            return data;
        }
    }
}
