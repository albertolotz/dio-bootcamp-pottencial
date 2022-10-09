using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Doc.CL02Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Doc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager _clienteManager;
        public ClientesController(IClienteManager clienteManager) => _clienteManager = clienteManager;


        [HttpGet("")]
        public async Task<IActionResult> get()
        {
            return Ok(await _clienteManager.GetClientesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _clienteManager.GetClientesAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post(Cliente cliente)
        {
            var clienteInserido = await _clienteManager.InsertClienteAsync(cliente);
            return CreatedAtAction(nameof(Get),new {id = cliente.Id}, cliente);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Cliente cliente)
        {
            var clienteAtualizado = await _clienteManager.UpdateClienteAsync(cliente);
            if(clienteAtualizado==null)
            {
                return NotFound();
            }
            return Ok(clienteAtualizado);
        }

        [HttpDelete]
        public async Task<ActionResult>  Delete(int id)
        {
            await _clienteManager.DeleteClienteAsync(id);
            return NoContent();
        }
    }
}