using ES.Core.Communication;
using ES.WebApp.MVC.Models;
using System.Threading.Tasks;

namespace ES.WebApp.MVC.Interfaces
{
    public interface IClienteService
    {
        Task<EnderecoViewModel> ObterEndereco();
        Task<ResponseResult> AdicionarEndereco(EnderecoViewModel endereco);
    }
}
