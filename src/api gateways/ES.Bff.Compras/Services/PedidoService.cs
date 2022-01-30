using ES.Bff.Compras.Extensions;
using ES.Bff.Compras.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

namespace ES.Bff.Compras.Services
{

    public class PedidoService : Service, IPedidoService
    {
        private readonly HttpClient _httpClient;

        public PedidoService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.PedidoUrl);
        }
    }
}
