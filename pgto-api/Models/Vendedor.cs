using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pgto_api.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; } 
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        //public virtual List<Venda> Vendas { get; set; } 
    }
}
