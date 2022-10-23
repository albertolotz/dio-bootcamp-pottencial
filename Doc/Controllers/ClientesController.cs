using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Doc.CL02Manager.Interfaces;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using Microsoft.AspNetCore.Mvc;


namespace Doc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager _clienteManager;
        public ClientesController(IClienteManager clienteManager) => _clienteManager = clienteManager;

        /// <summary>
        /// Retorna todos os clientes cadastrados e ativos.
        /// </summary>
        [HttpGet("")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> get()
        {
            return Ok(await _clienteManager.GetClientesAsync());
        }
        
        /// <summary>
        /// Retorna um cliente com base no ID.
        /// </summary>
        /// <param name="id" example="999">ID do Cliente</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _clienteManager.GetClientesAsync(id));
        }

        /// <summary>
        /// Cadastra um novo cliente.
        /// </summary>
        /// <param name="novoCliente"></param>
        [HttpPost]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]        
        public async Task<ActionResult> Post(NovoCliente novoCliente)
        {
            var clienteInserido = await _clienteManager.InsertClienteAsync(novoCliente);
            return CreatedAtAction(nameof(Get),new {id = clienteInserido.Id}, clienteInserido);
        }

        /// <summary>
        /// Edita um cliente pesquisando pelo ID informado.
        /// </summary>
        /// <param name="alteraCliente"></param>

        [HttpPut]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Put(AlteraCliente alteraCliente)
        {
            var clienteAtualizado = await _clienteManager.UpdateClienteAsync(alteraCliente);
            if(clienteAtualizado==null)
            {
                return NotFound();
            }
            return Ok(clienteAtualizado);
        }

        /// <summary>
        /// Apaga um cliente com referencia no ID informado.
        /// </summary>
        /// <param name="id" example="999">ID do Cliente</param>
        [HttpDelete]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult>  Delete(int id)
        {
            await _clienteManager.DeleteClienteAsync(id);
            return NoContent();
        }
    }
}