using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pgto_api.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; } 
        public decimal Preco { get; set; }
        //public virtual List<Venda> Vendas { get; set; } 
    }
}