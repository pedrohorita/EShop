using ES.Clientes.API.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ClientesContext>();
        }
    }
}
