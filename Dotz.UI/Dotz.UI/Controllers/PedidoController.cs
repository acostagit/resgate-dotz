using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotz.Application.DTO;
using Dotz.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotz.UI.Controllers
{
    [Route("api/[pedido]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoApp _applicationService;
        public PedidoController(IPedidoApp applicationService)
        {
            this._applicationService = applicationService;
        }

        // GET: api/<PedidoController>
        public ActionResult<IEnumerable<string>> SelecionarTodos()
        {
            try
            {
                var produtos = _applicationService.SelecionarTodos();
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
                var produtos = _applicationService.SelecionarPorId(id);
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] PedidoDTO dto)
        {
            try
            {
                return new OkObjectResult(_applicationService.Incluir(dto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] PedidoDTO dto)
        {
            try
            {
                _applicationService.Alterar(dto);
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
                _applicationService.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
