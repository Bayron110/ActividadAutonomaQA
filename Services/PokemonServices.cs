using ActividadAutonoma.Models;
using Newtonsoft.Json;
using System.Net.Http;
namespace ActividadAutonoma.Services
{
    public class PokemonServices
    {

        private readonly HttpClient _httpClient;

        public PokemonServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pokemon>> GetPokemonAsync()
        {
            var response = await _httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon");
            var pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(response);
            return pokemons ?? new List<Pokemon>();
        
        
        }
    }
}
