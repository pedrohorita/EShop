using ES.Core.Messages.Integration;
using ES.Pagamentos.API.Models;
using System;
using System.Threading.Tasks;

namespace ES.Pagamentos.API.Interfaces
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
        Task<ResponseMessage> CapturarPagamento(Guid pedidoId);
        Task<ResponseMessage> CancelarPagamento(Guid pedidoId);
    }
}
