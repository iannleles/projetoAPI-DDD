using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Application.DTO;
using MyWebAPI.Application.Interfaces;

namespace MentoriaAbril.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutosController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {   
            return Ok(_produtoAppService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(ProdutoDTO produtoDTO)
        {
            _produtoAppService.Insert(produtoDTO);
            return Ok(produtoDTO);
        }

        //[HttpPut]
        //public IActionResult Update(ProdutoDTO produtoDTO)
        //{
           
        //    return Ok(produtoDTO);
        //}


        //[HttpDelete]

        //public IActionResult Delete(int id)
        //{
        //    var produto = _context.Produtos.Find(id);
        //    if (produto == null)
        //        return NotFound();
        //    _context.Produtos.Remove(produto);
        //    _context.SaveChanges();
        //    return Ok("Produto" + id + " excluído com sucesso");

        //}


        //[HttpGet("GetById", Name =  "GetById")]

        //public IActionResult GetById(int id)
        //{
        //    var produto = _context.Produtos.Find(id);
        //    if (produto == null)
        //        return NotFound();

        //    var produtoDTO = new ProdutoDTO
        //    {
        //        Id = produto.Id,
        //        Nome = produto.Nome,
        //        Marca = produto.Marca,
        //    };

        //    return Ok(produto);
        //}
    }
}
