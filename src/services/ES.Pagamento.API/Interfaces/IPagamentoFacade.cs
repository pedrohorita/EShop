using ES.Pagamentos.API.Models;
using System.Threading.Tasks;

namespace ES.Pagamentos.API.Interfaces
{
    public interface IPagamentoFacade
    {
        Task<Transacao> AutorizarPagamento(Pagamento pagamento);
        Task<Transacao> CapturarPagamento(Transacao transacao);
        Task<Transacao> CancelarAutorizacao(Transacao transacao);
    }
}
