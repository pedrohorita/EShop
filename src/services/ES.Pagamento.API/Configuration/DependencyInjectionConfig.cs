using ES.Pagamentos.API.Data;
using ES.Pagamentos.API.Data.Repository;
using ES.Pagamentos.API.Facede;
using ES.Pagamentos.API.Interfaces;
using ES.Pagamentos.API.Services;
using ES.WebAPI.Core.Usuario;
using ES.WebAPI.Core.Usuario.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Pagamentos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoFacade, PagamentoCartaoCreditoFacade>();

            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}
