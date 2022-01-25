﻿using ES.Clientes.API.Application.Commands;
using ES.Clientes.API.Application.Events;
using ES.Clientes.API.Data;
using ES.Clientes.API.Data.Interface;
using ES.Clientes.API.Data.Repository;
using ES.Core.Mediator;
using ES.Core.Mediator.Interfaces;
using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}
