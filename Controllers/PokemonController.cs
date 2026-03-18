using ActividadAutonoma.Services;
using Microsoft.AspNetCore.Mvc;

namespace ActividadAutonoma.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonServices _pokemonservices;

        public PokemonController(PokemonServices pokemonservices)
        {
            _pokemonservices = pokemonservices;
        }

        // Lista de pokemones
        public async Task<IActionResult> Index()
        {
            var pokemones = await _pokemonservices.ObtenerPokemones();
            return View(pokemones);
        }

        // Detalle de un pokemon
        public async Task<IActionResult> Details(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return RedirectToAction(nameof(Index));
            }

            var pokemon = await _pokemonservices.ObtenerDetalle(nombre);

            if (pokemon == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(pokemon);
        }
    }
}