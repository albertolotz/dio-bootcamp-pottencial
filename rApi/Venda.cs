using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rApi
{
    public class Venda
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}