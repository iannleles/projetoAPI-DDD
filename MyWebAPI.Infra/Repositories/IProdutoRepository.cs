using MyWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.Infra.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto Insert(Produto produtoDTO);
        Produto Update(Produto produtoDTO);
        Produto GetById(int Id);
        void Delete(Produto produto);
    }
}
