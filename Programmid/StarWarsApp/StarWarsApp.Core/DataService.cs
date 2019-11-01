using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            dynamic data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<People>(response.ToString());
            }
            return data;
        }
    }
}
