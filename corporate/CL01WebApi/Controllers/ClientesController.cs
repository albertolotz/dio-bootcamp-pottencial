using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Microsoft.AspNetCore.Mvc;


namespace CL01WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        public ClientesController()
        {
        }

        [HttpGet("")]
        public IActionResult get()
        {
            return Ok( new List<Cliente>()
            {
                new Cliente
                {
                    Id=1,
                    Nome="Alberto",
                    DataNascimento = new DateTime(2000,10,01)
                },
                new Cliente
                {
                    Id=2,
                    Nome="lotz",
                    DataNascimento = new DateTime(2003,10,01)
                }
            });
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetTModelById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<string> PostTModel(string model)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutTModel(int id, string model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteTModelById(int id)
        {
            return null;
        }
    }
}