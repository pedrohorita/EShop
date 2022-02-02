using ES.Pedidos.API.Application.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.Pedidos.API.Application.Queries.Interfaces
{
    public interface IPedidoQueries
    {
        Task<PedidoDTO> ObterUltimoPedido(Guid clienteId);
        Task<IEnumerable<PedidoDTO>> ObterListaPorClienteId(Guid clienteId);
    }
}
