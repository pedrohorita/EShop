using ES.Core.Data.Interfaces;
using ES.Pedidos.Domain.Vouchers;
using System.Threading.Tasks;

namespace ES.Pedidos.Domain.Interfaces
{
    public interface IVoucherRepository : IRepository<Voucher>
    {
        Task<Voucher> ObterVoucherPorCodigo(string codigo);
        void Atualizar(Voucher voucher);
    }
}
