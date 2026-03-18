using Newtonsoft.Json;
using System.Collections.Generic;
namespace ActividadAutonoma.Models
{
    public class PokemonDetalles
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public SpritesPokemon Sprites { get; set; }
        public List<TipoSlot> Types { get; set; }
        public List<HabilidadSlot> Abilities { get; set; }
    }
    public class SpritesPokemon
    {
        [JsonProperty("front_default")]
        public string Imagen { get; set; }
    }

    public class TipoSlot
    {
        public int Slot { get; set; }
        public TipoPokemon Type { get; set; }
    }

    public class TipoPokemon
    {
        public string Name { get; set; }
    }

    public class HabilidadSlot
    {
        [JsonProperty("is_hidden")]
        public bool EsOculta { get; set; }

        public int Slot { get; set; }
        public HabilidadPokemon Ability { get; set; }
    }

    public class HabilidadPokemon
    {
        public string Name { get; set; }
    }
}
