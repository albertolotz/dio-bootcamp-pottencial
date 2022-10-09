using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL04Core.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}