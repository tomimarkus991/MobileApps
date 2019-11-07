using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Core
{
    public class DataService
    {
        public static async Task<MainWeather> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
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
            HttpClient client = new HttpClient();
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
