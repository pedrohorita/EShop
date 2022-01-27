using ES.MessageBus.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ES.MessageBus.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMessageBus(this IServiceCollection services, string connection)
        {
            if (string.IsNullOrEmpty(connection)) 
                throw new ArgumentNullException();

            services.AddSingleton<IMessageBus>(new Services.MessageBus(connection));

            return services;
        }
    }
}
