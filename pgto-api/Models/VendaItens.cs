using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pgto_api.Models
{
    public class VendaItens
    {
        public int VendaItensId { get; set; }
        
        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
    }
}