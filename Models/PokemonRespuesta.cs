namespace ActividadAutonoma.Models
{
    public class PokemonRespuesta
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Pokemon> Results { get; set; }
    }
}
