using MyWebAPI.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.Application.Interfaces
{
    public interface IProdutoAppService
    {
        IEnumerable<ProdutoDTO> GetAll();
        ProdutoDTO Insert(ProdutoDTO produtoDTO);
        //ProdutoDTO Update(ProdutoDTO produtoDTO);
        

    }
}
