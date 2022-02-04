using ES.Bff.Compras.Models;
using ES.Core.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.Bff.Compras.Interfaces
{
    public interface IPedidoService
    {
        Task<ResponseResult> FinalizarPedido(PedidoDTO pedido);
        Task<PedidoDTO> ObterUltimoPedido();
        Task<IEnumerable<PedidoDTO>> ObterListaPorClienteId();

        Task<VoucherDTO> ObterVoucherPorCodigo(string codigo);
    }
}
