using ES.Clientes.API.Models;
using ES.Core.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.Clientes.API.Data.Interface
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void Adicionar(Cliente cliente);

        Task<IEnumerable<Cliente>> ObterTodos();
        Task<Cliente> ObterPorCpf(string cpf);
    }
   
}
