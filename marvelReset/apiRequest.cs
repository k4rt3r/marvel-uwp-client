using marvelReset.Dtos;
using marvelReset.Model;
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

        //CHARACTER TYPE METHODS
        public static List<Character> GetCharacters(int offset)
        {
            string url = "https://localhost:44385/api/characters/offset="+offset; //NO FUNCIONA

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(response.Content);
            return characters;
        }

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
        
        public static List<Character> SearchCharactersWith(string name)
        {
            string url = $"https://localhost:44385/api/characters/nameStartsWith={name}";

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(response.Content);
            return characters;
        }

        //CHARACTER MODEL TYPE METHODS
        public static List<CharacterModel> GetCharactersM(int offset)
        {
            string url = "https://localhost:44385/api/characters/" + offset; //NO FUNCIONA

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<CharacterModel> characters = new List<CharacterModel>();
            characters = JsonConvert.DeserializeObject<List<CharacterModel>>(response.Content);
            return characters;
        }
        public static List<CharacterModel> SearchCharactersWithM(string name)
        {
            string url = $"https://localhost:44385/api/characters/nameStartsWith={name}";

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            String resultado = response.Content.ToString();

            List<CharacterModel> characters = JsonConvert.DeserializeObject<List<CharacterModel>>(response.Content);
            return characters;
        }
    }
}
