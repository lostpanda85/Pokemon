using Pokemon.Interfaces;
using Pokemon.Services;

namespace Pokemon.Infrastructure
{
    public static class IServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            // Add services scoped to their interface
            services.AddScoped<IPokemonService, PokemonService>();
        }
    }
}
