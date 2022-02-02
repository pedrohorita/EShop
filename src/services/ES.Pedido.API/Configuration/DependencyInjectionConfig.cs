using ES.Core.Mediator;
using ES.Core.Mediator.Interfaces;
using ES.Pedidos.API.Application.Commands;
using ES.Pedidos.API.Application.Events;
using ES.Pedidos.API.Application.Queries;
using ES.Pedidos.API.Application.Queries.Interfaces;
using ES.Pedidos.Domain.Interfaces;
using ES.Pedidos.Infra.Data;
using ES.Pedidos.Infra.Data.Repository;
using ES.WebAPI.Core.Usuario;
using ES.WebAPI.Core.Usuario.Interfaces;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Pedidos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            // Commands
            services.AddScoped<IRequestHandler<AdicionarPedidoCommand, ValidationResult>, PedidoCommandHandler>();

            // Events
            services.AddScoped<INotificationHandler<PedidoRealizadoEvent>, PedidoEventHandler>();

            // Application
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IVoucherQueries, VoucherQueries>();
            services.AddScoped<IPedidoQueries, PedidoQueries>();

            // Data
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<PedidosContext>();
        }
    }
}
