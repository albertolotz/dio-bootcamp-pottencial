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
    public class ProdutoController : ControllerBase
    {
        private readonly SharedContext _context;
        public ProdutoController(SharedContext context) => _context = context;
        
        [HttpPost]
        public IActionResult CreateProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}