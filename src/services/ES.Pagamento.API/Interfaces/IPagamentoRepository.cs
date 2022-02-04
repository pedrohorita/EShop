using ES.Core.Data.Interfaces;
using ES.Pagamentos.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.Pagamentos.API.Interfaces
{
    public interface IPagamentoRepository : IRepository<Pagamento>
    {
        void AdicionarPagamento(Pagamento pagamento);
        void AdicionarTransacao(Transacao transacao);
        Task<Pagamento> ObterPagamentoPorPedidoId(Guid pedidoId);
        Task<IEnumerable<Transacao>> ObterTransacaoesPorPedidoId(Guid pedidoId);
    }
}
