using ES.Catalogo.API.Models;
using ES.Core.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.Catalogo.API.Data.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);

        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
    }
}
