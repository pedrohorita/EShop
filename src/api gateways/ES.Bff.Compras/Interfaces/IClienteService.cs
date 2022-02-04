using ES.Bff.Compras.Models;
using System.Threading.Tasks;

namespace ES.Bff.Compras.Interfaces
{
    public interface IClienteService
    {
        Task<EnderecoDTO> ObterEndereco();
    }
}
