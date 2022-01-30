using ES.Core.Mediator;
using ES.Core.Mediator.Interfaces;
using ES.Pedido.Infra.Data;
using ES.WebAPI.Core.Usuario;
using ES.WebAPI.Core.Usuario.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Pedido.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            // Application
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Data
           
           
            services.AddScoped<PedidosContext>();
        }
    }
}
