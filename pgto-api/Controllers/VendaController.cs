using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pgto_api.Context;
using pgto_api.Models;

namespace pgto_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly SharedContext _context;
        public VendaController(SharedContext context) => _context = context;

        [HttpPost]
        public IActionResult CreateVenda(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }

    }
}