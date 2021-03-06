using MyWebAPI.Application.DTO;
using MyWebAPI.Application.Interfaces;
using MyWebAPI.Domain.Entities;
using MyWebAPI.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _produtoRepository.GetAll();
            var produtosDTO = produtos.Select(c => new ProdutoDTO
            {

                Id = c.Id,
                Marca = c.Marca,
                Nome = c.Nome

            });

            return produtosDTO;
        }

        public ProdutoDTO Insert(ProdutoDTO produtoDTO)
        {
            var produto = new Produto
            {
                Marca = produtoDTO.Marca,
                Nome = produtoDTO.Nome,
            };
            _produtoRepository.Insert(produto);
           
            produtoDTO.Id = produto.Id;

            return produtoDTO;
        }        

        public ProdutoDTO GetProdutoDTOById(int Id)
        {
            var produto = _produtoRepository.GetById(Id);
            

            var produtoDTO = new ProdutoDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Marca = produto.Marca,
            };

            return produtoDTO;
        }

        public ProdutoDTO Update(ProdutoDTO produtoDTO)
        {
            var produtoAlterado = _produtoRepository.GetById((int)produtoDTO.Id); 
            produtoAlterado.Nome = produtoDTO.Nome;
            produtoAlterado.Marca = produtoDTO.Marca;
            _produtoRepository.Update(produtoAlterado);
             return produtoDTO;
        }

        public void Delete(int id)
        {
            var produto = _produtoRepository.GetById(id);
            _produtoRepository.Delete(produto);            
        }
    }
}
