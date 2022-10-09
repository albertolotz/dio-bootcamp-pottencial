using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rApi
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public virtual List<Venda> Vendas { get; set; }
    }
}