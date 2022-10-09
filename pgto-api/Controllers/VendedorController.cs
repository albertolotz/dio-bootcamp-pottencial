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
    public class VendedorController : ControllerBase
    {
        private readonly SharedContext _context;
        public VendedorController(SharedContext context) => _context = context;
       
        [HttpPost]
        public IActionResult CreateVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return Ok(vendedor);
        }
    }
}