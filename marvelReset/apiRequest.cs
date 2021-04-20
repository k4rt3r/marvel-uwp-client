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
        
        public static List<Character> GetCharacters(int offset)//COMO APLICAR EL OFFSET
        {
            string url = "https://localhost:44385/api/characters/0"; //NO FUNCIONA

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(response.Content);
            return characters;
        }

        //COMO APLICAR EL OFFSET + LIMIT

        public static List<Character> GetCharacters(int limit = 100, int offset = 0)
        {
            string url = $"https://localhost:44385/api/characters?limit={limit}&offset={offset}";

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(response.Content);
            return characters;
        }

        public static List<Character> SearchCharactersWith(string name, int limit=100, int offset = 0)//COMO APLICAR EL NOMBRE + OFFSET + LIMIT  
        {
            string url = $"https://localhost:44385/api/characters?nameStartsWith={name}&limit={limit}&offset={offset}";

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
