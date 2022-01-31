using ES.Bff.Compras.Models;
using System.Threading.Tasks;

namespace ES.Bff.Compras.Interfaces
{
    public interface IPedidoService
    {
        Task<VoucherDTO> ObterVoucherPorCodigo(string codigo);
    }
}
