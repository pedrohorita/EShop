using ES.Catalogo.API.Data;
using ES.Catalogo.API.Data.Interfaces;
using ES.Catalogo.API.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
