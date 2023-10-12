using Microsoft.AspNetCore.Mvc;
using Pokemon.Interfaces;

namespace Pokemon.Controllers
{
    [Route("pokemon")]
    [ApiController]
    public class Pokemon : ControllerBase
    {
        private readonly IPokemonService _service;
        public Pokemon(IPokemonService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<string> GetPokemonName(int pokemonId)
        {
            return Ok(_service.GetPokemon(pokemonId));
        }
    }
}
