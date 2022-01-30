using ES.Pedidos.API.Application.DTO;
using System.Threading.Tasks;

namespace ES.Pedidos.API.Application.Queries.Interfaces
{
    public interface IVoucherQueries
    {
        Task<VoucherDTO> ObterVoucherPorCodigo(string codigo);
    }
}
