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

        public async Task<List<Pokemon>> ObtenerPokemones()
        {
            var response = await _httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon");
            var data = JsonConvert.DeserializeObject<PokemonRespuesta>(response);
            return data.Results;
        }

        public async Task<PokemonDetalles> ObtenerDetalle(string nombre)
        {
            var response = await _httpClient.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{nombre}");
            var data = JsonConvert.DeserializeObject<PokemonDetalles>(response);
            return data;
        }
    }
}