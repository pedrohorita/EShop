using ES.Bff.Compras.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.Bff.Compras.Interfaces
{
    public interface ICatalogoService
    {
        Task<ItemProdutoDTO> ObterPorId(Guid id);
        Task<IEnumerable<ItemProdutoDTO>> ObterItens(IEnumerable<Guid> ids);
    }
}
