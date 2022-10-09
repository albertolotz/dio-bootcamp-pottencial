using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pgto_api.Models
{
    public class Venda
    {
       public int VendaId { get; set; }
       public DateTime DataVenda { get; set; }
       public string StatusVenda { get; set; }
       public int VendedorId { get; set; }
       public virtual Vendedor Vendedor { get; set; }
       public virtual List<VendaItens> VendaItens { get; set; }
       public int VendaItensId { get; set; }
       public VendaItens VendaItem { get; set; }

    }
}