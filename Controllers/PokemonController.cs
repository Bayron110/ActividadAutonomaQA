using ActividadAutonoma.Services;
using Microsoft.AspNetCore.Http;
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

        // GET: PokemonController
        public async Task<ActionResult> Index()
        {
            var pokemon = await _pokemonservices.GetPokemonAsync();
            return View(pokemon);
        }

        // GET: PokemonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PokemonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PokemonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokemonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PokemonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokemonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PokemonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
