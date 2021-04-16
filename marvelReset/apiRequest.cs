using marvelReset.Dtos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset
{
    class apiRequest
    {
        public static List<Character> GetCharacters(int offset = 1)
        {
            string url = "https://localhost:44385/api/characters/0";

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(response.Content);
            return characters;
        }
    }
}
