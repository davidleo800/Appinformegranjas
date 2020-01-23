using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
namespace AppInformeGranjas.Models
{
    class ManagerMort
    {
        HttpClient client;
        const String URL = "https://weakened-bet.000webhostapp.com/Webservicexamarin/WebService.php";
        private HttpClient getClient() {

            client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept","application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");


            return client;
        }

        public async Task<IEnumerable<Mortalidad>> getMoritalidad() {

            client = getClient();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode) {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Mortalidad>>(content);
            }
            return Enumerable.Empty<Mortalidad>();
        
        }

     



    }
}
