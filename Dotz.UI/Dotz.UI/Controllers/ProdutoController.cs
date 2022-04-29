using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotz.Application.DTO;
using Dotz.Application.Interfaces;
using Dotz.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotz.UI.Controllers
{
    [Route("api/[produto]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApp _produtoService;

        public ProdutoController(IProdutoApp produtoAppService)
        {
            this._produtoService = produtoAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> SelecionarTodos()
        {
            try
            {
                var produtos = _produtoService.SelecionarTodos();
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<string> BuscarPorId(int id)
        {
            try
            {
                var produtos = _produtoService.SelecionarPorId(id);
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] ProdutoDTO dto)
        {
            try
            {
                return new OkObjectResult(_produtoService.Incluir(dto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] ProdutoDTO dto)
        {
            try
            {
                _produtoService.Alterar(dto);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _produtoService.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
