using ES.Core.Data.Interfaces;
using ES.Pedidos.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace ES.Pedidos.Domain.Interfaces
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<Pedido> ObterPorId(Guid id);
        Task<IEnumerable<Pedido>> ObterListaPorClienteId(Guid clienteId);
        void Adicionar(Pedido pedido);
        void Atualizar(Pedido pedido);

        DbConnection ObterConexao();


        /* Pedido Item */
        Task<PedidoItem> ObterItemPorId(Guid id);
        Task<PedidoItem> ObterItemPorPedido(Guid pedidoId, Guid produtoId);
    }
}
