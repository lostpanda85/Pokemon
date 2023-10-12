using Pokemon.Interfaces;
using Data;

namespace Pokemon.Services
{
    public class PokemonService : IPokemonService
    {
        public Models.Pokemon GetPokemon(int id)
        {
            return CreatePokemon.GeneratePokemon();
        }
    }
}
