using Models;

namespace Data
{
    public static class CreatePokemon
    {
        public static Pokemon GeneratePokemon()
        {
            return new Pokemon
            {
                Name = "Pikachu",
                Id = 25
            };
        }
    }
}