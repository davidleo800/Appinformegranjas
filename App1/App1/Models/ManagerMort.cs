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
        const String URL = "http://127.0.0.1/Webservicexamarin/WebService.php";
        private HttpClient getClient() {

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept","application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");


            return client;
        }

        public async Task<IEnumerable<Mortalidad>> getMoritalidad() {

            HttpClient client = getClient();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode) {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Mortalidad>>(content);
            }
            return Enumerable.Empty<Mortalidad>();
        
        }


    }
}
